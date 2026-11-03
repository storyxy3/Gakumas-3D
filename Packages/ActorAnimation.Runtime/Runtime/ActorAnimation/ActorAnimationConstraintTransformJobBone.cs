namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationConstraintTransformJobBone : IActorAnimationConstraintJobBone
    {
        private bool _isActive;
        public ActorAnimationConstraintExecuteType executeType;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle constraintSourceHandle0;
        public Vector3Property constraintSourceWeightHandle0;
        public ReadOnlyTransformHandle constraintSourceHandle1;
        public Vector3Property constraintSourceWeightHandle1;
        public ReadOnlyTransformHandle constraintSourceHandle2;
        public Vector3Property constraintSourceWeightHandle2;
        public ReadOnlyTransformHandle constraintSourceHandle3;
        public Vector3Property constraintSourceWeightHandle3;
        public TransformSceneHandle fieldConstraintSourceHandle0;
        public Vector3Property fieldConstraintSourceWeightHandle0;
        public float3 offsetPosition;
        public quaternion offsetRotation;
        public float3 offsetScale;
        public bool IsActive
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsValid(AnimationStream stream)
        {
            return default(bool);
        }

        public bool Resolve(AnimationStream stream)
        {
            return default(bool);
        }

        public void Execute(AnimationStream stream)
        {
        }

        public ActorAnimationConstraintTransformJobBone(ActorAnimationConstraintTransformBone bone, Animator animator)
        {
            this = default;
        }

        public void Update(ActorAnimationConstraintTransformBone bone)
        {
        }

        public void UpdateSource(ActorAnimationConstraintTransformBone bone, Animator animator)
        {
        }
    }
}
