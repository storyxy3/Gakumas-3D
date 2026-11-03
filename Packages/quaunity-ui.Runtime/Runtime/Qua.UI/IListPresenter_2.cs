namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Qua.UI;

    public interface IListPresenter<TCellPresenter, TItemModel> : IListPresenter<TItemModel>, IListPresenter
    {
        List<TCellPresenter> Cells { get; }

        List<TCellPresenter> AllCells { get; }

        void UpdateItemModel(TCellPresenter cell, TItemModel itemModel);
        TCellPresenter GetCellFromIndex(int index);
        void InternalSetItemModels(List<TItemModel> itemModels, Func<int, TItemModel, TCellPresenter> getReusableCell);
    }
}
