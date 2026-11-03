namespace Qua.UI
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Qua.UI;

    public interface IListPresenter
    {
        IListView View { get; }

        int ItemCount { get; }

        int CellCount { get; }

        UniTask InitializeAsync(CancellationToken ct);
        int GetNearestIndex(ListEnum.CellPositionType positionType);
    }
}
