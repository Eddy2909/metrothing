namespace MetroThing.Controls
{
    partial class ConnectedDevicesTile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.devicesTile = new MetroFramework.Controls.MetroTile();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // devicesTile
            // 
            this.devicesTile.ActiveControl = null;
            this.devicesTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesTile.Location = new System.Drawing.Point(0, 0);
            this.devicesTile.Name = "devicesTile";
            this.devicesTile.Size = new System.Drawing.Size(100, 100);
            this.devicesTile.TabIndex = 21;
            this.devicesTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.devicesTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_100_bright_devices;
            this.devicesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.devicesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.devicesTile.UseSelectable = true;
            this.devicesTile.UseTileImage = true;
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ConnectedDevicesTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.devicesTile);
            this.Name = "ConnectedDevicesTile";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile devicesTile;
        private MetroFramework.Components.MetroToolTip Tooltip;
    }
}
