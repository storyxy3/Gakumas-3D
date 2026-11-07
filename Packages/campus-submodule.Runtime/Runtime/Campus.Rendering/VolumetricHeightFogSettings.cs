namespace Campus.Rendering
{
    using global::System;
    using global::Campus.Rendering;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;
    using global::UnityEngine.Serialization;

    [Serializable]
    public class VolumetricHeightFogSettings
    {
        [FormerlySerializedAs("mask")]
        public LayerMask Mask;
        public bool Hdr;
        [Range(0f, 3f)]
        public int Downsample = 1;
        public VolumetricHeightFogRaymarchMode RaymarchMode;
        public MsaaQuality Msaa = MsaaQuality.Disabled;
        public VolumetricHeightFogSettings()
        {
        }
    }
}
