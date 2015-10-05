using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;
using MetroFramework;
using MetroFramework.Forms;
using MetroThing.Core;
using MetroThing.Core.Manager;
using MetroThing.Properties;
using MetroThing.Types;

namespace MetroThing.Forms
{
    public partial class SettingsForm : MetroForm
    {
        private const string FilenameFilter = "XML files (*.xml)|*.xml| All files (*.*)|*.*";
        private readonly XmlSerializer _xmlSerializer;

        public SettingsForm()
        {
            InitializeComponent();

            _xmlSerializer = new XmlSerializer(typeof (SettingsSnapshot));

            closeToTryCheckbox.Checked = Settings.Default.CloseToTray;
            showOnlyInTaskbarCheckbox.Checked = Settings.Default.ShowOnlyInTaskbar;
        }

        private void backupSettingsTile_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Filter = FilenameFilter,
                OverwritePrompt = true,
                FileName = "metrothing settings backup " + Assembly.GetExecutingAssembly().GetName().Version + ".xml"
            };

            if (dialog.ShowDialog() != DialogResult.OK) return;

            using (var file = File.Create(dialog.FileName))
            {
                _xmlSerializer.Serialize(file, AppSettings.Backup());
            }

            MetroMessageBox.Show(this, "Backup file was successfully saved.", "Backup", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void restoreSettingsTile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = FilenameFilter
            };

            if (dialog.ShowDialog() != DialogResult.OK) return;

            var answer = MetroMessageBox.Show(this,
                "This will remove all other settings and instances that you have currently configured.\n\nAre you sure?",
                "Restore warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes) return;

            using (var file = File.OpenText(dialog.FileName))
            {
                var data = (SettingsSnapshot) _xmlSerializer.Deserialize(file);
                AppSettings.Restore(data);
            }

            MetroMessageBox.Show(this, "Backup file was successfully restored.", "Restore", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void resetSettingsTile_Click(object sender, EventArgs e)
        {
            var answer = MetroMessageBox.Show(this,
                "This will remove all settings and instances that you have currently configured.\n\nAre you sure?",
                "Reset warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                Singleton<SyncthingInstanceManager>.Instance.Clear();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Settings.Default.CloseToTray = closeToTryCheckbox.Checked;
            Settings.Default.ShowOnlyInTaskbar = showOnlyInTaskbarCheckbox.Checked;

            Close();
        }
    }
}