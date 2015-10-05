namespace MetroThing.Controls
{
    partial class ConnectivityTile
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
            this.heartTile = new MetroFramework.Controls.MetroTile();
            this.idleSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.heartTile.SuspendLayout();
            this.SuspendLayout();
            // 
            // heartTile
            // 
            this.heartTile.ActiveControl = null;
            this.heartTile.Controls.Add(this.idleSpinner);
            this.heartTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heartTile.Location = new System.Drawing.Point(0, 0);
            this.heartTile.Name = "heartTile";
            this.heartTile.Size = new System.Drawing.Size(50, 50);
            this.heartTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.heartTile.TabIndex = 0;
            this.Tooltip.SetToolTip(this.heartTile, "Trying to connect on all available endpoints...");
            this.heartTile.UseSelectable = true;
            this.heartTile.UseTileImage = true;
            // 
            // idleSpinner
            // 
            this.idleSpinner.Location = new System.Drawing.Point(5, 5);
            this.idleSpinner.Maximum = 100;
            this.idleSpinner.Name = "idleSpinner";
            this.idleSpinner.Size = new System.Drawing.Size(40, 40);
            this.idleSpinner.Style = MetroFramework.MetroColorStyle.Orange;
            this.idleSpinner.TabIndex = 0;
            this.idleSpinner.UseSelectable = true;
            this.idleSpinner.Value = 33;
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ConnectivityTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.heartTile);
            this.Name = "ConnectivityTile";
            this.Size = new System.Drawing.Size(50, 50);
            this.Tooltip.SetToolTip(this, "Trying to connect on all available endpoints...");
            this.heartTile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile heartTile;
        private MetroFramework.Controls.MetroProgressSpinner idleSpinner;
        private MetroFramework.Components.MetroToolTip Tooltip;


    }
}
