namespace MetroThing.Types
{
    public class Singleton<T> where T : class, new()
    {
        private Singleton()
        {
        }

        public static T Instance
        {
            get { return SingletonCreator.instance; }
        }

        private class SingletonCreator
        {
            internal static readonly T instance = new T();

            static SingletonCreator()
            {
            }
        }
    }
}