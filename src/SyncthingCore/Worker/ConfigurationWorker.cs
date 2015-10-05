using System;
using System.Linq;
using System.Threading.Tasks;
using SyncthingCore.Collections;
using SyncthingCore.Extensions;
using SyncthingRestClient.Response;

namespace SyncthingCore.Worker
{
    public class ConfigurationWorker : BaseWorker<ConfigurationWorkerEventArgs>
    {
        public ConfigurationWorker(ManagedInstance instance)
            : base(instance, instance.Directives.FolderStatusDirective)
        {
        }

        protected override async void OnFetch()
        {
            try
            {
                var result = await Task.Run(
                    () => RestClient.GetConfigAsync(ExecutionCancelationToken),
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

            // Remove all that do no longer exist

            ManagedInstance.Folders.SynchronizeTo(new FoldersCollection(EventArgs.Response.Folders).ToList());
        }
    }

    public class ConfigurationWorkerEventArgs : BaseWorkerEventArgs<GetConfigResponse>
    {
    }
}