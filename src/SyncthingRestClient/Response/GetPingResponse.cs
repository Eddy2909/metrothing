using RestSharp.Deserializers;

namespace SyncthingRestClient.Response
{
    public class GetPingResponse
    {
        [DeserializeAs(Name = "ping")]
        public string Ping { get; set; }
    }
}