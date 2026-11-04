namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine.Animations;

    public static class ActorAnimationSwingSkeletonUtility
    {
        public static void ProcessSwingSkeleton<TDriver>(this TDriver driver, AnimationStream stream, ref ActorAnimationSwingJobSkeleton swingJobSkeleton)
            where TDriver : struct, IActorAnimationSwingSkeleton
        {
            swingJobSkeleton.Execute(stream);
        }
    }
}
