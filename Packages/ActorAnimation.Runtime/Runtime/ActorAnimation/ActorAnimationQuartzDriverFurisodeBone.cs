namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverFurisodeBone")]
    public class ActorAnimationQuartzDriverFurisodeBone : ActorAnimationQuartzDriverBoneBase
    {
        public ActorAnimationQuartzDriverFurisodeSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return default(ActorAnimationQuartzDriverBoneType);
        }

        public static quaternion Calc(Vector3 handWorldPosition, Vector3 forearmWorldPosition, Quaternion furisodeOffsetWorldRotation, Quaternion spineWorldRotation, float3 backWay, float apexAngle, float coefficient, float min, float max)
        {
            return default(quaternion);
        }

        public ActorAnimationQuartzDriverFurisodeBone()
        {
        }
    }
}
