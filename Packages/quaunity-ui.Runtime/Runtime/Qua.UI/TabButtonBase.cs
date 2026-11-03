namespace Qua.UI
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;

    public class TabButtonBase : QuaUIBehaviour
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CCloseAsync_003Ed__5 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TabButtonBase _003C_003E4__this;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
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
        private struct _003COpenAsync_003Ed__3 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TabButtonBase _003C_003E4__this;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [SerializeField]
        protected ButtonBase _button;
        public ButtonBase Button
        {
            get
            {
                return null;
            }
        }

        [AsyncStateMachine(typeof(_003COpenAsync_003Ed__3))]
        public UniTask OpenAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask OnOpenAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CCloseAsync_003Ed__5))]
        public UniTask CloseAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask OnCloseAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public TabButtonBase()
        {
        }
    }
}
