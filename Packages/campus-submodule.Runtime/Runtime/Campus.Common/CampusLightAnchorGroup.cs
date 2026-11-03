namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;

    public class CampusLightAnchorGroup : CampusLightAnchorBase
    {
        [SerializeField]
        private CampusLightAnchor[] _lightAnchors;
        public CampusLightAnchor[] LightAnchors
        {
            get
            {
                return null;
            }
        }

        private void OnValidate()
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

        public CampusLightAnchorGroup()
        {
        }
    }
}
