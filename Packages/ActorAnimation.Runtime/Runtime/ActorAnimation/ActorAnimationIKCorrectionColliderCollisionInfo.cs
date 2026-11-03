namespace ActorAnimation
{
    using global::System.Runtime.InteropServices;
    using global::ActorAnimation;
    using global::UnityEngine;

    public struct ActorAnimationIKCorrectionColliderCollisionInfo
    {
        public float ColliderRadius;
        public float ColliderDampArea;
        public Vector3 ColliderPosition;
        public float ColliderWeight;
        public float Distance;
        public ActorAnimationIKCorrectionColliderCollisionInfo([global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(-1f)] float colliderRadius, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(-1f)] float colliderDampArea, [Optional] Vector3 colliderPosition, float colliderWeight = 0f, float distance = 3.4028235E+38f)
        {
            this = default;
        }

        public static ActorAnimationIKCorrectionColliderCollisionInfo FromSphereColliderCollision(float colliderRadius, float colliderDampArea, Vector3 colliderPosition, float colliderWeight, Vector3 goalPosition, float goalRadius)
        {
            return default(ActorAnimationIKCorrectionColliderCollisionInfo);
        }
    }
}
