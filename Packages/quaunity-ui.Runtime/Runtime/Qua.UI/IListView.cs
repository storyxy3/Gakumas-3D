namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;

    public interface IListView
    {
        QuaScrollRect ScrollView { get; }

        float CellSize { get; }

        ListEnum.DirectionType DirectionType { get; }

        void MoveScrollToFixPosition(ListEnum.CellPositionType positionType, int index);
        Vector3 GetPositionFromFixPosition(ListEnum.CellPositionType positionType, int index);
        void ClampScrollPosition();
        Vector3 GetCellCenter(int index);
    }
}
