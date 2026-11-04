namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverHairBone")]
    public class ActorAnimationQuartzDriverHairBone : ActorAnimationQuartzDriverBoneBase
    {
        public ActorAnimationQuartzDriverHairSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return (ActorAnimationQuartzDriverBoneType)2;
        }

        public static (quaternion, float3) Calc(quaternion referenceHeadRotation, quaternion referenceNeckRotation, math.RotationOrder translateConnectionAxis, float3 headTranslateCoefficient, float3 headTranslateLimitMin, float3 headTranslateLimitMax, math.RotationOrder rotationOrder, float3 headRotateCoefficient, float3 headRotateLimitMin, float3 headRotateLimitMax, math.RotationOrder rotateConnectionAxis, float3 neckRotateCoefficient, float3 neckRotateLimitMin, float3 neckRotateLimitMax, ActorAnimationQuartzDriverRotationComposeType composeType)
        {
            var headEuler = ActorAnimationMathUtility.ToEuler(referenceHeadRotation, math.RotationOrder.YXZ) * 57.29578f;
            var neckEuler = ActorAnimationMathUtility.ToEuler(referenceNeckRotation, math.RotationOrder.YXZ) * 57.29578f;
            var head = ActorAnimationMathUtility.EulerToBendrollYRoll(headEuler);
            var neck = ActorAnimationMathUtility.EulerToBendrollYRoll(neckEuler);
            float translateX = ActorAnimationMathUtility.SingleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(head[1]), headTranslateCoefficient[0], headTranslateLimitMin[0], headTranslateLimitMax[0]);
            float translateY = ActorAnimationMathUtility.SingleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(head[0]), headTranslateCoefficient[1], headTranslateLimitMin[1], headTranslateLimitMax[1]);
            float translateZ = ActorAnimationMathUtility.SingleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(head[2]), headTranslateCoefficient[2], headTranslateLimitMin[2], headTranslateLimitMax[2]);
            var translation = ActorAnimationMathUtility.ExchangeArrayFromAxisConnection(translateX, translateY, translateZ, translateConnectionAxis);
            float neckRotateX = ActorAnimationMathUtility.SingleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(neck[1]), neckRotateCoefficient[0], neckRotateLimitMin[0], neckRotateLimitMax[0]);
            float neckRotateY = ActorAnimationMathUtility.SingleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(neck[0]), neckRotateCoefficient[1], neckRotateLimitMin[1], neckRotateLimitMax[1]);
            float neckRotateZ = ActorAnimationMathUtility.SingleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(neck[2]), neckRotateCoefficient[2], neckRotateLimitMin[2], neckRotateLimitMax[2]);
            float headRotateX = ActorAnimationMathUtility.SingleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(head[1]), headRotateCoefficient[0], headRotateLimitMin[0], headRotateLimitMax[0]);
            float headRotateY = ActorAnimationMathUtility.SingleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(head[0]), headRotateCoefficient[1], headRotateLimitMin[1], headRotateLimitMax[1]);
            float headRotateZ = ActorAnimationMathUtility.SingleCoefficientConversion(ActorAnimationMathUtility.FormatRangeDegree(head[2]), headRotateCoefficient[2], headRotateLimitMin[2], headRotateLimitMax[2]);
            float x = (neckRotateX + headRotateX) * 0.017453292f;
            float y = (neckRotateY + headRotateY) * 0.017453292f;
            float z = (neckRotateZ + headRotateZ) * 0.017453292f;
            quaternion rotation;
            switch (composeType)
            {
                case ActorAnimationQuartzDriverRotationComposeType.BendRoll:
                    rotation = ActorAnimationMathUtility.AxisrotationToQuaternionWithBendRoll(x, y, z);
                    break;
                case ActorAnimationQuartzDriverRotationComposeType.RollBend:
                    rotation = ActorAnimationMathUtility.AxisrotationToQuaternionWithRollBend(x, y, z);
                    break;
                case ActorAnimationQuartzDriverRotationComposeType.Matrix:
                    rotation = ActorAnimationMathUtility.AxisrotationToQuaternionWithMatrix(-x, -y, -z);
                    break;
                default:
                    rotation = ActorAnimationMathUtility.ToUnityQuaternion(ActorAnimationMathUtility.AxisrotationToEuler(x, y, z));
                    rotation = ActorAnimationMathUtility.ToUnityQuaternion(ActorAnimationMathUtility.ToEuler(rotation, math.RotationOrder.XYZ) * 57.29578f);
                    break;
            }
            var euler = ActorAnimationMathUtility.ToEuler(rotation, rotationOrder);
            euler = ActorAnimationMathUtility.ExchangeArrayFromAxisConnection(euler.x, euler.y, euler.z, rotateConnectionAxis);
            return (ActorAnimationMathUtility.ToUnityQuaternion(euler * 57.29578f), translation);
        }

        public ActorAnimationQuartzDriverHairBone()
        {
        }
    }
}
