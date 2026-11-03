namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class CrowdOcclusionVolume : Volume
    {
        [Min(0f)]
        public float radius;
        [NonSerialized]
        private Crowd _crowd;
        private void LateUpdate()
        {
        }

        private void OnDestroy()
        {
        }

        private void UpdateParameters()
        {
        }

        public CrowdOcclusionVolume()
        {
        }
    }
}
