using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace SyncthingCore.Worker
{
    /// <summary>
    ///     Monitors a connection towards a connected instance
    /// </summary>
    public class HeartbeatWorker : BaseWorker<HeartbeatWorkerEventArgs>
    {
        private readonly Ping _ping = new Ping();

        public HeartbeatWorker(ManagedInstance instance)
            : base(instance, instance.Directives.HeartbeatDirective)
        {
        }

        protected override async void OnFetch()
        {
            // @todo Wait for ICMP and API ping at the same time (WaitAll)
            await ExecuteIcmpPing();
            await ExecuteApiPing();

            UpdateInstance();

            base.OnFetch();
        }

        private async Task ExecuteIcmpPing()
        {
            try
            {
                var result = await Task.Run(
                    () => _ping.SendPingAsync(ManagedInstance.ConnectedEndpoint.Hostname),
                    ExecutionCancelationToken);

                if (result.Status == IPStatus.Success)
                {
                    EventArgs.PingAlive = true;
                    EventArgs.PingRoundtripTime = result.RoundtripTime;
                }
                else
                {
                    EventArgs.PingErrorMessage = result.Status.ToString();
                }
            }
            catch (Exception e)
            {
                EventArgs.PingErrorMessage = e.InnerException == null ? e.Message : e.InnerException.Message;
            }
        }

        private async Task ExecuteApiPing()
        {
            try
            {
                var result =
                    await Task.Run(() => RestClient.GetPingAsync(ExecutionCancelationToken), ExecutionCancelationToken);

                if (result != null)
                {
                    EventArgs.Success = true;
                    EventArgs.ApiAlive = true;
                }
            }
            catch (Exception e)
            {
                EventArgs.ApiErrorMessage = e.Message;
            }
        }

        private void UpdateInstance()
        {
            if (EventArgs.PingAlive)
                ManagedInstance.Statistics.ClientToInstanceLatency = EventArgs.PingRoundtripTime;
            else
                ManagedInstance.Statistics.ClientToInstanceLatency = null;
        }
    }

    public class HeartbeatWorkerEventArgs : BaseWorkerEventArgs
    {
        public bool PingAlive { get; set; }
        public long PingRoundtripTime { get; set; }
        public string PingErrorMessage { get; set; }
        public bool ApiAlive { get; set; }
        public string ApiErrorMessage { get; set; }
    }
}