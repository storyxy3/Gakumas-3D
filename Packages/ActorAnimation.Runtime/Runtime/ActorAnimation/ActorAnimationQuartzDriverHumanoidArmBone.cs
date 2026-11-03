namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverHumanoidArmBone")]
    public class ActorAnimationQuartzDriverHumanoidArmBone : ActorAnimationQuartzDriverBoneBase
    {
        public ActorAnimationQuartzDriverHumanoidArmSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return default(ActorAnimationQuartzDriverBoneType);
        }

        public static float Calc(float muscleValue, float muscleConvertCoefficient, float rotateCoefficient)
        {
            return default(float);
        }

        public ActorAnimationQuartzDriverHumanoidArmBone()
        {
        }
    }
}
