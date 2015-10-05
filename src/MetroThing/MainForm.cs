using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroThing.Controls;
using MetroThing.Core.Helpers;
using MetroThing.Core.Manager;
using MetroThing.Forms;
using MetroThing.Properties;
using MetroThing.Types;
using Serilog;
using SyncthingCore;

namespace MetroThing
{
    public partial class MainForm : MetroForm
    {
        private readonly Dictionary<Guid, InstanceFlowItemControl> _instanceUiControls =
            new Dictionary<Guid, InstanceFlowItemControl>();

        private string _changelog;

        public MainForm()
        {
            // Subscribe to possible installation manager events
            Singleton<InstallationManager>.Instance.VersionUpdated += OnInsstallerEvent;

            InitializeComponent();

            versionLabel.Text = @"v" + Version;

            NotifyIcon.Text = "metro.thing " + versionLabel.Text;
            NotifyIcon.Icon = Resources.app;

            ShowInTaskbar = !Settings.Default.ShowOnlyInTaskbar;
        }

        public static string Version
        {
            get
            {
                var version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

                return String.Format("{0}.{1}.{2}",
                    version.ProductMajorPart, version.FileMinorPart, version.ProductBuildPart);
            }
        }

        private void OnInsstallerEvent(object sender, Tuple<string, string> tuple)
        {
            if (versionUpgradedNoticeTile.InvokeRequired)
            {
                versionUpgradedNoticeTile.Invoke(new Action(() =>
                {
                    versionUpgradedNoticeTile.Text = String.Format("App was updated to v{0}, click here restart!",
                        tuple.Item1);
                    versionUpgradedNoticeTile.Visible = true;

                    changelogTile.Visible = true;
                    _changelog = tuple.Item2;
                }));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set main icon
            Icon = Resources.app;

            // Initialize logger
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .ReadAppSettings()
                .CreateLogger();

            // Restore window settings
            if (Settings.Default.MainFormMaximized)
            {
                WindowState = FormWindowState.Maximized;
                Location = Settings.Default.MainFormLocation;
                Size = Settings.Default.MainFormSize;
            }
            else if (Settings.Default.MainFormMinimized)
            {
                WindowState = FormWindowState.Minimized;
                Location = Settings.Default.MainFormLocation;
                Size = Settings.Default.MainFormSize;
            }
            else
            {
                if (!Settings.Default.MainFormLocation.IsEmpty)
                    Location = Settings.Default.MainFormLocation;

                if (!Settings.Default.MainFormSize.IsEmpty)
                    Size = Settings.Default.MainFormSize;

                if (Settings.Default.MainFormLocation.IsEmpty && Settings.Default.MainFormSize.IsEmpty)
                {
                    StartPosition = FormStartPosition.CenterScreen;
                }
            }

            Settings.Default.PropertyChanged += OnSettingsChanged;

            // Register to instance change
            Singleton<SyncthingInstanceManager>.Instance.CollectionChanged += OnSyncthingInstancesCollectionChanged;

            Singleton<NetworkTotalsManager>.Instance.TotalsChanged += OnNetworkTotalsChanged;

            // Restore settings
            AppSettings.Load(this);
        }

        private void OnSettingsChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ShowOnlyInTaskbar")
                ShowInTaskbar = !Settings.Default.ShowOnlyInTaskbar;
        }

        private void OnSyncthingInstancesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Log.Logger.Verbose("{@this} noticed a change in the available syncthing instances due to [{@action}]", Name,
                e.Action);

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (ManagedInstance entry in e.NewItems)
                    {
                        var instanceControl = new InstanceFlowItemControl {Parent = instancesFlowLayoutPanel};
                        _instanceUiControls.Add(entry.Id, instanceControl);

                        instanceControl.Instance = entry;
                    }
                    break;

                case NotifyCollectionChangedAction.Remove:
                    foreach (ManagedInstance entry in e.OldItems)
                    {
                        if (_instanceUiControls.ContainsKey(entry.Id))
                        {
                            var control = _instanceUiControls[entry.Id];
                            instancesFlowLayoutPanel.Controls.Remove(control);

                            _instanceUiControls.Remove(entry.Id);
                        }
                    }
                    break;

                case NotifyCollectionChangedAction.Reset:
                    foreach (var control in _instanceUiControls)
                    {
                        instancesFlowLayoutPanel.Controls.Remove(control.Value);
                    }
                    _instanceUiControls.Clear();
                    break;
            }
        }

        private void OnNetworkTotalsChanged(object sender, EventArgs e)
        {
            var totals = (NetworkTotalsManager) sender;

            NotifyIcon.Text =
                String.Format("metro.thing " + versionLabel.Text + Environment.NewLine + "Totals: " +
                              StringHelper.ConvertByteSizeToHumanReadable(totals.TotalBytesInPerSecond)) + "/s down, " +
                StringHelper.ConvertByteSizeToHumanReadable(totals.TotalBytesOutPerSecond) + "/s up";
        }

        private AddInstanceForm CreateAddInstanceForm()
        {
            return new AddInstanceForm();
        }

        private SettingsForm CreateSettingsForm()
        {
            return new SettingsForm();
        }

        private OpenSharedFolderForm CreateOpenSharedFolderForm()
        {
            return new OpenSharedFolderForm(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Visible && Settings.Default.CloseToTray)
            {
                e.Cancel = true;
                Hide();

                return;
            }

            // Save window settings
            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    Settings.Default.MainFormLocation = RestoreBounds.Location;
                    Settings.Default.MainFormSize = RestoreBounds.Size;
                    Settings.Default.MainFormMaximized = true;
                    Settings.Default.MainFormMinimized = false;
                    break;
                case FormWindowState.Normal:
                    Settings.Default.MainFormLocation = Location;
                    Settings.Default.MainFormSize = Size;
                    Settings.Default.MainFormMaximized = false;
                    Settings.Default.MainFormMinimized = false;
                    break;
                default:
                    Settings.Default.MainFormLocation = RestoreBounds.Location;
                    Settings.Default.MainFormSize = RestoreBounds.Size;
                    Settings.Default.MainFormMaximized = false;
                    Settings.Default.MainFormMinimized = true;
                    break;
            }

            Settings.Default.Save();
            AppSettings.Save();
        }

        private void addInstanceTile_Click(object sender, EventArgs e)
        {
            var form = CreateAddInstanceForm();
            form.ShowDialog();
            BringToFront();
        }

        private void githubTile_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/kreischweide/metrothing");
        }

        private void settingsTile_Click(object sender, EventArgs e)
        {
            var form = CreateSettingsForm();
            form.ShowDialog();
            BringToFront();
        }

        private void openSharedFolderTile_Click(object sender, EventArgs e)
        {
            var form = CreateOpenSharedFolderForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            form.Dispose();
            BringToFront();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new OpenSharedFolderForm(this);
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point(MousePosition.X - form.Width, MousePosition.Y - form.Height);
                form.Show();
                form.TopMost = true;
                form.ShowContextElements();
                form.BringToFront();
                form.Focus();
            }
            catch (ObjectDisposedException)
            {
                // We ignore this one, as the form might already be disposed while its opening during startup. Edgecase hopefully.
            }
        }

        private void versionUpgradedNoticeTile_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void changelogTile_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(_changelog))
            {
                Process.Start(@"https://github.com/kreischweide/metrothing/releases");
            }
            else
            {
                var form = new ChangelogForm(_changelog);
                form.Show();
            }
        }
    }
}