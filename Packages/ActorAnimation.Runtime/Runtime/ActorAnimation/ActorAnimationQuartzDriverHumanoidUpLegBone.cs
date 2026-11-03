namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverHumanoidUpLegBone")]
    public class ActorAnimationQuartzDriverHumanoidUpLegBone : ActorAnimationQuartzDriverBoneBase
    {
        public ActorAnimationQuartzDriverHumanoidUpLegSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return default(ActorAnimationQuartzDriverBoneType);
        }

        public static float Calc(float muscleValue, float muscleConvertCoefficient, float rotateCoefficient)
        {
            return default(float);
        }

        public ActorAnimationQuartzDriverHumanoidUpLegBone()
        {
        }
    }
}
