namespace MetroThing.Controls
{
    partial class UploadSpeedTile
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
            this.uploadTile = new MetroFramework.Controls.MetroTile();
            this.uploadIconPictureBox = new System.Windows.Forms.PictureBox();
            this.uploadLabel = new MetroFramework.Controls.MetroLabel();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.uploadTile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadTile
            // 
            this.uploadTile.ActiveControl = null;
            this.uploadTile.Controls.Add(this.uploadIconPictureBox);
            this.uploadTile.Controls.Add(this.uploadLabel);
            this.uploadTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadTile.Location = new System.Drawing.Point(0, 0);
            this.uploadTile.Name = "uploadTile";
            this.uploadTile.Size = new System.Drawing.Size(100, 50);
            this.uploadTile.Style = MetroFramework.MetroColorStyle.Purple;
            this.uploadTile.TabIndex = 18;
            this.uploadTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadTile.UseSelectable = true;
            // 
            // uploadIconPictureBox
            // 
            this.uploadIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.uploadIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uploadIconPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.uploadIconPictureBox.Image = global::MetroThing.Properties.Resources.fontawesome_50_bright_up;
            this.uploadIconPictureBox.Location = new System.Drawing.Point(75, 0);
            this.uploadIconPictureBox.Name = "uploadIconPictureBox";
            this.uploadIconPictureBox.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.uploadIconPictureBox.Size = new System.Drawing.Size(25, 50);
            this.uploadIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uploadIconPictureBox.TabIndex = 2;
            this.uploadIconPictureBox.TabStop = false;
            // 
            // uploadLabel
            // 
            this.uploadLabel.BackColor = System.Drawing.Color.Transparent;
            this.uploadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.uploadLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.uploadLabel.Location = new System.Drawing.Point(0, 0);
            this.uploadLabel.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.uploadLabel.Name = "uploadLabel";
            this.uploadLabel.Size = new System.Drawing.Size(100, 50);
            this.uploadLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.uploadLabel.TabIndex = 1;
            this.uploadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadLabel.UseCustomBackColor = true;
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // UploadSpeedTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uploadTile);
            this.Name = "UploadSpeedTile";
            this.Size = new System.Drawing.Size(100, 50);
            this.uploadTile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uploadIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile uploadTile;
        private System.Windows.Forms.PictureBox uploadIconPictureBox;
        private MetroFramework.Controls.MetroLabel uploadLabel;
        private MetroFramework.Components.MetroToolTip Tooltip;
    }
}
