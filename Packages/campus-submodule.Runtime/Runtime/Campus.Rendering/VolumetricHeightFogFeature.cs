namespace Campus.Rendering
{
    using global::Campus.Rendering;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;

    public class VolumetricHeightFogFeature : ScriptableRendererFeature
    {
        public VolumetricHeightFogSettings Settings;
        public Shader FogShader;
        private DrawVolumetricHeightFogPass _drawPass;
        private BlitVolumetricHeightFogPass _blitPass;
        public override void Create()
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        public VolumetricHeightFogFeature()
        {
        }
    }
}
