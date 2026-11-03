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
                return default(bool);
            }
        }

        public static T Instance
        {
            get
            {
                return null;
            }
        }

        protected virtual void OnEnable()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        private static void UpdateInstance()
        {
        }

        public VLMonoBehaviourSingleton()
        {
        }
    }
}
