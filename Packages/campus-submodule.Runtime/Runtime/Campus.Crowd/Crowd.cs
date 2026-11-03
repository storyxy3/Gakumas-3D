namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::UnityEngine.Rendering;

    [Serializable]
    [VolumeComponentMenu("Campus/群衆システム")]
    public class Crowd : VolumeComponent
    {
        public CrowdVolumeParameter target;
        public Vector3Parameter occlusionPosition;
        public FloatParameter occlusionRadius;
        public ClampedIntParameter drawDetailCount;
        public MinFloatParameter heightOcclusionStart;
        public ClampedFloatParameter heightOcclusionMin;
        public BillboardQualityParameter billboardQuality;
        public Crowd()
        {
        }
    }
}
