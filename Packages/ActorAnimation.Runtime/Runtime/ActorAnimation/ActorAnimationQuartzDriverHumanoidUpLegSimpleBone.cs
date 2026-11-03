namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverSimpleHumanoidUpLegBone")]
    public class ActorAnimationQuartzDriverHumanoidUpLegSimpleBone : ActorAnimationQuartzDriverSimpleBoneBase
    {
        public Animator animator;
        public ActorAnimationQuartzDriverHumanoidUpLegSetting setting;
        private const int LeftUpLeg = 23;
        private const int RightUpLeg = 31;
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

        public ActorAnimationQuartzDriverHumanoidUpLegSimpleBone()
        {
        }
    }
}
