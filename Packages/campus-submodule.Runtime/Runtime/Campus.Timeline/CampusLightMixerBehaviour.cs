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
            int count = playable.GetInputCount();
            TransformInfo transformInfo = default;
            LightInfo lightInfo = default;
            for (int i = 0; i < count; i++)
            {
                float weight = playable.GetInputWeight(i);
                var behaviour = ((ScriptPlayable<CampusLightBehaviour>)playable.GetInput(i)).GetBehaviour();
                CalculateTransformInfo(ref transformInfo, behaviour, weight);
                CalculateLightInfo(ref lightInfo, behaviour, weight);
            }
            ApplyTransformInfo(ref transformInfo);
            ApplyLightInfo(ref lightInfo);
        }

        private void CalculateTransformInfo(ref TransformInfo info, CampusLightBehaviour behaviour, float weight)
        {
            info.yaw += behaviour.yaw * weight;
            info.pitch += behaviour.pitch * weight;
            info.roll += behaviour.roll * weight;
            info.anchorOffset += behaviour.anchorOffset * weight;
            info.distance += behaviour.distance * weight;
            if (weight > 0f)
            {
                info.upDirection = behaviour.upDirection;
                info.anchor = behaviour.anchor;
                info.useCamera = behaviour.useCamera;
                info.enable = behaviour.controlTransform;
            }
        }

        private void CalculateLightInfo(ref LightInfo info, CampusLightBehaviour behaviour, float weight)
        {
            if (weight == 0f) return;
            info.color += behaviour.color * weight;
            info.intensity += behaviour.intensity * weight;
            info.shadowStrength += behaviour.shadowStrength * weight;
            info.range += behaviour.range * weight;
            info.spotAngle += behaviour.spotAngle * weight;
            info.innerSpotAngleRatio += behaviour.innerSpotAngleRatio * weight;
            if (weight > 0f) info.useShadow = behaviour.useShadow;
        }

        private void ApplyTransformInfo(ref TransformInfo info)
        {
            if (transformAnchor == null) return;
            transformAnchor.SetAnchorActive(info.enable);
            transformAnchor.SetYaw(info.yaw);
            transformAnchor.SetPitch(info.pitch);
            transformAnchor.SetRoll(info.roll);
            transformAnchor.SetAnchorOffset(info.anchorOffset);
            transformAnchor.SetUpDirection(info.upDirection);
            transformAnchor.SetUseCamera(info.useCamera);
            transformAnchor.SetDistance(info.distance);
            if (transformAnchor is ICampusTransformAnchorTarget target) target.SetTarget(info.anchor);
        }

        private void ApplyLightInfo(ref LightInfo info)
        {
            if (lightAnchor == null) return;
            lightAnchor.SetColor(info.color);
            lightAnchor.SetIntensity(info.intensity);
            lightAnchor.SetRange(info.range);
            lightAnchor.SetShadow(info.useShadow ? LightShadows.Soft : LightShadows.None);
            lightAnchor.SetShadowStrength(info.shadowStrength);
            lightAnchor.SetSpotAngle(info.spotAngle);
            lightAnchor.SetInnerSpotAngle(info.innerSpotAngleRatio * info.spotAngle);
        }

        public CampusLightMixerBehaviour()
        {
        }
    }
}
