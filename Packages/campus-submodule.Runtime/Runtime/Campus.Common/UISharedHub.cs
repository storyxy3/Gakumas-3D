namespace Campus.Common
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    [ExecuteAlways]
    public class UISharedHub : QuaUIBehaviour
    {
        [CompilerGenerated]
        private bool _003CSkipSetBlendMode_003Ek__BackingField;
        [CompilerGenerated]
        private Action m_onTransformChanged;
        public bool SkipSetBlendMode
        {
            [CompilerGenerated]
            get
            {
                return _003CSkipSetBlendMode_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CSkipSetBlendMode_003Ek__BackingField = value;
            }
        }

        public event Action onTransformChanged
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        protected override void Awake()
        {
        }

        private void LateUpdate()
        {
        }

        private void CheckTransformChanged()
        {
        }

        protected override void OnDestroy()
        {
        }

        public UISharedHub()
        {
        }
    }
}
