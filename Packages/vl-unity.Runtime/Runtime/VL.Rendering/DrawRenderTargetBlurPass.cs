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
            if (blurShader == null) return;
            _pass = new RenderTargetBlurPass(RenderPassEvent.BeforeRenderingOpaques, UnityEngine.Rendering.CoreUtils.CreateEngineMaterial(blurShader));
        }

        protected override void Dispose(bool disposing)
        {
            _pass?.Dispose();
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            if (_pass != null) renderer.EnqueuePass(_pass);
        }

        public DrawRenderTargetBlurPass()
        {
        }
    }
}
