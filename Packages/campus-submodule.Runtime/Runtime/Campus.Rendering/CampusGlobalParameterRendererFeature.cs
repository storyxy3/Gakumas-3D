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
            if (settings == null) settings = new CampusActorParameterSettings();
            _pass = new CampusActorParameterPass();
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            _pass.Setup(settings);
            renderer.EnqueuePass(_pass);
        }

        public CampusGlobalParameterRendererFeature()
        {
        }
    }
}
