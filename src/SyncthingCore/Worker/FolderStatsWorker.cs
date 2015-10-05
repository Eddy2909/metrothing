using System;
using System.Linq;
using System.Threading.Tasks;
using SyncthingRestClient.Response;

namespace SyncthingCore.Worker
{
    public class FolderStatsWorker : BaseWorker<FolderStatsWorkerEventArgs>
    {
        public FolderStatsWorker(ManagedInstance instance)
            : base(instance, instance.Directives.FolderStatsDirective)
        {
        }

        protected override async void OnFetch()
        {
            try
            {
                var result = await Task.Run(
                    () => RestClient.GetFolderStatsAsync(ExecutionCancelationToken),
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
            if (EventArgs.Response.Folders == null) return;

            foreach (var entry in EventArgs.Response.Folders)
            {
                var folderEntry = entry;
                var foundFolders = ManagedInstance.Folders.Where(x => x.Id == folderEntry.Key);

                foreach (var foundFolder in foundFolders)
                {
                    foundFolder.LastFileAt = entry.Value.LastFile.At;
                    foundFolder.LastFilename = entry.Value.LastFile.Filename;
                }
            }

            ManagedInstance.Statistics.FolderCount = EventArgs.Response.Folders.Count;
        }
    }

    public class FolderStatsWorkerEventArgs : BaseWorkerEventArgs<GetFolderStatsResponse>
    {
    }
}