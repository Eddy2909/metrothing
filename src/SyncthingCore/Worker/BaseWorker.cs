using System;
using System.Threading;
using System.Threading.Tasks;
using Serilog;
using Stateless;
using SyncthingRestClient;

namespace SyncthingCore.Worker
{
    public abstract class BaseWorker<T> where T : new()
    {
        private readonly WorkerDirective _directive;
        protected readonly ManagedInstance ManagedInstance;
        protected RestClient RestClient;

        protected BaseWorker(ManagedInstance instance, WorkerDirective directive)
        {
            ManagedInstance = instance;
            _directive = directive;

            ConfigureStateMachine();
            RegisterEventHandlers();

            Log.Logger.Debug(
                "{instance} ~ {thread} and configured it with {@directive}",
                instance.CustomName, GetType(), instance.Directives);
        }

        protected virtual void RegisterEventHandlers()
        {
            // On successfull connection we want to:
            // - Get the usable RestClient
            // - Start the worker
            ManagedInstance.Connected += OnConnected;

            // Ond disconnection we want to:
            // - Stop the worker
            ManagedInstance.Disconnecting += OnDisconnecting;
        }

        protected virtual void OnConnected(object sender, ConnectedEventArgs e)
        {
            if (!e.Success) return;

            RestClient = e.RestClient;

            Cleanup();

            StateMachine.Fire(Trigger.Start);
        }

        protected virtual void OnDisconnecting(object sender, InstanceEventArgs e)
        {
            RestClient = null;

            StateMachine.Fire(Trigger.Stop);
        }

        public event EventHandler<T> Executed;

        protected void Cleanup()
        {
            _executionCancellationTokenSource = new CancellationTokenSource();

            EventArgs = new T();
        }

        #region Volatile

        /// <summary>
        ///     Token for OnFetch related tasks
        /// </summary>
        private CancellationTokenSource _executionCancellationTokenSource;

        protected CancellationToken ExecutionCancelationToken
        {
            get { return _executionCancellationTokenSource.Token; }
        }

        /// <summary>
        ///     Token for OnWait related tasks
        /// </summary>
        private CancellationTokenSource _waitingCancellationTokenSource;

        protected CancellationToken WaitingCancellationToken
        {
            get { return _waitingCancellationTokenSource.Token; }
        }

        /// <summary>
        ///     Generic EventArgs to use
        /// </summary>
        protected T EventArgs;

        #endregion

        #region State Machine

        protected StateMachine<State, Trigger> StateMachine;

        protected enum State
        {
            Running,
            Fetching,
            Waiting,
            Stopped
        }

        protected enum Trigger
        {
            Start,
            Stop,
            Finish
        }

        private void ConfigureStateMachine()
        {
            StateMachine = new StateMachine<State, Trigger>(State.Stopped);

            if (_directive.InDebugMode)
                StateMachine.OnTransitioned(OnStateMachineTransitioned);

            StateMachine.Configure(State.Stopped)
                .Permit(Trigger.Start, State.Fetching)
                .OnEntry(OnStop);

            StateMachine.Configure(State.Running)
                .Permit(Trigger.Stop, State.Stopped);

            StateMachine.Configure(State.Fetching)
                .SubstateOf(State.Running)
                .Permit(Trigger.Finish, State.Waiting)
                .OnEntry(OnFetch);

            StateMachine.Configure(State.Waiting)
                .SubstateOf(State.Running)
                .Permit(Trigger.Finish, State.Fetching)
                .OnEntry(OnWait);

            StateMachine.OnUnhandledTrigger((state, trigger) => { });
        }

        private void OnStateMachineTransitioned(StateMachine<State, Trigger>.Transition obj)
        {
            Log.Logger.Debug(
                @"{instance} ~ {worker} ~ FSM ~ Transitioned from ""{source}"" to ""{destination}"" because of ""{trigger}""",
                ManagedInstance, this, obj.Source, obj.Destination, obj.Trigger);
        }

        #endregion

        #region Virtuals

        protected virtual void OnStop()
        {
            // Cancel all tokenized threads that might run
            if (_executionCancellationTokenSource != null)
                _executionCancellationTokenSource.Cancel();

            if (_waitingCancellationTokenSource != null)
                _waitingCancellationTokenSource.Cancel();

            Stop();
        }

        protected virtual async void OnWait()
        {
            Log.Logger.Debug(
                "{instance} ~ {thread}:OnWait for {time}",
                ManagedInstance, GetType(), _directive.WaitTime);

            _waitingCancellationTokenSource = new CancellationTokenSource();
            // _waitingCancellationTokenSource.CancelAfter(_directive.WaitTime + TimeSpan.FromSeconds(1));

            // @todo Reactivate WaitingCancellationToken token
            try
            {
                await Task.Delay(_directive.WaitTime, WaitingCancellationToken);
            }
            catch (TaskCanceledException)
            {
            }

            Cleanup();

            StateMachine.Fire(Trigger.Finish);
        }

        protected virtual void OnFetch()
        {
            // @todo If not IsEnabled, the thread should not even be fired, need to look at this, for now just dont fire the EventArgs
            if (_directive.IsEnabled)
            {
                Log.Logger.Debug(
                    "{instance} ~ {thread}:OnFetch executed with result {@result}",
                    ManagedInstance, GetType(), EventArgs);

                OnExecuted(EventArgs);
            }

            StateMachine.Fire(Trigger.Finish);
        }

        protected void Start()
        {
            Cleanup();

            StateMachine.Fire(Trigger.Start);
        }

        protected void Stop()
        {
            Cleanup();

            StateMachine.Fire(Trigger.Stop);
        }

        protected void Finish()
        {
            StateMachine.Fire(Trigger.Finish);
        }

        protected virtual void OnExecuted(T e)
        {
            var handler = Executed;
            if (handler != null) handler(this, e);
        }

        #endregion
    }
}