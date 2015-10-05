using RestSharp.Deserializers;

namespace SyncthingRestClient.Response
{
    public class GetReportResponse
    {
        [DeserializeAs(Name = "folderMaxFiles")]
        public long LargestFolderFiles { get; set; }

        [DeserializeAs(Name = "folderMaxMiB")]
        public long LargestFolderMebibyte { get; set; }

        [DeserializeAs(Name = "longVersion")]
        public string LongVersion { get; set; }

        [DeserializeAs(Name = "memorySize")]
        public long MemorySize { get; set; }

        [DeserializeAs(Name = "memoryUsageMiB")]
        public long MemoryUsageMebibyte { get; set; }

        [DeserializeAs(Name = "numDevices")]
        public int DeviceCount { get; set; }

        [DeserializeAs(Name = "numFolders")]
        public int FolderCount { get; set; }

        [DeserializeAs(Name = "platform")]
        public string Platform { get; set; }

        [DeserializeAs(Name = "sha256Perf")]
        public float CryptPerformance { get; set; }

        [DeserializeAs(Name = "totFiles")]
        public long TotalFilesCount { get; set; }

        [DeserializeAs(Name = "totMiB")]
        public long TotalMebibyteCount { get; set; }

        [DeserializeAs(Name = "uniqueID")]
        public string UniqueIdentifier { get; set; }

        [DeserializeAs(Name = "version")]
        public string Version { get; set; }
    }
}