namespace VL.Animation
{
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    public interface IMotionDefinePlayerEvent
    {
        void InvokePlayEvent(LayerParam layerParam, ClipParam clipParam, in FrameData info);
        void InvokePrepareFrameEvent(LayerParam layerParam, ClipParam clipParam, double currentTime, in FrameData info);
    }
}
