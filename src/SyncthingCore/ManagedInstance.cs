using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Serilog;
using Stateless;
using SyncthingCore.Collections;
using SyncthingCore.Exceptions;
using SyncthingCore.Extensions;
using SyncthingCore.Types;
using SyncthingCore.Worker;
using SyncthingRestClient;
using SyncthingRestClient.Response;

namespace SyncthingCore
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class ManagedInstance
    {
        private string _customName;
        private RestClient _restClient;

        public ManagedInstance()
        {
            Initialize();
        }

        public ManagedInstance(ManagedInstanceDirective directive)
        {
            Initialize(directive);
        }

        public ManagedInstanceDirective Directives { get; set; }

        private void Initialize(ManagedInstanceDirective directive = null)
        {
            Directives = directive ?? new ManagedInstanceDirective();

            Log.Logger.Debug("Instance initialized with {@directive}", Directives);

            Information = new Information(this);
            Statistics = new Statistic(this);
            Synchronization = new Synchronization(this);

            Announcers = new AnnouncerCollection();
            Folders = new FoldersCollection();
            Errors = new ErrorCollection();

            PossibleEndpoints = new RestEndpointCollection();

            Id = Guid.NewGuid();

            ConfigureThreads();
            ConfigureStateMachine();
        }

        public override string ToString()
        {
            return CustomName;
        }

        /// <summary>
        ///     Removes any trace of volatile information that could taint the behaivour in an disconnected state.
        /// </summary>
        private void Clear()
        {
            Information.Clear();
            Statistics.Clear();
            Synchronization.Clear();

            Announcers.RemoveAll();
            Folders.RemoveAll();
            Errors.RemoveAll();

            ConnectedEndpoint = null;
        }

        protected virtual void OnMonitored(InstanceEventArgs e)
        {
            var handler = Monitored;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnUnmonitored(InstanceEventArgs e)
        {
            var handler = Unmonitored;
            if (handler != null) handler(this, e);
        }

        private void OnConnecting(InstanceEventArgs e)
        {
            var handler = Connecting;
            if (handler != null) handler(this, e);
        }

        private void OnConnected(ConnectedEventArgs e)
        {
            e.RestClient = _restClient;

            var handler = Connected;
            if (handler != null) handler(this, e);
        }

        private void OnDisconnecting(InstanceEventArgs e)
        {
            var handler = Disconnecting;
            if (handler != null) handler(this, e);
        }

        private void OnDisconnected(InstanceEventArgs e)
        {
            var handler = Disconnected;
            if (handler != null) handler(this, e);
        }

        private void OnConnectionChecked(HeartbeatWorkerEventArgs e)
        {
            var handler = ConnectionChecked;
            if (handler != null) handler(this, e);
        }

        #region Thread listeners

        private void OnEndpointConnectStatusReceived(object sender, ConnectionWorkerEventArgs e)
        {
            if (!e.Success)
            {
                // Update instance name to first default if no custom name was given
                Information.DisplayName = String.IsNullOrWhiteSpace(CustomName)
                    ? PossibleEndpoints.First().Hostname
                    : CustomName;
            }
            else
            {
                // Sometimes a racing condition will occur that the connector detects a connection, through the instance is now unmonitored.
                if (!_fsm.CanFire(Trigger.Connected)) return;

                // Update instance name to conneted endpoint, if no custom name was given
                Information.DisplayName = String.IsNullOrWhiteSpace(CustomName) ? e.RestEndpoint.Hostname : CustomName;

                // Set default rest client and connected endpoint to the available ones
                _restClient = e.RestClient;
                ConnectedEndpoint = e.RestEndpoint;

                _fsm.Fire(Trigger.Connected);
            }
        }

        private void OnHeartbeatReceived(object sender, HeartbeatWorkerEventArgs e)
        {
            OnConnectionChecked(e);

            // The heartbeat controls wether a connected instance becomes available or unavailable
            if (e.ApiAlive)
            {
                // Mark the connection connected if it is healed/connected again
                if (_fsm.CanFire(Trigger.Connected))
                    _fsm.Fire(Trigger.Connected);
            }
            else
            {
                _fsm.Fire(Trigger.Disconnected);
            }
        }

        #endregion

        #region Public

        /// <summary>
        ///     Identifies the internal instance.
        /// </summary>
        /// <remarks>
        ///     Does not reflect the Syncthing ID.
        /// </remarks>
        public Guid Id { get; set; }

        /// <summary>
        ///     Display name of this instance. If no custom one was set this will be the connected hostname.
        /// </summary>
        public string CustomName
        {
            get { return _customName; }
            set
            {
                _customName = value;
                if (Information != null) Information.DisplayName = value;
            }
        }

        /// <summary>
        ///     API key to use for the Syncthing REST API.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        ///     Should HTTPS be used when connecting to the Syncthing REST API
        /// </summary>
        /// <remarks>Must be set in the Syncthing instance first!</remarks>
        public bool UseHttps { get; set; }

        /// <summary>
        ///     A collection of REST endpoints to try.
        /// </summary>
        /// <remarks>
        ///     This comes in handy if your client switches the network often (like a laptop) where the instance might be available
        ///     through a LAN based hostname (office) or through an external port-forwarding (on the go).
        /// </remarks>
        public RestEndpointCollection PossibleEndpoints;

        /// <summary>
        ///     The currently connected endpoint, if the managed instance is in the Connected state, otherwise null
        /// </summary>
        public RestEndpoint ConnectedEndpoint;

        /// <summary>
        ///     Contains basic information about the Syncthing instance
        /// </summary>
        public Information Information;

        /// <summary>
        ///     Contains all available statistics given by the Syncthing instance
        /// </summary>
        public Statistic Statistics;

        /// <summary>
        ///     Conaints all information about the overall synchronization effort
        /// </summary>
        public Synchronization Synchronization;

        /// <summary>
        ///     Contains all announcers known to the Syncthing instance
        /// </summary>
        public AnnouncerCollection Announcers;

        /// <summary>
        ///     Contains all folders known to this instance
        /// </summary>
        public FoldersCollection Folders;

        /// <summary>
        ///     Contains and manages all available error messages on the Syncthing instance
        /// </summary>
        public ErrorCollection Errors;

        /// <summary>
        ///     Initiates the instance monitoring
        /// </summary>
        public void Watch()
        {
            // Check configuration
            if (PossibleEndpoints.Count == 0)
                throw new ManagedInstanceConfigurationException("No possible REST endpoints defined");

            if (string.IsNullOrWhiteSpace(ApiKey))
                throw new ManagedInstanceConfigurationException("No API key set");

            _fsm.Fire(Trigger.Watch);
        }

        /// <summary>
        ///     Stops the instance monitoring
        /// </summary>
        public void Unwatch()
        {
            _fsm.Fire(Trigger.Unwatch);
        }

        /// <summary>
        ///     Disconnects the Syncthing instance, stopping and canceling all threads
        /// </summary>
        public void Disconnect()
        {
            _fsm.Fire(Trigger.Disconnect);
        }

        public async Task RestartAsync()
        {
            if (_fsm.IsInState(State.Connected))
            {
                await _restClient.RestartAsync(CancellationToken.None);
            }
        }

        public async Task UpgradeAsync()
        {
            if (_fsm.IsInState(State.Connected))
            {
                await _restClient.UpgradeAsync(CancellationToken.None);
            }
        }

        public async Task RescanAllAsync()
        {
            if (Folders != null && Folders.Count > 0)
            {
                var rescanFolders = Folders.ToList();

                Log.Logger.Verbose("{instance} ~ Triggered rescan of all folders: {@folders}", this, rescanFolders);

                await Task.Run(async () =>
                {
                    foreach (var folder in rescanFolders)
                    {
                        await _restClient.PostRescanAsync(folder.Id, CancellationToken.None);
                    }
                });
            }
        }

        public async Task<GetNeedResponse> LoadNeededFiles(Folder folder)
        {
            return await _restClient.GetNeedAsync(folder.Id, CancellationToken.None);
        }

        public async Task<PostBumpResponse> BumpFile(string folderId, string fileId)
        {
            return await _restClient.PostBumpAsync(folderId, fileId, CancellationToken.None);
        }

        #endregion

        #region State Machine

        public enum State
        {
            Unmonitored,
            Monitored,
            Disconnected,
            Connecting,
            Restarting,
            Upgrading,
            Connected
        }

        private enum Trigger
        {
            Watch,
            Unwatch,
            Connect,
            Connected,
            Disconnect,
            Disconnected,
            Restart,
            Upgrade
        }

        private StateMachine<State, Trigger> _fsm;


        private void ConfigureStateMachine()
        {
            _fsm = new StateMachine<State, Trigger>(State.Unmonitored);

            _fsm.OnTransitioned(OnStateMachineTransitioned);

            _fsm.Configure(State.Unmonitored)
                .Permit(Trigger.Watch, State.Connecting)
                .OnEntry(OnUnmonitoredState);

            _fsm.Configure(State.Monitored)
                .Permit(Trigger.Unwatch, State.Unmonitored)
                .OnEntry(OnMonitoredState);

            _fsm.Configure(State.Disconnected)
                .SubstateOf(State.Monitored)
                .PermitReentry(Trigger.Disconnect)
                .Permit(Trigger.Connect, State.Connecting)
                .OnEntry(OnDisconnectedState);

            _fsm.Configure(State.Connecting)
                .SubstateOf(State.Disconnected)
                .Permit(Trigger.Connected, State.Connected)
                .OnEntry(OnConnectingState);

            _fsm.Configure(State.Restarting)
                .SubstateOf(State.Disconnected)
                .Permit(Trigger.Connected, State.Connected);

            _fsm.Configure(State.Upgrading)
                .SubstateOf(State.Disconnected)
                .Permit(Trigger.Connected, State.Connected);

            _fsm.Configure(State.Connected)
                .SubstateOf(State.Monitored)
                .Permit(Trigger.Restart, State.Restarting)
                .Permit(Trigger.Upgrade, State.Upgrading)
                .Permit(Trigger.Disconnect, State.Disconnected)
                .Permit(Trigger.Disconnected, State.Disconnected)
                .OnEntry(OnConnectedState)
                .OnExit(OnConnectedStateExit);
        }

        private void OnStateMachineTransitioned(StateMachine<State, Trigger>.Transition obj)
        {
            Log.Logger.Verbose(
                @"{instance} ~ FSM ~ Transitioned from ""{source}"" to ""{destination}"" because of ""{trigger}""", this,
                obj.Source, obj.Destination, obj.Trigger);
        }

        private void OnUnmonitoredState()
        {
            OnUnmonitored(new InstanceEventArgs());
        }

        private void OnMonitoredState()
        {
            OnMonitored(new InstanceEventArgs());
        }

        private void OnConnectingState()
        {
            OnConnecting(new InstanceEventArgs());
        }

        private void OnConnectedState()
        {
            OnConnected(new ConnectedEventArgs {Success = true});
        }

        private void OnConnectedStateExit()
        {
            OnDisconnecting(new InstanceEventArgs());

            // We need to clear all volatile information as soon as we leave the connected
            // state. All remaining information could polute other mechanics
            Clear();
        }

        private void OnDisconnectedState()
        {
            OnDisconnected(new InstanceEventArgs());

            // Automatically try to reconnect on disconnect
            _fsm.Fire(Trigger.Connect);
        }

        public bool IsInState(State state)
        {
            return _fsm.IsInState(state);
        }

        #endregion

        #region Threads

        public EndpointConnectWorker EndpointConnectWorker { get; private set; }

        public HeartbeatWorker HeartbeatWorker { get; private set; }

        public FolderStatsWorker FolderStatsWorker { get; private set; }

        public ConfigurationWorker ConfigurationWorker { get; private set; }

        public VersionUpgradeWorker VersionUpgradeWorker { get; private set; }

        public ReportStatusWorker ReportStatusWorker { get; private set; }

        public SystemStatusWorker SystemStatusWorker { get; private set; }

        public ConnectionStatusWorker ConnectionStatusWorker { get; private set; }

        public FolderModelWorker FolderModelWorker { get; private set; }

        private void ConfigureThreads()
        {
            EndpointConnectWorker = new EndpointConnectWorker(this);
            HeartbeatWorker = new HeartbeatWorker(this);
            ConnectionStatusWorker = new ConnectionStatusWorker(this);
            SystemStatusWorker = new SystemStatusWorker(this);
            ReportStatusWorker = new ReportStatusWorker(this);
            VersionUpgradeWorker = new VersionUpgradeWorker(this);
            ConfigurationWorker = new ConfigurationWorker(this);
            FolderStatsWorker = new FolderStatsWorker(this);
            FolderModelWorker = new FolderModelWorker(this);

            // Connection monitoring events will be processed by this manager,
            // all other workers will enrich the information nodes themself.
            EndpointConnectWorker.Executed += OnEndpointConnectStatusReceived;
            HeartbeatWorker.Executed += OnHeartbeatReceived;
        }

        #endregion

        #region Events

        /// <summary>
        ///     Will be fired when Watch() was executed and the connection tests are about to happen
        /// </summary>
        public event EventHandler<InstanceEventArgs> Monitored;

        /// <summary>
        ///     Will be fired when Unwatch() was executed and the instance is in no useable state
        /// </summary>
        public event EventHandler<InstanceEventArgs> Unmonitored;

        /// <summary>
        ///     Will be fired when Connect() was executed and the connection tests begin.
        /// </summary>
        public event EventHandler<InstanceEventArgs> Connecting;

        /// <summary>
        ///     Will be fired when Connect() finished successfully and the aggregation of data through threads started.
        /// </summary>
        public event EventHandler<ConnectedEventArgs> Connected;

        /// <summary>
        ///     Will be fired when the Disconnect() was executed
        /// </summary>
        public event EventHandler<InstanceEventArgs> Disconnecting;

        /// <summary>
        ///     Will be fired when Disconnect() succeeds or the connection check failed.
        /// </summary>
        public event EventHandler<InstanceEventArgs> Disconnected;

        /// <summary>
        ///     Will be fired as soon as the connection becomes available API calls become possible.
        /// </summary>
        /// <summary>
        ///     Will be fired when the internal heartbeat check was executed.
        /// </summary>
        /// <remarks>The result can be found in the EventArgs</remarks>
        public event EventHandler<HeartbeatWorkerEventArgs> ConnectionChecked;

        #endregion
    }

    public class InstanceEventArgs : EventArgs
    {
        public bool Success;
    }

    public class ConnectedEventArgs : InstanceEventArgs
    {
        public RestClient RestClient;
    }
}