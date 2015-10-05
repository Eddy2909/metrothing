namespace MetroThing.Controls
{
    partial class SharedFolderFlowItemControl
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
            this.seperatorTile = new MetroFramework.Controls.MetroTile();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.folderDetailsLabel = new MetroFramework.Controls.MetroLabel();
            this.folderNameLabel = new MetroFramework.Controls.MetroLabel();
            this.folderTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // seperatorTile
            // 
            this.seperatorTile.ActiveControl = null;
            this.seperatorTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.seperatorTile.Location = new System.Drawing.Point(0, 59);
            this.seperatorTile.Name = "seperatorTile";
            this.seperatorTile.Size = new System.Drawing.Size(300, 1);
            this.seperatorTile.TabIndex = 0;
            this.seperatorTile.UseSelectable = true;
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox.Location = new System.Drawing.Point(4, 3);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(52, 52);
            this.iconPictureBox.TabIndex = 1;
            this.iconPictureBox.TabStop = false;
            this.iconPictureBox.Click += new System.EventHandler(this.AnyControl_Click);
            // 
            // folderDetailsLabel
            // 
            this.folderDetailsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderDetailsLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.folderDetailsLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.folderDetailsLabel.Location = new System.Drawing.Point(63, 24);
            this.folderDetailsLabel.Name = "folderDetailsLabel";
            this.folderDetailsLabel.Size = new System.Drawing.Size(234, 15);
            this.folderDetailsLabel.TabIndex = 3;
            this.folderDetailsLabel.Text = "C:\\Adrian\\asdasd\\asdadsdasadsadsdasadsdas\\asdasdas";
            this.folderDetailsLabel.Click += new System.EventHandler(this.TargetDirectory_Click);
            // 
            // folderNameLabel
            // 
            this.folderNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.folderNameLabel.Location = new System.Drawing.Point(63, 3);
            this.folderNameLabel.Name = "folderNameLabel";
            this.folderNameLabel.Size = new System.Drawing.Size(234, 23);
            this.folderNameLabel.TabIndex = 2;
            this.folderNameLabel.Text = "Inbox";
            this.folderNameLabel.Click += new System.EventHandler(this.AnyControl_Click);
            // 
            // folderTimeLabel
            // 
            this.folderTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTimeLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.folderTimeLabel.Location = new System.Drawing.Point(63, 40);
            this.folderTimeLabel.Name = "folderTimeLabel";
            this.folderTimeLabel.Size = new System.Drawing.Size(234, 15);
            this.folderTimeLabel.TabIndex = 4;
            this.folderTimeLabel.Text = "just now";
            this.folderTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.folderTimeLabel.Click += new System.EventHandler(this.TargetDirectory_Click);
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // SharedFolderFlowItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.folderTimeLabel);
            this.Controls.Add(this.folderDetailsLabel);
            this.Controls.Add(this.folderNameLabel);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.seperatorTile);
            this.Name = "SharedFolderFlowItemControl";
            this.Size = new System.Drawing.Size(300, 60);
            this.Click += new System.EventHandler(this.AnyControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile seperatorTile;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private MetroFramework.Controls.MetroLabel folderDetailsLabel;
        private MetroFramework.Controls.MetroLabel folderNameLabel;
        private MetroFramework.Controls.MetroLabel folderTimeLabel;
        private MetroFramework.Components.MetroToolTip Tooltip;
    }
}
