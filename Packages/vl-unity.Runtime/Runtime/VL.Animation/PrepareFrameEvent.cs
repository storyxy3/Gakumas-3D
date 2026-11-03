namespace VL.Animation
{
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    public delegate void PrepareFrameEvent(LayerParam layerParam, ClipParam clipParam, double currentTime, in FrameData info);
}
