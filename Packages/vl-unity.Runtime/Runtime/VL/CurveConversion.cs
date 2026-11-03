namespace VL
{
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::VL;

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
