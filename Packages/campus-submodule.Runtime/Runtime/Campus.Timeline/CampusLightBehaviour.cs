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
        public bool controlTransform;
        public Vector3 anchorOffset;
        public float yaw;
        public float pitch;
        public float roll;
        [Min(0f)]
        public float distance;
        public bool useCamera;
        public CampusTransformAnchor.UpDirection upDirection;
        [ColorUsage(false)]
        public Color color;
        public float intensity;
        public float range;
        public bool useShadow;
        [Range(0f, 1f)]
        public float shadowStrength;
        [Range(0f, 180f)]
        public float spotAngle;
        [Range(0f, 1f)]
        public float innerSpotAngleRatio;
        public override void OnPlayableCreate(Playable playable)
        {
        }

        public CampusLightBehaviour()
        {
        }
    }
}
