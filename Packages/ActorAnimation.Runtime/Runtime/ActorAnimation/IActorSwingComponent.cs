namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    public interface IActorSwingComponent : IActorAnimationBone
    {
        bool isActiveAndEnabled { get; }

        Transform transform { get; }
    }
}
