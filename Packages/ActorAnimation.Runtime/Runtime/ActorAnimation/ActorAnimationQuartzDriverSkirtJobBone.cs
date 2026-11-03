namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverSkirtJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle referenceHandle;
        public quaternion initialReferenceRotation;
        public math.RotationOrder rotationOrder;
        public float3 innerCoefficient;
        public float3 outerCoefficient;
        public float3 limitMin;
        public float3 limitMax;
        public math.RotationOrder connectionAxis;
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

        public ActorAnimationQuartzDriverSkirtJobBone(ActorAnimationQuartzDriverSkirtSetting setting, Transform transform, Animator animator)
        {
            this = default;
        }

        public void Update(ActorAnimationQuartzDriverSkirtSetting setting)
        {
        }
    }
}
