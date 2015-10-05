using System.Collections.Generic;
using System.Collections.ObjectModel;
using SyncthingCore.Types;
using SyncthingRestClient.Response;

namespace SyncthingCore.Collections
{
    public class FoldersCollection : ObservableCollection<Folder>
    {
        public FoldersCollection()
        {
        }

        public FoldersCollection(IEnumerable<GetConfigResponseFoldersNode> foldersNode)
        {
            foreach (var folder in foldersNode)
            {
                Add(new Folder(folder));
            }
        }

        public bool Equals(Folder x, Folder y)
        {
            return x.Id == y.Id && x.Path == y.Path;
        }

        public int GetHashCode(Folder obj)
        {
            return 37*obj.Id.GetHashCode() + 19*obj.Path.GetHashCode();
        }
    }
}