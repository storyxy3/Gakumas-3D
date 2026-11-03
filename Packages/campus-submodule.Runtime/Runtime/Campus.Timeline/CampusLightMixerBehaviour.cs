namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Common;
    using global::Campus.Timeline;
    using global::JetBrains.Annotations;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class CampusLightMixerBehaviour : PlayableBehaviour
    {
        private struct TransformInfo
        {
            public bool enable;
            public Transform anchor;
            public Vector3 anchorOffset;
            public float yaw;
            public float pitch;
            public float roll;
            [Min(0f)]
            public float distance;
            public bool useCamera;
            public CampusTransformAnchor.UpDirection upDirection;
        }

        private struct LightInfo
        {
            public Color color;
            public float intensity;
            public float range;
            public bool useShadow;
            public float spotAngle;
            public float innerSpotAngleRatio;
            [Range(0f, 1f)]
            public float shadowStrength;
        }

        [NonSerialized]
        [CanBeNull]
        public ICampusTransformAnchor transformAnchor;
        [NonSerialized]
        [CanBeNull]
        public ICampusLightAnchor lightAnchor;
        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        private void CalculateTransformInfo(ref TransformInfo info, CampusLightBehaviour behaviour, float weight)
        {
        }

        private void CalculateLightInfo(ref LightInfo info, CampusLightBehaviour behaviour, float weight)
        {
        }

        private void ApplyTransformInfo(ref TransformInfo info)
        {
        }

        private void ApplyLightInfo(ref LightInfo info)
        {
        }

        public CampusLightMixerBehaviour()
        {
        }
    }
}
