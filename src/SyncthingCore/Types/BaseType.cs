namespace SyncthingCore.Types
{
    public abstract class BaseType : PropertyChangedType, IBaseType
    {
        public abstract void Clear();

        #region Managed Instance

        private ManagedInstance _instance;

        protected BaseType(ManagedInstance instance)
        {
            _instance = instance;
        }

        #endregion
    }
}