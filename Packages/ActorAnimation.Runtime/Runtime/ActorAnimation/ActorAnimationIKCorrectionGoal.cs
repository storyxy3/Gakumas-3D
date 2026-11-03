namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    public class ActorAnimationIKCorrectionGoal : ActorAnimationIKCorrectionComponentBase
    {
        public AvatarIKGoal goal;
        public bool enable;
        [Range(0f, 0.2f)]
        public float radius;
        public Vector3 offset;
        public ActorAnimationIKCorrectionGoal()
        {
        }
    }
}
