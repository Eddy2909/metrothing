using System.Collections.Specialized;
using SyncthingCore.Collections;

namespace SyncthingCore.EventListeners
{
    public class ErrorEventHandler
    {
        private ErrorCollection _collection;

        public ErrorEventHandler(ErrorCollection collection)
        {
            _collection = collection;

            collection.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    // POST /rest/error
                    break;
                case NotifyCollectionChangedAction.Reset:
                    // POST /rest/error/clear
                    break;
            }
        }
    }
}