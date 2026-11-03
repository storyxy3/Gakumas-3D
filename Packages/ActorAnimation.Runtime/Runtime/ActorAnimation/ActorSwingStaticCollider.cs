namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;

    [Serializable]
    public class ActorSwingStaticCollider : ActorSwingCollider
    {
        public ActorSwingJobCollisionMask seatDynamicCorrectionDisableCollisionMask;
        public ActorSwingStaticCollider()
        {
        }
    }
}
