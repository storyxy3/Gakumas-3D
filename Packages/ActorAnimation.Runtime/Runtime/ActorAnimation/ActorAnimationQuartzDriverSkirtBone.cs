// TODO(qa-recon): Selected APK bodies still need reconstruction: Calc.
namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverSkirtBone")]
    public class ActorAnimationQuartzDriverSkirtBone : ActorAnimationQuartzDriverBoneBase
    {
        public ActorAnimationQuartzDriverSkirtSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return (ActorAnimationQuartzDriverBoneType)1;
        }

        public static quaternion Calc(quaternion initialReferenceRotation, quaternion currentReferenceRotation, math.RotationOrder rotationOrder, float3 innerCoefficient, float3 outerCoefficient, float3 limitMin, float3 limitMax, math.RotationOrder connectionAxis)
        {
            var angles = ActorAnimationMathUtility.ToEuler(math.mul(currentReferenceRotation, math.inverse(initialReferenceRotation)), rotationOrder);
            angles[0] *= 57.29578f;
            angles[1] *= 57.29578f;
            angles[2] *= 57.29578f;
            var bendRoll = ActorAnimationMathUtility.EulerToBendrollQuaternionInverseYRoll(angles, rotationOrder);
            float roll = ActorAnimationMathUtility.FormatRangeDegree(bendRoll[0]);
            float pitch = ActorAnimationMathUtility.FormatRangeDegree(bendRoll[2]);
            float yaw = ActorAnimationMathUtility.FormatRangeDegree(bendRoll[1]);
            bendRoll[0] = roll;
            bendRoll[1] = pitch;
            bendRoll[2] = yaw;
            float x = ActorAnimationMathUtility.DualCoefficientConversion(bendRoll[0], innerCoefficient[0], outerCoefficient[0], limitMin[0], limitMax[0]);
            float y = ActorAnimationMathUtility.DualCoefficientConversion(bendRoll[1], innerCoefficient[1], outerCoefficient[1], limitMin[1], limitMax[1]);
            float z = ActorAnimationMathUtility.DualCoefficientConversion(bendRoll[2], innerCoefficient[2], outerCoefficient[2], limitMin[2], limitMax[2]);
            x += bendRoll[0] * outerCoefficient[0];
            y += bendRoll[1] * outerCoefficient[1];
            z += bendRoll[2] * outerCoefficient[2];
            return ActorAnimationMathUtility.AxisrotationToQuaternionWithBendRoll(x * 0.017453292f, y * 0.017453292f, z * 0.017453292f);
        }

        public ActorAnimationQuartzDriverSkirtBone()
        {
        }
    }
}
