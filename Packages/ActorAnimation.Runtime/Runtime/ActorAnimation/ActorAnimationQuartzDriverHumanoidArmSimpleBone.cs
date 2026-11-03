namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverSimpleHumanoidArmBone")]
    public class ActorAnimationQuartzDriverHumanoidArmSimpleBone : ActorAnimationQuartzDriverSimpleBoneBase
    {
        public Animator animator;
        public ActorAnimationQuartzDriverHumanoidArmSetting setting;
        private const int LeftArm = 41;
        private const int RightArm = 50;
        private HumanPoseHandler handler;
        private HumanPose humanPose;
        public void Start()
        {
        }

        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return default(ActorAnimationQuartzDriverBoneType);
        }

        private void Update()
        {
        }

        public ActorAnimationQuartzDriverHumanoidArmSimpleBone()
        {
        }
    }
}
