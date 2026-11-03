namespace Qua.UI
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;

    public abstract class QuaScenePresenterBase : QuaParentPresenterBase
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeBaseAsync_003Ed__1 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public QuaScenePresenterBase _003C_003E4__this;
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

        protected override void Start()
        {
        }

        [AsyncStateMachine(typeof(_003CInitializeBaseAsync_003Ed__1))]
        public override UniTask InitializeBaseAsync(TransitionParam param, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected abstract UniTask InitializeAsync(CancellationToken ct);
        public sealed override UniTask OnBehindOpenAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public sealed override UniTask OnOpenInAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public sealed override UniTask OnOpenOutAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public sealed override UniTask OnCloseInAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public sealed override UniTask OnCloseOutAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public sealed override void OnEndOpenIn(TransitionInfo info)
        {
        }

        public sealed override void OnEndCloseIn(TransitionInfo info)
        {
        }

        public virtual void OnTreeWillChange()
        {
        }

        public virtual void OnTreeDidChange()
        {
        }

        protected QuaScenePresenterBase()
        {
        }
    }
}
