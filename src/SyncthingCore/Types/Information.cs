namespace SyncthingCore.Types
{
    public class Information : BaseType
    {
        private string _displayName;
        private bool? _isUpgradeAvailable;
        private string _latestVersion;
        private string _longVersion;
        private string _operatingSystem;
        private string _platform;
        private string _syncthingId;
        private string _version;

        public Information(ManagedInstance instance) : base(instance)
        {
        }

        /// <summary>
        ///     The device ID
        /// </summary>
        public string SyncthingId
        {
            get { return _syncthingId; }
            set { SetField(ref _syncthingId, value, "SyncthingId"); }
        }

        public string DisplayName
        {
            get { return _displayName; }
            set { SetField(ref _displayName, value, "DisplayName"); }
        }

        /// <summary>
        ///     Long version string of the currently running instance
        /// </summary>
        public string LongVersion
        {
            get { return _longVersion; }
            set { SetField(ref _longVersion, value, "LongVersion"); }
        }

        /// <summary>
        ///     Operating system of the running instance
        /// </summary>
        public string OperatingSystem
        {
            get { return _operatingSystem; }
            set { SetField(ref _operatingSystem, value, "OperatingSystem"); }
        }

        /// <summary>
        ///     Platform identifier of the running instance
        /// </summary>
        public string Platform
        {
            get { return _platform; }
            set { SetField(ref _platform, value, "Platform"); }
        }

        /// <summary>
        ///     Semantic version number of the currently running instance
        /// </summary>
        public string Version
        {
            get { return _version; }
            set { SetField(ref _version, value, "Version"); }
        }

        /// <summary>
        ///     Can the underlying Syncthing version upgraded
        /// </summary>
        public bool? IsUpgradeAvailable
        {
            get { return _isUpgradeAvailable; }
            set { SetField(ref _isUpgradeAvailable, value, "IsUpgradeAvailable"); }
        }

        /// <summary>
        ///     What is the latest version available as reported by the upgrade check
        /// </summary>
        public string LatestVersion
        {
            get { return _latestVersion; }
            set { SetField(ref _latestVersion, value, "LatestVersion"); }
        }

        public override void Clear()
        {
            SyncthingId = null;
            DisplayName = null;
            LongVersion = null;
            OperatingSystem = null;
            Platform = null;
            Version = null;
            IsUpgradeAvailable = null;
            LatestVersion = null;
        }
    }
}