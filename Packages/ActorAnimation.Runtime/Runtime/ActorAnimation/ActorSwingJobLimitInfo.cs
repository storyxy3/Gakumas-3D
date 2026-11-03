namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;

    [Serializable]
    public struct ActorSwingJobLimitInfo
    {
        public byte useLimit;
        public float3 positive;
        public float3 negative;
        public ActorSwingJobLimitInfo(LimitInfo info)
        {
            this = default;
        }
    }
}
