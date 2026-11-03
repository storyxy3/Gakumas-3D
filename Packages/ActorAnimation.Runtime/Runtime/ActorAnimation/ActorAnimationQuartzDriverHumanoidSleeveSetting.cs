namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverHumanoidSleeveSetting
    {
        public float3 outerMinusCoefficient;
        public float3 innerCoefficient;
        public float3 outerPlusCoefficient;
        public float3 switchMinus;
        public float3 switchPlus;
        public GameObject referenceBone;
        public ActorAnimationQuartzDriverRotationComposeType composeType;
        public ActorAnimationQuartzDriverRotationDecomposeType decomposeType;
        public static readonly ArmDof ArmDofForeArmRollInOut;
        public static readonly float MuscleConvertCoefficientForeArmRollInOut;
        public static readonly float MuscleConvertCoefficientHandInOut;
        public static readonly float MuscleConvertCoefficientHandDownUp;
        public HumanPartDof humanPartDof;
        public ActorAnimationQuartzDriverHumanoidSleeveSetting()
        {
        }

        public ActorAnimationQuartzDriverHumanoidSleeveSetting(ActorAnimationQuartzDriverHumanoidSleeveSetting source)
        {
        }

        public ActorAnimationQuartzDriverHumanoidSleeveSetting ConvertToUnity()
        {
            return null;
        }
    }
}
