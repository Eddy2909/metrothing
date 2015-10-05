using System;

namespace SyncthingCore.Types
{
    public class Connection
    {
        // Only set on speicifc client, not filled in totals
        public string Address { get; set; }
        public string Version { get; set; }
        public DateTime At { get; set; }
        public long IncomingByteCount { get; set; }
        public long OutgoingByteCount { get; set; }
    }
}