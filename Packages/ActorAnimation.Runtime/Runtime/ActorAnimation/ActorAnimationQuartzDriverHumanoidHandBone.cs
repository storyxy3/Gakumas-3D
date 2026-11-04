namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverHumanoidHandBone")]
    public class ActorAnimationQuartzDriverHumanoidHandBone : ActorAnimationQuartzDriverBoneBase
    {
        public ActorAnimationQuartzDriverHumanoidHandSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return (ActorAnimationQuartzDriverBoneType)4;
        }

        public static float Calc(float muscleValue, float muscleConvertCoefficient, float rotateCoefficient)
        {
            return muscleValue * muscleConvertCoefficient * rotateCoefficient;
        }

        public ActorAnimationQuartzDriverHumanoidHandBone()
        {
        }
    }
}
