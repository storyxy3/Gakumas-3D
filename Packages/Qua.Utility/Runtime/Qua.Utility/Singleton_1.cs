namespace Qua.Utility
{
    using global::Qua.Utility;
    using global::UnityEngine;

    public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                return null;
            }
        }

        public static bool ExistInstance
        {
            get
            {
                return default(bool);
            }
        }

        protected void Awake()
        {
        }

        protected void OnDestroy()
        {
        }

        protected void OnApplicationQuit()
        {
        }

        public static void CreateInstance()
        {
        }

        private static void Initialize(T instance)
        {
        }

        private static void MoveInstance(T instance)
        {
        }

        private static void Finalize(T instance)
        {
        }

        protected virtual void OnInitialize()
        {
        }

        protected virtual void OnFinalize()
        {
        }

        public static void DestroyInstance()
        {
        }

        protected virtual bool IsDontDestroy()
        {
            return default(bool);
        }

        protected virtual string GetCategory()
        {
            return null;
        }

        protected Singleton()
        {
        }
    }
}
