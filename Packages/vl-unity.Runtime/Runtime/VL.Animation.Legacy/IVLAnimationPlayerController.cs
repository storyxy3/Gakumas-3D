namespace VL.Animation.Legacy
{
    using global::VL.Animation;
    using global::VL.Animation.Legacy;

    public interface IVLAnimationPlayerController : IAnimationController
    {
        void RegisterPrepareFrameEvent(VLAnimationClipParamMixerPlayable.PrepareFrameEvent onLayerPrepareFrameEvent);
        void UnregisterPrepareFrameEvent(VLAnimationClipParamMixerPlayable.PrepareFrameEvent onLayerPrepareFrameEvent);
    }
}
