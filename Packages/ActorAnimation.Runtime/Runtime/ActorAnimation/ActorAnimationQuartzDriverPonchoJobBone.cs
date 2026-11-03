namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverPonchoJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle referenceArmHandle;
        public ReadOnlyTransformHandle referencePonchoOffsetHandle;
        public ReadOnlyTransformHandle referenceArmOffsetHandle;
        public ReadOnlyTransformHandle referenceBodyOffsetHandle;
        public ReadOnlyTransformHandle referenceInnerOffsetHandle;
        public ReadOnlyTransformHandle referenceOuterOffsetHandle;
        public float lerpCoefficient;
        public float innerLimit;
        public float outerLimit;
        public float3 axisWay;
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

        public ActorAnimationQuartzDriverPonchoJobBone(ActorAnimationQuartzDriverPonchoSetting setting, Transform transform, Animator animator)
        {
            this = default;
        }

        public void Update(ActorAnimationQuartzDriverPonchoSetting setting)
        {
        }
    }
}
