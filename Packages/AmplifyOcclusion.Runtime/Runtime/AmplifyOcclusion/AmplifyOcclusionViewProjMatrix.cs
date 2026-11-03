namespace AmplifyOcclusion
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class AmplifyOcclusionViewProjMatrix
    {
        private Matrix4x4 m_prevViewProjMatrixLeft;
        private Matrix4x4 m_prevInvViewProjMatrixLeft;
        private Matrix4x4 m_prevViewProjMatrixRight;
        private Matrix4x4 m_prevInvViewProjMatrixRight;
        public void UpdateGlobalShaderConstants_Matrices(CommandBuffer cb, Camera aCamera, bool isUsingTemporalFilter)
        {
        }

        public AmplifyOcclusionViewProjMatrix()
        {
        }
    }
}
