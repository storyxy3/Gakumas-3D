namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine.Animations;

    public static class CampusActorAnimationJointLimitUtility
    {
        public static void ProcessJointLimit<TJointLimitJob>(this TJointLimitJob jointLimitJob, AnimationStream stream, ref CampusActorAnimationJointLimit jointLimit)
            where TJointLimitJob : struct, ICampusActorAnimationJointLimit
        {
        }
    }
}
