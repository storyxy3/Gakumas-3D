namespace Campus.Live
{
    using global::Unity.Collections;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class LiveRenderingDebugFeature : ScriptableRendererFeature
    {
        public override void Create()
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        private static void UpdateVisibleLights(NativeArray<VisibleLight> visibleLights)
        {
        }

        public LiveRenderingDebugFeature()
        {
        }
    }
}
