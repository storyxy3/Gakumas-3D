namespace Qua.UI
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Qua.UI;

    public abstract class ListCellPresenterBase<TItemModel> : QuaUIBehaviour
    {
        public abstract UniTask SelfInitializeAsync(CancellationToken ct);
        public abstract int GetIndex();
        public abstract void SetData(int index, TItemModel model);
        public abstract void SetItemModel(TItemModel itemModel);
        public abstract TItemModel GetItemModel();
        protected ListCellPresenterBase()
        {
        }
    }
}
