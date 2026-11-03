namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::Qua.UI;

    public interface IListPresenter<TItemModel> : IListPresenter
    {
        List<TItemModel> ItemModels { get; }

        void SetItemModels(List<TItemModel> itemModels);
        void UpdateItemModel(int index, TItemModel itemModel);
    }
}
