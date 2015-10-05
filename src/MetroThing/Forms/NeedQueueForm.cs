using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroThing.Bindings;
using SyncthingCore;
using SyncthingCore.Types;

namespace MetroThing.Forms
{
    public partial class NeedQueueForm : MetroForm
    {
        private readonly ManagedInstance _instance;
        private Tuple<string, string> _selectedFolderAndFile;

        public NeedQueueForm(ManagedInstance instance)
        {
            InitializeComponent();

            _instance = instance;

            Text = String.Format("Downloading to {0}", _instance.Information.DisplayName);
        }

        private async void RefreshData()
        {
            refreshTile.Visible = false;
            loadProgressLabel.Visible = true;
            loadProgressBar.Visible = true;
            loadProgressBar.Value = 0;
            loadProgressBar.Maximum = _instance.Folders.Count + 1;
            loadProgressBar.Step = 1;

            var progressList = new NeedBindingList();
            var queuedList = new NeedBindingList();
            var restList = new NeedBindingList();

            var folders = _instance.Folders.ToList();

            foreach (var folder in folders)
            {
                loadProgressLabel.Text = String.Format("Fetching information for folder [{0}]", folder.Id);
                loadProgressLabel.Refresh();

                var result = await _instance.LoadNeededFiles(folder);

                foreach (var file in result.progress)
                {
                    progressList.Add(new NeedBindingItem(file, folder));
                }

                foreach (var file in result.queued)
                {
                    queuedList.Add(new NeedBindingItem(file, folder));
                }

                foreach (var file in result.rest)
                {
                    restList.Add(new NeedBindingItem(file, folder));
                }

                loadProgressBar.PerformStep();
            }

            loadProgressLabel.Text = String.Format("Loading data into grid");

            progressGrid.DataSource = progressList;
            queueGrid.DataSource = queuedList;
            restGrid.DataSource = restList;

            loadProgressBar.Visible = false;
            
            loadProgressLabel.Text = String.Format("{0} queued files found in {1} shared folders",
                progressList.Count + queuedList.Count + restList.Count, folders.Count);

            refreshTile.Visible = true;
        }

        private void closeTile_Click(object sender, EventArgs e)
        {
            progressGrid.DataSource = null;
            Close();
        }

        private void refreshTile_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void progressGrid_SelectionChanged(object sender, EventArgs e)
        {
            var source = (MetroGrid) sender;

            if (source.SelectedRows.Count > 0)
            {
                bumpTile.Visible = true;

                _selectedFolderAndFile = new Tuple<string, string>(
                    source.SelectedRows[0].Cells[1].Value.ToString(), source.SelectedRows[0].Cells[2].Value.ToString());
            }
            else
            {
                bumpTile.Visible = false;
            }
        }

        private void grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var source = (MetroGrid) sender;
            source.TabStop = false;
            source.ClearSelection();
        }

        private async void bumpTile_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, String.Format(
                "The file {0} will be pushed to the top of the queue\n\nAre you sure?",
                Path.GetFileName(_selectedFolderAndFile.Item2)),
                "Bump file", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                loadProgressLabel.Visible = true;
                loadProgressLabel.Text = String.Format("Bumping file in folder {0} to the top of the queue", _selectedFolderAndFile.Item1);

                loadProgressBar.Visible = true;
                loadProgressBar.Value = 0;
                loadProgressBar.Maximum = 1;

                await _instance.BumpFile(_selectedFolderAndFile.Item1, _selectedFolderAndFile.Item2);

                progressGrid.ClearSelection();
                queueGrid.ClearSelection();
                restGrid.ClearSelection();

                RefreshData();
            }
        }

        private void NeedQueueForm_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}