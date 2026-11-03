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

    public class SnapListPresenterBase<TView, TCellPresenter, TItemModel> : ListPresenterBase<TView, TCellPresenter, TItemModel> where TView : SnapListViewBase where TCellPresenter : ListCellPresenterBase<TItemModel>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeAsync_003Ed__9 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public SnapListPresenterBase<TView, TCellPresenter, TItemModel> _003C_003E4__this;
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

        [AsyncStateMachine(typeof(SnapListPresenterBase<,, >._003CInitializeAsync_003Ed__9))]
        public override UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual SnapToCell AddSnapToCell(GameObject targetGameObject)
        {
            return null;
        }

        protected override void UpdateContentAreaSize()
        {
        }

        public override void SetScrollable(bool isScrollable)
        {
        }

        protected override void InternalSetItemModels(List<TItemModel> itemModels, [Optional] Func<int, TItemModel, TCellPresenter> getReusableCell)
        {
        }

        public SnapListPresenterBase()
        {
        }

        [CompilerGenerated]
        private void _003CInitializeAsync_003Eb__9_1(int index)
        {
        }

        [CompilerGenerated]
        private void _003CInitializeAsync_003Eb__9_2()
        {
        }

        [CompilerGenerated]
        private void _003CInitializeAsync_003Eb__9_3(int index)
        {
        }

        [CompilerGenerated]
        private void _003CInitializeAsync_003Eb__9_0(Vector2 _)
        {
        }

        [CompilerGenerated]
        [DebuggerHidden]
        private UniTask _003C_003En__0(CancellationToken ct)
        {
            return default(UniTask);
        }
    }
}
