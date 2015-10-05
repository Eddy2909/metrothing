using System;
using System.ComponentModel;
using MetroFramework;
using MetroFramework.Controls;
using MetroThing.Core.Helpers;
using MetroThing.Forms;
using SyncthingCore;

namespace MetroThing.Controls
{
    public partial class DownloadSpeedTile : MetroUserControl
    {
        private ManagedInstance _instance;

        public DownloadSpeedTile()
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
            switch (e.PropertyName)
            {
                case "DownloadPerSecond":
                    var speed = Instance.Statistics.DownloadPerSecond;

                    downloadTile.Style = speed > 0 ? MetroColorStyle.Pink : MetroColorStyle.Purple;
                    downloadLabel.Text = speed > 0 ? StringHelper.ConvertByteSizeToHumanReadable(speed) : "";

                    downloadTile.Refresh();
                    break;

                case "DownloadTotal":
                    if (Instance.Statistics.DownloadTotal != null)
                    {
                        Tooltip.SetToolTip(downloadLabel, String.Format(
                            "Total download since restart: {0}",
                            StringHelper.ConvertByteSizeToHumanReadable(Instance.Statistics.DownloadTotal)));
                    }
                    else
                    {
                        Tooltip.RemoveAll();
                    }
                    break;
            }
        }

        private void DownloadSpeedTile_Click(object sender, EventArgs e)
        {
            var form = new NeedQueueForm(Instance);
            form.Show();
        }
    }
}