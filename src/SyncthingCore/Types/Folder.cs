using System;
using SyncthingRestClient.Response;

namespace SyncthingCore.Types
{
    public class Folder
    {
        public Folder(GetConfigResponseFoldersNode folderNode)
        {
            Id = folderNode.Id;
            Path = folderNode.Path;
        }

        public string Id { get; set; }
        public string Path { get; set; }
        public DateTime LastFileAt { get; set; }
        public string LastFilename { get; set; }
        public long NeededBytes { get; set; }
        public long NeededFiles { get; set; }
    }
}