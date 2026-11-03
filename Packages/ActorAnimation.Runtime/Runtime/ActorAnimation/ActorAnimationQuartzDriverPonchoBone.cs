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
            return default(ActorAnimationQuartzDriverBoneType);
        }

        public static (quaternion, float3) Calc(Quaternion armLocalRotation, Vector3 ponchoOffsetWorldPosition, Quaternion ponchoOffsetWorldRotation, Vector3 armOffsetWorldPosition, Vector3 bodyOffsetWorldPosition, Vector3 innerOffsetLocalPosition, Vector3 outerOffsetLocalPosition, float lerpCoefficient, float innerLimit, float outerLimit, float3 defaultWay)
        {
            return default((quaternion, float3));
        }

        private static quaternion CalcRotation(Vector3 ponchoOffsetWorldPosition, Quaternion ponchoOffsetWorldRotation, Vector3 armOffsetWorldPosition, Vector3 bodyOffsetWorldPosition, float lerpCoefficient, float3 defaultWay)
        {
            return default(quaternion);
        }

        private static float3 CalcPosition(Quaternion armLocalRotation, Vector3 innerOffsetLocalPosition, Vector3 outerOffsetLocalPosition, float lerpCoefficient, float innerLimit, float outerLimit)
        {
            return default(float3);
        }

        public ActorAnimationQuartzDriverPonchoBone()
        {
        }
    }
}
