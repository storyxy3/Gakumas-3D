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
        }

        public override void SetColor(Color value)
        {
        }

        public override void SetIntensity(float value)
        {
        }

        public override void SetRange(float value)
        {
        }

        public override void SetShadow(LightShadows value)
        {
        }

        public override void SetShadowStrength(float value)
        {
        }

        public override void SetSpotAngle(float value)
        {
        }

        public override void SetInnerSpotAngle(float value)
        {
        }

        public CampusLightAnchor()
        {
        }
    }
}
