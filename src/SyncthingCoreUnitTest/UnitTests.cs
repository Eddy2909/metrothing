using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SyncthingCore;
using SyncthingCore.Collections;
using SyncthingCore.Exceptions;
using SyncthingCore.Types;
using SyncthingCore.Worker;
using SyncthingCoreUnitTest.Properties;

namespace SyncthingCoreUnitTest
{
    [TestClass]
    [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
    public class UnitTests
    {
        private RestEndpointCollection GetDefaultRestEndpointCollection()
        {
            return new RestEndpointCollection
            {
                new RestEndpoint
                {
                    Hostname = Settings.Default.ServerHostname,
                    Port = Settings.Default.ServerPort,
                    Priority = 100
                }
            };
        }

        private string GetDefaultApiKey()
        {
            return Settings.Default.ServerApiKey;
        }

        private ManagedInstance GetDefaultInstance(ManagedInstanceDirective directive = null)
        {
            return new ManagedInstance(directive ?? GetDefaultDirective())
            {
                ApiKey = GetDefaultApiKey(),
                UseHttps = Settings.Default.ServerUseHttps,
                PossibleEndpoints = GetDefaultRestEndpointCollection()
            };
        }

        private ManagedInstanceDirective GetDefaultDirective()
        {
            var directive = new ManagedInstanceDirective();
            var wait = TimeSpan.FromMilliseconds(600);
            var timeout = TimeSpan.FromSeconds(1);

            directive.HeartbeatDirective = new WorkerDirective(true, wait, timeout);
            directive.ReportStatusDirective = new WorkerDirective(true, wait, timeout);
            directive.SystemStatusDirective = new WorkerDirective(true, wait, timeout);
            directive.VersionUpgradeDirective = new WorkerDirective(true, wait, timeout);

            return directive;
        }

        private ManagedInstanceDirective GetClearDirective()
        {
            var directive = new ManagedInstanceDirective();
            var time = TimeSpan.FromHours(1);

            directive.HeartbeatDirective = new WorkerDirective(false, time, time);
            directive.ReportStatusDirective = new WorkerDirective(false, time, time);
            directive.SystemStatusDirective = new WorkerDirective(false, time, time);
            directive.VersionUpgradeDirective = new WorkerDirective(false, time, time);

            return directive;
        }

        [TestMethod]
        public void TestInstantiationWithoutConfig()
        {
            new ManagedInstance();
        }

        [TestMethod]
        public void TestInstantiationWithConfig()
        {
            var config = new ManagedInstanceDirective {DoAutomaticUpdates = false};
            new ManagedInstance(config);
        }

        [TestMethod]
        [ExpectedException(typeof (ManagedInstanceConfigurationException))]
        public async Task TestMissingEndpoints()
        {
            var instance = new ManagedInstance
            {
                ApiKey = "unittest"
            };

            instance.Watch();

            await Task.Delay(TimeSpan.FromSeconds(3));


            Assert.IsTrue(instance.IsInState(ManagedInstance.State.Disconnected));
        }

        [TestMethod]
        [ExpectedException(typeof (ManagedInstanceConfigurationException))]
        public async Task TestMissingApiKey()
        {
            var instance = new ManagedInstance
            {
                PossibleEndpoints = GetDefaultRestEndpointCollection()
            };

            instance.Watch();

            await Task.Delay(TimeSpan.FromSeconds(3));

            Assert.IsTrue(instance.IsInState(ManagedInstance.State.Disconnected));
        }

        [TestMethod]
        public async Task TestManagedConnectDisconnectCycle()
        {
            var instance = GetDefaultInstance();

            var connects = 0;
            var disconnects = 0;

            instance.Connected +=
                delegate(object sender, ConnectedEventArgs e)
                {
                    if (!e.Success) return;

                    connects++;
                    Assert.IsTrue(instance.IsInState(ManagedInstance.State.Connected));
                    Assert.IsNotNull(instance.ConnectedEndpoint);
                };

            instance.Disconnected +=
                delegate(object sender, InstanceEventArgs e)
                {
                    if (!e.Success) return;

                    disconnects++;
                    Assert.IsTrue(instance.IsInState(ManagedInstance.State.Disconnected));
                    Assert.IsNull(instance.ConnectedEndpoint);
                };


            for (var i = 1; i < 3; i++)
            {
                instance.Watch();
                await Task.Delay(TimeSpan.FromSeconds(3));
                //Assert.IsTrue(instance.CurrentState == ManagedInstance.State.Connected);
                //Assert.IsNotNull(instance.ConnectedEndpoint);

                instance.Disconnect();
                await Task.Delay(TimeSpan.FromSeconds(3));
                //Assert.IsTrue(instance.CurrentState == ManagedInstance.State.Disconnected);
                //Assert.IsNull(instance.ConnectedEndpoint);
            }

            Assert.IsTrue(connects > 1);
            Assert.IsTrue(disconnects > 1);
        }

        [TestMethod]
        [ExpectedException(typeof (ManagedInstanceConnectionException))]
        public void TestManagedConnectWithWrongEndpointWithHigherPriority()
        {
            var instance = GetDefaultInstance();

            instance.PossibleEndpoints.Add(new RestEndpoint
            {
                Hostname = "localhost",
                Port = 12345,
                Priority = 999
            });

            instance.Watch();
        }

        [TestMethod]
        public async Task TestHeartbeatWorker()
        {
            var directive = GetClearDirective();
            directive.HeartbeatDirective =
                new WorkerDirective(true, TimeSpan.FromMilliseconds(800), TimeSpan.FromSeconds(2));

            var instance = GetDefaultInstance(directive);
            var heartbeats = new List<HeartbeatWorkerEventArgs>();

            instance.ConnectionChecked +=
                delegate(object sender, HeartbeatWorkerEventArgs e) { heartbeats.Add(e); };

            instance.Watch();
            await Task.Delay(TimeSpan.FromSeconds(5));

            Assert.IsTrue(heartbeats.Count > 4);

            foreach (var beat in heartbeats)
            {
                Assert.IsTrue(beat.PingAlive);
                Assert.IsTrue(beat.ApiAlive);
                Assert.IsTrue(beat.PingRoundtripTime >= 0);
            }
        }

        [TestMethod]
        public async Task TestSystemStatusWorker()
        {
            var instance = GetDefaultInstance();
            var infoPropertyChanges = new List<PropertyChangedEventArgs>();
            var statsPropertyChanges = new List<PropertyChangedEventArgs>();

            instance.Information.PropertyChanged +=
                delegate(object sender, PropertyChangedEventArgs e) { infoPropertyChanges.Add(e); };

            instance.Statistics.PropertyChanged +=
                delegate(object sender, PropertyChangedEventArgs e) { statsPropertyChanges.Add(e); };

            instance.Watch();
            await Task.Delay(TimeSpan.FromSeconds(3));

            Assert.IsTrue(infoPropertyChanges.Count > 0);
            Assert.IsTrue(statsPropertyChanges.Count > 0);
        }

        [TestMethod]
        public async Task TestReportStatusWorker()
        {
            var directive = GetClearDirective();
            directive.ReportStatusDirective =
                new WorkerDirective(true, TimeSpan.FromMilliseconds(800), TimeSpan.FromMilliseconds(2000));

            var instance = GetDefaultInstance(directive);
            var infoPropertyChanges = new List<PropertyChangedEventArgs>();
            var statsPropertyChanges = new List<PropertyChangedEventArgs>();

            instance.Information.PropertyChanged +=
                delegate(object sender, PropertyChangedEventArgs e) { infoPropertyChanges.Add(e); };

            instance.Statistics.PropertyChanged +=
                delegate(object sender, PropertyChangedEventArgs e) { statsPropertyChanges.Add(e); };

            instance.Watch();
            await Task.Delay(TimeSpan.FromSeconds(5));

            Assert.IsTrue(infoPropertyChanges.Count > 0);
            Assert.IsTrue(statsPropertyChanges.Count > 5);
        }

        [TestMethod]
        public async Task TestVersionUpgradeWorker()
        {
            var directive = GetClearDirective();
            directive.VersionUpgradeDirective =
                new WorkerDirective(true, TimeSpan.FromMilliseconds(800), TimeSpan.FromMilliseconds(3000));

            var instance = GetDefaultInstance(directive);
            var result = false;

            instance.Information.PropertyChanged +=
                delegate(object sender, PropertyChangedEventArgs e)
                {
                    if (e.PropertyName == "LatestVersion") result = true;
                };

            instance.Watch();
            await Task.Delay(TimeSpan.FromSeconds(5));

            Assert.IsFalse(string.IsNullOrWhiteSpace(instance.Information.LatestVersion));
            Assert.IsTrue(result);
        }
    }
}