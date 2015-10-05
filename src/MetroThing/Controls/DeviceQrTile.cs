using System;
using System.ComponentModel;
using MetroFramework.Controls;
using SyncthingCore;

namespace MetroThing.Controls
{
    public partial class DeviceQrTile : MetroUserControl
    {
        private ManagedInstance _instance;

        public DeviceQrTile()
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

            // Update identity tab
            if (Instance.Information.SyncthingId != null && qrPicture.Text != Instance.Information.SyncthingId)
                qrPicture.Text = Instance.Information.SyncthingId;

            qrPicture.Visible = !String.IsNullOrWhiteSpace(Instance.Information.SyncthingId);
        }
    }
}