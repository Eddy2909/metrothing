using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroThing.Core;
using MetroThing.Core.Manager;
using MetroThing.Types;
using Serilog;
using SyncthingCore;
using SyncthingCore.Types;

namespace MetroThing.Forms
{
    public partial class AddInstanceForm : MetroForm
    {
        public AddInstanceForm()
        {
            InitializeComponent();

            ActiveControl = hostnameTextBox;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var hostnameValidation = UserInputValidator.ValidateNetworkHostname(hostnameTextBox.Text);
            var portValidation = UserInputValidator.ValidateNetworkPortNumber(portTextBox.Text);
            var apiKeyValidation = UserInputValidator.ValidateSyncthingApiKey(apiKeyTextBox.Text);
            var displayNameValidation = UserInputValidator.ValidateSyncthingDisplayName(customNameTextBox.Text);

            var errorMessages = new List<string>();

            // Validate port number
            if (!portValidation.IsValid)
                errorMessages.Add(portValidation.Message);

            // Validate hostname
            if (!hostnameValidation.IsValid)
                errorMessages.Add(hostnameValidation.Message);

            // Validate API key
            if (!apiKeyValidation.IsValid)
                errorMessages.Add(apiKeyValidation.Message);

            if (errorMessages.Count > 0)
            {
                MetroMessageBox.Show(this, String.Join(Environment.NewLine, errorMessages),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            var instance = new ManagedInstance
            {
                UseHttps = useHttpsToggle.Checked,
                ApiKey = apiKeyValidation.ValidatedValue
            };

            instance.PossibleEndpoints.Add(new RestEndpoint
            {
                Hostname = hostnameValidation.ValidatedValue,
                Port = portValidation.ValidatedValue,
                Priority = 100,
                IsPingable = true
            });

            // Assign display name
            if (displayNameValidation.IsValid)
                instance.CustomName = customNameTextBox.Text.Trim();

            Log.Logger.Information("New Syncthing instance created: {@Instance}", instance);

            Singleton<SyncthingInstanceManager>.Instance.Add(instance);

            AppSettings.Save(ParentForm);

            Close();
        }
    }
}