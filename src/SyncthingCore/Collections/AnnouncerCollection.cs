using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SyncthingCore.Types;

namespace SyncthingCore.Collections
{
    [Serializable]
    public class AnnouncerCollection : ObservableCollection<Announcer>
    {
        public AnnouncerCollection()
        {
        }

        public AnnouncerCollection(Dictionary<string, bool> announcerNode)
        {
            foreach (var announcer in announcerNode)
            {
                Add(new Announcer(announcer.Key) {Connected = announcer.Value});
            }
        }

        public bool Equals(Announcer x, Announcer y)
        {
            return x.AbsoluteUri == y.AbsoluteUri && x.Connected == y.Connected;
        }

        public int GetHashCode(Announcer obj)
        {
            return 37*obj.AbsoluteUri.GetHashCode() + 19*obj.Connected.GetHashCode();
        }
    }
}