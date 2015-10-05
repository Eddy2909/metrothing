using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroThing.Properties;
using SyncthingCore;

namespace MetroThing.Controls
{
    public partial class VersionUpgradeTile : MetroUserControl
    {
        private ManagedInstance _instance;

        public VersionUpgradeTile()
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
                    _instance.Information.PropertyChanged -= OnPropertyChanged;

                // Attach new event listeners
                if (value != null)
                    value.Information.PropertyChanged += OnPropertyChanged;

                _instance = value;
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "IsUpgradeAvailable") return;

            if (Instance.Information.IsUpgradeAvailable == null)
            {
                versionSpinner.Spinning = true;
                versionSpinner.Visible = true;

                versionTile.Style = MetroColorStyle.Orange;
                versionTile.Refresh();
            }
            else if ((bool) Instance.Information.IsUpgradeAvailable)
            {
                versionSpinner.Spinning = false;
                versionSpinner.Visible = false;

                versionTile.Style = MetroColorStyle.Orange;
                versionTile.TileImage = Resources.fontawesome_50_bright_reload;

                Tooltip.SetToolTip(this, String.Format(
                    "Upgrade available from {0} to {1}",
                    Instance.Information.Version, Instance.Information.LatestVersion));
            }
            else
            {
                versionSpinner.Spinning = false;
                versionSpinner.Visible = false;

                versionTile.Style = MetroColorStyle.Lime;
                versionTile.TileImage = Resources.fontawesome_50_bright_positive;

                Tooltip.SetToolTip(this, String.Format(
                    "Running current version {0}", Instance.Information.Version));
            }

            versionTile.Refresh();
        }

        private async void versionTile_Click(object sender, EventArgs e)
        {
            if ((bool) !Instance.Information.IsUpgradeAvailable) return;

            var result = MetroMessageBox.Show(FindForm(), String.Format(
                "The instance on [{0}] will be upgraded, restarted and might be unavailable for some time.\n\nDo you want to upgrade now?",
                Instance.Information.DisplayName), "Upgrade Syncthing version",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                await Instance.UpgradeAsync();

                await Task.Delay(TimeSpan.FromSeconds(10));

                Instance.Disconnect();
            }
        }
    }
}