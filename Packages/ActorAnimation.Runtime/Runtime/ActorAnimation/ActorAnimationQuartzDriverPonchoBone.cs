namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverPonchoBone")]
    public class ActorAnimationQuartzDriverPonchoBone : ActorAnimationQuartzDriverBoneBase
    {
        public ActorAnimationQuartzDriverPonchoSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return (ActorAnimationQuartzDriverBoneType)11;
        }

        public static (quaternion, float3) Calc(Quaternion armLocalRotation, Vector3 ponchoOffsetWorldPosition, Quaternion ponchoOffsetWorldRotation, Vector3 armOffsetWorldPosition, Vector3 bodyOffsetWorldPosition, Vector3 innerOffsetLocalPosition, Vector3 outerOffsetLocalPosition, float lerpCoefficient, float innerLimit, float outerLimit, float3 defaultWay)
        {
            var rotation = CalcRotation(ponchoOffsetWorldPosition, ponchoOffsetWorldRotation, armOffsetWorldPosition, bodyOffsetWorldPosition, lerpCoefficient, defaultWay);
            var position = CalcPosition(armLocalRotation, innerOffsetLocalPosition, outerOffsetLocalPosition, lerpCoefficient, innerLimit, outerLimit);
            return (rotation, position);
        }

        private static quaternion CalcRotation(Vector3 ponchoOffsetWorldPosition, Quaternion ponchoOffsetWorldRotation, Vector3 armOffsetWorldPosition, Vector3 bodyOffsetWorldPosition, float lerpCoefficient, float3 defaultWay)
        {
            var direction = (armOffsetWorldPosition * lerpCoefficient + bodyOffsetWorldPosition * (1f - lerpCoefficient) - ponchoOffsetWorldPosition).normalized;
            var localDirection = Quaternion.Inverse(ponchoOffsetWorldRotation) * direction;
            return Quaternion.FromToRotation(defaultWay, localDirection);
        }

        private static float3 CalcPosition(Quaternion armLocalRotation, Vector3 innerOffsetLocalPosition, Vector3 outerOffsetLocalPosition, float lerpCoefficient, float innerLimit, float outerLimit)
        {
            var angles = ActorAnimationMathUtility.EulerToBendroll(armLocalRotation.eulerAngles);
            float angle = angles[1];
            if (angle > 0f)
                return math.lerp(float3.zero, (float3)innerOffsetLocalPosition, math.clamp(angle / innerLimit, 0f, 1f));
            if (angle < 0f)
                return math.lerp(float3.zero, (float3)outerOffsetLocalPosition, math.clamp(angle / outerLimit, 0f, 1f));
            return (float3)Vector3.zero;
        }

        public ActorAnimationQuartzDriverPonchoBone()
        {
        }
    }
}
