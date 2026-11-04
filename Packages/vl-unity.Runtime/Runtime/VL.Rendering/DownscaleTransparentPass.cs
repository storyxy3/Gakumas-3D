// TODO(qa-recon): Execute retains native semantic flags for URP mip-bias compatibility, initialization and the external ProFlare accessor; see TASK_D_REPORT.md.
namespace VL.Rendering
{
    using global::System;
    using global::System.Linq;
    using global::UnityEngine.Experimental.Rendering;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::UnityEngine.Rendering.Universal.Internal;
    using global::VL;
    using global::VL.Rendering;
    using global::VLB;

    public class DownscaleTransparentPass : ScriptableRenderPass
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<string, ShaderTagId> _003C_003E9__9_0;
            public _003C_003Ec()
            {
            }

            internal ShaderTagId _003C_002Ector_003Eb__9_0(string x)
            {
                return new ShaderTagId(x);
            }
        }

        public static readonly int _CameraDepthTexture = Shader.PropertyToID("_CameraDepthTexture");
        private readonly DrawObjectsPass _transparentPass;
        private readonly DrawObjectsPass _distortionPass;
        private readonly Material _downscaleMaterial;
        private ForwardLights _forwardLights;
        private DeferredLights _deferredLights;
        private DownscaleBuffers _buffers;
        private CustomRenderPassData _renderPass;
        private CustomSubPassData[] _subPass;
        private readonly ProfilingSampler _vlbProfilingSampler = new ProfilingSampler("Volumetric Light Beam");
        private VLBDrawSystem _vlbDrawSystem;
        private ProFlareBatchForSRPData _proFlareData;
        public DownscaleTransparentPass(string[] transparentShaderTagIds, LayerMask transparentLayerMask, Material downscaleMaterial, DownscaleBuffers buffers)
        {
            profilingSampler = new ProfilingSampler("Downscale Transparent");
            _transparentPass = new DrawObjectsPass("Downscale Transparent", transparentShaderTagIds.Select(_003C_003Ec._003C_003E9__9_0 ?? (_003C_003Ec._003C_003E9__9_0 = _003C_003Ec._003C_003E9._003C_002Ector_003Eb__9_0)).ToArray(), false, RenderPassEvent.BeforeRenderingTransparents, VLRenderQueue.DownscaleTransparentRange, transparentLayerMask, new StencilState(false), 0);
            _distortionPass = new DrawObjectsPass("Distortion", new[] { new ShaderTagId("Distortion") }, false, RenderPassEvent.BeforeRenderingTransparents, VLRenderQueue.DownscaleTransparentRange, transparentLayerMask, new StencilState(false), 0);
            _downscaleMaterial = downscaleMaterial;
            _buffers = buffers;
            _renderPass = new CustomRenderPassData
            {
                attachmentDescriptors = new[]
                {
                    new AttachmentDescriptor((GraphicsFormat)48) { loadAction = RenderBufferLoadAction.Clear, storeAction = RenderBufferStoreAction.Store, clearColor = Color.black },
                    new AttachmentDescriptor((GraphicsFormat)46) { loadAction = RenderBufferLoadAction.Clear, storeAction = RenderBufferStoreAction.Store, clearColor = Color.black },
                    new AttachmentDescriptor((GraphicsFormat)92) { loadAction = RenderBufferLoadAction.DontCare, storeAction = RenderBufferStoreAction.DontCare }
                },
                depthAttachmentIndex = 2,
                memoryless = new[] { false, false, true }
            };
            _subPass = new[]
            {
                new CustomSubPassData { colors = new[] { 0 }, profilingSampler = new ProfilingSampler("Render Transparent"), renderAction = OnRenderTransparent },
                new CustomSubPassData { colors = new[] { 1 }, profilingSampler = new ProfilingSampler("Render Distortion"), renderAction = OnRenderDistortion }
            };
        }

        public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
        {
            ResetTarget();
        }

        public void Setup(ForwardLights forwardLights, DeferredLights deferredLights)
        {
            _forwardLights = forwardLights;
            _deferredLights = deferredLights;
            ConfigureInput(ScriptableRenderPassInput.Color);
        }

        public void SetVLBDrawSystem(VLBDrawSystem vlbDrawSystem)
        {
            _vlbDrawSystem = vlbDrawSystem;
        }

        public void SetupProFlare(ProFlareBatchForSRPData proFlareData)
        {
            _proFlareData = proFlareData;
        }

        private void OnRenderTransparent(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var cmd = CommandBufferPool.Get();
            Vector2 scale = Vector2.one;
            Blitter.BlitTexture(cmd, new Vector4(scale.x, scale.y, 0f, 0f), _downscaleMaterial, 1);
            context.ExecuteCommandBuffer(cmd);
            cmd.Clear();
            _transparentPass.Execute(context, ref renderingData);
            using (new ProfilingScope(cmd, _vlbProfilingSampler))
            {
                _vlbDrawSystem?.Execute(cmd, ref renderingData.cullResults);
                _vlbDrawSystem?.ExecuteHD(cmd, ref renderingData.cullResults, _deferredLights?.GetAdditionalLightsShadowCasterPass());
                _vlbDrawSystem?.MarkRendered();
            }
            if (_proFlareData != null)
            {
                _proFlareData.RenderFlares(cmd);
                cmd.SetViewProjectionMatrices(renderingData.cameraData.GetViewMatrix(), renderingData.cameraData.GetProjectionMatrix());
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        private void OnRenderDistortion(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            _distortionPass.Execute(context, ref renderingData);
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, profilingSampler))
            {
                var cameraType = renderingData.cameraData.cameraType;
                var descriptor = renderingData.cameraData.cameraTargetDescriptor;
                if (cameraType == CameraType.Game || cameraType == CameraType.SceneView)
                {
                    descriptor.width >>= 1;
                    descriptor.height >>= 1;
                }
                descriptor.msaaSamples = 1;
                descriptor.depthStencilFormat = GraphicsFormat.None;
                descriptor.graphicsFormat = (GraphicsFormat)48;
                RenderingUtils.ReAllocateIfNeeded(ref _buffers.transparent, descriptor, FilterMode.Bilinear, TextureWrapMode.Repeat, name: _buffers.transparent.name);
                descriptor.graphicsFormat = (GraphicsFormat)46;
                RenderingUtils.ReAllocateIfNeeded(ref _buffers.distortion, descriptor, FilterMode.Bilinear, TextureWrapMode.Repeat, name: _buffers.distortion.name);
                descriptor.graphicsFormat = GraphicsFormat.None;
                descriptor.depthStencilFormat = (GraphicsFormat)91;
                RenderingUtils.ReAllocateIfNeeded(ref _buffers.depthTexture, descriptor, FilterMode.Point, TextureWrapMode.Clamp, name: _buffers.depthTexture.name);
                CoreUtils.SetRenderTarget(cmd, _buffers.depthTexture, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store);
                Vector2 scale = Vector2.one;
                Blitter.BlitTexture(cmd, new Vector4(scale.x, scale.y, 0f, 0f), _downscaleMaterial, 0);
                cmd.SetGlobalTexture(_CameraDepthTexture, _buffers.depthTexture.nameID);
                cmd.SetGlobalTexture(_buffers.depthTexture.name, _buffers.depthTexture.nameID);
                if (_proFlareData != null)
                {
                    _proFlareData.CompleteJob();
                    if (_proFlareData.VisibleFlareElementCount > 0) _proFlareData.ComputeFlares(cmd);
                }
                VLRenderingCompatibility.SetGlobalMipBias(cmd, ref renderingData.cameraData, 0.5f);
                _forwardLights.SetFPParams1(cmd, new Vector2(renderingData.cameraData.pixelWidth * 2, renderingData.cameraData.pixelHeight * 2));
                context.ExecuteCommandBuffer(cmd);
                cmd.Clear();
                _renderPass.width = descriptor.width;
                _renderPass.height = descriptor.height;
                _renderPass.attachmentDescriptors[0].loadStoreTarget = _buffers.transparent.nameID;
                _renderPass.attachmentDescriptors[1].loadStoreTarget = _buffers.distortion.nameID;
                CustomRenderPassUtility.Execute(context, ref renderingData, _renderPass, _subPass);
                VLRenderingCompatibility.SetGlobalMipBias(cmd, ref renderingData.cameraData, 1f);
                cmd.SetGlobalTexture(_buffers.transparent.name, _buffers.transparent.nameID);
                cmd.SetGlobalTexture(_buffers.distortion.name, _buffers.distortion.nameID);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }
    }
}
