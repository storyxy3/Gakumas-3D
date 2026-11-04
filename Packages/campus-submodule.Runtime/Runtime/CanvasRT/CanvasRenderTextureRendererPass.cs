namespace CanvasRT
{
    using global::System.Collections.Generic;
    using global::Campus.Common;
    using global::Campus.Live.Monitor;
    using global::CanvasRT;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL;

    public class CanvasRenderTextureRendererPass : ScriptableRenderPass
    {
        private static readonly ProfilingSampler _profilingSampler = new ProfilingSampler("Draw Canvas");
        private FilteringSettings _filteringSettings;
        private FilteringSettings _overlayFilteringSettings;
        private RenderStateBlock _renderStateBlock;
        private readonly List<ShaderTagId> _actorShaderTagIds = new List<ShaderTagId> { new ShaderTagId("UniversalForwardPerformance") };
        private readonly List<ShaderTagId> _shaderTagIds = new List<ShaderTagId> { new ShaderTagId("SRPDefaultUnlit"), new ShaderTagId("UniversalForward"), new ShaderTagId("UniversalForwardOnly") };
        private UIDrawObjects _actorDrawObjects;
        private CustomRenderPassData _renderPass;
        private CustomSubPassData[] _subPass;
        private VolumeStack _volumeStack;
        private LayerMask _layerMask;
        public CanvasRenderTextureRendererPass(CanvasRenderTextureRendererData data)
        {
            renderPassEvent = (RenderPassEvent)0;
            short overlay = (short)SortingLayer.GetLayerValueFromName("MonitorOverlay");
            _filteringSettings = new FilteringSettings(RenderQueueRange.all) { sortingLayerRange = new SortingLayerRange(0, 0) };
            _overlayFilteringSettings = new FilteringSettings(RenderQueueRange.all) { sortingLayerRange = new SortingLayerRange(overlay, overlay) };
            _renderStateBlock = new RenderStateBlock(RenderStateMask.Nothing);
            var actorFiltering = new FilteringSettings(RenderQueueRange.all) { layerMask = data.layerMask.value, renderingLayerMask = data.actorRenderingLayer };
            _actorDrawObjects = new UIDrawObjects(actorFiltering, new RenderStateBlock(RenderStateMask.Nothing));
            _layerMask = data.layerMask;
            _renderPass = new CustomRenderPassData
            {
                attachmentDescriptors = new[]
                {
                    new AttachmentDescriptor((RenderTextureFormat)22) { loadAction = RenderBufferLoadAction.Clear, storeAction = RenderBufferStoreAction.Store, clearColor = Color.clear },
                    new AttachmentDescriptor((global::UnityEngine.Experimental.Rendering.GraphicsFormat)92) { loadAction = RenderBufferLoadAction.Clear, storeAction = RenderBufferStoreAction.DontCare }
                },
                depthAttachmentIndex = 1,
                memoryless = new[] { false, true }
            };
            _subPass = new[]
            {
                new CustomSubPassData
                {
                    colors = new[] { 0 },
                    profilingSampler = new ProfilingSampler("Render Canvas Render Texture"),
                    renderAction = OnRenderCanvasRenderTexture
                }
            };
        }

        public void Dispose()
        {
            _volumeStack?.Dispose();
        }

        public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
        {
            ResetTarget();
        }

        private void Draw3DImage(ScriptableRenderContext context, ref RenderingData renderingData, CommandBuffer cmd, Monitor3DImage image)
        {
            var camera = image.targetCamera;
            var cameraTransform = camera.transform;
            if (_volumeStack == null) _volumeStack = VolumeManager.instance.CreateStack();
            VolumeManager.instance.Update(_volumeStack, cameraTransform, _layerMask);
            global::Campus.Rendering.CampusActorParameterPass.UpdateActorCommand(cmd, _volumeStack, cameraTransform);
            context.ExecuteCommandBuffer(cmd);
            cmd.Clear();
            var viewport = image.GetViewportRect();
            var position = cameraTransform.position;
            var view = cameraTransform.worldToLocalMatrix;
            if (image.virtualActorController != null)
            {
                float scale = image.virtualActorController.HumanScale / CampusActorController.BaseHeight;
                var local = image.virtualActorController.transform.worldToLocalMatrix.MultiplyPoint(position);
                position = image.virtualActorController.transform.localToWorldMatrix.MultiplyPoint(local * scale);
                view = Matrix4x4.TRS(position, cameraTransform.rotation, Vector3.one).inverse;
            }
            view = Matrix4x4.Scale(new Vector3(1f, 1f, -1f)) * view;
            var lens = camera.m_Lens;
            float fieldOfView = lens.IsPhysicalCamera ? lens.FocalLengthToVerticalFOV() : lens.FieldOfView;
            var projection = Matrix4x4.Perspective(fieldOfView, viewport.width / viewport.height, lens.NearClipPlane, lens.FarClipPlane);
            var drawing = CreateDrawingSettings(_actorShaderTagIds, ref renderingData, (SortingCriteria)18);
            _actorDrawObjects.Execute(context, ref renderingData, ref drawing, view, projection, position, viewport);
        }

        private void OnRenderCanvasRenderTexture(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var camera = renderingData.cameraData.camera;
            if (!camera.TryGetComponent<CanvasRenderTexture>(out var canvas) || !canvas.isActiveAndEnabled) return;
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, _profilingSampler))
            {
                context.ExecuteCommandBuffer(cmd);
                cmd.Clear();
                var drawing = CreateDrawingSettings(_shaderTagIds, ref renderingData, SortingCriteria.None);
                context.DrawRenderers(renderingData.cullResults, ref drawing, ref _filteringSettings, ref _renderStateBlock);
                if (canvas.threeDImages != null)
                {
                    for (int i = 0; i < canvas.threeDImages.Count; i++)
                    {
                        var image = canvas.threeDImages[i];
                        if (image == null || !image.enabled || image.targetCamera == null) continue;
                        Draw3DImage(context, ref renderingData, cmd, image);
                    }
                    cmd.SetViewport(camera.pixelRect);
                    cmd.SetViewProjectionMatrices(renderingData.cameraData.GetViewMatrix(), renderingData.cameraData.GetProjectionMatrix());
                    cmd.SetGlobalVector(Shader.PropertyToID("_WorldSpaceCameraPos"), renderingData.cameraData.worldSpaceCameraPos);
                    context.ExecuteCommandBuffer(cmd);
                    cmd.Clear();
                }
                context.DrawRenderers(renderingData.cullResults, ref drawing, ref _overlayFilteringSettings, ref _renderStateBlock);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var target = renderingData.cameraData.camera.targetTexture;
            if (target == null) return;
            _renderPass.width = target.width;
            _renderPass.height = target.height;
            _renderPass.attachmentDescriptors[0].graphicsFormat = target.graphicsFormat;
            _renderPass.attachmentDescriptors[0].loadStoreTarget = target;
            CustomRenderPassUtility.Execute(context, ref renderingData, _renderPass, _subPass);
        }
    }
}
