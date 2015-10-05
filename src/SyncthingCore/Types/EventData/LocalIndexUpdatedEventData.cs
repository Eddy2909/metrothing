using System;

namespace SyncthingCore.Types.EventData
{
    public class LocalIndexUpdatedEventData : IEventData
    {
        public string Flags { get; set; }
        public string Folder { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
    }
}