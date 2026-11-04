namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverHumanoidSleeveJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        private static readonly float3 _xAxis = new float3(1f, 0f, 0f);
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle referenceHandle;
        public MuscleHandle forearmTwistMuscleHandle;
        public float3 outerMinusCoefficient;
        public float3 innerCoefficient;
        public float3 outerPlusCoefficient;
        public float3 switchMinus;
        public float3 switchPlus;
        public ActorAnimationQuartzDriverRotationComposeType composeType;
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
        }

        public bool IsValid(AnimationStream stream)
        {
            return referenceHandle.IsValid(stream) && drivenHandle.IsValid(stream);
        }

        public bool Resolve(AnimationStream stream)
        {
            if (drivenHandle.IsResolved(stream)) return true;
            drivenHandle.Resolve(stream);
            return drivenHandle.IsResolved(stream);
        }

        public void Execute(AnimationStream stream)
        {
            float twist = stream.AsHuman().GetMuscle(forearmTwistMuscleHandle);
            var twistRotation = quaternion.AxisAngle(_xAxis, twist * ActorAnimationQuartzDriverHumanoidSleeveSetting.MuscleConvertCoefficientForeArmRollInOut * 0.017453292f);
            var referenceRotation = (quaternion)referenceHandle.GetLocalRotation(stream);
            var euler = ActorAnimationMathUtility.ToUnityEuler(math.mul(twistRotation, referenceRotation));
            var bendRoll = ActorAnimationMathUtility.EulerToBendroll(euler);
            drivenHandle.SetLocalRotation(stream, ActorAnimationQuartzDriverHumanoidSleeveBone.Calc(bendRoll, outerMinusCoefficient, innerCoefficient, outerPlusCoefficient, switchMinus, switchPlus, composeType));
        }

        public ActorAnimationQuartzDriverHumanoidSleeveJobBone(ActorAnimationQuartzDriverHumanoidSleeveSetting setting, Transform transform, Animator animator)
        {
            _isActive = true;
            drivenHandle = ReadWriteTransformHandle.Bind(animator, transform);
            referenceHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceBone.transform);
            forearmTwistMuscleHandle = new MuscleHandle(setting.humanPartDof, ActorAnimationQuartzDriverHumanoidSleeveSetting.ArmDofForeArmRollInOut);
            outerMinusCoefficient = setting.outerMinusCoefficient;
            innerCoefficient = setting.innerCoefficient;
            outerPlusCoefficient = setting.outerPlusCoefficient;
            switchMinus = setting.switchMinus;
            switchPlus = setting.switchPlus;
            composeType = setting.composeType;
        }

        public void Update(ActorAnimationQuartzDriverHumanoidSleeveSetting setting)
        {
            outerMinusCoefficient = setting.outerMinusCoefficient;
            innerCoefficient = setting.innerCoefficient;
            outerPlusCoefficient = setting.outerPlusCoefficient;
            switchMinus = setting.switchMinus;
            switchPlus = setting.switchPlus;
            composeType = setting.composeType;
        }
    }
}
