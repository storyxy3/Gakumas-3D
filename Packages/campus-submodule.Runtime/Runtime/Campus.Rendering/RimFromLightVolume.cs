namespace Campus.Rendering
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.Rendering;

    [ExecuteAlways]
    public class RimFromLightVolume : Volume
    {
        public Light TargetLight;
        public float ColorScale;
        private VLActorParameter _srpCamera;
        private Color _prevColor;
        private float _prevColorScale;
        private void LateUpdate()
        {
        }

        private void OnDestroy()
        {
        }

        public RimFromLightVolume()
        {
        }
    }
}
