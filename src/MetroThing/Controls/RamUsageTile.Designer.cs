namespace MetroThing.Controls
{
    partial class RamUsageTile
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
            this.ramTile = new MetroFramework.Controls.MetroTile();
            this.ramLabel = new MetroFramework.Controls.MetroLabel();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.ramTile.SuspendLayout();
            this.SuspendLayout();
            // 
            // ramTile
            // 
            this.ramTile.ActiveControl = null;
            this.ramTile.Controls.Add(this.ramLabel);
            this.ramTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ramTile.Location = new System.Drawing.Point(0, 0);
            this.ramTile.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.ramTile.Name = "ramTile";
            this.ramTile.Size = new System.Drawing.Size(100, 50);
            this.ramTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.ramTile.TabIndex = 24;
            this.ramTile.Text = "RAM";
            this.ramTile.TileImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ramTile.UseSelectable = true;
            // 
            // ramLabel
            // 
            this.ramLabel.BackColor = System.Drawing.Color.Transparent;
            this.ramLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ramLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ramLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ramLabel.Location = new System.Drawing.Point(0, 0);
            this.ramLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(100, 50);
            this.ramLabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.ramLabel.TabIndex = 0;
            this.ramLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ramLabel.UseCustomBackColor = true;
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // RamUsageTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ramTile);
            this.Name = "RamUsageTile";
            this.Size = new System.Drawing.Size(100, 50);
            this.ramTile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile ramTile;
        private MetroFramework.Controls.MetroLabel ramLabel;
        private MetroFramework.Components.MetroToolTip Tooltip;
    }
}
