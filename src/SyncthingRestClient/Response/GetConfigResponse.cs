using System.Collections.Generic;
using RestSharp.Deserializers;

namespace SyncthingRestClient.Response
{
    public class GetConfigResponse
    {
        [DeserializeAs(Name = "Version")]
        public int Version { get; set; }

        [DeserializeAs(Name = "Devices")]
        public List<GetConfigResponseDevicesNode> Devices { get; set; }

        [DeserializeAs(Name = "Folders")]
        public List<GetConfigResponseFoldersNode> Folders { get; set; }

        [DeserializeAs(Name = "GUI")]
        public GetConfigResponseGuiNode Gui { get; set; }
    }

    public class GetConfigResponseDevicesNode
    {
        [DeserializeAs(Name = "DeviceID")]
        public string DeviceId { get; set; }

        [DeserializeAs(Name = "Name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "Introducer")]
        public bool IsIntroducer { get; set; }
    }

    public class GetConfigResponseFoldersNode
    {
        [DeserializeAs(Name = "ID")]
        public string Id { get; set; }

        [DeserializeAs(Name = "Path")]
        public string Path { get; set; }

        [DeserializeAs(Name = "ReadOnly")]
        public bool IsReadOnly { get; set; }

        [DeserializeAs(Name = "RescanIntervalS")]
        public int RescanInterval { get; set; }

        [DeserializeAs(Name = "Devices")]
        public List<GetConfigResponseFoldersDevicesNode> Devices { get; set; }
    }

    public class GetConfigResponseFoldersDevicesNode
    {
        [DeserializeAs(Name = "DeviceID")]
        public string DeviceId { get; set; }
    }

    public class GetConfigResponseGuiNode
    {
        [DeserializeAs(Name = "APIKey")]
        public string ApiKey { get; set; }

        [DeserializeAs(Name = "Address")]
        public string ListeningAddress { get; set; }

        [DeserializeAs(Name = "Enabled")]
        public bool IsEnabled { get; set; }

        [DeserializeAs(Name = "Password")]
        public string Password { get; set; }

        [DeserializeAs(Name = "UseTLS")]
        public bool UseHttps { get; set; }

        [DeserializeAs(Name = "User")]
        public string Username { get; set; }
    }
}