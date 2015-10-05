namespace MetroThing.Controls
{
    partial class SharedFoldersTile
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
            this.foldersTile = new MetroFramework.Controls.MetroTile();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // foldersTile
            // 
            this.foldersTile.ActiveControl = null;
            this.foldersTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foldersTile.Location = new System.Drawing.Point(0, 0);
            this.foldersTile.Name = "foldersTile";
            this.foldersTile.Size = new System.Drawing.Size(100, 100);
            this.foldersTile.TabIndex = 19;
            this.foldersTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foldersTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_100_bright_folder_closed;
            this.foldersTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foldersTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.foldersTile.UseSelectable = true;
            this.foldersTile.UseTileImage = true;
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // SharedFoldersTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.foldersTile);
            this.Name = "SharedFoldersTile";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile foldersTile;
        private MetroFramework.Components.MetroToolTip Tooltip;
    }
}
