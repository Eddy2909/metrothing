using System;
using System.Threading.Tasks;
using SyncthingRestClient.Response;

namespace SyncthingCore.Worker
{
    public class ReportStatusWorker : BaseWorker<ReportStatusWorkerEventArgs>
    {
        public ReportStatusWorker(ManagedInstance instance)
            : base(instance, instance.Directives.ReportStatusDirective)
        {
        }

        protected override async void OnFetch()
        {
            try
            {
                var result = await Task.Run(
                    () => RestClient.GetReportAsync(ExecutionCancelationToken),
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

            /* @todo Ease by replacing each possible field by lower cost calls */
            ManagedInstance.Statistics.CryptPerformance = response.CryptPerformance;
            ManagedInstance.Statistics.TotalDeviceCount = response.DeviceCount;
            ManagedInstance.Statistics.FolderCount = response.FolderCount; // Overwritten by FolderStatsWorker
            ManagedInstance.Statistics.LargestFolderFileCount = response.LargestFolderFiles;
            ManagedInstance.Statistics.LargestFolderMaxMebibyte = response.LargestFolderMebibyte;
            ManagedInstance.Information.LongVersion = response.LongVersion;
            ManagedInstance.Statistics.MemoryAvailable = response.MemorySize;
            ManagedInstance.Information.Platform = response.Platform;
            ManagedInstance.Statistics.FileCount = response.TotalFilesCount;
            ManagedInstance.Statistics.MebibyteCount = response.TotalMebibyteCount;
            ManagedInstance.Information.Version = response.Version;
        }
    }

    public class ReportStatusWorkerEventArgs : BaseWorkerEventArgs<GetReportResponse>
    {
    }
}