namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class CrowdVolume : Volume
    {
        [SerializeField]
        public CrowdModelData modelData;
        [SerializeField]
        public CrowdData crowdData;
        [SerializeField]
        public CrowdColorPreset colorPreset;
        [SerializeField]
        public Transform lookAtTarget;
        [SerializeField]
        [Range(0f, 1f)]
        public float randomLookAtWeight;
        [NonSerialized]
        private Crowd _crowd;
        [NonSerialized]
        private ICrowdAnimation _animation;
        [NonSerialized]
        private ICrowdPenlight _crowdPenlight;
        public Vector3 Position
        {
            get
            {
                return default(Vector3);
            }
        }

        public ICrowdAnimation AnimationComponent
        {
            get
            {
                return null;
            }
        }

        public ICrowdPenlight CrowdPenlight
        {
            get
            {
                return null;
            }
        }

        public Crowd Crowd
        {
            get
            {
                return null;
            }
        }

        public void BuildHierarchy()
        {
        }

        private void LateUpdate()
        {
        }

        private void OnDestroy()
        {
        }

        private void UpdateParameters()
        {
        }

        public CrowdVolume()
        {
        }
    }
}
