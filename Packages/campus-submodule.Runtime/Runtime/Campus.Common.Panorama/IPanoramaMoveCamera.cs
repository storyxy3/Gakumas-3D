namespace Campus.Common.Panorama
{
    using global::Campus.Common;
    using global::UnityEngine;

    public interface IPanoramaMoveCamera
    {
        void RequestAddAngle(Vector3 diffAngle);
        void ResetAngle();
        void RequestAddPosition(Vector3 diffPosition);
        void SetAutoLookEnable(bool isEnable);
        void SetAutoLookTarget(ICampusActorController target);
        void AddAutoLookAdjustAngle(Vector3 angle);
    }
}
