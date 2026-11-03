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
                    return default(Matrix4x4);
                }
            }

            public Matrix4x4 viewMatrix
            {
                get
                {
                    return default(Matrix4x4);
                }
            }
        }

        [SerializeField]
        private MultiCameraData[] _cameraDatas;
        public void SetCameraData(int index, CinemachineVirtualCamera virtualCamera, MeshRenderer maskRenderer, bool useOffset)
        {
        }

        public void ClearCameraData(int index)
        {
        }

        public MultiCameraData GetCameraData(int index)
        {
            return default(MultiCameraData);
        }

        public VLMultiCamera()
        {
        }
    }
}
