namespace Titan
{
    using global::UnityEngine;

    public enum MarkerExecutionType
    {
        [InspectorName("通常（シークで実行しない）")]
        Callback,
        [InspectorName("シークでも実行")]
        Tween,
        [InspectorName("シークでも実行（前向きのみ）")]
        ForwardTween,
        [InspectorName("シークでも実行（後ろ向きのみ）")]
        BackwardsTween
    }
}
