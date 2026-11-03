namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class GlobalWindRendererFeature : ScriptableRendererFeature
    {
        private class GlobalWindPass : ScriptableRenderPass
        {
            private static readonly int _GlobalWind;
            public GlobalWindPass()
            {
            }

            public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
            {
            }
        }

        private GlobalWindPass _pass;
        public override void Create()
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        public GlobalWindRendererFeature()
        {
        }
    }
}
