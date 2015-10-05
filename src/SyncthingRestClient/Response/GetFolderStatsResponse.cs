using System;
using System.Collections.Generic;
using RestSharp.Deserializers;

namespace SyncthingRestClient.Response
{
    public class GetFolderStatsResponse
    {
        /// <summary>
        ///     Contains Folder ID as key and information about it as value
        /// </summary>
        public Dictionary<string, GetFolderStatsResponseMainNode> Folders;
    }

    public class GetFolderStatsResponseMainNode
    {
        [DeserializeAs(Name = "LastFile")]
        public GetFolderStatsResponseLastfileNode LastFile { get; set; }
    }

    public class GetFolderStatsResponseLastfileNode
    {
        public DateTime At { get; set; }
        public string Filename { get; set; }
    }
}