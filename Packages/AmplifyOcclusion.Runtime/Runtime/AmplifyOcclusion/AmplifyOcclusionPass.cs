namespace AmplifyOcclusion
{
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public sealed class AmplifyOcclusionPass : ScriptableRenderPass
    {
        private static readonly ProfilingSampler m_RenderSampler = new ProfilingSampler("AO - Render");
        private AmplifyOcclusionRenderingData m_amplifyOcclusionRenderingData;
        public AmplifyOcclusionPass(Material occlusionMat, Material blurMat, Material applyOcclusionMat)
        {
            m_amplifyOcclusionRenderingData = new AmplifyOcclusionRenderingData(occlusionMat, blurMat, applyOcclusionMat);
            renderPassEvent = RenderPassEvent.AfterRenderingOpaques;
        }

        public bool Initialize()
        {
            return m_amplifyOcclusionRenderingData.Initialize();
        }

        public void Dispose()
        {
            m_amplifyOcclusionRenderingData.Dispose();
        }

        public void Setup(global::AmplifyOcclusion.AmplifyOcclusion settings, ref CameraData cameraData)
        {
            m_amplifyOcclusionRenderingData.Setup(settings);
            ScriptableRenderPassInput input = settings.PerPixelNormals.value == PerPixelNormalSource.Normal
                ? ScriptableRenderPassInput.Depth | ScriptableRenderPassInput.Normal
                : ScriptableRenderPassInput.Depth;
            if (m_amplifyOcclusionRenderingData.UsingTemporalFilter(cameraData.isSceneViewCamera))
                input |= ScriptableRenderPassInput.Motion;
            ConfigureInput(input);
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            CommandBuffer cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, m_RenderSampler))
            {
                m_amplifyOcclusionRenderingData.UpdateParams(cmd, ref renderingData.cameraData);
                m_amplifyOcclusionRenderingData.ComputeOcclusion(cmd, ref renderingData.cameraData);
                m_amplifyOcclusionRenderingData.RenderBlurAndCombine(cmd, ref renderingData.cameraData);
                m_amplifyOcclusionRenderingData.RenderTemporal(cmd, ref renderingData.cameraData);
                m_amplifyOcclusionRenderingData.ApplyOcclusion(cmd, ref renderingData.cameraData, renderingData.cameraData.renderer.cameraColorTargetHandle);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }
    }
}
