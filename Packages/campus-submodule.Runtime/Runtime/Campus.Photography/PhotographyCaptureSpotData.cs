namespace Campus.Photography
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class PhotographyCaptureSpotData
    {
        [SerializeField]
        private Vector3 _cameraPosition;
        [SerializeField]
        private Vector3 _cameraRotation;
        [SerializeField]
        private float _cameraFocalLength;
        public PhotographyCaptureSpotData()
        {
        }
    }
}
