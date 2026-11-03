namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [ExecuteAlways]
    [AddComponentMenu("ActorAnimation/QuartzDriverSimpleHumanoidSleeveBone")]
    public class ActorAnimationQuartzDriverHumanoidSleeveSimpleBone : ActorAnimationQuartzDriverSimpleBoneBase
    {
        public ActorAnimationQuartzDriverHumanoidSleeveSetting setting;
        private ActorAnimationQuartzDriverHumanoidSleeveSetting unitySetting;
        private const int ForeArmRollInOutMuscleIndexLeft = 43;
        private const int ForeArmRollInOutMuscleIndexRight = 52;
        private const int HandInOutMuscleHandleIndexLeft = 45;
        private const int HandInOutMuscleHandleIndexRight = 54;
        private const int HandDownUpMuscleHandleIndexLeft = 44;
        private const int HandDownUpMuscleHandleIndexRight = 53;
        private HumanPoseHandler handler;
        private HumanPose humanPose;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return default(ActorAnimationQuartzDriverBoneType);
        }

        private void Update()
        {
        }

        public ActorAnimationQuartzDriverHumanoidSleeveSimpleBone()
        {
        }
    }
}
