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
            return default(ActorAnimationQuartzDriverBoneType);
        }

        public static (quaternion, float3) Calc(quaternion referenceHeadRotation, quaternion referenceNeckRotation, math.RotationOrder translateConnectionAxis, float3 headTranslateCoefficient, float3 headTranslateLimitMin, float3 headTranslateLimitMax, math.RotationOrder rotationOrder, float3 headRotateCoefficient, float3 headRotateLimitMin, float3 headRotateLimitMax, math.RotationOrder rotateConnectionAxis, float3 neckRotateCoefficient, float3 neckRotateLimitMin, float3 neckRotateLimitMax, ActorAnimationQuartzDriverRotationComposeType composeType)
        {
            return default((quaternion, float3));
        }

        public ActorAnimationQuartzDriverHairBone()
        {
        }
    }
}
