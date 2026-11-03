namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::UnityEngine.Rendering;

    [Serializable]
    public sealed class BillboardQualityParameter : VolumeParameter<BillboardQuality>
    {
        public BillboardQualityParameter(BillboardQuality value, bool overrideState = false)
        {
        }
    }
}
