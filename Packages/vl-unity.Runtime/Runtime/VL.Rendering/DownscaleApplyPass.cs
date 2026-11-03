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
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }
    }
}
