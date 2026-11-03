namespace Campus.Common
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class UIDrawObjects
    {
        private RenderStateBlock _renderStateBlock;
        private FilteringSettings _filteringSettings;
        public UIDrawObjects(FilteringSettings filteringSettings, RenderStateBlock renderStateBlock)
        {
        }

        public void Execute(ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings drawSettings, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Vector3 cameraPosition, Rect viewport)
        {
        }
    }
}
