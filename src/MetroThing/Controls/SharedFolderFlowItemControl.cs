using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Devcorner.NIdenticon;
using MetroThing.Core.Helpers;
using SyncthingCore.Types;

namespace MetroThing.Controls
{
    public partial class SharedFolderFlowItemControl : UserControl
    {
        private Folder _folder;

        public SharedFolderFlowItemControl()
        {
            InitializeComponent();
        }

        public Folder Folder
        {
            get { return _folder; }
            set
            {
                if (value != null)
                {
                    // Set name
                    folderNameLabel.Text = value.Id;

                    // Set Identicon
                    iconPictureBox.Image = new IdenticonGenerator()
                        .WithBlocks(5, 5)
                        .Create(value.Id, new Size(iconPictureBox.Width, iconPictureBox.Height));

                    // Set either last file and time OR path
                    if (value.LastFilename != null)
                    {
                        folderDetailsLabel.Text = value.LastFilename;
                        folderTimeLabel.Text = StringHelper.TimeAgo(value.LastFileAt);

                        Tooltip.SetToolTip(folderDetailsLabel, Path.GetFileName(value.LastFilename));
                    }
                    else
                    {
                        folderDetailsLabel.Text = value.Path;
                        folderTimeLabel.Text = String.Empty;

                        Tooltip.SetToolTip(folderDetailsLabel, value.Path);
                    }
                }

                _folder = value;
            }
        }

        private void AnyControl_Click(object sender, EventArgs e)
        {
            FilesystemHelper.OpenPathInExplorer(_folder.Path);
            CloseParentForm();
        }

        private void TargetDirectory_Click(object sender, EventArgs e)
        {
            if (_folder.LastFilename != null)
            {
                FilesystemHelper.OpenPathInExplorer(Path.Combine(_folder.Path, _folder.LastFilename));
                CloseParentForm();
            }
            else
            {
                AnyControl_Click(sender, e);
            }
        }

        private void CloseParentForm()
        {
            if (ParentForm != null)
                ParentForm.Close();
        }
    }
}