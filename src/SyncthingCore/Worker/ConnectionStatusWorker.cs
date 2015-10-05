using System;
using System.Threading.Tasks;
using SyncthingRestClient.Response;

namespace SyncthingCore.Worker
{
    public class ConnectionStatusWorker : BaseWorker<ConnectionStatusWorkerEventArgs>
    {
        private GetConnetionResponse _lastConnectionResponse;

        public ConnectionStatusWorker(ManagedInstance instance)
            : base(instance, instance.Directives.ConnectionStatusDirective)
        {
        }

        protected override async void OnFetch()
        {
            try
            {
                var result = await Task.Run(
                    () => RestClient.GetConnectionsAsync(ExecutionCancelationToken),
                    ExecutionCancelationToken);

                if (result != null)
                {
                    EventArgs.Success = true;
                    EventArgs.Response = result;
                }
            }
            catch (Exception e)
            {
                EventArgs.ErrorMessage = e.InnerException == null ? e.Message : e.InnerException.Message;
            }
            finally
            {
                UpdateInstance();

                base.OnFetch();
            }
        }

        private void UpdateInstance()
        {
            if (!EventArgs.Success) return;

            var response = EventArgs.Response;

            if (_lastConnectionResponse != null)
            {
                var timeDiff = (response.Total.At - _lastConnectionResponse.Total.At).TotalSeconds;
                var inDiff =
                    (long) ((response.Total.InBytesTotal - _lastConnectionResponse.Total.InBytesTotal)/timeDiff);
                var outDiff =
                    (long) ((response.Total.OutBytesTotal - _lastConnectionResponse.Total.OutBytesTotal)/timeDiff);

                ManagedInstance.Statistics.DownloadTotal = EventArgs.Response.Total.InBytesTotal;
                ManagedInstance.Statistics.DownloadPerSecond = inDiff;

                ManagedInstance.Statistics.UploadTotal = EventArgs.Response.Total.OutBytesTotal;
                ManagedInstance.Statistics.UploadPerSecond = outDiff;

                ManagedInstance.Statistics.OnlineDeviceCount = EventArgs.Response.AvailableConnections;
            }

            _lastConnectionResponse = response;
        }
    }

    public class ConnectionStatusWorkerEventArgs : BaseWorkerEventArgs<GetConnetionResponse>
    {
    }
}