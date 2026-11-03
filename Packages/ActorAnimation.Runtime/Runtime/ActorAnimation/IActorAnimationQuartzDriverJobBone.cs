namespace ActorAnimation
{
    using global::UnityEngine.Animations;

    public interface IActorAnimationQuartzDriverJobBone
    {
        bool IsActive { get; }

        bool IsValid(AnimationStream stream);
        bool Resolve(AnimationStream stream);
        void Execute(AnimationStream stream);
    }
}
