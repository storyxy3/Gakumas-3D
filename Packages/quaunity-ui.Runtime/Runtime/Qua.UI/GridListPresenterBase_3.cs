namespace Qua.UI
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Qua.UI;

    public class GridListPresenterBase<TView, TCellPresenter, TItemModel> : ListPresenterBase<TView, TCellPresenter, TItemModel> where TView : GridListViewBase where TCellPresenter : ListCellPresenterBase<TItemModel>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass2_0
        {
            public GridListPresenterBase<TView, TCellPresenter, TItemModel> _003C_003E4__this;
            public bool hasNext;
            public _003C_003Ec__DisplayClass2_0()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003CGetSortedTargetCellTable_003Ed__2 : IEnumerable<IEnumerable<TCellPresenter>>, IEnumerable, IEnumerator<IEnumerable<TCellPresenter>>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private IEnumerable<TCellPresenter> _003C_003E2__current;
            private int _003C_003El__initialThreadId;
            public GridListPresenterBase<TView, TCellPresenter, TItemModel> _003C_003E4__this;
            private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;
            private IEnumerator<TCellPresenter> _003Cenumerator_003E5__2;
            IEnumerable<TCellPresenter> System.Collections.Generic.IEnumerator<System.Collections.Generic.IEnumerable<TCellPresenter>>.Current
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
            public _003CGetSortedTargetCellTable_003Ed__2(int _003C_003E1__state)
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

            private void _003C_003Em__Finally1()
            {
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }

            [DebuggerHidden]
            IEnumerator<IEnumerable<TCellPresenter>> System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<TCellPresenter>>.GetEnumerator()
            {
                return null;
            }

            [DebuggerHidden]
            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }
        }

        public override UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual float GetOtherCellSize(int index)
        {
            return default(float);
        }

        [IteratorStateMachine(typeof(GridListPresenterBase<,, >._003CGetSortedTargetCellTable_003Ed__2))]
        public IEnumerable<IEnumerable<TCellPresenter>> GetSortedTargetCellTable()
        {
            return null;
        }

        public GridListPresenterBase()
        {
        }
    }
}
