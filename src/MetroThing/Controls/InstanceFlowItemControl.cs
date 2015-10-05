using System;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroThing.Core.Helpers;
using MetroThing.Core.Manager;
using MetroThing.Types;
using Stateless;
using SyncthingCore;

namespace MetroThing.Controls
{
    public partial class InstanceFlowItemControl : MetroUserControl
    {
        private readonly StateMachine<State, Trigger> _fsm = new StateMachine<State, Trigger>(State.Uninitialized);
        private ManagedInstance _instance;

        public InstanceFlowItemControl()
        {
            InitializeComponent();

            ConfigureStateMachine();
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public ManagedInstance Instance
        {
            get { return _instance; }
            set
            {
                // Clear old
                if (_instance != null)
                {
                    deviceIdentityTextBox.DataBindings.Clear();
                    instanceNameLabel.DataBindings.Clear();
                }

                // Set new
                if (value != null)
                {
                    // Add bindings
                    deviceIdentityTextBox.DataBindings.Add("Text", value.Information, "SyncthingId");
                    instanceNameLabel.DataBindings.Add("Text", value.Information, "DisplayName");

                    // Configure user controls
                    connectivityTile.Instance = value;
                    cpuUsageTile.Instance = value;
                    ramUsageTile.Instance = value;
                    identiconTile.Instance = value;
                    discoveryTile.Instance = value;
                    versionUpgradeTile.Instance = value;
                    deviceQrTile.Instance = value;
                    uploadSpeedTile.Instance = value;
                    downloadSpeedTile.Instance = value;
                    sharedFoldersTile.Instance = value;
                    connectedDevicesTile.Instance = value;
                    overallSyncProgressTile.Instance = value;

                    // Add listeners
                    value.Connected += OnConnected;
                    value.Disconnected += OnDisconnected;
                }

                _instance = value;
            }
        }

        private void OnDisconnected(object sender, InstanceEventArgs e)
        {
            deviceIpTextBox.Text = "n/a";
            identityCopyToClipboardButton.Visible = false;

            deviceIdentityTextBox.Text = "n/a";
        }

        private void OnConnected(object sender, InstanceEventArgs e)
        {
            try
            {
                var ipAddresses = Dns.GetHostEntry(Instance.ConnectedEndpoint.Hostname);
                if (ipAddresses != null)
                    deviceIpTextBox.Text = String.Join(Environment.NewLine, ipAddresses.AddressList.ToList());

                informationTooltip.SetToolTip(deviceIpTextBox, "");

                identityCopyToClipboardButton.Visible = true;
            }
            catch (NullReferenceException exception)
            {
                deviceIpTextBox.Text = "Error";
                informationTooltip.SetToolTip(deviceIpTextBox, exception.Message);
            }
        }

        private void ConfigureBindings(ManagedInstance instance)
        {
            // CPU tile
            var cpuTileBinding = new Binding("Text", instance.Statistics, "CpuUsage")
            {
                FormatString = "P1",
                FormattingEnabled = true
            };

            // RAM tile
            var ramTileBinding = new Binding("Text", instance.Statistics, "MemoryUsage");
            ramTileBinding.Format += delegate(object sender, ConvertEventArgs e)
            {
                if (e.DesiredType != typeof (string)) return;
                e.Value = StringHelper.ConvertByteSizeToHumanReadable((long) e.Value);
            };
        }

        private void ConfigureStateMachine()
        {
            _fsm.Configure(State.Uninitialized)
                .Permit(Trigger.Initialize, State.Disconnected);

            _fsm.Configure(State.Disconnected)
                .Permit(Trigger.Connect, State.Connected);

            _fsm.Configure(State.Connected)
                .Permit(Trigger.Disconnect, State.Disconnected)
                .Permit(Trigger.Upgrade, State.AwaitingUpgrade);

            _fsm.Configure(State.AwaitingUpgrade)
                .Permit(Trigger.Connect, State.Connected);

            _fsm.OnUnhandledTrigger((state, trigger) => { });

            _fsm.Fire(Trigger.Initialize);
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(deviceIdentityTextBox.Text.Trim());
        }

        private void removeInstanceTile_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(FindForm(), String.Format(
                "The connection to instance [{0}] will be removed!\n\nAre you sure?",
                Instance.Information.DisplayName), "Remove connection",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Singleton<SyncthingInstanceManager>.Instance.Remove(Instance);
            }
        }

        private async void restartTile_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(FindForm(), String.Format(
                "The instance [{0}] will be restarted. It might be unavailable for some time.\n\nAre you sure?",
                Instance.Information.DisplayName), "Restart instance",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                await Instance.RestartAsync();
                mainTabControl.SelectTab(0);
            }
        }

        private async void rescanAllTile_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(FindForm(), String.Format(
                "The instance [{0}] will now rescan all folders. This might cause heavy load for some time.\n\nAre you sure?",
                Instance.Information.DisplayName), "Rescan all folders",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (true)
            {
                await Instance.RescanAllAsync();
            }
        }

        private enum State
        {
            Uninitialized,
            Disconnected,
            AwaitingUpgrade,
            Connected
        }

        private enum Trigger
        {
            Initialize,
            Connect,
            Upgrade,
            Disconnect
        }
    }
}