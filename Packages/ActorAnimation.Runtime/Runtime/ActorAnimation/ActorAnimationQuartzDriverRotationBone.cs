namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverRotationBone")]
    public class ActorAnimationQuartzDriverRotationBone : ActorAnimationQuartzDriverBoneBase
    {
        public ActorAnimationQuartzDriverRotationSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return (ActorAnimationQuartzDriverBoneType)0;
        }

        public static quaternion Calc(quaternion referenceRotation, math.RotationOrder rotationOrder, float3 coefficient, float3 limitMin, float3 limitMax, math.RotationOrder connectionAxis, ActorAnimationQuartzDriverRotationDecomposeType decomposeType, ActorAnimationQuartzDriverRotationComposeType composeType)
        {
            float3 angles = ActorAnimationMathUtility.ToEuler(referenceRotation, rotationOrder);
            switch (decomposeType)
            {
                case ActorAnimationQuartzDriverRotationDecomposeType.Euler: break;
                case ActorAnimationQuartzDriverRotationDecomposeType.StereoProjectionEuler:
                    angles = ActorAnimationMathUtility.EulerToBendroll(angles);
                    break;
                case ActorAnimationQuartzDriverRotationDecomposeType.StereoProjectionQuaternion:
                    angles = ActorAnimationMathUtility.EulerToBendrollQuaternionInverse(angles);
                    break;
                default: angles = float3.zero; break;
            }
            float x = ActorAnimationMathUtility.FormatRangeDegree(angles.x);
            float y = ActorAnimationMathUtility.FormatRangeDegree(angles.y);
            float z = ActorAnimationMathUtility.FormatRangeDegree(angles.z);
            x = ActorAnimationMathUtility.SingleCoefficientConversion(x, coefficient.x, limitMin.x, limitMax.x);
            y = ActorAnimationMathUtility.SingleCoefficientConversion(y, coefficient.y, limitMin.y, limitMax.y);
            z = ActorAnimationMathUtility.SingleCoefficientConversion(z, coefficient.z, limitMin.z, limitMax.z);
            switch (composeType)
            {
                case ActorAnimationQuartzDriverRotationComposeType.BendRoll:
                    return ActorAnimationMathUtility.AxisrotationToQuaternionWithBendRoll(-x, -y, -z);
                case ActorAnimationQuartzDriverRotationComposeType.RollBend:
                    return ActorAnimationMathUtility.AxisrotationToQuaternionWithRollBend(-x, -y, -z);
                case ActorAnimationQuartzDriverRotationComposeType.Matrix:
                    return ActorAnimationMathUtility.AxisrotationToQuaternionWithMatrix(x, y, z);
                default:
                    return ActorAnimationMathUtility.ToUnityQuaternion(
                        ActorAnimationMathUtility.ExchangeArrayFromAxisConnection(x, y, z, connectionAxis) * 57.29578f);
            }
        }

        public ActorAnimationQuartzDriverRotationBone()
        {
        }
    }
}
