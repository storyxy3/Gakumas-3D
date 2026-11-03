namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverSimpleFrillBone")]
    public class ActorAnimationQuartzDriverFrillSimpleBone : ActorAnimationQuartzDriverSimpleBoneBase
    {
        public ActorAnimationQuartzDriverFrillSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return default(ActorAnimationQuartzDriverBoneType);
        }

        private void Start()
        {
        }

        private void Update()
        {
        }

        public ActorAnimationQuartzDriverFrillSimpleBone()
        {
        }
    }
}
