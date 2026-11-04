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
            UpdateParameters();
        }

        private void OnDestroy()
        {
            if (_crowd != null) UnityEngine.Object.DestroyImmediate(_crowd);
            UnityEngine.Object.DestroyImmediate(profile);
        }

        private void UpdateParameters()
        {
            if (_crowd == null && !profile.TryGet(out _crowd)) _crowd = profile.Add<Crowd>();
            _crowd.occlusionRadius.Override(radius);
            _crowd.occlusionPosition.Override(transform.position);
        }

        public CrowdOcclusionVolume()
        {
        }
    }
}
