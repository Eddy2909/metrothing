using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using SyncthingCore.Types;
using SyncthingRestClient;

namespace SyncthingCore.Worker
{
    /// <summary>
    ///     Will try to establish a connection to an instance, iterating over all available
    ///     endpoints and their priority
    /// </summary>
    public class EndpointConnectWorker : BaseWorker<ConnectionWorkerEventArgs>
    {
        public EndpointConnectWorker(ManagedInstance instance)
            : base(instance, instance.Directives.EndpointConnectDirective)
        {
        }

        protected override void RegisterEventHandlers()
        {
            // We want the connection to be tested, so this worker is only active in the Connecting phase
            ManagedInstance.Connecting += OnConnecting;
            ManagedInstance.Connected += OnConnected;
        }

        private void OnConnecting(object sender, InstanceEventArgs eArgs)
        {
            Start();
        }

        protected override void OnConnected(object sender, ConnectedEventArgs e)
        {
            Stop();
        }

        protected override async void OnFetch()
        {
            // Try all possible endpoints until we find one that does not throws an error
            var errors = new List<string>();

            foreach (var endpoint in ManagedInstance.PossibleEndpoints.OrderByDescending(o => o.Priority).ToList())
            {
                var restClient = new RestClient(
                    endpoint.Hostname,
                    endpoint.Port,
                    ManagedInstance.UseHttps,
                    ManagedInstance.ApiKey);

                try
                {
                    var result = await Task.Run(
                        () => restClient.PostPingAsync(ExecutionCancelationToken),
                        ExecutionCancelationToken);

                    if (result == null) return;

                    EventArgs.Success = true;
                    EventArgs.RestClient = restClient;
                    EventArgs.RestEndpoint = endpoint;

                    Log.Logger.Debug("{instance} ~ {thread}:OnFetch connected to {@result}", ManagedInstance,
                        GetType(), EventArgs);

                    break;
                }
                catch (Exception e)
                {
                    var errorMessage = string.Format("Failed to connect to {0}: {1}", restClient.Uri, e.Message);
                    errors.Add(errorMessage);

                    Log.Logger.Debug("{instance} ~ {thread}:OnFetch failed to connect to {@result}", ManagedInstance,
                        GetType(), EventArgs);
                }
            }

            OnExecuted(EventArgs);

            // Aggregate all errors
            if (EventArgs.Success)
            {
                Stop();
            }
            else
            {
                EventArgs.ErrorMessage = String.Format("Failed to connect to all possible endpoints: {0}",
                    Environment.NewLine + String.Join(Environment.NewLine, errors));

                Log.Logger.Debug("{instance} ~ {thread}:OnFetch gave up and will try again", ManagedInstance,
                    GetType());

                Finish();
            }
        }
    }

    public class ConnectionWorkerEventArgs : BaseWorkerEventArgs
    {
        public RestClient RestClient { get; set; }
        public RestEndpoint RestEndpoint { get; set; }
    }
}