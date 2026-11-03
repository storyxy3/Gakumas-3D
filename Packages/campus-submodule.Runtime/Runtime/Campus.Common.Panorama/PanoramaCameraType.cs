namespace Campus.Common.Panorama
{
    using global::UnityEngine;

    public enum PanoramaCameraType
    {
        [InspectorName("オートカメラ")]
        UnDefined = -1,
        [InspectorName("フォーカスカメラ")]
        Focus,
        [InspectorName("クレーンカメラ")]
        Crane,
        [InspectorName("ドローンカメラ")]
        Drone,
        [InspectorName("ステージカメラ")]
        Stage
    }
}
