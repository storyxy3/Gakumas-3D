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
            return default(ActorAnimationQuartzDriverBoneType);
        }

        public static quaternion Calc(quaternion referenceRotation, math.RotationOrder rotationOrder, float3 outerMinusCoefficient, float3 innerCoefficient, float3 outerPlusCoefficient, float3 switchMinus, float3 switchPlus, math.RotationOrder connectionAxis, ActorAnimationQuartzDriverRotationDecomposeType decomposeType, ActorAnimationQuartzDriverRotationComposeType composeType)
        {
            return default(quaternion);
        }

        public ActorAnimationQuartzDriverFrillBone()
        {
        }
    }
}
