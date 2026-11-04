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
            ColliderRadius = colliderRadius;
            ColliderDampArea = colliderDampArea;
            ColliderPosition = colliderPosition;
            ColliderWeight = colliderWeight;
            Distance = distance;
        }

        public static ActorAnimationIKCorrectionColliderCollisionInfo FromSphereColliderCollision(float colliderRadius, float colliderDampArea, Vector3 colliderPosition, float colliderWeight, Vector3 goalPosition, float goalRadius)
        {
            return new ActorAnimationIKCorrectionColliderCollisionInfo(colliderRadius, colliderDampArea, colliderPosition,
                colliderWeight, Vector3.Distance(goalPosition, colliderPosition) - (colliderRadius + goalRadius));
        }
    }
}
