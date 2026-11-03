namespace Qua.UI
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;

    public abstract class QuaParentPresenterBase : WindowPresenterBase, IQuaParentPresenter
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CApplyTransitionAsync_003Ed__4 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public QuaParentPresenterBase _003C_003E4__this;
            public TransitionInfo info;
            public CancellationToken ct;
            private bool _003CshouldBlocking_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public virtual void RecursiveBack()
        {
        }

        public virtual ScreenPresenterBase GetBehindScreen()
        {
            return null;
        }

        protected virtual void ShowDisplayBlocking()
        {
        }

        protected virtual void HideDisplayBlocking()
        {
        }

        [AsyncStateMachine(typeof(_003CApplyTransitionAsync_003Ed__4))]
        protected override UniTask ApplyTransitionAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected override void OnNodeWillChange()
        {
        }

        protected override void OnNodeDidChange()
        {
        }

        protected QuaParentPresenterBase()
        {
        }
    }
}
