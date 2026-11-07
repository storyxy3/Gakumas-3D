namespace Qua.UI
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;

    public class GenericTabButtonBase<TTabItem> : TabButtonBase
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeAsync_003Ed__4 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GenericTabButtonBase<TTabItem> _003C_003E4__this;
            public TTabItem item;
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
        private TTabItem _003CTabItem_003Ek__BackingField;
        public virtual TTabItem TabItem
        {
            [CompilerGenerated]
            get
            {
                return _003CTabItem_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CTabItem_003Ek__BackingField = value;
            }
        }

        [AsyncStateMachine(typeof(GenericTabButtonBase<>._003CInitializeAsync_003Ed__4))]
        public UniTask InitializeAsync(TTabItem item, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask OnInitializeAsync(TTabItem item, CancellationToken ct)
        {
            return default(UniTask);
        }

        public GenericTabButtonBase()
        {
        }
    }
}
