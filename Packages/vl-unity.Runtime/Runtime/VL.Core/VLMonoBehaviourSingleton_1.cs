namespace VL.Core
{
    using global::UnityEngine;

    public class VLMonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected static T _instance;
        public static bool HasInstance
        {
            get
            {
                return _instance != null;
            }
        }

        public static T Instance
        {
            get
            {
                UpdateInstance();
                return _instance;
            }
        }

        protected virtual void OnEnable()
        {
            if (_instance != null && _instance != this && FindObjectsOfType<T>().Length > 1)
            {
                DestroyImmediate(gameObject);
                return;
            }
            _instance = GetComponent<T>();
        }

        protected virtual void OnDestroy()
        {
            if (_instance == this) _instance = null;
        }

        private static void UpdateInstance()
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                if (_instance == null)
                {
                    var go = new GameObject(typeof(T).Name) { hideFlags = (HideFlags)52 };
                    _instance = go.AddComponent(typeof(T)) as T;
                    Debug.LogFormat("Create Instance");
                }
            }
        }

        public VLMonoBehaviourSingleton()
        {
        }
    }
}
