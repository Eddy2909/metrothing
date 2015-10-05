namespace MetroThing.Controls
{
    partial class InstanceFlowItemControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.overviewTabPage = new MetroFramework.Controls.MetroTabPage();
            this.instanceNameLabel = new MetroFramework.Controls.MetroLabel();
            this.identityTabPage = new MetroFramework.Controls.MetroTabPage();
            this.deviceIpTextBox = new System.Windows.Forms.TextBox();
            this.deviceIpLabel = new MetroFramework.Controls.MetroLabel();
            this.identityCopyToClipboardButton = new MetroFramework.Controls.MetroButton();
            this.deviceIdentityLabel = new MetroFramework.Controls.MetroLabel();
            this.deviceIdentityTextBox = new System.Windows.Forms.TextBox();
            this.settingsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.rescanAllTile = new MetroFramework.Controls.MetroTile();
            this.removeInstanceTile = new MetroFramework.Controls.MetroTile();
            this.restartTile = new MetroFramework.Controls.MetroTile();
            this.applySettingsButton = new MetroFramework.Controls.MetroButton();
            this.informationTooltip = new MetroFramework.Components.MetroToolTip();
            this.overallSyncProgressTile = new MetroThing.Controls.OverallSyncProgressTile();
            this.connectedDevicesTile = new MetroThing.Controls.ConnectedDevicesTile();
            this.sharedFoldersTile = new MetroThing.Controls.SharedFoldersTile();
            this.downloadSpeedTile = new MetroThing.Controls.DownloadSpeedTile();
            this.uploadSpeedTile = new MetroThing.Controls.UploadSpeedTile();
            this.versionUpgradeTile = new MetroThing.Controls.VersionUpgradeTile();
            this.discoveryTile = new MetroThing.Controls.DiscoveryTile();
            this.identiconTile = new MetroThing.Controls.IdenticonTile();
            this.ramUsageTile = new MetroThing.Controls.RamUsageTile();
            this.cpuUsageTile = new MetroThing.Controls.CpuUsageTile();
            this.connectivityTile = new MetroThing.Controls.ConnectivityTile();
            this.deviceQrTile = new MetroThing.Controls.DeviceQrTile();
            this.mainTabControl.SuspendLayout();
            this.overviewTabPage.SuspendLayout();
            this.identityTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.overviewTabPage);
            this.mainTabControl.Controls.Add(this.identityTabPage);
            this.mainTabControl.Controls.Add(this.settingsTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(427, 225);
            this.mainTabControl.TabIndex = 3;
            this.mainTabControl.UseSelectable = true;
            // 
            // overviewTabPage
            // 
            this.overviewTabPage.Controls.Add(this.overallSyncProgressTile);
            this.overviewTabPage.Controls.Add(this.connectedDevicesTile);
            this.overviewTabPage.Controls.Add(this.sharedFoldersTile);
            this.overviewTabPage.Controls.Add(this.downloadSpeedTile);
            this.overviewTabPage.Controls.Add(this.uploadSpeedTile);
            this.overviewTabPage.Controls.Add(this.versionUpgradeTile);
            this.overviewTabPage.Controls.Add(this.discoveryTile);
            this.overviewTabPage.Controls.Add(this.identiconTile);
            this.overviewTabPage.Controls.Add(this.ramUsageTile);
            this.overviewTabPage.Controls.Add(this.cpuUsageTile);
            this.overviewTabPage.Controls.Add(this.connectivityTile);
            this.overviewTabPage.Controls.Add(this.instanceNameLabel);
            this.overviewTabPage.HorizontalScrollbarBarColor = true;
            this.overviewTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.overviewTabPage.HorizontalScrollbarSize = 10;
            this.overviewTabPage.Location = new System.Drawing.Point(4, 38);
            this.overviewTabPage.Name = "overviewTabPage";
            this.overviewTabPage.Size = new System.Drawing.Size(419, 183);
            this.overviewTabPage.TabIndex = 0;
            this.overviewTabPage.Text = "Overview";
            this.overviewTabPage.VerticalScrollbarBarColor = true;
            this.overviewTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.overviewTabPage.VerticalScrollbarSize = 10;
            // 
            // instanceNameLabel
            // 
            this.instanceNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.instanceNameLabel.Location = new System.Drawing.Point(0, 160);
            this.instanceNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.instanceNameLabel.Name = "instanceNameLabel";
            this.instanceNameLabel.Size = new System.Drawing.Size(418, 21);
            this.instanceNameLabel.TabIndex = 5;
            this.instanceNameLabel.Text = "INSTANCE-NAME";
            this.instanceNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // identityTabPage
            // 
            this.identityTabPage.Controls.Add(this.deviceIpTextBox);
            this.identityTabPage.Controls.Add(this.deviceIpLabel);
            this.identityTabPage.Controls.Add(this.identityCopyToClipboardButton);
            this.identityTabPage.Controls.Add(this.deviceIdentityLabel);
            this.identityTabPage.Controls.Add(this.deviceIdentityTextBox);
            this.identityTabPage.Controls.Add(this.deviceQrTile);
            this.identityTabPage.HorizontalScrollbarBarColor = true;
            this.identityTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.identityTabPage.HorizontalScrollbarSize = 10;
            this.identityTabPage.Location = new System.Drawing.Point(4, 38);
            this.identityTabPage.Name = "identityTabPage";
            this.identityTabPage.Size = new System.Drawing.Size(419, 183);
            this.identityTabPage.TabIndex = 3;
            this.identityTabPage.Text = "Identity";
            this.identityTabPage.VerticalScrollbarBarColor = true;
            this.identityTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.identityTabPage.VerticalScrollbarSize = 10;
            // 
            // deviceIpTextBox
            // 
            this.deviceIpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deviceIpTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceIpTextBox.Location = new System.Drawing.Point(187, 125);
            this.deviceIpTextBox.Multiline = true;
            this.deviceIpTextBox.Name = "deviceIpTextBox";
            this.deviceIpTextBox.Size = new System.Drawing.Size(224, 49);
            this.deviceIpTextBox.TabIndex = 35;
            this.deviceIpTextBox.Text = "unknown";
            this.deviceIpTextBox.WordWrap = false;
            // 
            // deviceIpLabel
            // 
            this.deviceIpLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.deviceIpLabel.Location = new System.Drawing.Point(186, 106);
            this.deviceIpLabel.Margin = new System.Windows.Forms.Padding(0);
            this.deviceIpLabel.Name = "deviceIpLabel";
            this.deviceIpLabel.Size = new System.Drawing.Size(205, 19);
            this.deviceIpLabel.TabIndex = 33;
            this.deviceIpLabel.Text = "Device IPs:";
            // 
            // identityCopyToClipboardButton
            // 
            this.identityCopyToClipboardButton.Location = new System.Drawing.Point(191, 59);
            this.identityCopyToClipboardButton.Name = "identityCopyToClipboardButton";
            this.identityCopyToClipboardButton.Size = new System.Drawing.Size(172, 23);
            this.identityCopyToClipboardButton.TabIndex = 6;
            this.identityCopyToClipboardButton.Text = "Copy to clipboard";
            this.identityCopyToClipboardButton.UseSelectable = true;
            this.identityCopyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            // 
            // deviceIdentityLabel
            // 
            this.deviceIdentityLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.deviceIdentityLabel.Location = new System.Drawing.Point(186, 4);
            this.deviceIdentityLabel.Name = "deviceIdentityLabel";
            this.deviceIdentityLabel.Size = new System.Drawing.Size(215, 19);
            this.deviceIdentityLabel.TabIndex = 5;
            this.deviceIdentityLabel.Text = "Device Identity:";
            // 
            // deviceIdentityTextBox
            // 
            this.deviceIdentityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deviceIdentityTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceIdentityTextBox.Location = new System.Drawing.Point(191, 26);
            this.deviceIdentityTextBox.Multiline = true;
            this.deviceIdentityTextBox.Name = "deviceIdentityTextBox";
            this.deviceIdentityTextBox.Size = new System.Drawing.Size(210, 27);
            this.deviceIdentityTextBox.TabIndex = 4;
            this.deviceIdentityTextBox.Text = "unknown";
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.rescanAllTile);
            this.settingsTabPage.Controls.Add(this.removeInstanceTile);
            this.settingsTabPage.Controls.Add(this.restartTile);
            this.settingsTabPage.Controls.Add(this.applySettingsButton);
            this.settingsTabPage.HorizontalScrollbarBarColor = true;
            this.settingsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTabPage.HorizontalScrollbarSize = 10;
            this.settingsTabPage.Location = new System.Drawing.Point(4, 38);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(419, 183);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.VerticalScrollbarBarColor = true;
            this.settingsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTabPage.VerticalScrollbarSize = 10;
            // 
            // rescanAllTile
            // 
            this.rescanAllTile.ActiveControl = null;
            this.rescanAllTile.Location = new System.Drawing.Point(266, 3);
            this.rescanAllTile.Name = "rescanAllTile";
            this.rescanAllTile.Size = new System.Drawing.Size(150, 50);
            this.rescanAllTile.Style = MetroFramework.MetroColorStyle.Green;
            this.rescanAllTile.TabIndex = 5;
            this.rescanAllTile.Text = "Rescan folders";
            this.rescanAllTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rescanAllTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_rescan;
            this.rescanAllTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.informationTooltip.SetToolTip(this.rescanAllTile, "Sends the restart command to this instance.");
            this.rescanAllTile.UseSelectable = true;
            this.rescanAllTile.UseTileImage = true;
            this.rescanAllTile.Click += new System.EventHandler(this.rescanAllTile_Click);
            // 
            // removeInstanceTile
            // 
            this.removeInstanceTile.ActiveControl = null;
            this.removeInstanceTile.Location = new System.Drawing.Point(266, 115);
            this.removeInstanceTile.Name = "removeInstanceTile";
            this.removeInstanceTile.Size = new System.Drawing.Size(150, 50);
            this.removeInstanceTile.Style = MetroFramework.MetroColorStyle.Red;
            this.removeInstanceTile.TabIndex = 4;
            this.removeInstanceTile.Text = "Remove instance";
            this.removeInstanceTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeInstanceTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_negative;
            this.removeInstanceTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.informationTooltip.SetToolTip(this.removeInstanceTile, "Removes the instance from the monitoring.");
            this.removeInstanceTile.UseSelectable = true;
            this.removeInstanceTile.UseTileImage = true;
            this.removeInstanceTile.Click += new System.EventHandler(this.removeInstanceTile_Click);
            // 
            // restartTile
            // 
            this.restartTile.ActiveControl = null;
            this.restartTile.Location = new System.Drawing.Point(266, 59);
            this.restartTile.Name = "restartTile";
            this.restartTile.Size = new System.Drawing.Size(150, 50);
            this.restartTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.restartTile.TabIndex = 3;
            this.restartTile.Text = "Restart instance";
            this.restartTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restartTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_reload;
            this.restartTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.informationTooltip.SetToolTip(this.restartTile, "Sends the restart command to this instance.");
            this.restartTile.UseSelectable = true;
            this.restartTile.UseTileImage = true;
            this.restartTile.Click += new System.EventHandler(this.restartTile_Click);
            // 
            // applySettingsButton
            // 
            this.applySettingsButton.Location = new System.Drawing.Point(456, 96);
            this.applySettingsButton.Name = "applySettingsButton";
            this.applySettingsButton.Size = new System.Drawing.Size(75, 23);
            this.applySettingsButton.TabIndex = 1;
            this.applySettingsButton.Text = "Apply";
            this.applySettingsButton.UseSelectable = true;
            // 
            // informationTooltip
            // 
            this.informationTooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.informationTooltip.StyleManager = null;
            this.informationTooltip.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // overallSyncProgressTile
            // 
            this.overallSyncProgressTile.Instance = null;
            this.overallSyncProgressTile.Location = new System.Drawing.Point(213, 4);
            this.overallSyncProgressTile.Name = "overallSyncProgressTile";
            this.overallSyncProgressTile.Size = new System.Drawing.Size(149, 50);
            this.overallSyncProgressTile.Style = MetroFramework.MetroColorStyle.Lime;
            this.overallSyncProgressTile.TabIndex = 35;
            this.overallSyncProgressTile.UseSelectable = true;
            // 
            // connectedDevicesTile
            // 
            this.connectedDevicesTile.Instance = null;
            this.connectedDevicesTile.Location = new System.Drawing.Point(106, 59);
            this.connectedDevicesTile.Name = "connectedDevicesTile";
            this.connectedDevicesTile.Size = new System.Drawing.Size(100, 100);
            this.connectedDevicesTile.TabIndex = 34;
            this.connectedDevicesTile.UseSelectable = true;
            // 
            // sharedFoldersTile
            // 
            this.sharedFoldersTile.Instance = null;
            this.sharedFoldersTile.Location = new System.Drawing.Point(0, 59);
            this.sharedFoldersTile.Name = "sharedFoldersTile";
            this.sharedFoldersTile.Size = new System.Drawing.Size(100, 100);
            this.sharedFoldersTile.TabIndex = 33;
            this.sharedFoldersTile.UseSelectable = true;
            // 
            // downloadSpeedTile
            // 
            this.downloadSpeedTile.Instance = null;
            this.downloadSpeedTile.Location = new System.Drawing.Point(0, 3);
            this.downloadSpeedTile.Name = "downloadSpeedTile";
            this.downloadSpeedTile.Size = new System.Drawing.Size(100, 50);
            this.downloadSpeedTile.TabIndex = 32;
            this.downloadSpeedTile.UseSelectable = true;
            // 
            // uploadSpeedTile
            // 
            this.uploadSpeedTile.Instance = null;
            this.uploadSpeedTile.Location = new System.Drawing.Point(106, 3);
            this.uploadSpeedTile.Name = "uploadSpeedTile";
            this.uploadSpeedTile.Size = new System.Drawing.Size(100, 50);
            this.uploadSpeedTile.TabIndex = 31;
            this.uploadSpeedTile.UseSelectable = true;
            // 
            // versionUpgradeTile
            // 
            this.versionUpgradeTile.Instance = null;
            this.versionUpgradeTile.Location = new System.Drawing.Point(368, 59);
            this.versionUpgradeTile.Name = "versionUpgradeTile";
            this.versionUpgradeTile.Size = new System.Drawing.Size(50, 50);
            this.versionUpgradeTile.TabIndex = 30;
            this.versionUpgradeTile.UseSelectable = true;
            // 
            // discoveryTile
            // 
            this.discoveryTile.Instance = null;
            this.discoveryTile.Location = new System.Drawing.Point(212, 59);
            this.discoveryTile.Name = "discoveryTile";
            this.discoveryTile.Size = new System.Drawing.Size(94, 50);
            this.discoveryTile.TabIndex = 29;
            this.discoveryTile.UseSelectable = true;
            // 
            // identiconTile
            // 
            this.identiconTile.Instance = null;
            this.identiconTile.Location = new System.Drawing.Point(368, 3);
            this.identiconTile.Name = "identiconTile";
            this.identiconTile.Size = new System.Drawing.Size(50, 50);
            this.identiconTile.TabIndex = 28;
            this.identiconTile.UseSelectable = true;
            // 
            // ramUsageTile
            // 
            this.ramUsageTile.Instance = null;
            this.ramUsageTile.Location = new System.Drawing.Point(312, 115);
            this.ramUsageTile.Name = "ramUsageTile";
            this.ramUsageTile.Size = new System.Drawing.Size(106, 44);
            this.ramUsageTile.TabIndex = 27;
            this.ramUsageTile.UseSelectable = true;
            // 
            // cpuUsageTile
            // 
            this.cpuUsageTile.Instance = null;
            this.cpuUsageTile.Location = new System.Drawing.Point(212, 115);
            this.cpuUsageTile.Name = "cpuUsageTile";
            this.cpuUsageTile.Size = new System.Drawing.Size(94, 44);
            this.cpuUsageTile.TabIndex = 26;
            this.cpuUsageTile.UseSelectable = true;
            // 
            // connectivityTile
            // 
            this.connectivityTile.Instance = null;
            this.connectivityTile.Location = new System.Drawing.Point(312, 59);
            this.connectivityTile.Name = "connectivityTile";
            this.connectivityTile.Size = new System.Drawing.Size(50, 50);
            this.connectivityTile.TabIndex = 25;
            this.connectivityTile.UseSelectable = true;
            // 
            // deviceQrTile
            // 
            this.deviceQrTile.Instance = null;
            this.deviceQrTile.Location = new System.Drawing.Point(0, 0);
            this.deviceQrTile.Name = "deviceQrTile";
            this.deviceQrTile.Size = new System.Drawing.Size(180, 180);
            this.deviceQrTile.TabIndex = 34;
            this.deviceQrTile.UseSelectable = true;
            // 
            // InstanceFlowItemControl
            // 
            this.Controls.Add(this.mainTabControl);
            this.Name = "InstanceFlowItemControl";
            this.Size = new System.Drawing.Size(427, 221);
            this.mainTabControl.ResumeLayout(false);
            this.overviewTabPage.ResumeLayout(false);
            this.identityTabPage.ResumeLayout(false);
            this.identityTabPage.PerformLayout();
            this.settingsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mainTabControl;
        private MetroFramework.Controls.MetroTabPage overviewTabPage;
        private MetroFramework.Controls.MetroTabPage identityTabPage;
        private MetroFramework.Controls.MetroTabPage settingsTabPage;
        private MetroFramework.Controls.MetroButton applySettingsButton;
        private MetroFramework.Controls.MetroButton identityCopyToClipboardButton;
        private MetroFramework.Controls.MetroLabel deviceIdentityLabel;
        private System.Windows.Forms.TextBox deviceIdentityTextBox;
        private MetroFramework.Components.MetroToolTip informationTooltip;
        private MetroFramework.Controls.MetroLabel instanceNameLabel;
        private ConnectivityTile connectivityTile;
        private CpuUsageTile cpuUsageTile;
        private RamUsageTile ramUsageTile;
        private IdenticonTile identiconTile;
        private DiscoveryTile discoveryTile;
        private VersionUpgradeTile versionUpgradeTile;
        private MetroFramework.Controls.MetroLabel deviceIpLabel;
        private DeviceQrTile deviceQrTile;
        private System.Windows.Forms.TextBox deviceIpTextBox;
        private UploadSpeedTile uploadSpeedTile;
        private DownloadSpeedTile downloadSpeedTile;
        private SharedFoldersTile sharedFoldersTile;
        private ConnectedDevicesTile connectedDevicesTile;
        private MetroFramework.Controls.MetroTile removeInstanceTile;
        private MetroFramework.Controls.MetroTile restartTile;
        private OverallSyncProgressTile overallSyncProgressTile;
        private MetroFramework.Controls.MetroTile rescanAllTile;
    }
}
