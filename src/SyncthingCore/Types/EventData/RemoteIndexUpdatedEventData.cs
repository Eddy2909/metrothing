namespace SyncthingCore.Types.EventData
{
    public class RemoteIndexUpdatedEventData : IEventData
    {
        public string DeviceId { get; set; }
        public string Folder { get; set; }
        public long ItemCount { get; set; }
        public long Version { get; set; }
    }
}