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
    using global::UnityEngine;

    public class InfiniteSnapListPresenterBase<TView, TCellPresenter, TItemModel> : InfiniteListPresenterBase<TView, TCellPresenter, TItemModel> where TView : InfiniteSnapListViewBase where TCellPresenter : ListCellPresenterBase<TItemModel>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeAsync_003Ed__10 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public InfiniteSnapListPresenterBase<TView, TCellPresenter, TItemModel> _003C_003E4__this;
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
        protected ListEnum.CellPositionType _fixPositionType;
        protected SnapToCell _snapToCell;
        private int? _snapTargetIndex;
        public Action<int> onSnap;
        public Action<int> onSnapFinished;
        public Action<int> onNearestIndexChange;
        public SnapToCell SnapToCell
        {
            get
            {
                return null;
            }
        }

        public int SnappedIndex
        {
            get
            {
                return default(int);
            }
        }

        [AsyncStateMachine(typeof(InfiniteSnapListPresenterBase<,, >._003CInitializeAsync_003Ed__10))]
        public override UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public override void SetItemModels(List<TItemModel> itemModels)
        {
        }

        public void SetItemModels(List<TItemModel> itemModels, int snapIndex)
        {
        }

        protected override void UpdateContentAreaSize()
        {
        }

        protected override void CheckCellsReuse()
        {
        }

        protected virtual SnapToCell AddSnapToCell(GameObject targetGameObject)
        {
            return null;
        }

        public override void SetScrollable(bool isScrollable)
        {
        }

        public InfiniteSnapListPresenterBase()
        {
        }
    }
}
