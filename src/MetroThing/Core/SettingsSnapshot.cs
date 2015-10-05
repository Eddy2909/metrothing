using System;
using System.Collections.Generic;
using System.Reflection;
using SyncthingCore.Types;

namespace MetroThing.Core
{
    [Serializable]
    public class SettingsSnapshot
    {
        public SettingsSnapshot()
        {
            Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            DateTime = DateTime.Now;

            Instances = new List<Instance>();
        }

        public string Version { get; set; }
        public DateTime DateTime { get; set; }
        public List<Instance> Instances { get; set; }

        [Serializable]
        public class Instance
        {
            public Instance()
            {
                Endpoints = new List<InstanceEndpoint>();
            }

            public Guid Id { get; set; }
            public string Name { get; set; }
            public string ApiKey { get; set; }
            public bool UseHttps { get; set; }
            public List<InstanceEndpoint> Endpoints { get; set; }
        }

        [Serializable]
        public class InstanceEndpoint
        {
            public InstanceEndpoint()
            {
            }

            public InstanceEndpoint(RestEndpoint restEndpoint)
            {
                Hostname = restEndpoint.Hostname;
                Port = restEndpoint.Port;
                Priority = restEndpoint.Priority;
                IsPingable = restEndpoint.IsPingable;
            }

            public string Hostname { get; set; }
            public UInt16 Port { get; set; }
            public int Priority { get; set; }
            public bool IsPingable { get; set; }
        }
    }
}