namespace AmplifyOcclusion
{
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public sealed class AmplifyOcclusionPass : ScriptableRenderPass
    {
        private static readonly ProfilingSampler m_RenderSampler;
        private AmplifyOcclusionRenderingData m_amplifyOcclusionRenderingData;
        public AmplifyOcclusionPass(Material occlusionMat, Material blurMat, Material applyOcclusionMat)
        {
        }

        public bool Initialize()
        {
            return default(bool);
        }

        public void Dispose()
        {
        }

        public void Setup(global::AmplifyOcclusion.AmplifyOcclusion settings, ref CameraData cameraData)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }
    }
}
