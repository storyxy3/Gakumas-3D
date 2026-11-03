namespace Campus.Common
{
    using global::UnityEngine;

    public interface ICampusLightAnchor
    {
        void SetColor(Color value);
        void SetIntensity(float value);
        void SetRange(float value);
        void SetShadow(LightShadows value);
        void SetShadowStrength(float value);
        void SetSpotAngle(float value);
        void SetInnerSpotAngle(float value);
    }
}
