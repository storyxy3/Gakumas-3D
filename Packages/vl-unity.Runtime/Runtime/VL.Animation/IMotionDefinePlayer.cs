namespace VL.Animation
{
    using global::VL.Animation;

    public interface IMotionDefinePlayer : IAnimationPlayer
    {
        event PrepareFrameEvent onPrepareFrameEvent;
        ILayerAnimationController CreateLayerController(LayerParam param);
    }
}
