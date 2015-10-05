using System;
using System.Threading.Tasks;
using SyncthingRestClient.Response;

namespace SyncthingCore.Worker
{
    public class VersionUpgradeWorker : BaseWorker<VersionUpgradeWorkerEventArgs>
    {
        public VersionUpgradeWorker(ManagedInstance instance)
            : base(instance, instance.Directives.VersionUpgradeDirective)
        {
        }

        protected override async void OnFetch()
        {
            try
            {
                var result = await Task.Run(
                    () => RestClient.GetUpgradeStatusAsync(ExecutionCancelationToken),
                    ExecutionCancelationToken);

                if (result == null) return;

                EventArgs.Success = true;
                EventArgs.Response = result;
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

            ManagedInstance.Information.LatestVersion = response.LatestVersion;
            ManagedInstance.Information.Version = response.RunningVersion;
            ManagedInstance.Information.IsUpgradeAvailable = response.IsUpgradeAvailable;
        }
    }

    public class VersionUpgradeWorkerEventArgs : BaseWorkerEventArgs<GetUpgradeResponse>
    {
    }
}