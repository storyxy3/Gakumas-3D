namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/QuartzDriverSimpleSkirtBone")]
    public class ActorAnimationQuartzDriverSkirtSimpleBone : ActorAnimationQuartzDriverSimpleBoneBase
    {
        public ActorAnimationQuartzDriverSkirtSetting setting;
        private quaternion initialReferenceRotation;
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

        public ActorAnimationQuartzDriverSkirtSimpleBone()
        {
        }
    }
}
