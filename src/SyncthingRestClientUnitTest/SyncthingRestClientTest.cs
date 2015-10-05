using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SyncthingRestClient;
using SyncthingRestClient.Response;
using SyncthingRestClientUnitTest.Properties;

namespace SyncthingRestClientUnitTest
{
    [TestClass]
    public class SyncthingRestClientTest
    {
        private RestClient _client;

        private const string DeviceIdentifierRegex =
            "^[0-9A-Z]{7}-[0-9A-Z]{7}-[0-9A-Z]{7}-[0-9A-Z]{7}-[0-9A-Z]{7}-[0-9A-Z]{7}-[0-9A-Z]{7}-[0-9A-Z]{7}$";

        [TestInitialize]
        public void TestInit()
        {
            _client = new RestClient(
                Settings.Default.ServerHostname,
                Settings.Default.ServerPort,
                Settings.Default.ServerUseHttps,
                Settings.Default.ServerApiKey
                );
        }

        [TestMethod]
        public void TestGetPingRequest()
        {
            var response = _client.GetPing();
            AssertGetPingRequest(response);
        }

        [TestMethod]
        public async Task TestGetPingRequestAsync()
        {
            var response = await _client.GetPingAsync(CancellationToken.None);
            AssertGetPingRequest(response);
        }

        private static void AssertGetPingRequest(GetPingResponse response)
        {
            // ping property
            Assert.IsTrue(string.Equals(response.Ping, "pong"));
        }

        [TestMethod]
        public void TestGetVersionRequest()
        {
            var response = _client.GetVersion();
            AssertGetVersionRequest(response);
        }

        [TestMethod]
        public async Task TestGetVersionRequestAsync()
        {
            var response = await _client.GetVersionAsync(CancellationToken.None);
            AssertGetVersionRequest(response);
        }

        private static void AssertGetVersionRequest(GetVersionResponse response)
        {
            // arch property
            Assert.IsFalse(string.IsNullOrWhiteSpace(response.Architecture));

            // long version property
            StringAssert.Contains(response.LongVersion, "syncthing");

            // os property
            Assert.IsFalse(string.IsNullOrWhiteSpace(response.OperatingSystem));

            // version property
            Assert.IsFalse(string.IsNullOrWhiteSpace(response.Version));
        }

        [TestMethod]
        public void TestGetSystemRequest()
        {
            var response = _client.GetSystemStatus();
            AssertGetSystemRequest(response);
        }

        [TestMethod]
        public async Task TestGetSystemRequestAsync()
        {
            var response = await _client.GetSystemStatusAsync(CancellationToken.None);
            AssertGetSystemRequest(response);
        }

        private static void AssertGetSystemRequest(GetSystemResponse response)
        {
            // alloc property
            Assert.IsTrue(response.UsedMemory > 0);

            // sys property
            Assert.IsTrue(response.AllocatedMemory > 0);

            // external announcers property
            Assert.IsTrue(response.ExternalAnnouncers.Count > 0);

            // cpu property
            Assert.IsTrue(response.CpuUsage >= 0f && response.CpuUsage <= 100f);

            // go routines property
            Assert.IsTrue(response.GoRoutineCount > 0);

            // id property
            StringAssert.Matches(response.Identifier, new Regex(DeviceIdentifierRegex));
        }

        [TestMethod]
        public void TestGetUpgradeStatusRequest()
        {
            var response = _client.GetUpgradeStatus();
            AssertGetUpgradeStatusRequest(response);
        }

        [TestMethod]
        public async Task TestGetUpgradeStatusRequestAsync()
        {
            var response = await _client.GetUpgradeStatusAsync(CancellationToken.None);
            AssertGetUpgradeStatusRequest(response);
        }

        private static void AssertGetUpgradeStatusRequest(GetUpgradeResponse response)
        {
            // latest property
            Assert.IsFalse(string.IsNullOrWhiteSpace(response.LatestVersion));

            // running property
            Assert.IsFalse(string.IsNullOrWhiteSpace(response.RunningVersion));

            // newer property
            Assert.IsNotNull(response.IsUpgradeAvailable);
        }

        [TestMethod]
        public void TestGetReportRequest()
        {
            var response = _client.GetReport();
            AssertGetReportRequest(response);
        }

        [TestMethod]
        public async Task TesetGetReportRequestAsync()
        {
            var response = await _client.GetReportAsync(CancellationToken.None);
            AssertGetReportRequest(response);
        }

        private static void AssertGetReportRequest(GetReportResponse response)
        {
            // folderMaxFiles property
            Assert.IsTrue(response.LargestFolderFiles >= 0);

            // folderMaxMiB property
            Assert.IsTrue(response.LargestFolderMebibyte >= 0);

            // longVersion property
            StringAssert.Contains(response.LongVersion, "syncthing");

            // memorySize property
            Assert.IsTrue(response.MemorySize > 0);

            // memoryUsageMiB property
            Assert.IsTrue(response.MemoryUsageMebibyte > 0);

            // numDevices property
            Assert.IsTrue(response.DeviceCount >= 0);

            // numFolders property
            Assert.IsTrue(response.FolderCount >= 0);

            // platform property
            Assert.IsFalse(string.IsNullOrWhiteSpace(response.Platform));

            // sha256Perf property
            Assert.IsTrue(response.CryptPerformance >= 0f);

            // totFiles property
            Assert.IsTrue(response.TotalFilesCount >= 0);

            // totMiB property
            Assert.IsTrue(response.TotalMebibyteCount >= 0);

            // uniqueID property
            Assert.IsFalse(string.IsNullOrWhiteSpace(response.UniqueIdentifier));

            // version property
            Assert.IsFalse(string.IsNullOrWhiteSpace(response.Version));
        }

        [TestMethod]
        public void TestGetConnectionsRequest()
        {
            var response = _client.GetConnetions();
            AssertGetConnectionsRequest(response);
        }

        [TestMethod]
        public async Task TestGetConnectionsRequestAsync()
        {
            var response = await _client.GetConnectionsAsync(CancellationToken.None);
            AssertGetConnectionsRequest(response);
        }

        private static void AssertGetConnectionsRequest(GetConnetionResponse response)
        {
            // total sub object
            Assert.IsNotNull(response.Total);

            var total = response.Total;

            if (total == null) return;

            // total.At property
            DateTime dummy;
            Assert.IsTrue(DateTime.TryParse(total.At.ToLongTimeString(), out dummy));
            Assert.IsNotNull(dummy);

            // total.InBytesTotal property
            Assert.IsTrue(total.InBytesTotal >= 0);

            // total.OutBytesTotal property
            Assert.IsTrue(total.OutBytesTotal >= 0);
        }

        [TestMethod]
        public void TestGetConfigRequest()
        {
            var response = _client.GetConfig();
            AssertGetConfigRequest(response);
        }

        [TestMethod]
        public async Task TestGetConfigRequestAsync()
        {
            var response = await _client.GetConfigAsync(CancellationToken.None);
            AssertGetConfigRequest(response);
        }

        private static void AssertGetConfigRequest(GetConfigResponse response)
        {
            Assert.IsTrue(response.Version > 0);
            
            // devices node
            Assert.IsNotNull(response.Devices);
            Assert.IsTrue(response.Devices.Count > 0);

            foreach (var device in response.Devices)
            {
                Assert.IsFalse(String.IsNullOrWhiteSpace(device.DeviceId));
            }

            // folders node
            Assert.IsNotNull(response.Folders);
            Assert.IsTrue(response.Folders.Count > 0);

            foreach (var folder in response.Folders)
            {
                Assert.IsFalse(String.IsNullOrWhiteSpace(folder.Id));
                Assert.IsFalse(String.IsNullOrWhiteSpace(folder.Path));

                foreach (var device in folder.Devices)
                {
                    Assert.IsFalse(String.IsNullOrWhiteSpace(device.DeviceId));
                }
            }

            Assert.IsNotNull(response.Gui);
            Assert.IsFalse(String.IsNullOrWhiteSpace(response.Gui.ApiKey));
            Assert.IsFalse(String.IsNullOrWhiteSpace(response.Gui.ListeningAddress));
        }

        [TestMethod]
        public void TestGetFolderStats()
        {
            var response = _client.GetFolderStats();
            AssertGetFolderStatsRequest(response);
        }

        [TestMethod]
        public async Task TestGetFolderStatsAsync()
        {
            var response = await _client.GetFolderStatsAsync(CancellationToken.None);
            AssertGetFolderStatsRequest(response);
        }

        public void AssertGetFolderStatsRequest(GetFolderStatsResponse response)
        {
            var result = response.Folders;

            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

            foreach (var folder in result)
            {
                Assert.IsFalse(String.IsNullOrWhiteSpace(folder.Key));

                Assert.IsNotNull(folder.Value.LastFile);

                Assert.IsInstanceOfType(folder.Value.LastFile.At, typeof(DateTime));
                Assert.IsFalse(String.IsNullOrWhiteSpace(folder.Value.LastFile.Filename));
            }
        }

        [TestMethod]
        public void TestFormatDeviceIdentifier()
        {
            var format = _client.FormatDeviceIdentifier(@"p56ioi7m--zjnu2iq-gdr-eydm-2mgtmgl3bxnpq6w5btbbz4tjxzwicq");

            Assert.IsTrue(string.Equals(format, @"P56IOI7-MZJNU2Y-IQGDREY-DM2MGTI-MGL3BXN-PQ6W5BM-TBBZ4TJ-XZWICQ2"));
        }

        [TestMethod]
        public void TestVerifyDeviceIdentifier()
        {
            var verify = _client.VerifyDeviceIdentifier(@"1234");

            Assert.IsFalse(verify);
        }
    }
}