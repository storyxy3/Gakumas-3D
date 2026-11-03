namespace Titan
{
    using global::UnityEngine;

    public enum ParticlePlayType
    {
        [InspectorName("コールバックで実行")]
        Callback,
        [InspectorName("Tweenとして実行")]
        Tween
    }
}
