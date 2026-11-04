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
            return (ActorAnimationQuartzDriverBoneType)8;
        }

        public static float Calc(float muscleValue, float muscleConvertCoefficient, float rotateCoefficient)
        {
            return muscleValue * muscleConvertCoefficient * rotateCoefficient;
        }

        public ActorAnimationQuartzDriverHumanoidArmBone()
        {
        }
    }
}
