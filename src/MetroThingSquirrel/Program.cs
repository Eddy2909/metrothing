using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MetroThing.Core.Manager;
using MetroThing.Types;
using Squirrel;

namespace MetroThingSquirrel
{
    public static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Task.Run(async () =>
            {
                var upgraded = false;
                while (!upgraded)
                {
                    await Task.Delay(TimeSpan.FromSeconds(5));

                    using (
                        var mgr = new UpdateManager(@"http://distribute.klonmaschine.de/metrothing/", "metrothing",
                            FrameworkVersion.Net45))
                    {
                        SquirrelAwareApp.HandleEvents(
                            v => mgr.CreateShortcutForThisExe(),
                            v => mgr.CreateShortcutForThisExe(),
                            onAppUninstall: v => mgr.RemoveShortcutForThisExe());

                        // Try the update
                        try
                        {
                            var updateInfo = await mgr.CheckForUpdate();

                            if (updateInfo != null && updateInfo.ReleasesToApply.Count > 0)
                            {
#if !DEBUG
                                await mgr.UpdateApp();
#endif

                                upgraded = true;
                                Singleton<InstallationManager>.Instance.Updated(
                                    updateInfo.FutureReleaseEntry.Version.ToString(),
                                    String.Join("", updateInfo.FetchReleaseNotes().Values));
                            }
                        }
                        catch (Exception e)
                        {
                            Trace.WriteLine("Squirrel update failed: " + e.Message);
                        }
                    }

                    if (!upgraded)
                        await Task.Delay(TimeSpan.FromHours(12));
                }
            });

            MetroThing.Program.Main();
        }
    }
}