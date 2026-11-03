namespace AmplifyOcclusion
{
    using global::System.Runtime.InteropServices;
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Experimental.Rendering;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class AmplifyOcclusionRenderingData
    {
        private static readonly ProfilingSampler m_ComputeOcclusionSampler;
        private static readonly ProfilingSampler m_BlurSampler;
        private static readonly ProfilingSampler m_CombineSampler;
        private static readonly ProfilingSampler m_TemporalSampler;
        private static readonly ProfilingSampler m_ApplyOcclusionSampler;
        private GraphicsFormat m_occlusionRTFormat;
        private GraphicsFormat m_accumTemporalRTFormat;
        private GraphicsFormat m_motionIntensityRTFormat;
        private TargetDesc m_target;
        private global::AmplifyOcclusion.AmplifyOcclusion _settings;
        private RTHandle m_occlusionDepthRT;
        private RTHandle[] m_temporalAccumRT;
        private RTHandle m_depthMipmap;
        private RTHandle m_tmpSmallOcclusionRT;
        private RTHandle m_tmpBlurRT;
        private RTHandle m_tmpAOIntensityRT;
        private RTHandle m_tmpAOBlurIntensityRT;
        private RTHandle[] m_tmpMipRTs;
        private const float m_oneOverDepthScale = 1.5266243E-05f;
        private uint m_sampleStep;
        private uint m_curStepIdx;
        private int m_numberMips;
        private bool m_cacheAware;
        private SampleCountLevel m_prevSampleCount;
        private bool m_prevDownsample;
        private bool m_prevCacheAware;
        private bool m_prevBlurEnabled;
        private int m_prevBlurRadius;
        private int m_prevBlurPasses;
        private bool m_prevFilterEnabled;
        private bool m_prevFilterDownsample;
        private bool m_prevHDR;
        private bool m_prevMSAA;
        private bool m_HDR;
        private bool m_MSAA;
        private bool m_paramsChanged;
        private bool m_clearHistory;
        private Material m_occlusionMat;
        private Material m_blurMat;
        private Material m_applyOcclusionMat;
        private AmplifyOcclusionViewProjMatrix m_viewProjMatrix;
        private RenderTargetIdentifier[] applyDebugTargetsTemporal;
        private RenderTargetIdentifier[] applyPostEffectTargetsTemporal;
        public bool UsingTemporalFilter(bool isSceneViewCamera)
        {
            return default(bool);
        }

        private bool UsingMotionVectors(bool isSceneViewCamera)
        {
            return default(bool);
        }

        private bool UsingFilterDownsample(bool isSceneViewCamera)
        {
            return default(bool);
        }

        public AmplifyOcclusionRenderingData(Material occlusionMat, Material blurMat, Material applyOcclusionMat)
        {
        }

        private bool CheckRenderTextureFormats()
        {
            return default(bool);
        }

        public bool Initialize()
        {
            return default(bool);
        }

        public void Dispose()
        {
        }

        public void Setup(global::AmplifyOcclusion.AmplifyOcclusion settings)
        {
        }

        private void CheckParamsChanged(ref CameraData cameraData)
        {
        }

        private void UpdateGlobalShaderConstants(CommandBuffer cb, ref CameraData cameraData)
        {
        }

        public void UpdateParams(CommandBuffer cb, ref CameraData cameraData)
        {
        }

        private void UpdatePrevParams(ref CameraData cameraData)
        {
        }

        private void PerformBlit(CommandBuffer cb, RTHandle destination, Material mat, int pass)
        {
        }

        private void Blur(CommandBuffer cb, RTHandle aSourceRT, int aSourceWidth, int aSourceHeight)
        {
        }

        public void ComputeOcclusion(CommandBuffer cb, ref CameraData cameraData, [Optional] RenderTargetIdentifier mipChainBuffer, [Optional] Vector4[] minMaxArray)
        {
        }

        public void RenderBlurAndCombine(CommandBuffer cb, ref CameraData cameraData)
        {
        }

        private void ClearHistory(CommandBuffer cb)
        {
        }

        private void TemporalFilter(CommandBuffer cb)
        {
        }

        private void NeighborMotionIntensity(CommandBuffer cb, int aSourceWidth, int aSourceHeight)
        {
        }

        public void RenderTemporal(CommandBuffer cb, ref CameraData cameraData)
        {
        }

        public void ApplyOcclusion(CommandBuffer cb, ref CameraData cameraData, RTHandle aDestinyRT)
        {
        }
    }
}
