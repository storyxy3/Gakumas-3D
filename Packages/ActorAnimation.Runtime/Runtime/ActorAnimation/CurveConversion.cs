namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Collections;
    using global::UnityEngine;

    public static class CurveConversion
    {
        public static NativeArray<KeyframeData> CurveToKeyframes(AnimationCurve curve, Allocator allocator = Allocator.Temp)
        {
            return default(NativeArray<KeyframeData>);
        }

        private static KeyframeData KeyframeConversion(Keyframe key)
        {
            return default(KeyframeData);
        }
    }
}
