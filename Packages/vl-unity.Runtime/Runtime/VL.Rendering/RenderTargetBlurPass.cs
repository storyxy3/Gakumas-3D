namespace VL.Rendering
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class RenderTargetBlurPass : ScriptableRenderPass
    {
        private readonly ProfilingSampler _profilingSampler;
        private readonly DownsampleBlur _blur;
        private VLSRPRenderTargetBlur _requester;
        private RTHandle _blurTarget;
        public RenderTargetBlurPass(RenderPassEvent e, Material material)
        {
        }

        public void Dispose()
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }
    }
}
