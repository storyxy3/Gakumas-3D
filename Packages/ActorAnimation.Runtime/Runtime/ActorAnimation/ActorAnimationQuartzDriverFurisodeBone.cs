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
            return (ActorAnimationQuartzDriverBoneType)10;
        }

        public static quaternion Calc(Vector3 handWorldPosition, Vector3 forearmWorldPosition, Quaternion furisodeOffsetWorldRotation, Quaternion spineWorldRotation, float3 backWay, float apexAngle, float coefficient, float min, float max)
        {
            var direction = (handWorldPosition - forearmWorldPosition).normalized;
            float angle = Vector3.Angle(direction, Vector3.back);
            float weight = math.clamp(1f - angle / apexAngle, 0f, 1f);
            var localBack = Quaternion.Inverse(furisodeOffsetWorldRotation) * (spineWorldRotation * (Vector3)backWay);
            var rotation = Quaternion.FromToRotation(Vector3.up, localBack);
            var bendRoll = ActorAnimationMathUtility.EulerToBendroll(rotation.eulerAngles);
            float z = Mathf.Clamp(0f + weight * coefficient * bendRoll.z, min, max);
            return Quaternion.Euler((Vector3)new float3(0f, 0f, z));
        }

        public ActorAnimationQuartzDriverFurisodeBone()
        {
        }
    }
}
