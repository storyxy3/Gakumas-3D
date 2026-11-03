namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverSimpleHumanoidHandBone")]
    public class ActorAnimationQuartzDriverHumanoidHandSimpleBone : ActorAnimationQuartzDriverSimpleBoneBase
    {
        public Animator animator;
        public ActorAnimationQuartzDriverHumanoidHandSetting setting;
        private const int LeftHand = 43;
        private const int RightHand = 52;
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

        public ActorAnimationQuartzDriverHumanoidHandSimpleBone()
        {
        }
    }
}
