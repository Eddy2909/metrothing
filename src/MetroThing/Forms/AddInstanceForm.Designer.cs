namespace MetroThing.Forms
{
    partial class AddInstanceForm
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
            this.components = new System.ComponentModel.Container();
            this.hostnameLabel = new MetroFramework.Controls.MetroLabel();
            this.hostnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.portLabel = new MetroFramework.Controls.MetroLabel();
            this.portTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addInstanceDescriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.apiKeyLabel = new MetroFramework.Controls.MetroLabel();
            this.apiKeyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.customNameLabel = new MetroFramework.Controls.MetroLabel();
            this.customNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.generalPage = new MetroFramework.Controls.MetroTabPage();
            this.useHttpsToggle = new MetroFramework.Controls.MetroToggle();
            this.useHttpsLabel = new MetroFramework.Controls.MetroLabel();
            this.advancedPage = new MetroFramework.Controls.MetroTabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroTabControl1.SuspendLayout();
            this.generalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.AutoSize = true;
            this.hostnameLabel.Location = new System.Drawing.Point(3, 9);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(92, 19);
            this.hostnameLabel.TabIndex = 0;
            this.hostnameLabel.Text = "Hostname / IP";
            // 
            // hostnameTextBox
            // 
            this.hostnameTextBox.Lines = new string[0];
            this.hostnameTextBox.Location = new System.Drawing.Point(3, 32);
            this.hostnameTextBox.MaxLength = 32767;
            this.hostnameTextBox.Name = "hostnameTextBox";
            this.hostnameTextBox.PasswordChar = '\0';
            this.hostnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hostnameTextBox.SelectedText = "";
            this.hostnameTextBox.Size = new System.Drawing.Size(254, 23);
            this.hostnameTextBox.TabIndex = 1;
            this.hostnameTextBox.UseSelectable = true;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(263, 10);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(34, 19);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "Port";
            // 
            // portTextBox
            // 
            this.portTextBox.Lines = new string[] {
        "8080"};
            this.portTextBox.Location = new System.Drawing.Point(263, 32);
            this.portTextBox.MaxLength = 32767;
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.PasswordChar = '\0';
            this.portTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.portTextBox.SelectedText = "";
            this.portTextBox.Size = new System.Drawing.Size(46, 23);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "8080";
            this.portTextBox.UseSelectable = true;
            // 
            // addInstanceDescriptionLabel
            // 
            this.addInstanceDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addInstanceDescriptionLabel.Location = new System.Drawing.Point(20, 60);
            this.addInstanceDescriptionLabel.Name = "addInstanceDescriptionLabel";
            this.addInstanceDescriptionLabel.Size = new System.Drawing.Size(655, 58);
            this.addInstanceDescriptionLabel.TabIndex = 0;
            this.addInstanceDescriptionLabel.Text = "Please enter the details of the Syncthing instance you want to connect to. You ne" +
    "ed to have access to the API (same as web GUI of Syncthing) and a valid API key " +
    "(can be found in the same web GUI).";
            this.addInstanceDescriptionLabel.WrapToLine = true;
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Location = new System.Drawing.Point(420, 10);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(52, 19);
            this.apiKeyLabel.TabIndex = 6;
            this.apiKeyLabel.Text = "API key";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Lines = new string[0];
            this.apiKeyTextBox.Location = new System.Drawing.Point(420, 32);
            this.apiKeyTextBox.MaxLength = 32767;
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.PasswordChar = '*';
            this.apiKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apiKeyTextBox.SelectedText = "";
            this.apiKeyTextBox.Size = new System.Drawing.Size(218, 23);
            this.apiKeyTextBox.TabIndex = 7;
            this.apiKeyTextBox.UseSelectable = true;
            // 
            // addButton
            // 
            this.addButton.Highlight = true;
            this.addButton.Location = new System.Drawing.Point(474, 333);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseSelectable = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(576, 333);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            // 
            // customNameLabel
            // 
            this.customNameLabel.AutoSize = true;
            this.customNameLabel.Location = new System.Drawing.Point(3, 78);
            this.customNameLabel.Name = "customNameLabel";
            this.customNameLabel.Size = new System.Drawing.Size(195, 19);
            this.customNameLabel.TabIndex = 8;
            this.customNameLabel.Text = "Custom display name (optional)";
            // 
            // customNameTextBox
            // 
            this.customNameTextBox.Lines = new string[0];
            this.customNameTextBox.Location = new System.Drawing.Point(3, 101);
            this.customNameTextBox.MaxLength = 32767;
            this.customNameTextBox.Name = "customNameTextBox";
            this.customNameTextBox.PasswordChar = '\0';
            this.customNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customNameTextBox.SelectedText = "";
            this.customNameTextBox.Size = new System.Drawing.Size(306, 23);
            this.customNameTextBox.TabIndex = 9;
            this.customNameTextBox.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.generalPage);
            this.metroTabControl1.Controls.Add(this.advancedPage);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 121);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(649, 210);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // generalPage
            // 
            this.generalPage.Controls.Add(this.useHttpsToggle);
            this.generalPage.Controls.Add(this.useHttpsLabel);
            this.generalPage.Controls.Add(this.customNameTextBox);
            this.generalPage.Controls.Add(this.customNameLabel);
            this.generalPage.Controls.Add(this.hostnameLabel);
            this.generalPage.Controls.Add(this.hostnameTextBox);
            this.generalPage.Controls.Add(this.portLabel);
            this.generalPage.Controls.Add(this.apiKeyTextBox);
            this.generalPage.Controls.Add(this.portTextBox);
            this.generalPage.Controls.Add(this.apiKeyLabel);
            this.generalPage.HorizontalScrollbarBarColor = true;
            this.generalPage.HorizontalScrollbarHighlightOnWheel = false;
            this.generalPage.HorizontalScrollbarSize = 10;
            this.generalPage.Location = new System.Drawing.Point(4, 38);
            this.generalPage.Name = "generalPage";
            this.generalPage.Size = new System.Drawing.Size(641, 168);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "General";
            this.generalPage.VerticalScrollbarBarColor = true;
            this.generalPage.VerticalScrollbarHighlightOnWheel = false;
            this.generalPage.VerticalScrollbarSize = 10;
            // 
            // useHttpsToggle
            // 
            this.useHttpsToggle.AutoSize = true;
            this.useHttpsToggle.DisplayStatus = false;
            this.useHttpsToggle.Location = new System.Drawing.Point(339, 35);
            this.useHttpsToggle.Name = "useHttpsToggle";
            this.useHttpsToggle.Size = new System.Drawing.Size(50, 17);
            this.useHttpsToggle.TabIndex = 10;
            this.useHttpsToggle.Text = "Aus";
            this.useHttpsToggle.UseSelectable = true;
            // 
            // useHttpsLabel
            // 
            this.useHttpsLabel.AutoSize = true;
            this.useHttpsLabel.Location = new System.Drawing.Point(327, 10);
            this.useHttpsLabel.Name = "useHttpsLabel";
            this.useHttpsLabel.Size = new System.Drawing.Size(72, 19);
            this.useHttpsLabel.TabIndex = 4;
            this.useHttpsLabel.Text = "Use HTTPS";
            // 
            // advancedPage
            // 
            this.advancedPage.HorizontalScrollbarBarColor = true;
            this.advancedPage.HorizontalScrollbarHighlightOnWheel = false;
            this.advancedPage.HorizontalScrollbarSize = 10;
            this.advancedPage.Location = new System.Drawing.Point(4, 38);
            this.advancedPage.Name = "advancedPage";
            this.advancedPage.Size = new System.Drawing.Size(641, 168);
            this.advancedPage.TabIndex = 1;
            this.advancedPage.Text = "Advanced";
            this.advancedPage.VerticalScrollbarBarColor = true;
            this.advancedPage.VerticalScrollbarHighlightOnWheel = false;
            this.advancedPage.VerticalScrollbarSize = 10;
            this.advancedPage.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddInstanceForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(695, 376);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addInstanceDescriptionLabel);
            this.Name = "AddInstanceForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.Text = "Add Syncthing instance";
            this.metroTabControl1.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel hostnameLabel;
        private MetroFramework.Controls.MetroTextBox hostnameTextBox;
        private MetroFramework.Controls.MetroLabel portLabel;
        private MetroFramework.Controls.MetroTextBox portTextBox;
        private MetroFramework.Controls.MetroLabel addInstanceDescriptionLabel;
        private MetroFramework.Controls.MetroLabel apiKeyLabel;
        private MetroFramework.Controls.MetroTextBox apiKeyTextBox;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroLabel customNameLabel;
        private MetroFramework.Controls.MetroTextBox customNameTextBox;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage generalPage;
        private MetroFramework.Controls.MetroTabPage advancedPage;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Controls.MetroLabel useHttpsLabel;
        private MetroFramework.Controls.MetroToggle useHttpsToggle;
    }
}
