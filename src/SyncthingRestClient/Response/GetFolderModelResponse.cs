using System;
using RestSharp.Deserializers;

namespace SyncthingRestClient.Response
{
    public class GetFolderModelResponse
    {
        [DeserializeAs(Name = "globalBytes")]
        public long GlobalBytes { get; set; }

        [DeserializeAs(Name = "globalBytes")]
        public long GlobalDeleted { get; set; }

        [DeserializeAs(Name = "globalFiles")]
        public long GlobalFiles { get; set; }

        [DeserializeAs(Name = "inSyncBytes")]
        public long InSyncBytes { get; set; }

        [DeserializeAs(Name = "inSyncFiles")]
        public long InSyncFiles { get; set; }

        [DeserializeAs(Name = "localBytes")]
        public long LocalBytes { get; set; }

        [DeserializeAs(Name = "localDeleted")]
        public long LocalDeleted { get; set; }

        [DeserializeAs(Name = "localFiles")]
        public long LocalFiles { get; set; }

        [DeserializeAs(Name = "needBytes")]
        public long NeedBytes { get; set; }

        [DeserializeAs(Name = "needFiles")]
        public long NeedFiles { get; set; }

        [DeserializeAs(Name = "state")]
        public string State { get; set; }

        [DeserializeAs(Name = "stateChanged")]
        public DateTime StateChangedAt { get; set; }

        [DeserializeAs(Name = "version")]
        public int Version { get; set; }
    }
}