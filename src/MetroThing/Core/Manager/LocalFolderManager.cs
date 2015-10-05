using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using MetroThing.Types;
using SyncthingCore;
using SyncthingCore.Types;

namespace MetroThing.Core.Manager
{
    public class LocalFolderManager
    {
        private readonly Dictionary<string, Folder> _knownFolders;
        private readonly Dictionary<string, Folder> _knownLocalFolders;

        public LocalFolderManager()
        {
            _knownFolders = new Dictionary<string, Folder>();
            _knownLocalFolders = new Dictionary<string, Folder>();
        }

        public List<Folder> Folders
        {
            get { return _knownFolders.Values.ToList(); }
        }

        public List<Folder> LocalFolders
        {
            get { return _knownLocalFolders.Values.ToList(); }
        }

        public event EventHandler<FoldersChangedEventArgs> FoldersChanged;
        public event EventHandler<FoldersChangedEventArgs> LocalFoldersChanged;

        public void Subscribe(ManagedInstance instance)
        {
            instance.Folders.CollectionChanged += OnFolderChanged;
            instance.Unmonitored += OnUnmonitored;
        }

        private void OnUnmonitored(object sender, InstanceEventArgs e)
        {
            // We need to remove the instance from the monitored pool
            var senderInstance = (ManagedInstance) sender;

            senderInstance.Folders.CollectionChanged -= OnFolderChanged;
            senderInstance.Unmonitored -= OnUnmonitored;
        }

        private void OnFolderChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            _knownFolders.Clear();
            _knownLocalFolders.Clear();

            var localFoldersChanged = false;

            var manager = Singleton<SyncthingInstanceManager>.Instance;

            foreach (var folder in manager.SelectMany(instance => instance.Folders)
                )
            {
                if (Directory.Exists(folder.Path))
                {
                    if (!_knownLocalFolders.ContainsKey(folder.Id))
                    {
                        _knownLocalFolders.Add(folder.Id, folder);
                        localFoldersChanged = true;
                    }
                }

                if (!_knownFolders.ContainsKey(folder.Id))
                    _knownFolders.Add(folder.Id, folder);
            }

            OnFoldersChanged(new FoldersChangedEventArgs());

            if (localFoldersChanged)
                OnLocalFoldersChanged(new FoldersChangedEventArgs());
        }

        protected virtual void OnLocalFoldersChanged(FoldersChangedEventArgs e)
        {
            e.Folders = _knownLocalFolders.Values.ToList();

            var handler = LocalFoldersChanged;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnFoldersChanged(FoldersChangedEventArgs e)
        {
            e.Folders = _knownLocalFolders.Values.ToList();

            var handler = FoldersChanged;
            if (handler != null) handler(this, e);
        }
    }

    public class FoldersChangedEventArgs : EventArgs
    {
        public List<Folder> Folders;
    }
}