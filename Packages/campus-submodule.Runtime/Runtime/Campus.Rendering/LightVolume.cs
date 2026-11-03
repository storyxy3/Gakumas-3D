namespace Campus.Rendering
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.Rendering;

    [ExecuteAlways]
    public class LightVolume : Volume
    {
        public Color actorLightColor;
        [Min(0f)]
        public float actorIntensity;
        [Range(0f, 1f)]
        public float actorGIScale;
        public Color environmentColor;
        [Min(0f)]
        public float environmentIntensity;
        private VLActorParameter _actorParameter;
        private VLLightmapVolume _lightmapVolume;
        private void OnDestroy()
        {
        }

        private void LateUpdate()
        {
        }

        public LightVolume()
        {
        }
    }
}
