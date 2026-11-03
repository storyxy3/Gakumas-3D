namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Collections;
    using global::UnityEngine.Animations;

    public static class ActorAnimationConstraintUtility
    {
        public static void ProcessConstraintParts<TDriver, TBone>(this TDriver driver, AnimationStream stream, NativeArray<TBone> list)
            where TDriver : struct, IActorAnimation where TBone : struct, IActorAnimationConstraintJobBone
        {
        }
    }
}
