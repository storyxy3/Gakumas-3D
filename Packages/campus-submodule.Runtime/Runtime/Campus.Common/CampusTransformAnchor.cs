namespace Campus.Common
{
    using global::Campus.Common;
    using global::Cinemachine;
    using global::JetBrains.Annotations;
    using global::UnityEngine;

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class CampusTransformAnchor : MonoBehaviour, ICampusTransformAnchorTarget, ICampusTransformAnchor
    {
        private struct Axes
        {
            public Vector3 up;
            public Vector3 right;
            public Vector3 forward;
        }

        public enum UpDirection
        {
            World,
            Local
        }

        public bool anchorActive;
        [CanBeNull]
        public Transform anchor;
        public Vector3 anchorOffset;
        public float yaw;
        public float pitch;
        public float roll;
        [Min(0f)]
        public float distance;
        public bool useCamera;
        public UpDirection upDirection;
        private Vector3 AnchorPosition
        {
            get
            {
                return default(Vector3);
            }
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public void SetAnchorActive(bool value)
        {
        }

        public void SetAnchorOffset(Vector3 value)
        {
        }

        public void SetYaw(float value)
        {
        }

        public void SetPitch(float value)
        {
        }

        public void SetRoll(float value)
        {
        }

        public void SetDistance(float value)
        {
        }

        public void SetUseCamera(bool value)
        {
        }

        public void SetUpDirection(UpDirection value)
        {
        }

        public void SetTarget(Transform target)
        {
        }

        private void OnCinemachineCameraUpdated(CinemachineBrain arg0)
        {
        }

        private Axes GetCameraBasedAxes(Camera cam, Vector3 anchorPosition)
        {
            return default(Axes);
        }

        private void LateUpdate()
        {
        }

        private void UpdateTransform(Axes axes)
        {
        }

        public CampusTransformAnchor()
        {
        }
    }
}
