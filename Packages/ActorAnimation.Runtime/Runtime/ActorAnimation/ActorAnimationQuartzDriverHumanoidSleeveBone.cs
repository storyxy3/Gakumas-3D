namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverHumanoidSleeveBone")]
    public class ActorAnimationQuartzDriverHumanoidSleeveBone : ActorAnimationQuartzDriverBoneBase
    {
        public ActorAnimationQuartzDriverHumanoidSleeveSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return default(ActorAnimationQuartzDriverBoneType);
        }

        public static quaternion Calc(float3 referenceRollPitchYaw, float3 outerMinusCoefficient, float3 innerCoefficient, float3 outerPlusCoefficient, float3 switchMinus, float3 switchPlus, ActorAnimationQuartzDriverRotationComposeType composeType)
        {
            return default(quaternion);
        }

        public static float3 GetRollPitchYawDegreeFromMuscleValue(float rotX, float rotY, float rotZ)
        {
            return default(float3);
        }

        public ActorAnimationQuartzDriverHumanoidSleeveBone()
        {
        }
    }
}
