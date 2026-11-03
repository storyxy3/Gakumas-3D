namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine.Animations;

    public static class ActorAnimationRootControllerUtility
    {
        public static void ProcessRoot<TDriver>(this TDriver driver, AnimationStream stream, ref ActorAnimationRootControllerJobLocator rootLocator)
            where TDriver : struct, IActorAnimation
        {
        }
    }
}
