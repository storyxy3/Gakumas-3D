namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverHumanoidSleeveBone")]
    public class ActorAnimationQuartzDriverHumanoidSleeveBone : ActorAnimationQuartzDriverBoneBase
    {
        public ActorAnimationQuartzDriverHumanoidSleeveSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return (ActorAnimationQuartzDriverBoneType)5;
        }

        public static quaternion Calc(float3 referenceRollPitchYaw, float3 outerMinusCoefficient, float3 innerCoefficient, float3 outerPlusCoefficient, float3 switchMinus, float3 switchPlus, ActorAnimationQuartzDriverRotationComposeType composeType)
        {
            float x = ActorAnimationMathUtility.TripleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(referenceRollPitchYaw[0]), outerMinusCoefficient[0], innerCoefficient[0], outerPlusCoefficient[0], switchMinus[0], switchPlus[0]) * 0.017453292f;
            float y = ActorAnimationMathUtility.TripleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(referenceRollPitchYaw[1]), outerMinusCoefficient[1], innerCoefficient[1], outerPlusCoefficient[1], switchMinus[1], switchPlus[1]) * 0.017453292f;
            float z = ActorAnimationMathUtility.TripleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(referenceRollPitchYaw[2]), outerMinusCoefficient[2], innerCoefficient[2], outerPlusCoefficient[2], switchMinus[2], switchPlus[2]) * 0.017453292f;
            switch (composeType)
            {
                case ActorAnimationQuartzDriverRotationComposeType.BendRoll:
                    return ActorAnimationMathUtility.AxisrotationToQuaternionWithBendRoll(x, y, z);
                case ActorAnimationQuartzDriverRotationComposeType.RollBend:
                    return ActorAnimationMathUtility.AxisrotationToQuaternionWithRollBend(x, y, z);
                case ActorAnimationQuartzDriverRotationComposeType.Matrix:
                    return ActorAnimationMathUtility.AxisrotationToQuaternionWithMatrix(-x, -y, -z);
                default:
                    var rotation = ActorAnimationMathUtility.ToUnityQuaternion(ActorAnimationMathUtility.AxisrotationToEuler(x, y, z));
                    return ActorAnimationMathUtility.ToUnityQuaternion(ActorAnimationMathUtility.ToEuler(rotation, math.RotationOrder.XYZ) * 57.29578f);
            }
        }

        public static float3 GetRollPitchYawDegreeFromMuscleValue(float rotX, float rotY, float rotZ)
        {
            return new float3(rotX * ActorAnimationQuartzDriverHumanoidSleeveSetting.MuscleConvertCoefficientForeArmRollInOut,
                rotY * ActorAnimationQuartzDriverHumanoidSleeveSetting.MuscleConvertCoefficientHandInOut,
                rotZ * ActorAnimationQuartzDriverHumanoidSleeveSetting.MuscleConvertCoefficientHandDownUp);
        }

        public ActorAnimationQuartzDriverHumanoidSleeveBone()
        {
        }
    }
}
