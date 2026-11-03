namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Collections;
    using global::UnityEngine.Animations;

    public static class ActorAnimationQuartzDriverUtility
    {
        public static void ProcessQuartzDriverParts<TDriver, TBone>(this TDriver driver, AnimationStream stream, NativeArray<TBone> list)
            where TDriver : struct, IActorAnimation where TBone : struct, IActorAnimationQuartzDriverJobBone
        {
        }
    }
}
