namespace Qua.Global
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.Global;
    using global::TMPro;
    using global::UnityEngine;

    public class QuaGlobalTextMeshProUGUI : TextMeshProUGUI
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CAwake_003Ed__4 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncVoidMethodBuilder _003C_003Et__builder;
            public QuaGlobalTextMeshProUGUI _003C_003E4__this;
            private bool _003C_003E7__wrap1;
            private UniTask<bool>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CChangedDefaultFontId_003Ed__5 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncVoidMethodBuilder _003C_003Et__builder;
            public QuaGlobalTextMeshProUGUI _003C_003E4__this;
            public string fontId;
            private UniTask<bool>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CUpdateFont_003Ed__6 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;
            public string fontId;
            public QuaGlobalTextMeshProUGUI _003C_003E4__this;
            private UniTask<TMP_FontAsset>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [SerializeField]
        protected string _fontId;
        private string _loadedFontId;
        private TMP_FontAsset _loadedFont;
        private bool _isSetupFont;
        [AsyncStateMachine(typeof(_003CAwake_003Ed__4))]
        protected override void Awake()
        {
        }

        [AsyncStateMachine(typeof(_003CChangedDefaultFontId_003Ed__5))]
        private void ChangedDefaultFontId(string fontId)
        {
        }

        [AsyncStateMachine(typeof(_003CUpdateFont_003Ed__6))]
        protected UniTask<bool> UpdateFont(string fontId)
        {
            return default(UniTask<bool>);
        }

        private void UnloadFont()
        {
        }

        protected override void OnDestroy()
        {
        }

        public QuaGlobalTextMeshProUGUI()
        {
        }
    }
}
