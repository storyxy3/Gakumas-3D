namespace Campus.Rendering
{
    using global::Campus.Rendering;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class BlitVolumetricHeightFogPass : ScriptableRenderPass
    {
        private readonly ProfilingSampler _profilingSampler;
        private Material _material;
        private VolumetricHeightFogSettings _settings;
        public BlitVolumetricHeightFogPass(Material material, VolumetricHeightFogSettings settings)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }
    }
}
