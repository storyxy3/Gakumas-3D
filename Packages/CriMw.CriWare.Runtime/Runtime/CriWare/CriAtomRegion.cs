namespace CriWare
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::CriWare;
    using global::UnityEngine;

    [AddComponentMenu("CRIWARE/CRI Atom Region")]
    [DisallowMultipleComponent]
    public class CriAtomRegion : CriMonoBehaviour
    {
        [CompilerGenerated]
        private CriAtomEx3dRegion _003Cregion3dHn_003Ek__BackingField;
        internal List<CriAtomSourceBase> referringSources;
        internal List<CriAtomListener> referringListeners;
        internal List<CriAtomTransceiver> referringTransceivers;
        public CriAtomEx3dRegion region3dHn
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

        private void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        private void OnDestroy()
        {
        }

        protected virtual void InternalInitialize()
        {
        }

        protected virtual void InternalFinalize()
        {
        }

        protected virtual void InitializeParameters()
        {
        }

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        public CriAtomRegion()
        {
        }
    }
}
