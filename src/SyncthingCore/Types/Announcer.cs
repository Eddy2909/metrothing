using System;

namespace SyncthingCore.Types
{
    public class Announcer : Uri
    {
        public Announcer(string uriString) : base(uriString)
        {
        }

        public bool Connected { get; set; }
    }
}