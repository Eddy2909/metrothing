namespace MetroThing.Controls
{
    partial class DiscoveryTile
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
            this.discoTile = new MetroFramework.Controls.MetroTile();
            this.discoLabel = new MetroFramework.Controls.MetroLabel();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.discoTile.SuspendLayout();
            this.SuspendLayout();
            // 
            // discoTile
            // 
            this.discoTile.ActiveControl = null;
            this.discoTile.Controls.Add(this.discoLabel);
            this.discoTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discoTile.Location = new System.Drawing.Point(0, 0);
            this.discoTile.Name = "discoTile";
            this.discoTile.Size = new System.Drawing.Size(100, 50);
            this.discoTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.discoTile.TabIndex = 22;
            this.discoTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_discovery;
            this.discoTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discoTile.UseSelectable = true;
            this.discoTile.UseTileImage = true;
            // 
            // discoLabel
            // 
            this.discoLabel.BackColor = System.Drawing.Color.Transparent;
            this.discoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discoLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.discoLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.discoLabel.Location = new System.Drawing.Point(0, 0);
            this.discoLabel.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.discoLabel.Name = "discoLabel";
            this.discoLabel.Size = new System.Drawing.Size(100, 50);
            this.discoLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.discoLabel.TabIndex = 0;
            this.discoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.discoLabel.UseCustomBackColor = true;
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // DiscoveryTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.discoTile);
            this.Name = "DiscoveryTile";
            this.Size = new System.Drawing.Size(100, 50);
            this.discoTile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile discoTile;
        private MetroFramework.Controls.MetroLabel discoLabel;
        private MetroFramework.Components.MetroToolTip Tooltip;
    }
}
