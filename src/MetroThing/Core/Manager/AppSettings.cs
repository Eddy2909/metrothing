using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using MetroThing.Types;
using Serilog;
using SyncthingCore;
using SyncthingCore.Types;
using File = System.IO.File;

namespace MetroThing.Core.Manager
{
    public static class AppSettings
    {
        private const string DefaultFilename = "settings.xml";

        /// <summary>
        ///     Captures and saves the current settings to the default location
        /// </summary>
        /// <param name="form">If given, its visual representation is also saved</param>
        public static void Save(Form form = null)
        {
            // Ensure the app directory is there
            var folder = Path.GetDirectoryName(GetDefaultFileLocation());

            if (folder != null && !Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            // Serialize it into it
            using (var stream = new FileStream(GetDefaultFileLocation(), FileMode.Create))
            {
                try
                {
                    var serializer = new XmlSerializer(typeof (SettingsSnapshot));
                    var backup = Backup(form);

                    serializer.Serialize(stream, Backup());

                    Log.Logger.Debug("{this} ~ Settings saved: {@settings}", typeof (AppSettings), backup);
                }
                catch (Exception e)
                {
                    Log.Logger.Error("{this} ~ Settings could not be saved: {@error}", typeof (AppSettings), e);
                }
            }
        }

        /// <summary>
        ///     Loads and restores the current settings from the default location
        /// </summary>
        /// <param name="form">If given, its visual representation will also be restored</param>
        public static void Load(Form form = null)
        {
            if (!File.Exists(GetDefaultFileLocation())) return;

            using (var stream = new FileStream(GetDefaultFileLocation(), FileMode.Open))
            {
                try
                {
                    var serializer = new XmlSerializer(typeof (SettingsSnapshot));
                    var backup = (SettingsSnapshot) serializer.Deserialize(stream);

                    Restore(backup, form);

                    Log.Logger.Debug("{this} ~ Settings loaded: {@settings}", typeof (AppSettings), backup);
                }
                catch (Exception e)
                {
                    Log.Logger.Error("{this} ~ Settings could not be loaded: {@error}", typeof (AppSettings), e);
                }
            }
        }

        /// <summary>
        ///     Captures and returns the current settings
        /// </summary>
        /// <param name="form">If given, its visual representation is also be captured and returned</param>
        /// <returns>Current settings in a serializable object</returns>
        public static SettingsSnapshot Backup(Form form = null)
        {
            var snapshot = new SettingsSnapshot();

            // Instance settings
            foreach (var instance in Singleton<SyncthingInstanceManager>.Instance)
            {
                // Convert instance
                snapshot.Instances.Add(new SettingsSnapshot.Instance
                {
                    Id = instance.Id,
                    Name = instance.CustomName,
                    UseHttps = instance.UseHttps,
                    ApiKey = instance.ApiKey,
                    Endpoints =
                        instance.PossibleEndpoints.Select(endpoint => new SettingsSnapshot.InstanceEndpoint(endpoint))
                            .ToList()
                });
            }

            return snapshot;
        }

        /// <summary>
        ///     Restores the given snapshot back to the application
        /// </summary>
        /// <param name="snapshot">Deserialzable object created by Backup()</param>
        /// <param name="form">If given, its visual representation will also be restored</param>
        public static void Restore(SettingsSnapshot snapshot, Form form = null)
        {
            Singleton<SyncthingInstanceManager>.Instance.Clear();

            foreach (var definition in snapshot.Instances)
            {
                try
                {
                    var instance = new ManagedInstance
                    {
                        Id = definition.Id,
                        CustomName = definition.Name,
                        UseHttps = definition.UseHttps,
                        ApiKey = definition.ApiKey
                    };

                    foreach (var storedEndpoint in definition.Endpoints)
                    {
                        instance.PossibleEndpoints.Add(new RestEndpoint
                        {
                            Hostname = storedEndpoint.Hostname,
                            Port = storedEndpoint.Port,
                            Priority = storedEndpoint.Priority,
                            IsPingable = true
                        });
                    }

                    Singleton<SyncthingInstanceManager>.Instance.Add(instance);
                }
                catch (InvalidOperationException)
                {
                    // Ignore instances without an endpoint
                }
            }
        }

        private static string GetDefaultFileLocation()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                @"MetroThing\" + DefaultFilename);
        }
    }
}