namespace CriWare
{
    using global::System.Collections.Generic;
    using global::CriWare;
    using global::UnityEngine;

    public class CriMonoBehaviourManager : MonoBehaviour
    {
        private static CriMonoBehaviourManager _instance;
        private static List<CriMonoBehaviour> criMonoBehaviourList;
        public static CriMonoBehaviourManager instance
        {
            get
            {
                return null;
            }
        }

        public static void CreateInstance()
        {
        }

        private static int GetIndex(CriMonoBehaviour criMonoBehaviour)
        {
            return default(int);
        }

        public bool Register(CriMonoBehaviour criMonoBehaviour)
        {
            return default(bool);
        }

        public static bool UnRegister(CriMonoBehaviour criMonoBehaviour)
        {
            return default(bool);
        }

        private void Awake()
        {
        }

        private void Update()
        {
        }

        private void LateUpdate()
        {
        }

        public CriMonoBehaviourManager()
        {
        }
    }
}
