namespace Campus.Common
{
    using global::Campus.Common;
    using global::JetBrains.Annotations;
    using global::UnityEngine;
    using global::VLB;

    [RequireComponent(typeof(Light))]
    public class CampusLightAnchor : CampusLightAnchorBase
    {
        [CanBeNull]
        public Light targetLight;
        private VolumetricLightBeamSD _volumetricLightBeam;
        private void OnEnable()
        {
            if (_volumetricLightBeam == null && TryGetComponent<global::VLB.VolumetricLightBeamSD>(out var beam)) _volumetricLightBeam = beam;
        }

        public override void SetColor(Color value)
        {
            if (targetLight != null) targetLight.color = value;
        }

        public override void SetIntensity(float value)
        {
            if (targetLight != null) targetLight.intensity = value;
        }

        public override void SetRange(float value)
        {
            if (targetLight != null) targetLight.range = value;
        }

        public override void SetShadow(LightShadows value)
        {
            bool hadShadows = false;
            if (targetLight != null)
            {
                hadShadows = targetLight.shadows != LightShadows.None;
                targetLight.shadows = value;
            }
            if (value != LightShadows.None && !hadShadows && _volumetricLightBeam != null)
            {
                _volumetricLightBeam.enabled = false;
                _volumetricLightBeam.enabled = true;
            }
        }

        public override void SetShadowStrength(float value)
        {
            if (targetLight != null) targetLight.shadowStrength = value;
        }

        public override void SetSpotAngle(float value)
        {
            if (targetLight != null) targetLight.spotAngle = value;
        }

        public override void SetInnerSpotAngle(float value)
        {
            if (targetLight != null) targetLight.innerSpotAngle = value;
        }

        public CampusLightAnchor()
        {
        }
    }
}
