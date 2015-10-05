using System;
using System.Collections.Generic;
using RestSharp.Deserializers;

namespace SyncthingRestClient.Response
{
    public class GetNeedResponse
    {
        [DeserializeAs(Name = "progress")]
        public List<GetNeedResponseFileNode> progress { get; set; }

        [DeserializeAs(Name = "queued")]
        public List<GetNeedResponseFileNode> queued { get; set; }

        [DeserializeAs(Name = "rest")]
        public List<GetNeedResponseFileNode> rest { get; set; }
    }

    public class GetNeedResponseFileNode
    {
        [DeserializeAs(Name = "Flags")]
        public string Flags { get; set; }

        [DeserializeAs(Name = "LocalVersion")]
        public int LocalVersion { get; set; }

        [DeserializeAs(Name = "Version")]
        public int Version { get; set; }

        [DeserializeAs(Name = "Modified")]
        public DateTime ModifiedAt { get; set; }

        [DeserializeAs(Name = "Name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "Size")]
        public long Size { get; set; }
    }
}