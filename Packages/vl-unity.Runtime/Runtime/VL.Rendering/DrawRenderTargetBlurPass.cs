namespace VL.Rendering
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class DrawRenderTargetBlurPass : ScriptableRendererFeature
    {
        private RenderTargetBlurPass _pass;
        public Shader blurShader;
        public override void Create()
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        public DrawRenderTargetBlurPass()
        {
        }
    }
}
