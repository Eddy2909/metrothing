namespace MetroThing.Forms
{
    partial class OpenSharedFolderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderFlowControl = new System.Windows.Forms.FlowLayoutPanel();
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.openButton = new MetroFramework.Controls.MetroButton();
            this.shutdownButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // folderFlowControl
            // 
            this.folderFlowControl.AutoScroll = true;
            this.folderFlowControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderFlowControl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.folderFlowControl.Location = new System.Drawing.Point(20, 60);
            this.folderFlowControl.Name = "folderFlowControl";
            this.folderFlowControl.Size = new System.Drawing.Size(283, 303);
            this.folderFlowControl.TabIndex = 0;
            this.folderFlowControl.WrapContents = false;
            this.folderFlowControl.SizeChanged += new System.EventHandler(this.folderFlowControl_SizeChanged);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.DisplayFocus = true;
            this.closeButton.Location = new System.Drawing.Point(212, 380);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(33, 380);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open app";
            this.openButton.UseSelectable = true;
            this.openButton.Visible = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // shutdownButton
            // 
            this.shutdownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shutdownButton.Location = new System.Drawing.Point(124, 380);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Size = new System.Drawing.Size(75, 23);
            this.shutdownButton.TabIndex = 3;
            this.shutdownButton.Text = "Shutdown";
            this.shutdownButton.UseSelectable = true;
            this.shutdownButton.Visible = false;
            this.shutdownButton.Click += new System.EventHandler(this.shutdownButton_Click);
            // 
            // OpenSharedFolderForm
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(313, 423);
            this.Controls.Add(this.shutdownButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.folderFlowControl);
            this.MinimumSize = new System.Drawing.Size(313, 423);
            this.Name = "OpenSharedFolderForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 10, 60);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.Text = "Open folder";
            this.Deactivate += new System.EventHandler(this.OpenSharedFolderForm_Deactivate);
            this.Shown += new System.EventHandler(this.OpenSharedFolderForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel folderFlowControl;
        private MetroFramework.Controls.MetroButton closeButton;
        private MetroFramework.Controls.MetroButton openButton;
        private MetroFramework.Controls.MetroButton shutdownButton;
    }
}