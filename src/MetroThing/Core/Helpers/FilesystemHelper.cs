using System.Diagnostics;
using System.IO;

namespace MetroThing.Core.Helpers
{
    public static class FilesystemHelper
    {
        public static void OpenPathInExplorer(string path)
        {
            if (File.Exists(path)) path = Path.GetDirectoryName(path);

            var p = new Process {StartInfo = {FileName = @"explorer.exe", Arguments = @"file:\\\" + path}};
            p.Start();
        }
    }
}