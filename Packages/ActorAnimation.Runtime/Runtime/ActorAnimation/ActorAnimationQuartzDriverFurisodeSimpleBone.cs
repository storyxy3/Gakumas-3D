namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverSimpleFurisodeBone")]
    public class ActorAnimationQuartzDriverFurisodeSimpleBone : ActorAnimationQuartzDriverSimpleBoneBase
    {
        public ActorAnimationQuartzDriverFurisodeSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return default(ActorAnimationQuartzDriverBoneType);
        }

        private void Update()
        {
        }

        public ActorAnimationQuartzDriverFurisodeSimpleBone()
        {
        }
    }
}
