using System.Collections.Generic;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriAtomListener (TypeDefIndex 31667; 0x66a66b4..0x66a84d4).
    [AddComponentMenu("CRIWARE/CRI Atom Listener")]
    public class CriAtomListener : CriMonoBehaviour
    {
        [SerializeField] private CriAtomRegion regionOnStart;
        public bool activateListenerOnEnable;
        private static List<CriAtomListener> listenersList = new List<CriAtomListener>();
        private static CriAtomListener exclusiveListener;
        private static CriAtomEx3dListener dummyNativeListener;
        private Vector3 lastPosition;
        private CriAtomRegion currentRegion;
        private bool _isActive = true;

        public CriAtomEx3dListener nativeListener { get; protected set; }
        internal static CriAtomEx3dListener DummyNativeListener => dummyNativeListener;

        public bool isActive
        {
            get => _isActive;
            set
            {
                if (_isActive == value) return;
                _isActive = value;
                if (value) UpdatePosition();
                else
                {
                    nativeListener.SetPosition(float.MaxValue, float.MaxValue, float.MaxValue);
                    nativeListener.Update();
                }
            }
        }

        public CriAtomRegion region3d
        {
            get => currentRegion;
            set
            {
                if (currentRegion == value) return;
                if (currentRegion != null) currentRegion.referringListeners.Remove(this);
                if (nativeListener == null)
                {
                    Debug.LogError("CriAtomListener native listener is not initialized.");
                    currentRegion = null;
                    return;
                }
                nativeListener.Set3dRegion(value == null ? null : value.region3dHn);
                nativeListener.Update();
                currentRegion = value;
                if (currentRegion != null) currentRegion.referringListeners.Add(this);
            }
        }

        public static void CreateDummyNativeListener()
        {
            if (dummyNativeListener == null) dummyNativeListener = new CriAtomEx3dListener();
        }

        public static void DestroyDummyNativeListener()
        {
            if (dummyNativeListener == null) return;
            dummyNativeListener.Dispose();
            dummyNativeListener = null;
        }

        private void Awake()
        {
            if (!listenersList.Contains(this)) listenersList.Add(this);
            DestroyDummyNativeListener();
            nativeListener = new CriAtomEx3dListener();
            isActive = enabled;
        }

        private void Start()
        {
            if (regionOnStart != null) region3d = regionOnStart;
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            ActivateListener(activateListenerOnEnable);
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            isActive = false;
            if (exclusiveListener == this) exclusiveListener = null;
        }

        private void OnDestroy()
        {
            if (listenersList.Contains(this)) listenersList.Remove(this);
            region3d = null;
            nativeListener.Dispose();
            nativeListener = null;
        }

        public override void CriInternalUpdate() { }

        public override void CriInternalLateUpdate()
        {
            if (_isActive) UpdatePosition();
        }

        private void UpdatePosition()
        {
            Vector3 position = transform.position;
            Vector3 velocity = (position - lastPosition) / Time.deltaTime;
            Vector3 forward = transform.forward;
            Vector3 up = transform.up;
            lastPosition = position;
            if (nativeListener == null) return;
            nativeListener.SetPosition(position.x, position.y, position.z);
            nativeListener.SetVelocity(velocity.x, velocity.y, velocity.z);
            nativeListener.SetOrientation(forward.x, forward.y, forward.z, up.x, up.y, up.z);
            nativeListener.Update();
        }

        public void ActivateListener(bool exclusive = true)
        {
            if (exclusive)
            {
                exclusiveListener = this;
                foreach (CriAtomListener listener in listenersList)
                    if (listener != this) listener.isActive = false;
            }
            isActive = exclusiveListener == null || exclusiveListener == this;
        }
    }
}
