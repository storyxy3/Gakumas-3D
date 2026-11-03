namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverFurisodeJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle referenceHandHandle;
        public ReadOnlyTransformHandle referenceForearmHandle;
        public ReadOnlyTransformHandle referenceFurisodeOffsetHandle;
        public ReadOnlyTransformHandle referenceSpineHandle;
        public float3 backWay;
        public float apexAngle;
        public float coefficient;
        public float min;
        public float max;
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

        public ActorAnimationQuartzDriverFurisodeJobBone(ActorAnimationQuartzDriverFurisodeSetting setting, Transform transform, Animator animator)
        {
            this = default;
        }

        public void Update(ActorAnimationQuartzDriverFurisodeSetting setting)
        {
        }
    }
}
