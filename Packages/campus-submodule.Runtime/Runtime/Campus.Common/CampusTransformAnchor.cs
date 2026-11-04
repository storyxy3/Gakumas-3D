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
                return anchor != null ? anchor.transform.position + anchorOffset : Vector3.zero;
            }
        }

        private void OnEnable()
        {
            CinemachineCore.CameraUpdatedEvent.AddListener(OnCinemachineCameraUpdated);
        }

        private void OnDisable()
        {
            CinemachineCore.CameraUpdatedEvent.RemoveListener(OnCinemachineCameraUpdated);
        }

        public void SetAnchorActive(bool value)
        {
            anchorActive = value;
        }

        public void SetAnchorOffset(Vector3 value)
        {
            anchorOffset = value;
        }

        public void SetYaw(float value)
        {
            yaw = value;
        }

        public void SetPitch(float value)
        {
            pitch = value;
        }

        public void SetRoll(float value)
        {
            roll = value;
        }

        public void SetDistance(float value)
        {
            distance = value;
        }

        public void SetUseCamera(bool value)
        {
            useCamera = value;
        }

        public void SetUpDirection(UpDirection value)
        {
            upDirection = value;
        }

        public void SetTarget(Transform target)
        {
            anchor = target;
        }

        private void OnCinemachineCameraUpdated(CinemachineBrain arg0)
        {
            if (!useCamera) return;
            var camera = arg0.OutputCamera;
            if (camera == null || !global::VL.VLCameraController.HasInstance || camera != global::VL.VLCameraController.Instance.mainCamera) return;
            UpdateTransform(GetCameraBasedAxes(camera, AnchorPosition));
        }

        private Axes GetCameraBasedAxes(Camera cam, Vector3 anchorPosition)
        {
            if (transform.IsChildOf(cam.transform))
                return new Axes { up = Vector3.up, right = Vector3.right, forward = Vector3.forward };
            var matrix = cam.cameraToWorldMatrix;
            if (!cam.orthographic && (cam.transform.position - anchorPosition).sqrMagnitude >= 1e-10f)
            {
                var direction = (anchorPosition - cam.transform.position).normalized;
                var rotation = Quaternion.LookRotation(direction, upDirection == UpDirection.Local ? cam.transform.up : Vector3.up);
                matrix = Matrix4x4.Scale(new Vector3(1f, 1f, -1f)) * Matrix4x4.TRS(cam.transform.position, rotation, Vector3.one).inverse;
                matrix = matrix.inverse;
            }
            var axes = new Axes
            {
                up = (matrix * (Vector4)Vector3.up).normalized,
                right = (matrix * (Vector4)Vector3.right).normalized,
                forward = (matrix * (Vector4)Vector3.forward).normalized
            };
            if (upDirection == UpDirection.Local) axes.up = cam.transform.up.normalized;
            return axes;
        }

        private void LateUpdate()
        {
            if (!useCamera) UpdateTransform(new Axes { up = Vector3.up, right = Vector3.right, forward = Vector3.back });
        }

        private void UpdateTransform(Axes axes)
        {
            if (!anchorActive) return;
            var yawRotation = Quaternion.AngleAxis(yaw, axes.up);
            var pitchRotation = Quaternion.AngleAxis(pitch, axes.right);
            var position = AnchorPosition + (yawRotation * pitchRotation * axes.forward) * distance;
            transform.position = position;
            var angles = Quaternion.LookRotation(-(yawRotation * pitchRotation * axes.forward).normalized, axes.up).eulerAngles;
            angles.z = roll;
            transform.eulerAngles = angles;
        }

        public CampusTransformAnchor()
        {
        }
    }
}
