using System;
using System.ComponentModel;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Controls;
using MetroThing.Properties;
using SyncthingCore;
using SyncthingCore.Types;
using SyncthingCore.Worker;

namespace MetroThing.Controls
{
    public partial class ConnectivityTile : MetroUserControl
    {
        private ManagedInstance _instance;

        public ConnectivityTile()
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
                    _instance.Connected -= OnConnected;
                    _instance.ConnectionChecked -= OnConnectionChecked;
                    _instance.Disconnected -= OnDisconnected;
                    _instance.Statistics.PropertyChanged -= OnPropertyChanged;
                }

                // Attach new event listeners
                if (value != null)
                {
                    value.Connected += OnConnected;
                    value.ConnectionChecked += OnConnectionChecked;
                    value.Disconnected += OnDisconnected;
                    value.Statistics.PropertyChanged += OnPropertyChanged;
                }

                _instance = value;
            }
        }

        private void OnConnected(object sender, InstanceEventArgs e)
        {
            idleSpinner.Visible = false;
            idleSpinner.Spinning = false;

            heartTile.Style = MetroColorStyle.Lime;
            heartTile.TileImage = Resources.fontawesome_50_bright_heart;
            heartTile.Visible = true;
            heartTile.Refresh();
        }

        private void OnDisconnected(object sender, InstanceEventArgs e)
        {
            heartTile.Style = MetroColorStyle.Red;
            heartTile.Visible = true;

            idleSpinner.Style = MetroColorStyle.Red;
            idleSpinner.Visible = true;
            idleSpinner.Spinning = true;

            heartTile.Refresh();
            idleSpinner.Refresh();

            Tooltip.SetToolTip(this, "Service is currently not reachable");
        }

        private async void OnConnectionChecked(object sender, HeartbeatWorkerEventArgs e)
        {
            if (!e.ApiAlive) return;

            heartTile.TileImage = Resources.fontawesome_50_bright_heart_beat;
            heartTile.Refresh();

            await Task.Delay(TimeSpan.FromMilliseconds(200));

            heartTile.TileImage = Resources.fontawesome_50_bright_heart;
            heartTile.Refresh();
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var stats = (Statistic) sender;

            if (e.PropertyName != "ClientToInstanceLatency") return;

            if (stats.ClientToInstanceLatency != null)
            {
                Tooltip.SetToolTip(this, String.Format(
                    "Service available with a latency of {0}ms", Instance.Statistics.ClientToInstanceLatency
                    ));
            }
            else
            {
                if (Instance.IsInState(ManagedInstance.State.Connected))
                    Tooltip.SetToolTip(this, "Service available, but not pingable");
            }
        }
    }
}