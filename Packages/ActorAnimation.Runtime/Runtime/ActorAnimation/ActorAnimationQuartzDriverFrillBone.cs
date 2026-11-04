namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverFrillBone")]
    public class ActorAnimationQuartzDriverFrillBone : ActorAnimationQuartzDriverBoneBase
    {
        public ActorAnimationQuartzDriverFrillSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return (ActorAnimationQuartzDriverBoneType)3;
        }

        public static quaternion Calc(quaternion referenceRotation, math.RotationOrder rotationOrder, float3 outerMinusCoefficient, float3 innerCoefficient, float3 outerPlusCoefficient, float3 switchMinus, float3 switchPlus, math.RotationOrder connectionAxis, ActorAnimationQuartzDriverRotationDecomposeType decomposeType, ActorAnimationQuartzDriverRotationComposeType composeType)
        {
            float3 euler = ActorAnimationMathUtility.ToUnityEuler(referenceRotation);
            float3 angles = float3.zero;
            switch (decomposeType)
            {
                case ActorAnimationQuartzDriverRotationDecomposeType.Euler: angles = euler; break;
                case ActorAnimationQuartzDriverRotationDecomposeType.StereoProjectionEuler:
                    angles = ActorAnimationMathUtility.EulerToBendroll(euler);
                    break;
                case ActorAnimationQuartzDriverRotationDecomposeType.StereoProjectionQuaternion:
                    angles = ActorAnimationMathUtility.EulerToBendrollQuaternionInverse(euler);
                    break;
            }
            float x = ActorAnimationMathUtility.TripleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(angles[0]), outerMinusCoefficient[0], innerCoefficient[0], outerPlusCoefficient[0], switchMinus[0], switchPlus[0]) * 0.017453292f;
            float y = ActorAnimationMathUtility.TripleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(angles[1]), outerMinusCoefficient[1], innerCoefficient[1], outerPlusCoefficient[1], switchMinus[1], switchPlus[1]) * 0.017453292f;
            float z = ActorAnimationMathUtility.TripleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(angles[2]), outerMinusCoefficient[2], innerCoefficient[2], outerPlusCoefficient[2], switchMinus[2], switchPlus[2]) * 0.017453292f;
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
                    var result = ActorAnimationMathUtility.ToEuler(rotation, rotationOrder);
                    result = ActorAnimationMathUtility.ExchangeArrayFromAxisConnection(result.x, result.y, result.z, connectionAxis);
                    return ActorAnimationMathUtility.ToUnityQuaternion(result * 57.29578f);
            }
        }

        public ActorAnimationQuartzDriverFrillBone()
        {
        }
    }
}
