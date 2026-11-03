namespace Campus.Timeline
{
    using global::UnityEngine;

    public enum LookAtProhibitType
    {
        [InspectorName("なし")]
        None,
        [InspectorName("振り向き禁止")]
        Prohibit,
        [InspectorName("振り向き有効不可")]
        ProhibitLookAtEnable
    }
}
