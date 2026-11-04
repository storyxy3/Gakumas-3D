namespace VL.Rendering
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class MultiCameraPass : ScriptableRenderPass
    {
        public const int SubCameraStencilMask = 24;
        private RenderStateBlock _stateBlock;
        private FilteringSettings _filteringSettings;
        private List<ShaderTagId> _shaderTagIds;
        private readonly ProfilingSampler _profilingSampler;
        private Camera _camera;
        private VLMultiCamera.MultiCameraData _multiCameraData;
        public MultiCameraPass(int index, int stencilId, RenderPassEvent passEvent, DrawMultiCameraPass.Settings settings)
        {
            renderPassEvent = passEvent;
            _filteringSettings = new FilteringSettings(passEvent == RenderPassEvent.AfterRenderingOpaques ? RenderQueueRange.opaque : RenderQueueRange.transparent);
            _stateBlock = new RenderStateBlock(RenderStateMask.Stencil);
            _stateBlock.stencilReference = stencilId;
            _stateBlock.stencilState = new StencilState(true, SubCameraStencilMask, 255, CompareFunction.Equal);
            _shaderTagIds = new List<ShaderTagId>(settings.shaderPasses.Length);
            for (int i = 0; i < settings.shaderPasses.Length; i++)
                _shaderTagIds.Add(new ShaderTagId(settings.shaderPasses[i]));
            _profilingSampler = new ProfilingSampler(string.Format("MultiCamera({0})", index + 1));
        }

        public void Setup(Camera camera, VLMultiCamera.MultiCameraData data)
        {
            _camera = camera;
            _multiCameraData = data;
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, _profilingSampler))
            {
                context.ExecuteCommandBuffer(cmd);
                cmd.Clear();
                var drawingSettings = CreateDrawingSettings(_shaderTagIds, ref renderingData,
                    renderPassEvent == RenderPassEvent.AfterRenderingOpaques ? SortingCriteria.CommonOpaque : SortingCriteria.CommonTransparent);
                var originalProjection = _camera.projectionMatrix;
                var projection = _multiCameraData.projectionMatrix;
                if (_multiCameraData.useOffset && _multiCameraData.maskRenderer != null)
                {
                    var position = _camera.WorldToViewportPoint(_multiCameraData.maskRenderer.transform.position);
                    projection.m02 = 1f - position.x * 2f;
                    projection.m12 = 1f - position.y * 2f;
                }
                _filteringSettings.layerMask = 1 << _multiCameraData.camera.gameObject.layer;
                var view = _multiCameraData.viewMatrix;
                cmd.SetViewProjectionMatrices(view, projection);
                context.ExecuteCommandBuffer(cmd);
                _camera.TryGetCullingParameters(out var cullingParameters);
                CameraUtility.CalcCullingPlane(ref cullingParameters, projection * view);
                var cullingResults = context.Cull(ref cullingParameters);
                context.DrawRenderers(cullingResults, ref drawingSettings, ref _filteringSettings, ref _stateBlock);
                cmd.Clear();
                cmd.SetViewProjectionMatrices(_camera.worldToCameraMatrix, originalProjection);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }
    }
}
