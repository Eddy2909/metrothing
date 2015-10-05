using System;

namespace SyncthingCore.Worker
{
    public class BaseWorkerEventArgs : EventArgs
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class BaseWorkerEventArgs<T> : BaseWorkerEventArgs
    {
        public T Response { get; set; }
    }
}