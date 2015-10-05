using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SyncthingCore.Types;
using SyncthingRestClient.Response;

namespace SyncthingCore.Worker
{
    public class FolderModelWorker : BaseWorker<FolderModelWorkerEventArgs>
    {
        public FolderModelWorker(ManagedInstance instance)
            : base(instance, instance.Directives.FolderModelDirectove)
        {
        }

        protected override async void OnFetch()
        {
            foreach (var folder in ManagedInstance.Folders.ToList())
            {
                var currentFolder = folder;

                try
                {
                    var result = await Task.Run(
                        () => RestClient.GetFolderModelAsync(currentFolder.Id, ExecutionCancelationToken),
                        ExecutionCancelationToken);

                    if (result == null) return;

                    EventArgs.Success = true;
                    EventArgs.FolderResponses.Add(result);

                    UpdateInstance(currentFolder, result);
                }
                catch (Exception e)
                {
                    EventArgs.ErrorMessage = e.InnerException == null ? e.Message : e.InnerException.Message;
                }
            }

            // Calculate totals
            if (EventArgs.Success)
            {
                foreach (var folder in EventArgs.FolderResponses)
                {
                    EventArgs.TotalNeededBytes += folder.NeedBytes;
                    EventArgs.TotalNeededFiles += folder.NeedFiles;
                }

                ManagedInstance.Synchronization.TotalNeededBytes = EventArgs.TotalNeededBytes;
                ManagedInstance.Synchronization.TotalNeededFiles = EventArgs.TotalNeededFiles;
            }

            base.OnFetch();
        }

        private void UpdateInstance(Folder folder, GetFolderModelResponse result)
        {
            if (!EventArgs.Success) return;

            folder.NeededBytes = result.NeedBytes;
            folder.NeededFiles = result.NeedFiles;
        }
    }

    public class FolderModelWorkerEventArgs : BaseWorkerEventArgs<object>
    {
        public FolderModelWorkerEventArgs()
        {
            FolderResponses = new List<GetFolderModelResponse>();
            TotalNeededBytes = 0;
            TotalNeededFiles = 0;
        }

        public List<GetFolderModelResponse> FolderResponses { get; set; }
        public long TotalNeededBytes { get; set; }
        public long TotalNeededFiles { get; set; }
    }
}