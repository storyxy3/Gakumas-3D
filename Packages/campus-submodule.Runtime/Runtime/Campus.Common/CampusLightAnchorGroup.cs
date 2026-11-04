namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;

    public class CampusLightAnchorGroup : CampusLightAnchorBase
    {
        [SerializeField]
        private CampusLightAnchor[] _lightAnchors = global::System.Array.Empty<CampusLightAnchor>();
        public CampusLightAnchor[] LightAnchors
        {
            get
            {
                return _lightAnchors;
            }
        }

        private void OnValidate()
        {
            if (global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(_lightAnchors)) _lightAnchors = GetComponentsInChildren<CampusLightAnchor>();
        }

        public override void SetColor(Color value)
        {
            foreach (var anchor in _lightAnchors) anchor.SetColor(value);
        }

        public override void SetIntensity(float value)
        {
            foreach (var anchor in _lightAnchors) anchor.SetIntensity(value);
        }

        public override void SetRange(float value)
        {
            foreach (var anchor in _lightAnchors) anchor.SetRange(value);
        }

        public override void SetShadow(LightShadows value)
        {
            foreach (var anchor in _lightAnchors) anchor.SetShadow(value);
        }

        public override void SetShadowStrength(float value)
        {
            foreach (var anchor in _lightAnchors) anchor.SetShadowStrength(value);
        }

        public override void SetSpotAngle(float value)
        {
            foreach (var anchor in _lightAnchors) anchor.SetSpotAngle(value);
        }

        public override void SetInnerSpotAngle(float value)
        {
            foreach (var anchor in _lightAnchors) anchor.SetInnerSpotAngle(value);
        }

        public CampusLightAnchorGroup()
        {
        }
    }
}
