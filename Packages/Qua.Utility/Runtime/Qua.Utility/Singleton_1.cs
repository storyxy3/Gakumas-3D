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
                if (_instance == null)
                    CreateInstance();
                return _instance;
            }
        }

        public static bool ExistInstance
        {
            get
            {
                return _instance != null;
            }
        }

        protected void Awake()
        {
            Initialize(this as T);
        }

        protected void OnDestroy()
        {
            Finalize(this as T);
        }

        protected void OnApplicationQuit()
        {
            Finalize(this as T);
        }

        public static void CreateInstance()
        {
            if (_instance != null || QuittingState.IsQuitting)
                return;
            T instance = FindAnyObjectByType<T>();
            if (!(instance != null))
            {
                if (System.Attribute.GetCustomAttribute(typeof(T), typeof(SingletonCreatorAttribute)) is SingletonCreatorAttribute creator)
                {
                    instance = creator.CreateInstance<T>();
                    if (instance == null)
                        return;
                }
                else
                {
                    instance = new GameObject(typeof(T).Name).AddComponent<T>();
                }
            }
            Initialize(instance);
        }

        private static void Initialize(T instance)
        {
            if (_instance == null)
            {
                _instance = instance;
                MoveInstance(instance);
                instance.OnInitialize();
            }
            else if (_instance != instance)
            {
                DestroyImmediate(instance.gameObject);
            }
        }

        private static void MoveInstance(T instance)
        {
            string path;
            if (instance.IsDontDestroy())
            {
                path = "Singleton(DontDestroy)";
                HierarchyUtility.CreateDontDestroyGameObject(path);
            }
            else
            {
                path = "Singleton";
            }
            string category = instance.GetCategory();
            if (!string.IsNullOrEmpty(category))
                path = PathUtility.Combine(path, category);
            Transform parent = HierarchyUtility.FindOrCreateTransform(path);
            instance.transform.SetParent(parent);
        }

        private static void Finalize(T instance)
        {
            if (_instance == instance)
            {
                _instance.OnFinalize();
                _instance = null;
            }
        }

        protected virtual void OnInitialize()
        {
        }

        protected virtual void OnFinalize()
        {
        }

        public static void DestroyInstance()
        {
            if (_instance == null)
                return;
            DestroyImmediate(_instance.gameObject);
            _instance = null;
        }

        protected virtual bool IsDontDestroy()
        {
            return false;
        }

        protected virtual string GetCategory()
        {
            return "";
        }

        protected Singleton()
        {
        }
    }
}
