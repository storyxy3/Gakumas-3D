namespace AmplifyOcclusion
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class AmplifyOcclusionViewProjMatrix
    {
        private Matrix4x4 m_prevViewProjMatrixLeft = Matrix4x4.identity;
        private Matrix4x4 m_prevInvViewProjMatrixLeft = Matrix4x4.identity;
        private Matrix4x4 m_prevViewProjMatrixRight = Matrix4x4.identity;
        private Matrix4x4 m_prevInvViewProjMatrixRight = Matrix4x4.identity;
        public void UpdateGlobalShaderConstants_Matrices(CommandBuffer cb, Camera aCamera, bool isUsingTemporalFilter)
        {
            if (AmplifyOcclusionCommon.IsStereoSinglePassEnabled(aCamera))
            {
                Matrix4x4 viewLeft = aCamera.GetStereoViewMatrix(Camera.StereoscopicEye.Left);
                Matrix4x4 viewRight = aCamera.GetStereoViewMatrix(Camera.StereoscopicEye.Right);
                cb.SetGlobalMatrix(PropertyID._AO_CameraViewLeft, viewLeft);
                cb.SetGlobalMatrix(PropertyID._AO_CameraViewRight, viewRight);
                Matrix4x4 projectionMatrixLeft = aCamera.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left);
                Matrix4x4 projectionMatrixRight = aCamera.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
                Matrix4x4 projLeft = GL.GetGPUProjectionMatrix(projectionMatrixLeft, false);
                Matrix4x4 projRight = GL.GetGPUProjectionMatrix(projectionMatrixRight, false);
                cb.SetGlobalMatrix(PropertyID._AO_ProjMatrixLeft, projLeft);
                cb.SetGlobalMatrix(PropertyID._AO_ProjMatrixRight, projRight);
                if (isUsingTemporalFilter)
                {
                    Matrix4x4 viewProjMatrixLeft = projLeft * viewLeft;
                    Matrix4x4 viewProjMatrixRight = projRight * viewRight;
                    Matrix4x4 invViewProjMatrixLeft = Matrix4x4.Inverse(viewProjMatrixLeft);
                    Matrix4x4 invViewProjMatrixRight = Matrix4x4.Inverse(viewProjMatrixRight);
                    cb.SetGlobalMatrix(PropertyID._AO_InvViewProjMatrixLeft, invViewProjMatrixLeft);
                    cb.SetGlobalMatrix(PropertyID._AO_PrevViewProjMatrixLeft, m_prevViewProjMatrixLeft);
                    cb.SetGlobalMatrix(PropertyID._AO_PrevInvViewProjMatrixLeft, m_prevInvViewProjMatrixLeft);
                    cb.SetGlobalMatrix(PropertyID._AO_InvViewProjMatrixRight, invViewProjMatrixRight);
                    cb.SetGlobalMatrix(PropertyID._AO_PrevViewProjMatrixRight, m_prevViewProjMatrixRight);
                    cb.SetGlobalMatrix(PropertyID._AO_PrevInvViewProjMatrixRight, m_prevInvViewProjMatrixRight);
                    m_prevViewProjMatrixLeft = viewProjMatrixLeft;
                    m_prevInvViewProjMatrixLeft = invViewProjMatrixLeft;
                    m_prevViewProjMatrixRight = viewProjMatrixRight;
                    m_prevInvViewProjMatrixRight = invViewProjMatrixRight;
                }
            }
            else
            {
                Matrix4x4 view = aCamera.worldToCameraMatrix;
                cb.SetGlobalMatrix(PropertyID._AO_CameraViewLeft, view);
                if (isUsingTemporalFilter)
                {
                    Matrix4x4 proj = GL.GetGPUProjectionMatrix(aCamera.projectionMatrix, false);
                    Matrix4x4 viewProjMatrix = proj * view;
                    Matrix4x4 invViewProjMatrix = Matrix4x4.Inverse(viewProjMatrix);
                    cb.SetGlobalMatrix(PropertyID._AO_InvViewProjMatrixLeft, invViewProjMatrix);
                    cb.SetGlobalMatrix(PropertyID._AO_PrevViewProjMatrixLeft, m_prevViewProjMatrixLeft);
                    cb.SetGlobalMatrix(PropertyID._AO_PrevInvViewProjMatrixLeft, m_prevInvViewProjMatrixLeft);
                    m_prevViewProjMatrixLeft = viewProjMatrix;
                    m_prevInvViewProjMatrixLeft = invViewProjMatrix;
                }
            }
        }

        public AmplifyOcclusionViewProjMatrix()
        {
        }
    }
}
