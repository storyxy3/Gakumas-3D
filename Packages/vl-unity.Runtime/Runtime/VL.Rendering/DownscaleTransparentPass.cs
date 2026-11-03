namespace VL.Rendering
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::UnityEngine.Rendering.Universal.Internal;
    using global::VL;
    using global::VL.Rendering;
    using global::VLB;

    public class DownscaleTransparentPass : ScriptableRenderPass
    {
        public static readonly int _CameraDepthTexture;
        private readonly DrawObjectsPass _transparentPass;
        private readonly DrawObjectsPass _distortionPass;
        private readonly Material _downscaleMaterial;
        private ForwardLights _forwardLights;
        private DeferredLights _deferredLights;
        private DownscaleBuffers _buffers;
        private CustomRenderPassData _renderPass;
        private CustomSubPassData[] _subPass;
        private readonly ProfilingSampler _vlbProfilingSampler;
        private VLBDrawSystem _vlbDrawSystem;
        private ProFlareBatchForSRPData _proFlareData;
        public DownscaleTransparentPass(string[] transparentShaderTagIds, LayerMask transparentLayerMask, Material downscaleMaterial, DownscaleBuffers buffers)
        {
        }

        public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
        {
        }

        public void Setup(ForwardLights forwardLights, DeferredLights deferredLights)
        {
        }

        public void SetVLBDrawSystem(VLBDrawSystem vlbDrawSystem)
        {
        }

        public void SetupProFlare(ProFlareBatchForSRPData proFlareData)
        {
        }

        private void OnRenderTransparent(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        private void OnRenderDistortion(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }
    }
}
