namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;

    public abstract class CampusLightAnchorBase : MonoBehaviour, ICampusLightAnchor
    {
        public abstract void SetColor(Color value);
        public abstract void SetIntensity(float value);
        public abstract void SetRange(float value);
        public abstract void SetShadow(LightShadows value);
        public abstract void SetShadowStrength(float value);
        public abstract void SetSpotAngle(float value);
        public abstract void SetInnerSpotAngle(float value);
        protected CampusLightAnchorBase()
        {
        }
    }
}
