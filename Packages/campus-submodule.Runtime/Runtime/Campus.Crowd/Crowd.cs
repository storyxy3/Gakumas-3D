namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::UnityEngine.Rendering;

    [Serializable]
    [VolumeComponentMenu("Campus/群衆システム")]
    public class Crowd : VolumeComponent
    {
        public CrowdVolumeParameter target = new CrowdVolumeParameter(null);
        public Vector3Parameter occlusionPosition = new Vector3Parameter(global::UnityEngine.Vector3.zero);
        public FloatParameter occlusionRadius = new FloatParameter(-1000f);
        public ClampedIntParameter drawDetailCount = new ClampedIntParameter(1024, 0, 32768);
        public MinFloatParameter heightOcclusionStart = new MinFloatParameter(0.6f, 0f);
        public ClampedFloatParameter heightOcclusionMin = new ClampedFloatParameter(0f, 0f, 1f);
        public BillboardQualityParameter billboardQuality = new BillboardQualityParameter(BillboardQuality.RES_32);
        public Crowd()
        {
        }
    }
}
