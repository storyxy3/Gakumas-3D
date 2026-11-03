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

    public class ListReusableCellPresenterBase<TCellView, TCellModel, TItemModel> : ListCellPresenterBase<TItemModel> where TCellView : ListReusableCellViewBase where TCellModel : ListReusableCellModelBase<TItemModel>, new()
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSelfInitializeAsync_003Ed__6 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public ListReusableCellPresenterBase<TCellView, TCellModel, TItemModel> _003C_003E4__this;
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
        protected TCellView _view;
        protected TCellModel _model;
        public TCellView View
        {
            get
            {
                return null;
            }
        }

        public TCellModel Model
        {
            get
            {
                return null;
            }
        }

        [AsyncStateMachine(typeof(ListReusableCellPresenterBase<,, >._003CSelfInitializeAsync_003Ed__6))]
        public sealed override UniTask SelfInitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        private void SetBaseEvents()
        {
        }

        public sealed override int GetIndex()
        {
            return default(int);
        }

        public sealed override void SetData(int index, TItemModel model)
        {
        }

        public sealed override void SetItemModel(TItemModel itemModel)
        {
        }

        public sealed override TItemModel GetItemModel()
        {
            return default(TItemModel);
        }

        public ListReusableCellPresenterBase()
        {
        }
    }
}
