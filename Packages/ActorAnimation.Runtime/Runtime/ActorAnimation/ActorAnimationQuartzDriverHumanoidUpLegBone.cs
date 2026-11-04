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
            return (ActorAnimationQuartzDriverBoneType)7;
        }

        public static float Calc(float muscleValue, float muscleConvertCoefficient, float rotateCoefficient)
        {
            return muscleValue * muscleConvertCoefficient * rotateCoefficient;
        }

        public ActorAnimationQuartzDriverHumanoidUpLegBone()
        {
        }
    }
}
