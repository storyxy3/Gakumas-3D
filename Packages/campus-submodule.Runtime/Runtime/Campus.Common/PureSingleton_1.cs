namespace Campus.Common
{
    using global::Campus.Common;

    public class PureSingleton<T>
        where T : PureSingleton<T>, new()
    {
        protected static T _instance;
        public static T Instance
        {
            get
            {
                return null;
            }
        }

        public static bool HasInstance
        {
            get
            {
                return default(bool);
            }
        }

        protected virtual void Initialize()
        {
        }

        public static void ClearInstance()
        {
        }

        public PureSingleton()
        {
        }
    }
}
