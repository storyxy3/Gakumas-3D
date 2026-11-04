namespace VL.Rendering
{
    using global::System;
    using global::Cinemachine;
    using global::UnityEngine;
    using global::VL.Rendering;

    [RequireComponent(typeof(Camera))]
    public class VLMultiCamera : MonoBehaviour
    {
        [Serializable]
        public struct MultiCameraData
        {
            public bool useOffset;
            public CinemachineVirtualCamera camera;
            public MeshRenderer maskRenderer;
            public Matrix4x4 projectionMatrix
            {
                get
                {
                    if (camera == null || !VLSRPCameraController.HasInstance) return Matrix4x4.identity;
                    var lens = camera.m_Lens;
                    float fov = lens.IsPhysicalCamera ? lens.FocalLengthToVerticalFOV() : lens.FieldOfView;
                    return Matrix4x4.Perspective(fov, VLSRPCameraController.Instance.mainCamera.aspect, lens.NearClipPlane, lens.FarClipPlane);
                }
            }

            public Matrix4x4 viewMatrix
            {
                get
                {
                    if (camera == null) return Matrix4x4.identity;
                    return Matrix4x4.Scale(new Vector3(1f, 1f, -1f)) * camera.transform.worldToLocalMatrix;
                }
            }
        }

        [SerializeField]
        private MultiCameraData[] _cameraDatas;
        public void SetCameraData(int index, CinemachineVirtualCamera virtualCamera, MeshRenderer maskRenderer, bool useOffset)
        {
            if (index < 0 || index >= DrawMultiCameraPass.MaxMultiCamera)
                throw new ArgumentOutOfRangeException(string.Format("{0} < 0 || {1} >= VLSRPDefine.MaxMultiCamera", index, index));
            if (_cameraDatas == null) _cameraDatas = new MultiCameraData[index + 1];
            if (_cameraDatas.Length <= index) Array.Resize(ref _cameraDatas, index + 1);
            _cameraDatas[index] = new MultiCameraData { useOffset = useOffset, camera = virtualCamera, maskRenderer = maskRenderer };
        }

        public void ClearCameraData(int index)
        {
            if (index < 0 || index >= DrawMultiCameraPass.MaxMultiCamera)
                throw new ArgumentOutOfRangeException(string.Format("{0} < 0 || {1} >= VLSRPDefine.MaxMultiCamera", index, index));
            if (_cameraDatas != null && index < _cameraDatas.Length) _cameraDatas[index] = default;
        }

        public MultiCameraData GetCameraData(int index)
        {
            if (index < 0 || _cameraDatas == null || index >= _cameraDatas.Length) return default;
            return _cameraDatas[index];
        }

        public VLMultiCamera()
        {
        }
    }
}
