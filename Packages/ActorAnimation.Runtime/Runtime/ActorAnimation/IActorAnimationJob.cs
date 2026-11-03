namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    public interface IActorAnimationJob : IWeightedAnimationJob, IAnimationJob, IActorAnimation
    {
        void Create<TData>(Animator animator, ref TData rigData)
            where TData : struct, IActorAnimationRigData;
        void UpdateRigData<TData>(ref TData rigData)
            where TData : struct, IActorAnimationRigData;
        void UpdateConstraintSource<TData>(ref TData rigData, Animator animator)
            where TData : struct, IActorAnimationRigData;
        void UpdateManageProperty(ActorAnimationManageProperty manageProperty);
        void Destroy();
    }
}
