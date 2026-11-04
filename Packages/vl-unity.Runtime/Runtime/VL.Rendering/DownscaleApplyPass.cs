namespace VL.Rendering
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class DownscaleApplyPass : ScriptableRenderPass
    {
        private readonly Material _material;
        public DownscaleApplyPass(Material material)
        {
            profilingSampler = new ProfilingSampler("Apply Downscale");
            _material = material;
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, profilingSampler))
            {
                Blit(cmd, ref renderingData, _material, 12);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }
    }
}
