namespace VL.Animation.Legacy
{
    using global::VL.Animation;
    using global::VL.Animation.Legacy;

    public interface IVLAnimationClipPlayer : IAnimationPlayer
    {
        IVLAnimationPlayerController GetAnimationController(VLAnimationClipPlayerParam param);
    }
}
