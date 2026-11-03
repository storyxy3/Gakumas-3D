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
            return default(ActorAnimationQuartzDriverBoneType);
        }

        public static quaternion Calc(quaternion initialReferenceRotation, quaternion currentReferenceRotation, math.RotationOrder rotationOrder, float3 innerCoefficient, float3 outerCoefficient, float3 limitMin, float3 limitMax, math.RotationOrder connectionAxis)
        {
            return default(quaternion);
        }

        public ActorAnimationQuartzDriverSkirtBone()
        {
        }
    }
}
