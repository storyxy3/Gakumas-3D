namespace Qua.UI
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;

    public abstract class ScreenPresenterBase : WindowNode
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeBaseAsync_003Ed__4 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public ScreenPresenterBase _003C_003E4__this;
            public TransitionParam param;
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

        public sealed override WindowNodeType NodeType
        {
            get
            {
                return default(WindowNodeType);
            }
        }

        public sealed override ScreenPresenterBase TopScreen
        {
            get
            {
                return null;
            }
        }

        [AsyncStateMachine(typeof(_003CInitializeBaseAsync_003Ed__4))]
        public override UniTask InitializeBaseAsync(TransitionParam param, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected ScreenPresenterBase()
        {
        }
    }
}
