namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverHairJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle referenceHeadHandle;
        public ReadOnlyTransformHandle referenceNeckHandle;
        public math.RotationOrder translateConnectionAxis;
        public float3 headTranslateCoefficient;
        public float3 headTranslateLimitMin;
        public float3 headTranslateLimitMax;
        public math.RotationOrder rotationOrder;
        public float3 headRotateCoefficient;
        public float3 headRotateLimitMin;
        public float3 headRotateLimitMax;
        public math.RotationOrder rotateConnectionAxis;
        public float3 neckRotateCoefficient;
        public float3 neckRotateLimitMin;
        public float3 neckRotateLimitMax;
        public ActorAnimationQuartzDriverRotationComposeType composeType;
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

        public ActorAnimationQuartzDriverHairJobBone(ActorAnimationQuartzDriverHairSetting setting, Transform transform, Animator animator)
        {
            this = default;
        }

        public void Update(ActorAnimationQuartzDriverHairSetting setting)
        {
        }
    }
}
