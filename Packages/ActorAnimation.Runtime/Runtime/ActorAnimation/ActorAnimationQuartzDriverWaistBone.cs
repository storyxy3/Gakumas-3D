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
            var delta = thighWorldPosition - waistWorldPosition;
            var direction = math.mul(math.inverse(waistWorldRotation), math.normalize(delta));
            quaternion rotation = Quaternion.FromToRotation(Vector3.back, direction);
            return (rotation, waistWorldPosition + delta * weight);
        }

        public ActorAnimationQuartzDriverWaistBone()
        {
        }
    }
}
