namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;

    public abstract class CriMonoBehaviour : MonoBehaviour
    {
        [CompilerGenerated]
        private Guid _003Cguid_003Ek__BackingField;
        public Guid guid
        {
            [CompilerGenerated]
            get
            {
                return default(Guid);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public CriMonoBehaviour()
        {
        }

        protected virtual void OnEnable()
        {
        }

        protected virtual void OnDisable()
        {
        }

        public abstract void CriInternalUpdate();
        public abstract void CriInternalLateUpdate();
    }
}
