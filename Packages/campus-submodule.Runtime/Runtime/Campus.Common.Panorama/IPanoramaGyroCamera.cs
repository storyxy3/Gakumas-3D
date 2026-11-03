namespace Campus.Common.Panorama
{
    using global::System;
    using global::UnityEngine;

    public interface IPanoramaGyroCamera
    {
        Func<Vector3> GetGyroParameterFunc { get; set; }

        void OnGyroStatusChanged(bool isGyro);
        void ResetGyroParameter();
        void ResetAngle();
    }
}
