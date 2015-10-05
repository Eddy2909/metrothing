using System;
using System.Threading;
using System.Windows.Forms;
using MetroThing.Properties;

namespace MetroThing
{
    public static class Program
    {
        private static Mutex _mutex;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // Upgrade settings
            if (Settings.Default.UpgradeRequired)
            {
                Settings.Default.Upgrade();
                Settings.Default.UpgradeRequired = false;
                Settings.Default.Save();
            }

            // Only allow one instance
            bool newInstace;
            _mutex = new Mutex(true, "metrothing", out newInstace);
            GC.KeepAlive(_mutex);
            if (!newInstace) return;

            // Run
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}