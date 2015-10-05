using System;
using System.ComponentModel;
using MetroFramework.Controls;
using SyncthingCore;

namespace MetroThing.Controls
{
    public partial class ConnectedDevicesTile : MetroUserControl
    {
        private ManagedInstance _instance;

        public ConnectedDevicesTile()
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
                {
                    _instance.Statistics.PropertyChanged -= OnPropertyChanged;
                    _instance.Disconnected -= OnDisconnected;
                }


                // Attach new event listeners
                if (value != null)
                {
                    value.Statistics.PropertyChanged += OnPropertyChanged;
                    value.Disconnected += OnDisconnected;
                }

                _instance = value;
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "TotalDeviceCount" && e.PropertyName != "OnlineDeviceCount") return;
            if (Instance.Statistics.TotalDeviceCount == null || Instance.Statistics.OnlineDeviceCount == null) return;

            var totalDevices = Instance.Statistics.TotalDeviceCount;
            var onlineDevices = Instance.Statistics.OnlineDeviceCount;

            devicesTile.Text = String.Format("{0} / {1}", onlineDevices, totalDevices);

            Tooltip.SetToolTip(devicesTile, String.Format("{0} of {1} known devices are currently connected",
                onlineDevices, totalDevices));
        }

        private void OnDisconnected(object sender, InstanceEventArgs e)
        {
            devicesTile.Text = String.Empty;
            Tooltip.RemoveAll();
        }
    }
}