namespace Campus.Rendering
{
    using global::Campus.Rendering;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class BlitVolumetricHeightFogPass : ScriptableRenderPass
    {
        private readonly ProfilingSampler _profilingSampler = new ProfilingSampler("Blit Volumetric Height Fog");
        private Material _material;
        private VolumetricHeightFogSettings _settings;
        public BlitVolumetricHeightFogPass(Material material, VolumetricHeightFogSettings settings)
        {
            profilingSampler = new ProfilingSampler("BlitVolumetricHeightFogPass");
            renderPassEvent = RenderPassEvent.BeforeRenderingTransparents;
            _material = material;
            _settings = settings;
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            CommandBuffer cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, _profilingSampler))
            {
                context.ExecuteCommandBuffer(cmd);
                cmd.Clear();
                if (VolumeManager.instance.stack.GetComponent<VolumetricHeightFog>().UseFog.value)
                {
                    cmd.Blit(BuiltinRenderTextureType.None, BuiltinRenderTextureType.CurrentActive, _material, 1);
                    context.ExecuteCommandBuffer(cmd);
                    cmd.Clear();
                }
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }
    }
}
