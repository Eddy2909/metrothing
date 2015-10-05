namespace MetroThing.Forms
{
    partial class NeedQueueForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.refreshTile = new MetroFramework.Controls.MetroTile();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.closeTile = new MetroFramework.Controls.MetroTile();
            this.bumpTile = new MetroFramework.Controls.MetroTile();
            this.loadProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.loadProgressLabel = new MetroFramework.Controls.MetroLabel();
            this.queuesTabControl = new MetroFramework.Controls.MetroTabControl();
            this.progressTab = new System.Windows.Forms.TabPage();
            this.progressGrid = new MetroFramework.Controls.MetroGrid();
            this.FolderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queuedTabPage = new System.Windows.Forms.TabPage();
            this.queueGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restTabPage = new System.Windows.Forms.TabPage();
            this.restGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getNeedResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModifiedAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalVersionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoteVersionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.needBindingListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queuesTabControl.SuspendLayout();
            this.progressTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressGrid)).BeginInit();
            this.queuedTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queueGrid)).BeginInit();
            this.restTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getNeedResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.needBindingListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshTile
            // 
            this.refreshTile.ActiveControl = null;
            this.refreshTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshTile.Location = new System.Drawing.Point(672, 421);
            this.refreshTile.Name = "refreshTile";
            this.refreshTile.Size = new System.Drawing.Size(50, 50);
            this.refreshTile.TabIndex = 0;
            this.refreshTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_reload;
            this.refreshTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tooltip.SetToolTip(this.refreshTile, "Refresh queues");
            this.refreshTile.UseSelectable = true;
            this.refreshTile.UseTileImage = true;
            this.refreshTile.Click += new System.EventHandler(this.refreshTile_Click);
            // 
            // Tooltip
            // 
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // closeTile
            // 
            this.closeTile.ActiveControl = null;
            this.closeTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeTile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeTile.Location = new System.Drawing.Point(728, 421);
            this.closeTile.Name = "closeTile";
            this.closeTile.Size = new System.Drawing.Size(50, 50);
            this.closeTile.TabIndex = 1;
            this.closeTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_negative;
            this.closeTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tooltip.SetToolTip(this.closeTile, "Close");
            this.closeTile.UseSelectable = true;
            this.closeTile.UseTileImage = true;
            this.closeTile.Click += new System.EventHandler(this.closeTile_Click);
            // 
            // bumpTile
            // 
            this.bumpTile.ActiveControl = null;
            this.bumpTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bumpTile.Location = new System.Drawing.Point(616, 421);
            this.bumpTile.Name = "bumpTile";
            this.bumpTile.Size = new System.Drawing.Size(50, 50);
            this.bumpTile.TabIndex = 6;
            this.bumpTile.TileImage = global::MetroThing.Properties.Resources.fontawesome_50_bright_bump;
            this.bumpTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tooltip.SetToolTip(this.bumpTile, "Bump selected to top of the queue");
            this.bumpTile.UseSelectable = true;
            this.bumpTile.UseTileImage = true;
            this.bumpTile.Visible = false;
            this.bumpTile.Click += new System.EventHandler(this.bumpTile_Click);
            // 
            // loadProgressBar
            // 
            this.loadProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadProgressBar.FontSize = MetroFramework.MetroProgressBarSize.Small;
            this.loadProgressBar.HideProgressText = false;
            this.loadProgressBar.Location = new System.Drawing.Point(23, 448);
            this.loadProgressBar.Name = "loadProgressBar";
            this.loadProgressBar.Size = new System.Drawing.Size(587, 23);
            this.loadProgressBar.TabIndex = 3;
            this.loadProgressBar.Value = 50;
            this.loadProgressBar.Visible = false;
            // 
            // loadProgressLabel
            // 
            this.loadProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadProgressLabel.Location = new System.Drawing.Point(24, 423);
            this.loadProgressLabel.Name = "loadProgressLabel";
            this.loadProgressLabel.Size = new System.Drawing.Size(586, 19);
            this.loadProgressLabel.TabIndex = 4;
            this.loadProgressLabel.Text = "progress label";
            this.loadProgressLabel.Visible = false;
            // 
            // queuesTabControl
            // 
            this.queuesTabControl.Controls.Add(this.progressTab);
            this.queuesTabControl.Controls.Add(this.queuedTabPage);
            this.queuesTabControl.Controls.Add(this.restTabPage);
            this.queuesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queuesTabControl.Location = new System.Drawing.Point(20, 60);
            this.queuesTabControl.Name = "queuesTabControl";
            this.queuesTabControl.SelectedIndex = 0;
            this.queuesTabControl.Size = new System.Drawing.Size(758, 355);
            this.queuesTabControl.TabIndex = 5;
            this.queuesTabControl.UseSelectable = true;
            // 
            // progressTab
            // 
            this.progressTab.Controls.Add(this.progressGrid);
            this.progressTab.Location = new System.Drawing.Point(4, 38);
            this.progressTab.Name = "progressTab";
            this.progressTab.Size = new System.Drawing.Size(750, 313);
            this.progressTab.TabIndex = 0;
            this.progressTab.Text = "Currently";
            // 
            // progressGrid
            // 
            this.progressGrid.AllowUserToAddRows = false;
            this.progressGrid.AllowUserToDeleteRows = false;
            this.progressGrid.AllowUserToResizeRows = false;
            this.progressGrid.AutoGenerateColumns = false;
            this.progressGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.progressGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.progressGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.progressGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.progressGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.progressGrid.ColumnHeadersHeight = 30;
            this.progressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.progressGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModifiedAtColumn,
            this.FolderColumn,
            this.NameColumn,
            this.SizeColumn,
            this.LocalVersionColumn,
            this.RemoteVersionColumn});
            this.progressGrid.DataSource = this.needBindingListBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.progressGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.progressGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressGrid.EnableHeadersVisualStyles = false;
            this.progressGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.progressGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.progressGrid.Location = new System.Drawing.Point(0, 0);
            this.progressGrid.MultiSelect = false;
            this.progressGrid.Name = "progressGrid";
            this.progressGrid.ReadOnly = true;
            this.progressGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.progressGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.progressGrid.RowHeadersWidth = 40;
            this.progressGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.progressGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.progressGrid.Size = new System.Drawing.Size(750, 313);
            this.progressGrid.TabIndex = 3;
            this.progressGrid.Theme = MetroFramework.MetroThemeStyle.Light;
            this.progressGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_DataBindingComplete);
            this.progressGrid.SelectionChanged += new System.EventHandler(this.progressGrid_SelectionChanged);
            // 
            // FolderColumn
            // 
            this.FolderColumn.DataPropertyName = "Folder";
            this.FolderColumn.HeaderText = "Folder";
            this.FolderColumn.Name = "FolderColumn";
            this.FolderColumn.ReadOnly = true;
            // 
            // queuedTabPage
            // 
            this.queuedTabPage.Controls.Add(this.queueGrid);
            this.queuedTabPage.Location = new System.Drawing.Point(4, 38);
            this.queuedTabPage.Name = "queuedTabPage";
            this.queuedTabPage.Size = new System.Drawing.Size(750, 313);
            this.queuedTabPage.TabIndex = 1;
            this.queuedTabPage.Text = "Queued";
            // 
            // queueGrid
            // 
            this.queueGrid.AllowUserToAddRows = false;
            this.queueGrid.AllowUserToDeleteRows = false;
            this.queueGrid.AllowUserToResizeRows = false;
            this.queueGrid.AutoGenerateColumns = false;
            this.queueGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.queueGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.queueGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queueGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.queueGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.queueGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.queueGrid.ColumnHeadersHeight = 30;
            this.queueGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.queueGrid.DataSource = this.needBindingListBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.queueGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.queueGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queueGrid.EnableHeadersVisualStyles = false;
            this.queueGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.queueGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.queueGrid.Location = new System.Drawing.Point(0, 0);
            this.queueGrid.MultiSelect = false;
            this.queueGrid.Name = "queueGrid";
            this.queueGrid.ReadOnly = true;
            this.queueGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.queueGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.queueGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.queueGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.queueGrid.Size = new System.Drawing.Size(750, 313);
            this.queueGrid.TabIndex = 4;
            this.queueGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Folder";
            this.dataGridViewTextBoxColumn2.HeaderText = "Folder";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // restTabPage
            // 
            this.restTabPage.Controls.Add(this.restGrid);
            this.restTabPage.Location = new System.Drawing.Point(4, 38);
            this.restTabPage.Name = "restTabPage";
            this.restTabPage.Size = new System.Drawing.Size(750, 313);
            this.restTabPage.TabIndex = 2;
            this.restTabPage.Text = "Resting";
            // 
            // restGrid
            // 
            this.restGrid.AllowUserToAddRows = false;
            this.restGrid.AllowUserToDeleteRows = false;
            this.restGrid.AllowUserToResizeRows = false;
            this.restGrid.AutoGenerateColumns = false;
            this.restGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.restGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.restGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.restGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.restGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.restGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.restGrid.ColumnHeadersHeight = 30;
            this.restGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.restGrid.DataSource = this.needBindingListBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.restGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.restGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restGrid.EnableHeadersVisualStyles = false;
            this.restGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.restGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.restGrid.Location = new System.Drawing.Point(0, 0);
            this.restGrid.MultiSelect = false;
            this.restGrid.Name = "restGrid";
            this.restGrid.ReadOnly = true;
            this.restGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.restGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.restGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.restGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.restGrid.Size = new System.Drawing.Size(750, 313);
            this.restGrid.TabIndex = 4;
            this.restGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Folder";
            this.dataGridViewTextBoxColumn8.HeaderText = "Folder";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // getNeedResponseBindingSource
            // 
            this.getNeedResponseBindingSource.DataSource = typeof(SyncthingRestClient.Response.GetNeedResponse);
            // 
            // ModifiedAtColumn
            // 
            this.ModifiedAtColumn.DataPropertyName = "ModifiedAt";
            this.ModifiedAtColumn.HeaderText = "Modified at";
            this.ModifiedAtColumn.Name = "ModifiedAtColumn";
            this.ModifiedAtColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "File";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // SizeColumn
            // 
            this.SizeColumn.DataPropertyName = "Size";
            this.SizeColumn.HeaderText = "Size";
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.ReadOnly = true;
            // 
            // LocalVersionColumn
            // 
            this.LocalVersionColumn.DataPropertyName = "LocalVersion";
            this.LocalVersionColumn.HeaderText = "Local version";
            this.LocalVersionColumn.Name = "LocalVersionColumn";
            this.LocalVersionColumn.ReadOnly = true;
            // 
            // RemoteVersionColumn
            // 
            this.RemoteVersionColumn.DataPropertyName = "Version";
            this.RemoteVersionColumn.HeaderText = "Remote version";
            this.RemoteVersionColumn.Name = "RemoteVersionColumn";
            this.RemoteVersionColumn.ReadOnly = true;
            // 
            // needBindingListBindingSource
            // 
            this.needBindingListBindingSource.DataSource = typeof(MetroThing.Bindings.NeedBindingList);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ModifiedAt";
            this.dataGridViewTextBoxColumn1.HeaderText = "Modified at";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn4.HeaderText = "Size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LocalVersion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Local version";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Version";
            this.dataGridViewTextBoxColumn6.HeaderText = "Remote version";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ModifiedAt";
            this.dataGridViewTextBoxColumn7.HeaderText = "Modified at";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn10.HeaderText = "Size";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LocalVersion";
            this.dataGridViewTextBoxColumn11.HeaderText = "Local version";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Version";
            this.dataGridViewTextBoxColumn12.HeaderText = "Remote version";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // NeedQueueForm
            // 
            this.AcceptButton = this.closeTile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeTile;
            this.ClientSize = new System.Drawing.Size(798, 495);
            this.Controls.Add(this.bumpTile);
            this.Controls.Add(this.queuesTabControl);
            this.Controls.Add(this.loadProgressLabel);
            this.Controls.Add(this.loadProgressBar);
            this.Controls.Add(this.closeTile);
            this.Controls.Add(this.refreshTile);
            this.Name = "NeedQueueForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 80);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Download queue";
            this.Shown += new System.EventHandler(this.NeedQueueForm_Shown);
            this.queuesTabControl.ResumeLayout(false);
            this.progressTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressGrid)).EndInit();
            this.queuedTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queueGrid)).EndInit();
            this.restTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getNeedResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.needBindingListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile refreshTile;
        private MetroFramework.Components.MetroToolTip Tooltip;
        private MetroFramework.Controls.MetroTile closeTile;
        private System.Windows.Forms.BindingSource getNeedResponseBindingSource;
        private System.Windows.Forms.BindingSource needBindingListBindingSource;
        private MetroFramework.Controls.MetroProgressBar loadProgressBar;
        private MetroFramework.Controls.MetroLabel loadProgressLabel;
        private MetroFramework.Controls.MetroTabControl queuesTabControl;
        private System.Windows.Forms.TabPage progressTab;
        private MetroFramework.Controls.MetroGrid progressGrid;
        private System.Windows.Forms.TabPage queuedTabPage;
        private System.Windows.Forms.TabPage restTabPage;
        private MetroFramework.Controls.MetroGrid restGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private MetroFramework.Controls.MetroTile bumpTile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedAtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalVersionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemoteVersionColumn;
        private MetroFramework.Controls.MetroGrid queueGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}