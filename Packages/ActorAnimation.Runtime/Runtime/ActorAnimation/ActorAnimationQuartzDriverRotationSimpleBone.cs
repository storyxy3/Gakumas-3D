namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverSimpleRotationBone")]
    public class ActorAnimationQuartzDriverRotationSimpleBone : ActorAnimationQuartzDriverSimpleBoneBase
    {
        public ActorAnimationQuartzDriverRotationSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return default(ActorAnimationQuartzDriverBoneType);
        }

        private void Update()
        {
        }

        public ActorAnimationQuartzDriverRotationSimpleBone()
        {
        }
    }
}
