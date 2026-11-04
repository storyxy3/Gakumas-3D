namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverHumanoidArmJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public MuscleHandle referenceHandle;
        public float coefficient;
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
        }

        public bool IsValid(AnimationStream stream)
        {
            return drivenHandle.IsValid(stream);
        }

        public bool Resolve(AnimationStream stream)
        {
            if (!drivenHandle.IsResolved(stream))
            {
                drivenHandle.Resolve(stream);
                if (!drivenHandle.IsResolved(stream)) return false;
            }
            return true;
        }

        public void Execute(AnimationStream stream)
        {
            float angle = ActorAnimationQuartzDriverHumanoidArmBone.Calc(stream.AsHuman().GetMuscle(referenceHandle), ActorAnimationQuartzDriverHumanoidArmSetting.MuscleConvertCoefficient, coefficient);
            var euler = ActorAnimationMathUtility.ToUnityEuler(drivenHandle.GetLocalRotation(stream));
            euler.x = angle;
            drivenHandle.SetLocalRotation(stream, ActorAnimationMathUtility.ToUnityQuaternion(euler));
        }

        public ActorAnimationQuartzDriverHumanoidArmJobBone(ActorAnimationQuartzDriverHumanoidArmSetting setting, Transform transform, Animator animator)
        {
            _isActive = true;
            drivenHandle = ReadWriteTransformHandle.Bind(animator, transform);
            referenceHandle = new MuscleHandle(setting.humanPartDof, ActorAnimationQuartzDriverHumanoidArmSetting.ArmDof);
            coefficient = setting.coefficient;
        }

        public void Update(ActorAnimationQuartzDriverHumanoidArmSetting setting)
        {
            coefficient = setting.coefficient;
        }
    }
}
