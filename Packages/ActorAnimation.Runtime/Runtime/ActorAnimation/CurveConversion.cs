namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Collections;
    using global::UnityEngine;

    public static class CurveConversion
    {
        public static NativeArray<KeyframeData> CurveToKeyframes(AnimationCurve curve, Allocator allocator = Allocator.Temp)
        {
            int count = curve.length;
            var keys = new NativeArray<KeyframeData>(count, allocator);
            for (int i = 0; i < count; i++) keys[i] = KeyframeConversion(curve[i]);
            return keys;
        }

        private static KeyframeData KeyframeConversion(Keyframe key)
        {
            return new KeyframeData
            {
                time = key.time,
                value = key.value,
                inTangent = key.inTangent,
                outTangent = key.outTangent,
                inWeight = key.weightedMode == WeightedMode.In || key.weightedMode == WeightedMode.Both ? key.inWeight : 1f / 3f,
                outWeight = key.weightedMode == WeightedMode.Out || key.weightedMode == WeightedMode.Both ? key.outWeight : 1f / 3f
            };
        }
    }
}
