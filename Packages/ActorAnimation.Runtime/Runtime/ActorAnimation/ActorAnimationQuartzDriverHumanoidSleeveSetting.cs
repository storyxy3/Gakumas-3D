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
        public static readonly ArmDof ArmDofForeArmRollInOut = (ArmDof)6;
        public static readonly float MuscleConvertCoefficientForeArmRollInOut = -90f;
        public static readonly float MuscleConvertCoefficientHandInOut = -40f;
        public static readonly float MuscleConvertCoefficientHandDownUp = -80.0f;
        public HumanPartDof humanPartDof;
        public ActorAnimationQuartzDriverHumanoidSleeveSetting()
        {
        }

        public ActorAnimationQuartzDriverHumanoidSleeveSetting(ActorAnimationQuartzDriverHumanoidSleeveSetting source)
        {
        }

        public ActorAnimationQuartzDriverHumanoidSleeveSetting ConvertToUnity()
        {
            innerCoefficient[0] = -innerCoefficient[0];
            outerMinusCoefficient[0] = -outerMinusCoefficient[0];
            outerPlusCoefficient[0] = -outerPlusCoefficient[0];
            innerCoefficient[1] = -innerCoefficient[1];
            float outerMinusCoefficient1 = -outerPlusCoefficient[1];
            float outerPlusCoefficient1 = -outerMinusCoefficient[1];
            outerMinusCoefficient[1] = outerMinusCoefficient1;
            outerPlusCoefficient[1] = outerPlusCoefficient1;
            float switchMinus1 = -switchPlus[1];
            float switchPlus1 = -switchMinus[1];
            switchMinus[1] = switchMinus1;
            switchPlus[1] = switchPlus1;
            innerCoefficient[2] = -innerCoefficient[2];
            float outerMinusCoefficient2 = -outerPlusCoefficient[2];
            float outerPlusCoefficient2 = -outerMinusCoefficient[2];
            outerMinusCoefficient[2] = outerMinusCoefficient2;
            outerPlusCoefficient[2] = outerPlusCoefficient2;
            float switchMinus2 = -switchPlus[2];
            float switchPlus2 = -switchMinus[2];
            switchMinus[2] = switchMinus2;
            switchPlus[2] = switchPlus2;
            return this;
        }
    }
}
