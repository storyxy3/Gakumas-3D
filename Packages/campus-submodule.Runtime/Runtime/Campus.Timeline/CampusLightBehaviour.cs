namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Common;
    using global::JetBrains.Annotations;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusLightBehaviour : PlayableBehaviour
    {
        [SerializeField]
        private ExposedReference<Transform> _anchorReference;
        [NonSerialized]
        [CanBeNull]
        public Transform anchor;
        public bool controlTransform = true;
        public Vector3 anchorOffset;
        public float yaw;
        public float pitch = 90f;
        public float roll;
        [Min(0f)]
        public float distance = 5f;
        public bool useCamera;
        public CampusTransformAnchor.UpDirection upDirection;
        [ColorUsage(false)]
        public Color color = Color.white;
        public float intensity = 20f;
        public float range = 10f;
        public bool useShadow;
        [Range(0f, 1f)]
        public float shadowStrength;
        [Range(0f, 180f)]
        public float spotAngle = 45f;
        [Range(0f, 1f)]
        public float innerSpotAngleRatio = 0.5f;
        public override void OnPlayableCreate(Playable playable)
        {
            anchor = _anchorReference.Resolve(playable.GetGraph().GetResolver());
        }

        public CampusLightBehaviour()
        {
        }
    }
}
