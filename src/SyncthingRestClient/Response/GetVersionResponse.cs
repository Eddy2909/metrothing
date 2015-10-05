using RestSharp.Deserializers;

namespace SyncthingRestClient.Response
{
    public class GetVersionResponse
    {
        [DeserializeAs(Name = "arch")]
        public string Architecture { get; set; }

        [DeserializeAs(Name = "longVersion")]
        public string LongVersion { get; set; }

        [DeserializeAs(Name = "os")]
        public string OperatingSystem { get; set; }

        [DeserializeAs(Name = "version")]
        public string Version { get; set; }
    }
}