namespace SyncthingCore.Types
{
    public class Statistic : BaseType
    {
        private float? _clientToInstanceLatency;
        private float? _cpuUsage;
        private float? _cryptPerformance;
        private long? _downloadPerSecond;
        private long? _downloadTotal;
        private long? _fileCount;
        private int? _folderCount;
        private int? _goRoutineCount;
        private long? _largestFolderFileCount;
        private long? _largestFolderMaxMebibyte;
        private long? _mebibyteCount;
        private long? _memoryAllocation;
        private long? _memoryAvailable;
        private long? _memoryUsage;
        private int? _onlineDeviceCount;
        private int? _totalDeviceCount;
        private long? _uploadPerSecond;
        private long? _uploadTotal;

        public Statistic(ManagedInstance instance) : base(instance)
        {
        }

        /// <summary>
        ///     Current CPU usage in 0-100 percent
        /// </summary>
        public float? CpuUsage
        {
            get { return _cpuUsage; }
            set { SetField(ref _cpuUsage, value/100, "CpuUsage"); }
        }

        /// <summary>
        ///     Total system memory
        /// </summary>
        public long? MemoryAvailable
        {
            get { return _memoryAvailable; }
            set { SetField(ref _memoryAvailable, value, "MemoryAvailable"); }
        }

        /// <summary>
        ///     Currently used memory
        /// </summary>
        public long? MemoryUsage
        {
            get { return _memoryUsage; }
            set { SetField(ref _memoryUsage, value, "MemoryUsage"); }
        }

        /// <summary>
        ///     Currently allocated memory
        /// </summary>
        public long? MemoryAllocation
        {
            get { return _memoryAllocation; }
            set { SetField(ref _memoryAllocation, value, "MemoryAllocation"); }
        }

        /// <summary>
        ///     Currently running GO routines
        /// </summary>
        public int? GoRoutineCount
        {
            get { return _goRoutineCount; }
            set { SetField(ref _goRoutineCount, value, "GoRoutineCount"); }
        }

        /// <summary>
        ///     Evaluated system crypto performance
        /// </summary>
        public float? CryptPerformance
        {
            get { return _cryptPerformance; }
            set { SetField(ref _cryptPerformance, value, "CryptPerformance"); }
        }

        /// <summary>
        ///     Local client to syncthing instance latency in milliseconds
        /// </summary>
        /// <remarks>Measured via ICMP ping</remarks>
        public float? ClientToInstanceLatency
        {
            get { return _clientToInstanceLatency; }
            set { SetField(ref _clientToInstanceLatency, value, "ClientToInstanceLatency"); }
        }

        /// <summary>
        ///     Total number of known devices
        /// </summary>
        public int? TotalDeviceCount
        {
            get { return _totalDeviceCount; }
            set { SetField(ref _totalDeviceCount, value, "TotalDeviceCount"); }
        }

        /// <summary>
        ///     Total number of currently online remote devices
        /// </summary>
        /// <remarks>Might not be lower or equal to TotalDeviceCount as the numbers are based on two different calls</remarks>
        public int? OnlineDeviceCount
        {
            get { return _onlineDeviceCount; }
            set { SetField(ref _onlineDeviceCount, value, "OnlineDeviceCount"); }
        }

        /// <summary>
        ///     Total count of folders
        /// </summary>
        public int? FolderCount
        {
            get { return _folderCount; }
            set { SetField(ref _folderCount, value, "FolderCount"); }
        }

        /// <summary>
        ///     Total file count
        /// </summary>
        public long? FileCount
        {
            get { return _fileCount; }
            set { SetField(ref _fileCount, value, "FileCount"); }
        }

        /// <summary>
        ///     Total byte count
        /// </summary>
        public long? MebibyteCount
        {
            get { return _mebibyteCount; }
            set { SetField(ref _mebibyteCount, value, "MebibyteCount"); }
        }

        /// <summary>
        ///     How many files does the largest folder contain
        /// </summary>
        public long? LargestFolderFileCount
        {
            get { return _largestFolderFileCount; }
            set { SetField(ref _largestFolderFileCount, value, "LargestFolderFileCount"); }
        }

        /// <summary>
        ///     What is the size of the largest folder
        /// </summary>
        public long? LargestFolderMaxMebibyte
        {
            get { return _largestFolderMaxMebibyte; }
            set { SetField(ref _largestFolderMaxMebibyte, value, "LargestFolderMaxMebibyte"); }
        }

        /// <summary>
        ///     Average uploaded bytes per second
        /// </summary>
        public long? UploadPerSecond
        {
            get { return _uploadPerSecond; }
            set { SetField(ref _uploadPerSecond, value, "UploadPerSecond"); }
        }

        /// <summary>
        ///     Average downloaded bytes per second
        /// </summary>
        public long? DownloadPerSecond
        {
            get { return _downloadPerSecond; }
            set { SetField(ref _downloadPerSecond, value, "DownloadPerSecond"); }
        }

        /// <summary>
        ///     Total upload in bytes since the instance started
        /// </summary>
        public long? UploadTotal
        {
            get { return _uploadTotal; }
            set { SetField(ref _uploadTotal, value, "UploadTotal"); }
        }

        /// <summary>
        ///     Total download in bytes since the instance started
        /// </summary>
        public long? DownloadTotal
        {
            get { return _downloadTotal; }
            set { SetField(ref _downloadTotal, value, "DownloadTotal"); }
        }

        public override void Clear()
        {
            ClientToInstanceLatency = null;
            CpuUsage = null;
            CryptPerformance = null;
            DownloadPerSecond = null;
            FileCount = null;
            FolderCount = null;
            GoRoutineCount = null;
            LargestFolderFileCount = null;
            LargestFolderMaxMebibyte = null;
            MebibyteCount = null;
            MemoryAllocation = null;
            MemoryAvailable = null;
            MemoryUsage = null;
            OnlineDeviceCount = null;
            TotalDeviceCount = null;
            UploadPerSecond = null;
            UploadTotal = null;
        }
    }
}