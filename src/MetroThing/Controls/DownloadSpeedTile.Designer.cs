namespace MetroThing.Controls
{
    partial class DownloadSpeedTile
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
            this.downloadTile = new MetroFramework.Controls.MetroTile();
            this.downloadIconPictureBox = new System.Windows.Forms.PictureBox();
            this.downloadLabel = new MetroFramework.Controls.MetroLabel();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.downloadTile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadTile
            // 
            this.downloadTile.ActiveControl = null;
            this.downloadTile.Controls.Add(this.downloadIconPictureBox);
            this.downloadTile.Controls.Add(this.downloadLabel);
            this.downloadTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadTile.Location = new System.Drawing.Point(0, 0);
            this.downloadTile.Name = "downloadTile";
            this.downloadTile.Size = new System.Drawing.Size(100, 50);
            this.downloadTile.Style = MetroFramework.MetroColorStyle.Purple;
            this.downloadTile.TabIndex = 19;
            this.downloadTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.downloadTile.UseSelectable = true;
            this.downloadTile.Click += new System.EventHandler(this.DownloadSpeedTile_Click);
            // 
            // downloadIconPictureBox
            // 
            this.downloadIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.downloadIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.downloadIconPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.downloadIconPictureBox.Image = global::MetroThing.Properties.Resources.fontawesome_50_bright_down;
            this.downloadIconPictureBox.Location = new System.Drawing.Point(75, 0);
            this.downloadIconPictureBox.Name = "downloadIconPictureBox";
            this.downloadIconPictureBox.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.downloadIconPictureBox.Size = new System.Drawing.Size(25, 50);
            this.downloadIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.downloadIconPictureBox.TabIndex = 2;
            this.downloadIconPictureBox.TabStop = false;
            // 
            // downloadLabel
            // 
            this.downloadLabel.BackColor = System.Drawing.Color.Transparent;
            this.downloadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.downloadLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.downloadLabel.Location = new System.Drawing.Point(0, 0);
            this.downloadLabel.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(100, 50);
            this.downloadLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.downloadLabel.TabIndex = 1;
            this.downloadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.downloadLabel.UseCustomBackColor = true;
            this.downloadLabel.Click += new System.EventHandler(this.DownloadSpeedTile_Click);
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // DownloadSpeedTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.downloadTile);
            this.Name = "DownloadSpeedTile";
            this.Size = new System.Drawing.Size(100, 50);
            this.Click += new System.EventHandler(this.DownloadSpeedTile_Click);
            this.downloadTile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downloadIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile downloadTile;
        private System.Windows.Forms.PictureBox downloadIconPictureBox;
        private MetroFramework.Controls.MetroLabel downloadLabel;
        private MetroFramework.Components.MetroToolTip Tooltip;
    }
}
