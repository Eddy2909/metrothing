using System;
using System.ComponentModel;
using MetroFramework.Controls;
using MetroThing.Core.Helpers;
using SyncthingCore;

namespace MetroThing.Controls
{
    public partial class SharedFoldersTile : MetroUserControl
    {
        private ManagedInstance _instance;

        public SharedFoldersTile()
        {
            InitializeComponent();
        }

        public ManagedInstance Instance
        {
            get { return _instance; }
            set
            {
                // Clear old event listeners
                if (_instance != null)
                    _instance.Statistics.PropertyChanged -= OnPropertyChanged;

                // Attach new event listeners
                if (value != null)
                    value.Statistics.PropertyChanged += OnPropertyChanged;

                _instance = value;
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "FileCount")
            {
                var files = Instance.Statistics.FileCount;
                foldersTile.Text = StringHelper.ConvertLongToHumanReadableWithUnitPrefix(files);
            }

            if (e.PropertyName == "FolderCount" || e.PropertyName == "FileCount" || e.PropertyName == "MebibyteCount")
            {
                Tooltip.SetToolTip(
                    foldersTile,
                    String.Format("{0:N0} files ({1:N0} MiB) in {2:N0} shared folders",
                        Instance.Statistics.FileCount,
                        Instance.Statistics.MebibyteCount,
                        Instance.Statistics.FolderCount
                        ));
            }
        }
    }
}