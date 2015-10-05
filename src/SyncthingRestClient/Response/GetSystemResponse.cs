using System.Collections.Generic;
using RestSharp.Deserializers;

namespace SyncthingRestClient.Response
{
    public class GetSystemResponse
    {
        public GetSystemResponse()
        {
            ExternalAnnouncers = new Dictionary<string, bool>();
        }

        [DeserializeAs(Name = "alloc")]
        public long UsedMemory { get; set; }

        [DeserializeAs(Name = "cpuPercent")]
        public float CpuUsage { get; set; }

        [DeserializeAs(Name = "myID")]
        public string Identifier { get; set; }

        [DeserializeAs(Name = "sys")]
        public long AllocatedMemory { get; set; }

        [DeserializeAs(Name = "goroutines")]
        public int GoRoutineCount { get; set; }

        [DeserializeAs(Name = "extAnnounceOK")]
        public Dictionary<string, bool> ExternalAnnouncers { get; set; }
    }
}