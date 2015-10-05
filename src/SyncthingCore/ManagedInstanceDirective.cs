using System;

namespace SyncthingCore
{
    [Serializable]
    public class ManagedInstanceDirective
    {
        public ManagedInstanceDirective()
        {
            DoAutomaticUpdates = true;
            UpgradeTimeout = TimeSpan.FromSeconds(30);
            RestartTimeout = TimeSpan.FromSeconds(30);

            EndpointConnectDirective = new WorkerDirective(true, TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(5));
            HeartbeatDirective = new WorkerDirective(true, TimeSpan.FromSeconds(3), TimeSpan.FromSeconds(5));
            ConnectionStatusDirective = new WorkerDirective(true, TimeSpan.FromSeconds(3), TimeSpan.FromSeconds(5));
            SystemStatusDirective = new WorkerDirective(true, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(5));
            ReportStatusDirective = new WorkerDirective(true, TimeSpan.FromMinutes(15), TimeSpan.FromSeconds(5));
            VersionUpgradeDirective = new WorkerDirective(true, TimeSpan.FromHours(6), TimeSpan.FromSeconds(5));
            FolderStatusDirective = new WorkerDirective(true, TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(10));
            FolderStatsDirective = new WorkerDirective(true, TimeSpan.FromSeconds(3), TimeSpan.FromSeconds(5));
            FolderModelDirectove = new WorkerDirective(true, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(25));
        }

        public WorkerDirective EndpointConnectDirective { get; set; }
        public WorkerDirective HeartbeatDirective { get; set; }
        public WorkerDirective ConnectionStatusDirective { get; set; }
        public WorkerDirective SystemStatusDirective { get; set; }
        public WorkerDirective ReportStatusDirective { get; set; }
        public WorkerDirective VersionUpgradeDirective { get; set; }
        public WorkerDirective FolderStatusDirective { get; set; }
        public WorkerDirective FolderStatsDirective { get; set; }
        public WorkerDirective FolderModelDirectove { get; set; }

        /// <summary>
        ///     Manual override for all other update settings. Set to false, no other update will be executed.
        /// </summary>
        public bool DoAutomaticUpdates { get; set; }

        /// <summary>
        ///     How many milliseconds until an upgrading instance times out and moves to disconnected state
        /// </summary>
        /// <remarks>This includes the time that the instance needs to download the new binaries</remarks>
        public TimeSpan UpgradeTimeout { get; set; }

        /// <summary>
        ///     How many milliseconds until a restarting instance times out and moves to disconnected state
        /// </summary>
        public TimeSpan RestartTimeout { get; set; }
    }

    public class WorkerDirective
    {
        public WorkerDirective(bool isEnabled, TimeSpan waitTime, TimeSpan timeout, bool inDebugMode = false)
        {
            IsEnabled = isEnabled;
            WaitTime = waitTime;
            Timeout = timeout;
            InDebugMode = inDebugMode;
        }

        /// <summary>
        ///     Should the worker execute at all
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        ///     How many milliseconds should pass between requests
        /// </summary>
        public TimeSpan WaitTime { get; set; }

        /// <summary>
        ///     How many milliseconds should the request get to execute before thread cancelation
        /// </summary>
        public TimeSpan Timeout { get; set; }

        /// <summary>
        ///     Should details about the FSM be shown in the debug log
        /// </summary>
        public bool InDebugMode { get; set; }
    }
}