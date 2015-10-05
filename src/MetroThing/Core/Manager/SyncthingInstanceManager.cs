using System.Collections.ObjectModel;
using System.Collections.Specialized;
using MetroThing.Types;
using SyncthingCore;

namespace MetroThing.Core.Manager
{
    public class SyncthingInstanceManager : ObservableCollection<ManagedInstance>
    {
        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (ManagedInstance instance in e.NewItems)
                    {
                        Singleton<LocalFolderManager>.Instance.Subscribe(instance);
                        Singleton<NetworkTotalsManager>.Instance.Subscribe(instance);
                        instance.Watch();
                    }
                    break;

                case NotifyCollectionChangedAction.Remove:
                    foreach (ManagedInstance instance in e.OldItems)
                    {
                        instance.Unwatch();
                    }
                    break;
            }


            base.OnCollectionChanged(e);
        }

        protected override void ClearItems()
        {
            // We need to stop every instance before the manager resets
            foreach (var instance in this)
            {
                instance.Unwatch();
            }

            base.ClearItems();
        }
    }
}