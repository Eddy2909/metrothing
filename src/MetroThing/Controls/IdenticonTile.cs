using System;
using System.ComponentModel;
using System.Drawing;
using Devcorner.NIdenticon;
using MetroFramework.Controls;
using SyncthingCore;

namespace MetroThing.Controls
{
    public partial class IdenticonTile : MetroUserControl
    {
        private ManagedInstance _instance;

        public IdenticonTile()
        {
            InitializeComponent();
        }

        public ManagedInstance Instance
        {
            get { return _instance; }
            set
            {
                // Clear old event listeners
                if (_instance != null)
                    _instance.Information.PropertyChanged -= OnPropertyChanged;

                // Attach new event listeners
                if (value != null)
                    value.Information.PropertyChanged += OnPropertyChanged;

                _instance = value;
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "SyncthingId") return;

            if (Instance.Information.SyncthingId != null)
            {
                iconPictureBox.Image = new IdenticonGenerator()
                    .WithBlocks(5, 5)
                    .Create(Instance.Information.SyncthingId.Replace("-", ""),
                        new Size(iconPictureBox.Width, iconPictureBox.Height));
            }

            iconPictureBox.Visible = !String.IsNullOrWhiteSpace(Instance.Information.SyncthingId);
        }
    }
}