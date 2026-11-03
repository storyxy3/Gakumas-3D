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

    public abstract class QuaScreenPresenterBase<TView, TTransitionParam> : ScreenPresenterBase, IQuaScreenPresenter where TView : ScreenViewBase where TTransitionParam : TransitionParam
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeBaseAsync_003Ed__2 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public QuaScreenPresenterBase<TView, TTransitionParam> _003C_003E4__this;
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

        [SerializeField]
        protected TView _view;
        private CancellationTokenSource _nonBlockMethodCts;
        [AsyncStateMachine(typeof(QuaScreenPresenterBase<, >._003CInitializeBaseAsync_003Ed__2))]
        public override UniTask InitializeBaseAsync(TransitionParam param, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected abstract UniTask InitializeAsync(TTransitionParam param, CancellationToken ct);
        public virtual void RecursiveBack()
        {
        }

        public ScreenPresenterBase GetBehindScreen()
        {
            return null;
        }

        public override void OnEndOpenIn(TransitionInfo info)
        {
        }

        public override void OnEndCloseIn(TransitionInfo info)
        {
        }

        public override UniTask OnOpenOutAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public override UniTask OnCloseOutAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask NonBlockOpenInAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask NonBlockCloseInAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        private CancellationToken GetNonBlockCt()
        {
            return default(CancellationToken);
        }

        private void CancelNonBlockMethodCts()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected QuaScreenPresenterBase()
        {
        }

        [CompilerGenerated]
        [DebuggerHidden]
        private UniTask _003C_003En__0(TransitionParam param, CancellationToken ct)
        {
            return default(UniTask);
        }
    }
}
