namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverWaistBone")]
    public class ActorAnimationQuartzDriverWaistBone : ActorAnimationQuartzDriverBoneBase
    {
        public ActorAnimationQuartzDriverWaistSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return (ActorAnimationQuartzDriverBoneType)9;
        }

        public static (quaternion, float3) Calc(float3 waistWorldPosition, quaternion waistWorldRotation, float3 thighWorldPosition, float weight)
        {
            return default((quaternion, float3));
        }

        public ActorAnimationQuartzDriverWaistBone()
        {
        }
    }
}
