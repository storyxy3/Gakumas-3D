namespace Campus.Rendering
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.Rendering;

    [ExecuteAlways]
    public class SphereFogVolume : Volume
    {
        public Vector3 position;
        [Min(0f)]
        public float radius;
        [Range(0f, 1f)]
        public float maxAmount;
        public Color color;
        private VLDensityFogVolume _densityFog;
        private void OnDestroy()
        {
        }

        private void LateUpdate()
        {
        }

        public SphereFogVolume()
        {
        }
    }
}
