using System;

namespace SyncthingCore.Exceptions
{
    public class ManagedInstanceConnectionException : Exception
    {
        public ManagedInstanceConnectionException()
        {
        }

        public ManagedInstanceConnectionException(string message) : base(message)
        {
        }

        public ManagedInstanceConnectionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}