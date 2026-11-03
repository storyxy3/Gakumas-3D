namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;

    public interface ICampusTransformAnchor
    {
        void SetAnchorActive(bool value);
        void SetAnchorOffset(Vector3 value);
        void SetYaw(float value);
        void SetPitch(float value);
        void SetRoll(float value);
        void SetDistance(float value);
        void SetUseCamera(bool value);
        void SetUpDirection(CampusTransformAnchor.UpDirection value);
    }
}
