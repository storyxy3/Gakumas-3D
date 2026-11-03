namespace ActorAnimation
{
    using global::ActorAnimation;

    public interface IActorSwingBone : IActorSwingComponent, IActorAnimationBone
    {
        ActorSwingCollider swingCollider { get; }
    }
}
