namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine.Animations;

    public struct ActorAnimationFullbodyIKSimpleJob : IAnimationJob, IActorAnimationFullBodyIK
    {
        private ActorAnimationFullBodyIKJobSkeleton _fullBodyIKJobSkeleton;
        public ActorAnimationFullBodyIKJobSkeleton fullBodyIKJobSkeleton
        {
            set
            {
            }
        }

        public void ProcessAnimation(AnimationStream stream)
        {
        }

        public void ProcessRootMotion(AnimationStream stream)
        {
        }
    }
}
