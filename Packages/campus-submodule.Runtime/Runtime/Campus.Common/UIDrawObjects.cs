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
            _filteringSettings = filteringSettings;
            _renderStateBlock = renderStateBlock;
        }

        public void Execute(ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings drawSettings, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Vector3 cameraPosition, Rect viewport)
        {
            if (!renderingData.cameraData.camera.TryGetCullingParameters(false, out var cullingParameters)) return;
            var cmd = CommandBufferPool.Get();
            cmd.SetViewport(viewport);
            cmd.SetViewProjectionMatrices(viewMatrix, projectionMatrix);
            cmd.SetGlobalVector(Shader.PropertyToID("_WorldSpaceCameraPos"), cameraPosition);
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
            global::VL.Rendering.CameraUtility.CalcCullingPlane(ref cullingParameters, projectionMatrix * viewMatrix);
            cullingParameters.shadowDistance = 0f;
            cullingParameters.reflectionProbeSortingCriteria = (ReflectionProbeSortingCriteria)0;
            cullingParameters.cullingOptions = (CullingOptions)32;
            cullingParameters.cullingMask = (uint)_filteringSettings.layerMask;
            cullingParameters.origin = cameraPosition;
            var results = context.Cull(ref cullingParameters);
            context.DrawRenderers(results, ref drawSettings, ref _filteringSettings, ref _renderStateBlock);
        }
    }
}
