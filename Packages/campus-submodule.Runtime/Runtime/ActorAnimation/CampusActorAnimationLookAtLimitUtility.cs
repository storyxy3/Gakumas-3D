namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine.Animations;

    public static class CampusActorAnimationLookAtLimitUtility
    {
        public static void ProcessLookAtLimit<TDriver>(this TDriver driver, AnimationStream stream, ref CampusActorAnimationLookAtLimit lookAtLimit)
            where TDriver : struct, ICampusActorAnimationLookAtLimit
        {
        }
    }
}
