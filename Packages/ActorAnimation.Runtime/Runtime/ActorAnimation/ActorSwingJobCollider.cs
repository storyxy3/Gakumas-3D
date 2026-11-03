namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;

    [Serializable]
    public struct ActorSwingJobCollider
    {
        public byte active;
        public ActorSwingColliderType type;
        public ActorSwingJobCollisionMask collisionMask;
        public ActorSwingJobCollisionMask seatDynamicCorrectionDisableCollisionMask;
        public float3 fastHitPosition;
        public float fastHitRadius;
        public float3 float3_A;
        public float3 float3_B;
        public float float_A;
        public float float_B;
        public float3 position;
        public float3 subPosition;
        public float scale;
    }
}
