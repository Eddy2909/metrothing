using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Serilog;

namespace SyncthingCore.Extensions
{
    public static class ObservableCollectionExtensions
    {
        public static void RemoveAll<T>(this ObservableCollection<T> collection)
        {
            for (var i = collection.Count - 1; i >= 0; i--)
            {
                collection.RemoveAt(i);
            }
        }

        public static void SynchronizeTo<T>(this ObservableCollection<T> collection, List<T> sourcecollection)
        {
            // Remove all that do no longer exist
            var toRemove = collection.Except(sourcecollection).ToList();
            var toAdd = sourcecollection.Except(collection).ToList();

            Log.Logger.Verbose("SynchronizeTo with {type}, adding {added} and removing {removed}", collection.GetType(),
                toAdd.Count, toRemove.Count);

            foreach (var folder in toRemove)
                collection.Remove(folder);

            foreach (var folder in toAdd)
                collection.Add(folder);
        }
    }
}