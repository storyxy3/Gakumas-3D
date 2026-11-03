namespace Qua.UI
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;

    public class TabPageBase : QuaUIBehaviour
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CCloseAsync_003Ed__6 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TabPageBase _003C_003E4__this;
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
        private struct _003COpenAsync_003Ed__4 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TabPageBase _003C_003E4__this;
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

        [CompilerGenerated]
        private bool _003CIsOpen_003Ek__BackingField;
        public virtual bool IsOpen
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            protected set
            {
            }
        }

        [AsyncStateMachine(typeof(_003COpenAsync_003Ed__4))]
        public UniTask OpenAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask OnOpenAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CCloseAsync_003Ed__6))]
        public UniTask CloseAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask OnCloseAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public TabPageBase()
        {
        }
    }
}
