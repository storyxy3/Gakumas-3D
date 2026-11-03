namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;

    [Serializable]
    public struct ActorSwingJobChainBone
    {
        public ActorSwingJobCollider collider;
        public CollisionInfo collision;
        public int dynamicBoneIndex;
        public int chainOffsetIndex;
        public int depth;
        public float smoothing;
        public bool around;
        public float initialLoopLength;
    }
}
