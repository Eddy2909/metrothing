using System;
using System.ComponentModel;
using MetroFramework.Controls;
using SyncthingCore;
using SyncthingCore.Types;

namespace MetroThing.Controls
{
    public partial class CpuUsageTile : MetroUserControl
    {
        private ManagedInstance _instance;

        public CpuUsageTile()
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
            if (e.PropertyName != "CpuUsage" && e.PropertyName != "GoRoutineCount" &&
                e.PropertyName != "CryptPerformance") return;

            var stats = (Statistic) sender;

            // CPU usage
            cpuLabel.Text = stats.CpuUsage == null
                ? String.Empty
                : ((float) stats.CpuUsage).ToString("P2");

            // Tooltip
            if (stats.CpuUsage != null && stats.GoRoutineCount != null && stats.CryptPerformance != null)
            {
                Tooltip.SetToolTip(this,
                    String.Format("{0:P1} with {1:N0} GO routines\nCrypt performance is {2:N2} MiB/s",
                        stats.CpuUsage, stats.GoRoutineCount, stats.CryptPerformance));
            }
            else
            {
                Tooltip.RemoveAll();
            }
        }
    }
}