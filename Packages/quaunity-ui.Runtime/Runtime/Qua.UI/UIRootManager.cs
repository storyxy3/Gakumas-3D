namespace Qua.UI
{
    using global::Qua.UI;
    using global::Qua.Utility;
    using global::UnityEngine;

    public class UIRootManager : Singleton<UIRootManager>
    {
        [SerializeField]
        private Transform _windowRoot;
        [SerializeField]
        private Transform _dialogRoot;
        [SerializeField]
        private Transform _displayBlockingRoot;
        public static Transform WindowRoot
        {
            get
            {
                return null;
            }
        }

        public static Transform DialogRoot
        {
            get
            {
                return null;
            }
        }

        public static Transform DisplayBlockingRoot
        {
            get
            {
                return null;
            }
        }

        public UIRootManager()
        {
        }
    }
}
