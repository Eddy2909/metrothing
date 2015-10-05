namespace SyncthingCore.Types
{
    public class Synchronization : BaseType
    {
        private long? _totalNeededBytes;
        private long? _totalNeededFiles;

        public Synchronization(ManagedInstance instance) : base(instance)
        {
        }

        /// <summary>
        ///     Currently needed bytes for this instance, calculcated over all available folders
        /// </summary>
        public long? TotalNeededBytes
        {
            get { return _totalNeededBytes; }
            set { SetField(ref _totalNeededBytes, value, "TotalNeededBytes"); }
        }

        /// <summary>
        ///     Currently needed files for this instance, calculcated over all available folders
        /// </summary>
        public long? TotalNeededFiles
        {
            get { return _totalNeededFiles; }
            set { SetField(ref _totalNeededFiles, value, "TotalNeededFiles"); }
        }

        public override void Clear()
        {
            _totalNeededBytes = null;
            _totalNeededFiles = null;
        }
    }
}