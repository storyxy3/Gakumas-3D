namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverSimpleHairBone")]
    public class ActorAnimationQuartzDriverHairSimpleBone : ActorAnimationQuartzDriverSimpleBoneBase
    {
        public ActorAnimationQuartzDriverHairSetting setting;
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

        public ActorAnimationQuartzDriverHairSimpleBone()
        {
        }
    }
}
