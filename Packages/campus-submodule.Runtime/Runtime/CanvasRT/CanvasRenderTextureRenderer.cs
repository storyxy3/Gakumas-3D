namespace CanvasRT
{
    using global::CanvasRT;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class CanvasRenderTextureRenderer : ScriptableRenderer
    {
        private readonly CanvasRenderTextureRendererPass _renderUIPass;
        // TODO(qa-recon): DummyDll omits base constructor call; placeholder default data, original behavior unknown.
        public CanvasRenderTextureRenderer(CanvasRenderTextureRendererData data) : base(default(global::UnityEngine.Rendering.Universal.ScriptableRendererData))
        {
        }

        public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
        {
        }

        protected override void Dispose(bool disposing)
        {
        }
    }
}
