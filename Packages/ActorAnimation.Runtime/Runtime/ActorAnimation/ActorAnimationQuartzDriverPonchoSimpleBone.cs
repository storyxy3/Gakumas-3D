namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverSimplePonchoBone")]
    public class ActorAnimationQuartzDriverPonchoSimpleBone : ActorAnimationQuartzDriverSimpleBoneBase
    {
        public ActorAnimationQuartzDriverPonchoSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return default(ActorAnimationQuartzDriverBoneType);
        }

        private void Update()
        {
        }

        public ActorAnimationQuartzDriverPonchoSimpleBone()
        {
        }
    }
}
