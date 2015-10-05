using System.Collections.Specialized;
using SyncthingCore.Collections;

namespace SyncthingCore.EventListeners
{
    public class AnnouncerEventHandler
    {
        private readonly AnnouncerCollection _collection;

        public AnnouncerEventHandler(AnnouncerCollection collection)
        {
            _collection = collection;

            _collection.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    // POST /rest/discovery/hint
                    break;
                case NotifyCollectionChangedAction.Remove:
                    // Unknown
                    break;
            }
        }
    }
}