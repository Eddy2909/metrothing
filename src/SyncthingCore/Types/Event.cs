using System;

namespace SyncthingCore.Types
{
    public class Event
    {
        public enum EvenType
        {
            Ping,
            Starting,
            StartupComplete,
            DeviceDiscovered,
            DeviceConnected,
            DeviceDisconnected,
            DeviceRejected,
            LocalIndexUpdated,
            RemoteIndexUpdated,
            ItemStarted,
            ItemFinished,
            StateChanged,
            FolderRejected,
            ConfigSaved,
            DownloadProgress
        }

        public long Id { get; set; }
        public DateTime At { get; set; }
        public string Type { get; set; }
    }
}