namespace Campus.Rendering
{
    using global::Campus.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class CampusGlobalParameterRendererFeature : ScriptableRendererFeature
    {
        public CampusActorParameterSettings settings;
        private CampusActorParameterPass _pass;
        public override void Create()
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        public CampusGlobalParameterRendererFeature()
        {
        }
    }
}
