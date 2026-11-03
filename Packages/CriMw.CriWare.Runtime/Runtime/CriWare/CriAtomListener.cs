namespace CriWare
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::CriWare;
    using global::UnityEngine;

    [AddComponentMenu("CRIWARE/CRI Atom Listener")]
    public class CriAtomListener : CriMonoBehaviour
    {
        [CompilerGenerated]
        private CriAtomEx3dListener _003CnativeListener_003Ek__BackingField;
        [SerializeField]
        private CriAtomRegion regionOnStart;
        public bool activateListenerOnEnable;
        private static List<CriAtomListener> listenersList;
        private static CriAtomListener exclusiveListener;
        private static CriAtomEx3dListener dummyNativeListener;
        private Vector3 lastPosition;
        private CriAtomRegion currentRegion;
        private bool _isActive;
        public CriAtomEx3dListener nativeListener
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            protected set
            {
            }
        }

        public bool isActive
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public CriAtomRegion region3d
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        internal static CriAtomEx3dListener DummyNativeListener
        {
            get
            {
                return null;
            }
        }

        public static void CreateDummyNativeListener()
        {
        }

        public static void DestroyDummyNativeListener()
        {
        }

        private void Awake()
        {
        }

        private void Start()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        private void OnDestroy()
        {
        }

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        private void UpdatePosition()
        {
        }

        public void ActivateListener(bool exclusive = true)
        {
        }

        public CriAtomListener()
        {
        }
    }
}
