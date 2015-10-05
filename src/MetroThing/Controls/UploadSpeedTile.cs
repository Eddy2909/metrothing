using System;
using System.ComponentModel;
using MetroFramework;
using MetroFramework.Controls;
using MetroThing.Core.Helpers;
using SyncthingCore;

namespace MetroThing.Controls
{
    public partial class UploadSpeedTile : MetroUserControl
    {
        private ManagedInstance _instance;

        public UploadSpeedTile()
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
                case "UploadPerSecond":
                    var speed = Instance.Statistics.UploadPerSecond;

                    uploadTile.Style = speed > 0 ? MetroColorStyle.Pink : MetroColorStyle.Purple;
                    uploadTile.Refresh();

                    uploadLabel.Text = speed > 0 ? StringHelper.ConvertByteSizeToHumanReadable(speed) : "";
                    break;

                case "UploadTotal":
                    if (Instance.Statistics.UploadTotal != null)
                    {
                        Tooltip.SetToolTip(this, String.Format(
                            "Total upload since restart: {0}",
                            StringHelper.ConvertByteSizeToHumanReadable(Instance.Statistics.UploadTotal)));
                    }
                    else
                    {
                        Tooltip.RemoveAll();
                    }
                    break;
            }
        }
    }
}