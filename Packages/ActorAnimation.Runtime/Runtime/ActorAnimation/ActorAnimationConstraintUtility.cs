namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Collections;
    using global::Unity.Collections.LowLevel.Unsafe;
    using global::UnityEngine.Animations;

    public static class ActorAnimationConstraintUtility
    {
        public static unsafe void ProcessConstraintParts<TDriver, TBone>(this TDriver driver, AnimationStream stream, NativeArray<TBone> list)
            where TDriver : struct, IActorAnimation where TBone : struct, IActorAnimationConstraintJobBone
        {
            void* bones = list.GetUnsafeReadOnlyPtr();
            for (int i = 0; i < list.Length; i++)
            {
                ref var bone = ref UnsafeUtility.ArrayElementAsRef<TBone>(bones, i);
                if (bone.IsActive && bone.IsValid(stream) && bone.Resolve(stream))
                    bone.Execute(stream);
            }
        }
    }
}
