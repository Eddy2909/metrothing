using RestSharp.Deserializers;

namespace SyncthingRestClient.Response
{
    public class GetUpgradeResponse
    {
        [DeserializeAs(Name = "latest")]
        public string LatestVersion { get; set; }

        [DeserializeAs(Name = "newer")]
        public bool IsUpgradeAvailable { get; set; }

        [DeserializeAs(Name = "running")]
        public string RunningVersion { get; set; }
    }
}