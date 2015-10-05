namespace MetroThing.Controls
{
    partial class CpuUsageTile
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
            this.cpuLabel = new MetroFramework.Controls.MetroLabel();
            this.cpuTile = new MetroFramework.Controls.MetroTile();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.cpuTile.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpuLabel
            // 
            this.cpuLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpuLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.cpuLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.cpuLabel.Location = new System.Drawing.Point(0, 0);
            this.cpuLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(100, 50);
            this.cpuLabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.cpuLabel.TabIndex = 0;
            this.cpuLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cpuLabel.UseCustomBackColor = true;
            // 
            // cpuTile
            // 
            this.cpuTile.ActiveControl = null;
            this.cpuTile.Controls.Add(this.cpuLabel);
            this.cpuTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuTile.Location = new System.Drawing.Point(0, 0);
            this.cpuTile.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.cpuTile.Name = "cpuTile";
            this.cpuTile.Size = new System.Drawing.Size(100, 50);
            this.cpuTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.cpuTile.TabIndex = 23;
            this.cpuTile.Text = "CPU";
            this.cpuTile.TileImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cpuTile.UseSelectable = true;
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // CpuUsageTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cpuTile);
            this.Name = "CpuUsageTile";
            this.Size = new System.Drawing.Size(100, 50);
            this.cpuTile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel cpuLabel;
        private MetroFramework.Controls.MetroTile cpuTile;
        private MetroFramework.Components.MetroToolTip Tooltip;
    }
}
