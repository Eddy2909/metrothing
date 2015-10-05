namespace MetroThing.Controls
{
    partial class VersionUpgradeTile
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
            this.versionTile = new MetroFramework.Controls.MetroTile();
            this.versionSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.versionTile.SuspendLayout();
            this.SuspendLayout();
            // 
            // versionTile
            // 
            this.versionTile.ActiveControl = null;
            this.versionTile.Controls.Add(this.versionSpinner);
            this.versionTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionTile.Location = new System.Drawing.Point(0, 0);
            this.versionTile.Name = "versionTile";
            this.versionTile.Size = new System.Drawing.Size(50, 50);
            this.versionTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.versionTile.TabIndex = 0;
            this.versionTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.versionTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionTile.UseSelectable = true;
            this.versionTile.UseTileImage = true;
            this.versionTile.Click += new System.EventHandler(this.versionTile_Click);
            // 
            // versionSpinner
            // 
            this.versionSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versionSpinner.Location = new System.Drawing.Point(5, 5);
            this.versionSpinner.Maximum = 100;
            this.versionSpinner.Name = "versionSpinner";
            this.versionSpinner.Size = new System.Drawing.Size(40, 40);
            this.versionSpinner.Style = MetroFramework.MetroColorStyle.Orange;
            this.versionSpinner.TabIndex = 0;
            this.versionSpinner.UseSelectable = true;
            this.versionSpinner.Value = 33;
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // VersionUpgradeTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.versionTile);
            this.Name = "VersionUpgradeTile";
            this.Size = new System.Drawing.Size(50, 50);
            this.versionTile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile versionTile;
        private MetroFramework.Controls.MetroProgressSpinner versionSpinner;
        private MetroFramework.Components.MetroToolTip Tooltip;
    }
}
