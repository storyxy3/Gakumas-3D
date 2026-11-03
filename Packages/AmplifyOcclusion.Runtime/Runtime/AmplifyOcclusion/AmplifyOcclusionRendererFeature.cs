namespace AmplifyOcclusion
{
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;

    [DisallowMultipleRendererFeature(null)]
    public class AmplifyOcclusionRendererFeature : ScriptableRendererFeature
    {
        public Shader occlusionShader;
        public Shader blurShader;
        public Shader applyOcclusionShader;
        private AmplifyOcclusionPass _pass;
        private Material _occlusionMat;
        private Material _blurMat;
        private Material _applyOcclusionMat;
        public override void Create()
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        public AmplifyOcclusionRendererFeature()
        {
        }
    }
}
