using System;

namespace MetroThing.Core.Manager
{
    public class InstallationManager
    {
        public event EventHandler<Tuple<string, string>> VersionUpdated;

        protected virtual void OnVersionUpdated(Tuple<string, string> e)
        {
            var handler = VersionUpdated;
            if (handler != null) handler(this, e);
        }

        public void Updated(string version, string changelog)
        {
            OnVersionUpdated(new Tuple<string, string>(version, changelog));
        }
    }
}