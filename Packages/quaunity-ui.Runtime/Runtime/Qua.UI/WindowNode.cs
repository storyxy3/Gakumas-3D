namespace Qua.UI
{
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Qua.UI;

    public abstract class WindowNode : QuaUIBehaviour
    {
        public enum WindowNodeType
        {
            Window,
            Screen
        }

        [CompilerGenerated]
        private IWindowNodeState _003CBaseState_003Ek__BackingField;
        [CompilerGenerated]
        private WindowPresenterBase _003CParent_003Ek__BackingField;
        [CompilerGenerated]
        private WindowPresenterBase _003CRoot_003Ek__BackingField;
        [CompilerGenerated]
        private readonly bool _003CCanPool_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsInitialized_003Ek__BackingField;
        public abstract WindowNodeType NodeType { get; }

        public IWindowNodeState BaseState
        {
            [CompilerGenerated]
            get
            {
                return _003CBaseState_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CBaseState_003Ek__BackingField = value;
            }
        }

        public WindowPresenterBase Parent
        {
            [CompilerGenerated]
            get
            {
                return _003CParent_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CParent_003Ek__BackingField = value;
            }
        }

        public WindowPresenterBase Root
        {
            [CompilerGenerated]
            get
            {
                return _003CRoot_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CRoot_003Ek__BackingField = value;
            }
        }

        public abstract ScreenPresenterBase TopScreen { get; }

        public virtual bool CanPool
        {
            [CompilerGenerated]
            get
            {
                return _003CCanPool_003Ek__BackingField;
            }
        }

        internal bool IsInitialized
        {
            [CompilerGenerated]
            get
            {
                return _003CIsInitialized_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CIsInitialized_003Ek__BackingField = value;
            }
        }

        public virtual UniTask OnPreparePoolAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual UniTask InitializeBaseAsync(TransitionParam param, CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual UniTask OnGetFromPoolAsync(TransitionParam param, CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual void OnAddToPool()
        {
        }

        internal void SetState(IWindowNodeState state)
        {
        }

        internal void SetParent(WindowNode parent)
        {
        }

        public virtual UniTask OnOpenInAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual UniTask OnOpenOutAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual UniTask OnBehindOpenAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual UniTask OnCloseInAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual UniTask OnCloseOutAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual UniTask OnBehindCloseAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual void OnEndOpenIn(TransitionInfo info)
        {
        }

        public virtual void OnEndCloseIn(TransitionInfo info)
        {
        }

        public void Move(TransitionTree tree, [Optional] TransitionOptionalData optionalData)
        {
        }

        public void Back([Optional] TransitionOptionalData optionalData)
        {
        }

        protected CancellationToken GetCt()
        {
            return default(CancellationToken);
        }

        protected WindowNode()
        {
        }
    }
}
