using System;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroThing.Core.Helpers;
using SyncthingCore;
using SyncthingCore.Types;

namespace MetroThing.Controls
{
    public partial class OverallSyncProgressTile : MetroUserControl
    {
        private ManagedInstance _instance;
        private long? currentMaxBytes;

        public OverallSyncProgressTile()
        {
            InitializeComponent();
            Clear();
        }

        public ManagedInstance Instance
        {
            get { return _instance; }
            set
            {
                // Clear old event listeners
                if (_instance != null)
                {
                    _instance.Synchronization.PropertyChanged -= OnPropertyChanged;
                    _instance.Disconnected -= OnDisconnected;
                }

                // Attach new event listeners
                if (value != null)
                {
                    value.Synchronization.PropertyChanged += OnPropertyChanged;
                    value.Disconnected += OnDisconnected;
                }

                _instance = value;
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var sync = (Synchronization) sender;

            if (e.PropertyName == "TotalNeededBytes" || e.PropertyName == "TotalNeededFiles")
            {
                if (sync.TotalNeededBytes != null && sync.TotalNeededFiles != null)
                {
                    if (currentMaxBytes == null || sync.TotalNeededBytes > currentMaxBytes)
                        currentMaxBytes = sync.TotalNeededBytes;

                    if (sync.TotalNeededBytes == 0)
                    {
                        statusLabel.Text = "Synchronized";
                        detailLabel.Text = String.Empty;
                        progressBar.Value = 100;

                        currentMaxBytes = null;
                    }
                    else
                    {
                        statusLabel.Text = "Synchronizing:";
                        detailLabel.Text = String.Format("{0:N0} files ({1})",
                            sync.TotalNeededFiles, StringHelper.ConvertByteSizeToHumanReadable(sync.TotalNeededBytes));

                        progressBar.ProgressBarStyle = ProgressBarStyle.Blocks;

                        // Set the progress bar value
                        progressBar.Value =
                            (int) (((float) (currentMaxBytes - sync.TotalNeededBytes)/(float) currentMaxBytes)*100);
                    }

                    progressBar.Visible = true;
                    progressBar.Refresh();
                }
                else
                {
                    Clear();
                }
            }
        }

        private void OnDisconnected(object sender, InstanceEventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            currentMaxBytes = null;

            statusLabel.Text = String.Empty;
            detailLabel.Text = String.Empty;
            progressBar.ProgressBarStyle = ProgressBarStyle.Continuous;
            progressBar.Value = 100;
            progressBar.Visible = false;
            progressBar.Refresh();
        }
    }
}