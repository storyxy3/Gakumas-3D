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

    public abstract class QuaWindowPresenterBase<TView, TTransitionParam> : QuaParentPresenterBase where TView : WindowViewBase where TTransitionParam : TransitionParam
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeBaseAsync_003Ed__1 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public QuaWindowPresenterBase<TView, TTransitionParam> _003C_003E4__this;
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
        [AsyncStateMachine(typeof(QuaWindowPresenterBase<, >._003CInitializeBaseAsync_003Ed__1))]
        public override UniTask InitializeBaseAsync(TransitionParam param, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected abstract UniTask InitializeAsync(TTransitionParam param, CancellationToken ct);
        protected override Transform GetNodeRoot()
        {
            return null;
        }

        protected QuaWindowPresenterBase()
        {
        }
    }
}
