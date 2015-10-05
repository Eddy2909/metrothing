using System;
using System.Linq;
using System.Threading.Tasks;
using SyncthingCore.Collections;
using SyncthingCore.Extensions;
using SyncthingRestClient.Response;

namespace SyncthingCore.Worker
{
    public class SystemStatusWorker : BaseWorker<SystemStatusWorkerEventArgs>
    {
        public SystemStatusWorker(ManagedInstance instance)
            : base(instance, instance.Directives.SystemStatusDirective)
        {
        }

        protected override async void OnFetch()
        {
            try
            {
                var result = await Task.Run(
                    () => RestClient.GetSystemStatusAsync(ExecutionCancelationToken),
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

            ManagedInstance.Information.SyncthingId = response.Identifier;
            ManagedInstance.Statistics.MemoryAllocation = response.AllocatedMemory;
            ManagedInstance.Statistics.MemoryUsage = response.UsedMemory;
            ManagedInstance.Statistics.CpuUsage = response.CpuUsage;
            ManagedInstance.Statistics.GoRoutineCount = response.GoRoutineCount;

            // The API answer is authoritive and will always replace the local information
            ManagedInstance.Announcers.SynchronizeTo(new AnnouncerCollection(response.ExternalAnnouncers).ToList());
        }
    }

    public class SystemStatusWorkerEventArgs : BaseWorkerEventArgs<GetSystemResponse>
    {
    }
}