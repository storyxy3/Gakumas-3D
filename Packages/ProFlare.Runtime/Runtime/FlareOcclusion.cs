using global::System;

[Serializable]
public class FlareOcclusion
{
    public enum CullingState
    {
        Visible,
        CullCountDown,
        CanCull,
        Culled,
        NeverCull
    }

    public bool occluded;
    public float occlusionScale;
    public float occlusionBrigtness;
    public float occlusionTarget;
    public CullingState _CullingState;
    public float CullTimer;
    public float cullFader;
    public FlarePixelOcclusion flarePixelOcclusion;
    public FlareOcclusion()
    {
    }
}
