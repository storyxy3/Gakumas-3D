namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Collections;

    [Serializable]
    public struct ActorSwingJobBreastBoneCurve : IDisposable
    {
        public AnimationCurveData upCurveData;
        public AnimationCurveData sideCurveData;
        public NativeArray<KeyframeData> upKeyFrames;
        public NativeArray<KeyframeData> sideKeyFrames;
        public void Dispose()
        {
            if (upKeyFrames.IsCreated) upKeyFrames.Dispose();
            if (sideKeyFrames.IsCreated) sideKeyFrames.Dispose();
        }
    }
}
