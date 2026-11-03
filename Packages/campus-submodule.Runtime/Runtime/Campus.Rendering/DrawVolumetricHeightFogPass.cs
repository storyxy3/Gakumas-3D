namespace Campus.Rendering
{
    using global::Campus.Rendering;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL;

    public class DrawVolumetricHeightFogPass : ScriptableRenderPass
    {
        public static readonly string _USE_VOLUMETRIC_HEIGHT_FOG;
        public static readonly int _VolumetricHeightFog;
        public static readonly int _Volumetric3DMap;
        private readonly ProfilingSampler _profilingSampler;
        private static readonly ShaderTagId _ShaderTagId;
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
        }

        public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        private void RenderVolumetricFog(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        public override void FrameCleanup(CommandBuffer cmd)
        {
        }
    }
}
