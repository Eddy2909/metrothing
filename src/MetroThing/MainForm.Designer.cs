namespace MetroThing
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.controlContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showCLIWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instancesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.githubTile = new MetroFramework.Controls.MetroTile();
            this.addInstanceTile = new MetroFramework.Controls.MetroTile();
            this.settingsTile = new MetroFramework.Controls.MetroTile();
            this.versionLabel = new MetroFramework.Controls.MetroLabel();
            this.versionUpgradedNoticeTile = new MetroFramework.Controls.MetroTile();
            this.openSharedFolderTile = new MetroFramework.Controls.MetroTile();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.changelogTile = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.controlContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // controlContextMenu
            // 
            this.controlContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.toolStripSeparator1,
            this.showCLIWindowsToolStripMenuItem,
            this.showClientBrowserToolStripMenuItem});
            this.controlContextMenu.Name = "controlContextMenu";
            this.controlContextMenu.Size = new System.Drawing.Size(181, 76);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.killToolStripMenuItem});
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "Processes";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.killToolStripMenuItem.Text = "Kill";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // showCLIWindowsToolStripMenuItem
            // 
            this.showCLIWindowsToolStripMenuItem.Name = "showCLIWindowsToolStripMenuItem";
            this.showCLIWindowsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showCLIWindowsToolStripMenuItem.Text = "Show client console";
            // 
            // showClientBrowserToolStripMenuItem
            // 
            this.showClientBrowserToolStripMenuItem.Name = "showClientBrowserToolStripMenuItem";
            this.showClientBrowserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showClientBrowserToolStripMenuItem.Text = "Show client browser";
            // 
            // instancesFlowLayoutPanel
            // 
            this.instancesFlowLayoutPanel.AutoScroll = true;
            this.instancesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instancesFlowLayoutPanel.Location = new System.Drawing.Point(20, 60);
            this.instancesFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.instancesFlowLayoutPanel.Name = "instancesFlowLayoutPanel";
            this.instancesFlowLayoutPanel.Size = new System.Drawing.Size(450, 231);
            this.instancesFlowLayoutPanel.TabIndex = 0;
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // githubTile
            // 
            this.githubTile.ActiveControl = null;
            this.githubTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.githubTile.Location = new System.Drawing.Point(195, 297);
            this.githubTile.Name = "githubTile";
            this.githubTile.Size = new System.Drawing.Size(50, 50);
            this.githubTile.TabIndex = 7;
            this.githubTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_github;
            this.Tooltip.SetToolTip(this.githubTile, "Show project github");
            this.githubTile.UseSelectable = true;
            this.githubTile.UseTileImage = true;
            this.githubTile.Click += new System.EventHandler(this.githubTile_Click);
            // 
            // addInstanceTile
            // 
            this.addInstanceTile.ActiveControl = null;
            this.addInstanceTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addInstanceTile.Location = new System.Drawing.Point(27, 297);
            this.addInstanceTile.Name = "addInstanceTile";
            this.addInstanceTile.Size = new System.Drawing.Size(50, 50);
            this.addInstanceTile.TabIndex = 5;
            this.addInstanceTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_create;
            this.Tooltip.SetToolTip(this.addInstanceTile, "Add new instance");
            this.addInstanceTile.UseSelectable = true;
            this.addInstanceTile.UseTileImage = true;
            this.addInstanceTile.Click += new System.EventHandler(this.addInstanceTile_Click);
            // 
            // settingsTile
            // 
            this.settingsTile.ActiveControl = null;
            this.settingsTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsTile.Location = new System.Drawing.Point(139, 297);
            this.settingsTile.Name = "settingsTile";
            this.settingsTile.Size = new System.Drawing.Size(50, 50);
            this.settingsTile.TabIndex = 8;
            this.settingsTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_settings;
            this.Tooltip.SetToolTip(this.settingsTile, "Settings");
            this.settingsTile.UseSelectable = true;
            this.settingsTile.UseTileImage = true;
            this.settingsTile.Click += new System.EventHandler(this.settingsTile_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Enabled = false;
            this.versionLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.versionLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.versionLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.versionLabel.Location = new System.Drawing.Point(143, 29);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(60, 19);
            this.versionLabel.TabIndex = 9;
            this.versionLabel.Text = "version";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.versionLabel.UseCustomBackColor = true;
            this.versionLabel.UseCustomForeColor = true;
            // 
            // versionUpgradedNoticeTile
            // 
            this.versionUpgradedNoticeTile.ActiveControl = null;
            this.versionUpgradedNoticeTile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versionUpgradedNoticeTile.Location = new System.Drawing.Point(27, 353);
            this.versionUpgradedNoticeTile.Name = "versionUpgradedNoticeTile";
            this.versionUpgradedNoticeTile.Size = new System.Drawing.Size(303, 30);
            this.versionUpgradedNoticeTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.versionUpgradedNoticeTile.TabIndex = 10;
            this.versionUpgradedNoticeTile.Text = "upgrade notice";
            this.versionUpgradedNoticeTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionUpgradedNoticeTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionUpgradedNoticeTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.versionUpgradedNoticeTile.UseSelectable = true;
            this.versionUpgradedNoticeTile.Visible = false;
            this.versionUpgradedNoticeTile.Click += new System.EventHandler(this.versionUpgradedNoticeTile_Click);
            // 
            // openSharedFolderTile
            // 
            this.openSharedFolderTile.ActiveControl = null;
            this.openSharedFolderTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openSharedFolderTile.Location = new System.Drawing.Point(83, 297);
            this.openSharedFolderTile.Name = "openSharedFolderTile";
            this.openSharedFolderTile.Size = new System.Drawing.Size(50, 50);
            this.openSharedFolderTile.TabIndex = 11;
            this.openSharedFolderTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_folder_open;
            this.openSharedFolderTile.UseSelectable = true;
            this.openSharedFolderTile.UseTileImage = true;
            this.openSharedFolderTile.Click += new System.EventHandler(this.openSharedFolderTile_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // changelogTile
            // 
            this.changelogTile.ActiveControl = null;
            this.changelogTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changelogTile.Location = new System.Drawing.Point(336, 353);
            this.changelogTile.Name = "changelogTile";
            this.changelogTile.Size = new System.Drawing.Size(131, 30);
            this.changelogTile.TabIndex = 14;
            this.changelogTile.Text = "Show changelog";
            this.changelogTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changelogTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.changelogTile.UseSelectable = true;
            this.changelogTile.Visible = false;
            this.changelogTile.Click += new System.EventHandler(this.changelogTile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 391);
            this.Controls.Add(this.changelogTile);
            this.Controls.Add(this.openSharedFolderTile);
            this.Controls.Add(this.versionUpgradedNoticeTile);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.settingsTile);
            this.Controls.Add(this.githubTile);
            this.Controls.Add(this.addInstanceTile);
            this.Controls.Add(this.instancesFlowLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(490, 391);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 100);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "metro.thing";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.controlContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroContextMenu controlContextMenu;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showCLIWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClientBrowserToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel instancesFlowLayoutPanel;
        private MetroFramework.Controls.MetroTile addInstanceTile;
        private MetroFramework.Controls.MetroTile githubTile;
        private MetroFramework.Controls.MetroTile settingsTile;
        public MetroFramework.Components.MetroToolTip Tooltip;
        private MetroFramework.Controls.MetroLabel versionLabel;
        private MetroFramework.Controls.MetroTile versionUpgradedNoticeTile;
        private MetroFramework.Controls.MetroTile openSharedFolderTile;
        public System.Windows.Forms.NotifyIcon NotifyIcon;
        private MetroFramework.Controls.MetroTile changelogTile;
    }
}

