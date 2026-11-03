namespace Qua.UI
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;
    using global::Qua.Utility;
    using global::UnityEngine;

    public class ListPresenterBase<TView, TCellPresenter, TItemModel> : QuaUIBehaviour, IListPresenter<TCellPresenter, TItemModel>, IListPresenter<TItemModel>, IListPresenter where TView : ListViewBase where TCellPresenter : ListCellPresenterBase<TItemModel>
    {
        [CompilerGenerated]
        private sealed class _003CGetSortedTargetCells_003Ed__51 : IEnumerable<TCellPresenter>, IEnumerable, IEnumerator<TCellPresenter>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private TCellPresenter _003C_003E2__current;
            private int _003C_003El__initialThreadId;
            public ListPresenterBase<TView, TCellPresenter, TItemModel> _003C_003E4__this;
            private int _003Cend_003E5__2;
            private int _003Ci_003E5__3;
            TCellPresenter System.Collections.Generic.IEnumerator<TCellPresenter>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CGetSortedTargetCells_003Ed__51(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }

            [DebuggerHidden]
            IEnumerator<TCellPresenter> System.Collections.Generic.IEnumerable<TCellPresenter>.GetEnumerator()
            {
                return null;
            }

            [DebuggerHidden]
            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeAsync_003Ed__39 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public ListPresenterBase<TView, TCellPresenter, TItemModel> _003C_003E4__this;
            public CancellationToken ct;
            private ListPool<Transform>.ListContainer _003ClastChildList_003E5__2;
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
        protected List<TCellPresenter> _cells;
        protected List<TCellPresenter> _allCells;
        protected List<TItemModel> _itemModels;
        [SerializeField]
        protected TCellPresenter _cellPrefab;
        private int _currentStartIndex;
        private int _currentEndIndex;
        private int _indexOfStartCell;
        private int _indexOfEndCell;
        [CompilerGenerated]
        private int _003CMaxCellCountForInitialize_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CEnableCellOrderSorting_003Ek__BackingField;
        private HashSet<TCellPresenter> _cellSet;
        private List<TCellPresenter> _cellsBuffer;
        [CompilerGenerated]
        private int _003CFirstCellSiblingIndex_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CLastCellSiblingIndex_003Ek__BackingField;
        public IListView View
        {
            get
            {
                return null;
            }
        }

        public List<TCellPresenter> Cells
        {
            get
            {
                return null;
            }
        }

        public int CellCount
        {
            get
            {
                return default(int);
            }
        }

        public List<TCellPresenter> AllCells
        {
            get
            {
                return null;
            }
        }

        public List<TItemModel> ItemModels
        {
            get
            {
                return null;
            }
        }

        public int ItemCount
        {
            get
            {
                return default(int);
            }
        }

        public int MaxCellCountForInitialize
        {
            [CompilerGenerated]
            private get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool EnableCellOrderSorting
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        protected virtual int FirstCellSiblingIndex
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        protected virtual int LastCellSiblingIndex
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        [AsyncStateMachine(typeof(ListPresenterBase<,, >._003CInitializeAsync_003Ed__39))]
        public virtual UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual void SetItemModels(List<TItemModel> itemModels)
        {
        }

        public void SetItemModelsWithoutClamp(List<TItemModel> itemModels)
        {
        }

        protected virtual void InternalSetItemModels(List<TItemModel> itemModels, [Optional] Func<int, TItemModel, TCellPresenter> getReusableCell)
        {
        }

        void Qua.UI.IListPresenter<TCellPresenter, TItemModel>.InternalSetItemModels(List<TItemModel> itemModels, Func<int, TItemModel, TCellPresenter> getReusableCell)
        {
        }

        protected void AssignCellPresentersWithReuse(int indexOffset, int count, Func<int, TItemModel, TCellPresenter> getReusableCell)
        {
        }

        protected virtual void UpdateContentAreaSize()
        {
        }

        protected void AssignCells(int indexOffset)
        {
        }

        public virtual void UpdateCells()
        {
        }

        public void UpdateItemModel(TCellPresenter cell, TItemModel itemModel)
        {
        }

        public void UpdateItemModel(int index, TItemModel itemModel)
        {
        }

        protected virtual void CheckCellsReuse()
        {
        }

        [IteratorStateMachine(typeof(ListPresenterBase<,, >._003CGetSortedTargetCells_003Ed__51))]
        public IEnumerable<TCellPresenter> GetSortedTargetCells()
        {
            return null;
        }

        public TCellPresenter GetCellFromIndex(int index)
        {
            return null;
        }

        public virtual float GetCellSize(int index)
        {
            return default(float);
        }

        private void AssignCellIndexAndSetSiblingPosition(TCellPresenter cell, int index, bool insertFirst)
        {
        }

        protected virtual void AssignCellIndex(TCellPresenter cell, int index)
        {
        }

        protected virtual void SetSiblingPosition(TCellPresenter cell, bool isFirst)
        {
        }

        protected virtual TItemModel GetItem(int index)
        {
            return default(TItemModel);
        }

        protected virtual void SetItem(int index, TItemModel item)
        {
        }

        public void MoveScrollByHeadIndex(int centerIndex)
        {
        }

        public int GetNearestIndex(ListEnum.CellPositionType positionType)
        {
            return default(int);
        }

        protected virtual void OnRectChanged()
        {
        }

        public virtual void SetScrollable(bool isScrollable)
        {
        }

        public ListPresenterBase()
        {
        }

        [CompilerGenerated]
        private float _003CInitializeAsync_003Eb__39_0(int index)
        {
            return default(float);
        }

        [CompilerGenerated]
        private int _003CInitializeAsync_003Eb__39_1()
        {
            return default(int);
        }

        [CompilerGenerated]
        private void _003CInitializeAsync_003Eb__39_2(Vector2 position)
        {
        }

        [CompilerGenerated]
        private void _003CInitializeAsync_003Eb__39_3()
        {
        }
    }
}
