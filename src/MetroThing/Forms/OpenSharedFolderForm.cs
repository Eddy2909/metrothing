using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroThing.Controls;
using MetroThing.Core.Manager;
using MetroThing.Properties;
using MetroThing.Types;
using SyncthingCore.Types;

namespace MetroThing.Forms
{
    public partial class OpenSharedFolderForm : MetroForm
    {
        private readonly MainForm _owner;
        private List<Folder> _folders;

        public OpenSharedFolderForm()
        {
            InitializeComponent();
        }

        public OpenSharedFolderForm(MainForm metroWwner)
        {
            InitializeComponent();

            _owner = metroWwner;
        }

        private void OpenSharedFolderForm_Shown(object sender, EventArgs e)
        {
            _folders = Singleton<LocalFolderManager>.Instance.LocalFolders;

            foreach (var folder in _folders.OrderBy(o => o.Id))
            {
                var control = new SharedFolderFlowItemControl
                {
                    Folder = folder,
                    Width = folderFlowControl.Width - 30
                };

                folderFlowControl.Controls.Add(control);
            }
        }

        private void folderFlowControl_SizeChanged(object sender, EventArgs e)
        {
            FitControls();
        }

        private void FitControls()
        {
            foreach (SharedFolderFlowItemControl control in folderFlowControl.Controls)
            {
                control.Width = folderFlowControl.Width - 30;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenSharedFolderForm_Deactivate(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowContextElements()
        {
            openButton.Visible = true;
            shutdownButton.Visible = true;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (_owner.WindowState == FormWindowState.Minimized)
            {
                _owner.WindowState = FormWindowState.Normal;
                Close();
            }
            else
            {
                _owner.Show();
            }
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            _owner.NotifyIcon.Visible = false;
            _owner.NotifyIcon.Icon = null;

            Settings.Default.Save();
            AppSettings.Save();
            Environment.Exit(1);
        }
    }
}