namespace Campus.Rendering
{
    using global::System;
    using global::Campus.Rendering;
    using global::UnityEngine;
    using global::UnityEngine.Experimental.Rendering;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL;

    public class DrawVolumetricHeightFogPass : ScriptableRenderPass
    {
        public static readonly string _USE_VOLUMETRIC_HEIGHT_FOG = "_USE_VOLUMETRIC_HEIGHT_FOG";
        public static readonly int _VolumetricHeightFog = Shader.PropertyToID("_VolumetricHeightFog");
        public static readonly int _Volumetric3DMap = Shader.PropertyToID("_Volumetric3DMap");
        private readonly ProfilingSampler _profilingSampler = new ProfilingSampler("Volumetric Height Fog");
        private static readonly ShaderTagId _ShaderTagId = new ShaderTagId("VolumetricHeightFog");
        private VolumetricHeightFogSettings _settings;
        private RenderTextureDescriptor _descriptor;
        private FilteringSettings _filteringSettings;
        private RenderStateBlock _stateBlock;
        private CustomRenderPassData _renderPass;
        private CustomRenderPassData _blitRenderPass;
        private CustomSubPassData[] _subPasses;
        private CustomSubPassData[] _blitSubPasses;
        public DrawVolumetricHeightFogPass(VolumetricHeightFogSettings settings)
        {
            profilingSampler = new ProfilingSampler("DrawVolumetricHeightFogPass");
            _settings = settings;
            renderPassEvent = RenderPassEvent.AfterRenderingTransparents;
            _filteringSettings = new FilteringSettings(RenderQueueRange.transparent, settings.Mask, uint.MaxValue);
            _stateBlock = new RenderStateBlock(RenderStateMask.Nothing);
        }

        public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
        {
            cameraTextureDescriptor.width >>= _settings.Downsample;
            cameraTextureDescriptor.height >>= _settings.Downsample;
            cameraTextureDescriptor.msaaSamples = (int)_settings.Msaa;
            cameraTextureDescriptor.graphicsFormat = _settings.Hdr ? GraphicsFormat.R16G16B16A16_SFloat : GraphicsFormat.R8G8B8A8_SRGB;
            if (_renderPass == null)
            {
                var attachments = new AttachmentDescriptor[1];
                attachments[0] = new AttachmentDescriptor(cameraTextureDescriptor.graphicsFormat);
                attachments[0].ConfigureTarget(_VolumetricHeightFog, false, true);
                attachments[0].ConfigureClear(new Color(0f, 0f, 0f, 0f), 1f, 0);
                _renderPass = new CustomRenderPassData { attachmentDescriptors = attachments, depthAttachmentIndex = -1 };
                _subPasses = new CustomSubPassData[] { new CustomSubPassData { colors = new int[1], renderAction = RenderVolumetricFog } };
            }
            _renderPass.width = cameraTextureDescriptor.width;
            _renderPass.height = cameraTextureDescriptor.height;
            cmd.GetTemporaryRT(_VolumetricHeightFog, cameraTextureDescriptor, FilterMode.Bilinear);
            ResetTarget();
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            CommandBuffer cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, _profilingSampler))
            {
                bool useFog = VolumeManager.instance.stack.GetComponent<VolumetricHeightFog>().UseFog.value;
                CoreUtils.SetKeyword(cmd, _USE_VOLUMETRIC_HEIGHT_FOG, useFog);
                if (useFog)
                {
                    context.ExecuteCommandBuffer(cmd);
                    cmd.Clear();
                    CustomRenderPassUtility.Execute(context, ref renderingData, _renderPass, _subPasses);
                }
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        private void RenderVolumetricFog(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            DrawingSettings drawingSettings = CreateDrawingSettings(_ShaderTagId, ref renderingData, SortingCriteria.None);
            context.DrawRenderers(renderingData.cullResults, ref drawingSettings, ref _filteringSettings, ref _stateBlock);
        }

        public override void FrameCleanup(CommandBuffer cmd)
        {
            if (cmd == null)
                throw new ArgumentNullException("cmd");
            cmd.ReleaseTemporaryRT(_VolumetricHeightFog);
        }
    }
}
