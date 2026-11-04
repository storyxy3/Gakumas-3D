namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine.Animations;

    public static class ActorAnimationFullBodyIKUtility
    {
        public static void ProcessFullBodyIK<TDriver>(this TDriver driver, AnimationStream stream, ref ActorAnimationFullBodyIKJobSkeleton fullBodyIKJobSkeleton)
            where TDriver : struct, IActorAnimationFullBodyIK
        {
            fullBodyIKJobSkeleton.Execute(stream);
        }
    }
}
