using System;

namespace SyncthingCore.Exceptions
{
    public class ManagedInstanceConfigurationException : Exception
    {
        public ManagedInstanceConfigurationException()
        {
        }

        public ManagedInstanceConfigurationException(string message) : base(message)
        {
        }

        public ManagedInstanceConfigurationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}