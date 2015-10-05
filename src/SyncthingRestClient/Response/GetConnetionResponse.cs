using System;
using RestSharp.Deserializers;

namespace SyncthingRestClient.Response
{
    public class GetConnetionResponse
    {
        public int AvailableConnections { get; set; }

        [DeserializeAs(Name = "total")]
        public TotalDetails Total { get; set; }

        public class TotalDetails
        {
            public DateTime At { get; set; }
            public long InBytesTotal { get; set; }
            public long OutBytesTotal { get; set; }
        }
    }
}