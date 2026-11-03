namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverHumanoidHandJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public MuscleHandle referenceHandle;
        public float coefficient;
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

        public ActorAnimationQuartzDriverHumanoidHandJobBone(ActorAnimationQuartzDriverHumanoidHandSetting setting, Transform transform, Animator animator)
        {
            this = default;
        }

        public void Update(ActorAnimationQuartzDriverHumanoidHandSetting setting)
        {
        }
    }
}
