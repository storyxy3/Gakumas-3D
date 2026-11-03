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
            return default(ActorAnimationQuartzDriverBoneType);
        }

        public static quaternion Calc(quaternion referenceRotation, math.RotationOrder rotationOrder, float3 coefficient, float3 limitMin, float3 limitMax, math.RotationOrder connectionAxis, ActorAnimationQuartzDriverRotationDecomposeType decomposeType, ActorAnimationQuartzDriverRotationComposeType composeType)
        {
            return default(quaternion);
        }

        public ActorAnimationQuartzDriverRotationBone()
        {
        }
    }
}
