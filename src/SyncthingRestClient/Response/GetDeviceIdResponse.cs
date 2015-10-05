using RestSharp.Deserializers;

namespace SyncthingRestClient.Response
{
    public class GetDeviceIdResponse
    {
        [DeserializeAs(Name = "id")]
        public string Identifier { get; set; }

        [DeserializeAs(Name = "error")]
        public string Error { get; set; }
    }
}