using System;
using System.ComponentModel;
using MetroFramework.Controls;
using MetroThing.Core.Helpers;
using SyncthingCore;

namespace MetroThing.Controls
{
    public partial class RamUsageTile : MetroUserControl
    {
        private ManagedInstance _instance;

        public RamUsageTile()
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
                    _instance.Statistics.PropertyChanged -= OnPropertyChanged;

                // Attach new event listeners
                if (value != null)
                    value.Statistics.PropertyChanged += OnPropertyChanged;

                _instance = value;
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "MemoryUsage" && e.PropertyName != "MemoryAllocation") return;

            if (Instance.Statistics.MemoryUsage == null)
            {
                ramLabel.Text = "";
                Tooltip.RemoveAll();
            }
            else
            {
                ramLabel.Text = StringHelper.ConvertByteSizeToHumanReadable((long) Instance.Statistics.MemoryUsage);

                Tooltip.SetToolTip(this, String.Format("{0} used of {1} allocated",
                    ramLabel.Text, StringHelper.ConvertByteSizeToHumanReadable(Instance.Statistics.MemoryAllocation)));
            }
        }
    }
}