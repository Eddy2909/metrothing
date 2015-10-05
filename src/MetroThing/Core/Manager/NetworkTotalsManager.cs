using System;
using System.Collections.Generic;
using System.ComponentModel;
using SyncthingCore;

namespace MetroThing.Core.Manager
{
    public class NetworkTotalsManager
    {
        private readonly Dictionary<Guid, ManagedInstance> _instances;

        public NetworkTotalsManager()
        {
            _instances = new Dictionary<Guid, ManagedInstance>();
        }

        public long TotalBytesInPerSecond { get; private set; }
        public long TotalBytesOutPerSecond { get; private set; }
        public event EventHandler TotalsChanged;

        public void Subscribe(ManagedInstance instance)
        {
            _instances.Add(instance.Id, instance);

            instance.Statistics.PropertyChanged += OnStatisticsChanged;
            instance.Unmonitored += OnUnmonitored;
        }

        private void OnUnmonitored(object sender, InstanceEventArgs e)
        {
            // We need to remove the instance from the monitored pool
            var senderInstance = (ManagedInstance) sender;
            _instances.Remove(senderInstance.Id);

            senderInstance.Statistics.PropertyChanged -= OnStatisticsChanged;
            senderInstance.Unmonitored -= OnUnmonitored;
        }

        private void OnStatisticsChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "UploadPerSecond" && e.PropertyName != "DownloadPerSecond") return;

            long totalUp = 0;
            long totalDown = 0;

            foreach (var instance in _instances.Values)
            {
                if (instance.Statistics.UploadPerSecond != null)
                    totalUp += (long) instance.Statistics.UploadPerSecond;

                if (instance.Statistics.DownloadPerSecond != null)
                    totalDown += (long) instance.Statistics.DownloadPerSecond;
            }

            if (totalUp != TotalBytesOutPerSecond || totalDown != TotalBytesInPerSecond)
            {
                TotalBytesOutPerSecond = totalUp;
                TotalBytesInPerSecond = totalDown;

                OnTotalsChanged();
            }
        }

        protected virtual void OnTotalsChanged()
        {
            var handler = TotalsChanged;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}