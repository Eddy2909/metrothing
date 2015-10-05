namespace MetroThing.Forms
{
    partial class ChangelogForm
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
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.changelogBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Highlight = true;
            this.closeButton.Location = new System.Drawing.Point(525, 362);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // changelogBrowser
            // 
            this.changelogBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changelogBrowser.Location = new System.Drawing.Point(20, 60);
            this.changelogBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.changelogBrowser.Name = "changelogBrowser";
            this.changelogBrowser.Size = new System.Drawing.Size(580, 283);
            this.changelogBrowser.TabIndex = 2;
            // 
            // ChangelogForm
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(620, 403);
            this.ControlBox = false;
            this.Controls.Add(this.changelogBrowser);
            this.Controls.Add(this.closeButton);
            this.MaximizeBox = false;
            this.Name = "ChangelogForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 60);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.Text = "Changelog";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton closeButton;
        private System.Windows.Forms.WebBrowser changelogBrowser;
    }
}