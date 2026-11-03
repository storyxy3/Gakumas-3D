namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;

    public class InfiniteListPresenterBase<TView, TCellPresenter, TItemModel> : ListPresenterBase<TView, TCellPresenter, TItemModel> where TView : InfiniteListViewBase where TCellPresenter : ListCellPresenterBase<TItemModel>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeAsync_003Ed__1 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public InfiniteListPresenterBase<TView, TCellPresenter, TItemModel> _003C_003E4__this;
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

        private readonly List<TCellPresenter> _emptyList;
        [AsyncStateMachine(typeof(InfiniteListPresenterBase<,, >._003CInitializeAsync_003Ed__1))]
        public override UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected override void InternalSetItemModels(List<TItemModel> itemModels, [Optional] Func<int, TItemModel, TCellPresenter> getReusableCell)
        {
        }

        protected override TItemModel GetItem(int index)
        {
            return default(TItemModel);
        }

        protected override void SetItem(int index, TItemModel item)
        {
        }

        public int GetRealIndex(int index)
        {
            return default(int);
        }

        public InfiniteListPresenterBase()
        {
        }
    }
}
