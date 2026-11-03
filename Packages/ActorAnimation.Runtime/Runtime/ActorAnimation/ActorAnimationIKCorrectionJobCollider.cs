namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations.Rigging;

    public struct ActorAnimationIKCorrectionJobCollider
    {
        public ReadOnlyTransformHandle referenceHandle;
        public ActorAnimationIKCorrectionColliderType type;
        public float weight;
        public float radius;
        public float radiusSub;
        public float length;
        public float dampArea;
        public float3 offset;
        public float3 rotation;
        public ActorAnimationIKCorrectionJobCollider(Animator animator, ActorAnimationIKCorrectionCollider collider)
        {
            this = default;
        }

        public void UpdateProperty(ActorAnimationIKCorrectionCollider collider, Animator animator)
        {
        }
    }
}
