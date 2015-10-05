namespace MetroThing.Controls
{
    partial class IdenticonTile
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
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            this.Tooltip.SetToolTip(this.iconPictureBox, "This is the Identicon for this device!");
            // 
            // IdenticonTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconPictureBox);
            this.Name = "IdenticonTile";
            this.Size = new System.Drawing.Size(50, 50);
            this.Tooltip.SetToolTip(this, "This is the Identicon for this device!");
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconPictureBox;
        private MetroFramework.Components.MetroToolTip Tooltip;
    }
}
