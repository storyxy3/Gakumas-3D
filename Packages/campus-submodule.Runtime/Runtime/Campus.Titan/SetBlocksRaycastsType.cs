namespace Campus.Titan
{
    using global::UnityEngine;

    public enum SetBlocksRaycastsType
    {
        [InspectorName("通常 (UI表示時、開始。非表示時、終了）")]
        Auto,
        [InspectorName("開始")]
        Start,
        [InspectorName("終了")]
        Complete
    }
}
