using SyncthingCore.Types;
using SyncthingRestClient.Response;

namespace MetroThing.Bindings
{
    public class NeedBindingItem : GetNeedResponseFileNode
    {
        public NeedBindingItem(GetNeedResponseFileNode fileNode, Folder folder)
        {
            Folder = folder.Id;
            Flags = fileNode.Flags;
            Name = fileNode.Name;
            LocalVersion = fileNode.LocalVersion;
            Version = fileNode.Version;
            ModifiedAt = fileNode.ModifiedAt;
            Name = fileNode.Name;
            Size = fileNode.Size;
        }

        public string Folder { get; set; }
    }
}