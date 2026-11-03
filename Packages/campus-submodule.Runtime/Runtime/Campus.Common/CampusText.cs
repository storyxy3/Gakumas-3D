namespace Campus.Common
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Campus.Common;
    using global::Campus.Common.TMPro;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.Global;
    using global::TMPro;
    using global::UnityEngine;

    public class CampusText : QuaGlobalTextMeshProUGUI, ITMProTextStyleMask
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CApplyFontIdAsync_003Ed__42 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusText _003C_003E4__this;
            private UniTask<bool>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [SerializeField]
        protected TMProTextStyleType _styleType;
        [SerializeField]
        protected bool _ignoreLineSpacing;
        [SerializeField]
        protected bool _ignoreCharacterSpacing;
        [SerializeField]
        protected bool _isOutlineEnabled;
        [SerializeField]
        protected CampusFontOutlineSetting.OutlineColor _outlineColor;
        [SerializeField]
        protected string _outlineCustomCategory;
        [SerializeField]
        protected string _localizeKey;
        [SerializeField]
        private bool _autoKerningEnabled;
        [SerializeField]
        [Min(0f)]
        private float _autoKerningThreshold;
        [SerializeField]
        [Range(0f, 1f)]
        private float _autoKerningRatio;
        [CompilerGenerated]
        private Action m_onFontSharedMaterialSet;
        public TMProTextStyleType StyleType
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool IgnoreLineSpacing
        {
            get
            {
                return default(bool);
            }
        }

        public bool IgnoreCharacterSpacing
        {
            get
            {
                return default(bool);
            }
        }

        public string LocalizeKey
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override string text
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public event Action onFontSharedMaterialSet
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

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public void SetText(long val)
        {
        }

        public void SetText(int val)
        {
        }

        public void SetTextWithKey(string key)
        {
        }

        public void SetTextWithKey<T0>(string key, T0 v0)
        {
        }

        public void SetTextWithKey<T0, T1>(string key, T0 v0, T1 v1)
        {
        }

        public void SetTextWithKey<T0, T1, T2>(string key, T0 v0, T1 v1, T2 v2)
        {
        }

        public void SetTextWithKey<T0, T1, T2, T3>(string key, T0 v0, T1 v1, T2 v2, T3 v3)
        {
        }

        public void SetTextWithKey(string key, params object[] values)
        {
        }

        private void ApplyStyle()
        {
        }

        private void ApplyLocalize()
        {
        }

        public void SetOutline(bool isOutlineEnabled, CampusFontOutlineSetting.OutlineColor outlineColor, bool forceReset = false)
        {
        }

        public void ApplyOutline(bool forceReset = false)
        {
        }

        public void UpdateFontId(string fontId)
        {
        }

        [AsyncStateMachine(typeof(_003CApplyFontIdAsync_003Ed__42))]
        private UniTask ApplyFontIdAsync()
        {
            return default(UniTask);
        }

        private void AutoTextKerning(TMP_TextInfo textInfo)
        {
        }

        public void ApplyDefaultMaterial()
        {
        }

        public void ApplyDynamicOutlineMaterial()
        {
        }

        protected override void SetSharedMaterial(Material mat)
        {
        }

        protected override void OnDestroy()
        {
        }

        public CampusText()
        {
        }
    }
}
