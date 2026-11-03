namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    [ExecuteAlways]
    [AddComponentMenu("ActorAnimation/QuartzDriverSimpleLateRotationBone")]
    public class ActorAnimationQuartzDriverLateRotationSimpleBone : ActorAnimationQuartzDriverSimpleBoneBase
    {
        public ActorAnimationQuartzDriverRotationSetting setting;
        public override ActorAnimationQuartzDriverBoneType GetBoneType()
        {
            return default(ActorAnimationQuartzDriverBoneType);
        }

        private void LateUpdate()
        {
        }

        public ActorAnimationQuartzDriverLateRotationSimpleBone()
        {
        }
    }
}
