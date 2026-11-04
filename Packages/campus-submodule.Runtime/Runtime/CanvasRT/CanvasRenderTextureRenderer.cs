namespace CanvasRT
{
    using global::CanvasRT;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class CanvasRenderTextureRenderer : ScriptableRenderer
    {
        private readonly CanvasRenderTextureRendererPass _renderUIPass;
        public CanvasRenderTextureRenderer(CanvasRenderTextureRendererData data) : base(data)
        {
            _renderUIPass = new CanvasRenderTextureRendererPass(data);
        }

        public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            EnqueuePass(_renderUIPass);
        }

        public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
        {
            cullingParameters.cullingOptions = (CullingOptions)32;
            cullingParameters.isOrthographic = cameraData.camera.orthographic;
            cullingParameters.shadowDistance = 0f;
            cullingParameters.maximumVisibleLights = 0;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _renderUIPass.Dispose();
        }
    }
}
