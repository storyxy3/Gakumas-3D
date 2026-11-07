namespace Campus.Live
{
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class LiveRenderingDebugFeature : ScriptableRendererFeature
    {
        public override void Create()
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            NativeArray<VisibleLight> visibleLights = renderingData.cullResults.visibleLights;
            UpdateVisibleLights(visibleLights);
            LiveRenderingDebugData.LightCount = visibleLights.Length;
        }

        private static void UpdateVisibleLights(NativeArray<VisibleLight> visibleLights)
        {
            int count = visibleLights.Length;
            Light[] lights = LiveRenderingDebugData.VisibleLights ?? new Light[count];
            if (lights.Length != count)
                System.Array.Resize(ref lights, count);
            for (int i = 0; i < count; i++)
                lights[i] = visibleLights[i].light;
            LiveRenderingDebugData.VisibleLights = lights;
        }

        public LiveRenderingDebugFeature()
        {
        }
    }
}
