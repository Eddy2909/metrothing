using System;

namespace SyncthingCore.Types
{
    public class RestEndpoint
    {
        /// <summary>
        ///     Hostname or IP of the target system
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        ///     Web GUI port number of the target system
        /// </summary>
        public UInt16 Port { get; set; }

        /// <summary>
        ///     Priority order of this endpoint. Highest priority endpoints will be tried first on Watch()
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        ///     Does this endpoint support pings with over ICMP to test the latency
        /// </summary>
        public bool IsPingable { get; set; }
    }
}