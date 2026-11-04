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
            useLimit = (byte)(info.useLimit > 0 ? 1 : 0);
            negative = new float3(info.axisX.x, info.axisY.x, info.axisZ.x);
            positive = new float3(info.axisX.y, info.axisY.y, info.axisZ.y);
        }
    }
}
