namespace MetroThing.Forms
{
    partial class SettingsForm
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
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.backupSettingsTile = new MetroFramework.Controls.MetroTile();
            this.restoreSettingsTile = new MetroFramework.Controls.MetroTile();
            this.resetSettingsTile = new MetroFramework.Controls.MetroTile();
            this.showOnlyInTaskbarCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.closeToTryCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(411, 188);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // backupSettingsTile
            // 
            this.backupSettingsTile.ActiveControl = null;
            this.backupSettingsTile.Location = new System.Drawing.Point(24, 123);
            this.backupSettingsTile.Name = "backupSettingsTile";
            this.backupSettingsTile.Size = new System.Drawing.Size(150, 50);
            this.backupSettingsTile.Style = MetroFramework.MetroColorStyle.Green;
            this.backupSettingsTile.TabIndex = 1;
            this.backupSettingsTile.Text = "Backup settings";
            this.backupSettingsTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backupSettingsTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_download;
            this.backupSettingsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupSettingsTile.UseSelectable = true;
            this.backupSettingsTile.UseTileImage = true;
            this.backupSettingsTile.Click += new System.EventHandler(this.backupSettingsTile_Click);
            // 
            // restoreSettingsTile
            // 
            this.restoreSettingsTile.ActiveControl = null;
            this.restoreSettingsTile.Location = new System.Drawing.Point(180, 123);
            this.restoreSettingsTile.Name = "restoreSettingsTile";
            this.restoreSettingsTile.Size = new System.Drawing.Size(150, 50);
            this.restoreSettingsTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.restoreSettingsTile.TabIndex = 3;
            this.restoreSettingsTile.Text = "Restore settings";
            this.restoreSettingsTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.restoreSettingsTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_upload;
            this.restoreSettingsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restoreSettingsTile.UseSelectable = true;
            this.restoreSettingsTile.UseTileImage = true;
            this.restoreSettingsTile.Click += new System.EventHandler(this.restoreSettingsTile_Click);
            // 
            // resetSettingsTile
            // 
            this.resetSettingsTile.ActiveControl = null;
            this.resetSettingsTile.Location = new System.Drawing.Point(336, 123);
            this.resetSettingsTile.Name = "resetSettingsTile";
            this.resetSettingsTile.Size = new System.Drawing.Size(150, 50);
            this.resetSettingsTile.Style = MetroFramework.MetroColorStyle.Silver;
            this.resetSettingsTile.TabIndex = 4;
            this.resetSettingsTile.Text = "Reset settings";
            this.resetSettingsTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetSettingsTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_negative;
            this.resetSettingsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetSettingsTile.UseSelectable = true;
            this.resetSettingsTile.UseTileImage = true;
            this.resetSettingsTile.Click += new System.EventHandler(this.resetSettingsTile_Click);
            // 
            // showOnlyInTaskbarCheckbox
            // 
            this.showOnlyInTaskbarCheckbox.AutoSize = true;
            this.showOnlyInTaskbarCheckbox.Location = new System.Drawing.Point(24, 74);
            this.showOnlyInTaskbarCheckbox.Name = "showOnlyInTaskbarCheckbox";
            this.showOnlyInTaskbarCheckbox.Size = new System.Drawing.Size(102, 15);
            this.showOnlyInTaskbarCheckbox.TabIndex = 5;
            this.showOnlyInTaskbarCheckbox.Text = "Hide in taskbar";
            this.showOnlyInTaskbarCheckbox.UseSelectable = true;
            // 
            // closeToTryCheckbox
            // 
            this.closeToTryCheckbox.AutoSize = true;
            this.closeToTryCheckbox.Location = new System.Drawing.Point(24, 95);
            this.closeToTryCheckbox.Name = "closeToTryCheckbox";
            this.closeToTryCheckbox.Size = new System.Drawing.Size(89, 15);
            this.closeToTryCheckbox.TabIndex = 6;
            this.closeToTryCheckbox.Text = "Close to tray";
            this.closeToTryCheckbox.UseSelectable = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(513, 234);
            this.Controls.Add(this.closeToTryCheckbox);
            this.Controls.Add(this.showOnlyInTaskbarCheckbox);
            this.Controls.Add(this.resetSettingsTile);
            this.Controls.Add(this.restoreSettingsTile);
            this.Controls.Add(this.backupSettingsTile);
            this.Controls.Add(this.closeButton);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton closeButton;
        private MetroFramework.Controls.MetroTile backupSettingsTile;
        private MetroFramework.Controls.MetroTile restoreSettingsTile;
        private MetroFramework.Controls.MetroTile resetSettingsTile;
        private MetroFramework.Controls.MetroCheckBox showOnlyInTaskbarCheckbox;
        private MetroFramework.Controls.MetroCheckBox closeToTryCheckbox;
    }
}