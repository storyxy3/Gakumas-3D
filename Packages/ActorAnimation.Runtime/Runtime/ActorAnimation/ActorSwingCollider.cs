namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::UnityEngine;

    [Serializable]
    public class ActorSwingCollider
    {
        public ActorSwingColliderType type;
        public ActorSwingJobCollisionMask collisionMask;
        public Vector3 vector3_A;
        public Vector3 vector3_B;
        public float float_A;
        public float float_B;
        public ActorSwingCollider()
        {
        }
    }
}
