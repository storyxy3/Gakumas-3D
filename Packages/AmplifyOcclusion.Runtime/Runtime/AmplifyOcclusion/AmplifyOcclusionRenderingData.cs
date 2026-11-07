namespace AmplifyOcclusion
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Experimental.Rendering;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class AmplifyOcclusionRenderingData
    {
        private static readonly ProfilingSampler m_ComputeOcclusionSampler = new ProfilingSampler("AO 1 - ComputeOcclusion");
        private static readonly ProfilingSampler m_BlurSampler = new ProfilingSampler("AO 2 - Blur");
        private static readonly ProfilingSampler m_CombineSampler = new ProfilingSampler("AO 2b - Combine");
        private static readonly ProfilingSampler m_TemporalSampler = new ProfilingSampler("AO 2c - Temporal");
        private static readonly ProfilingSampler m_ApplyOcclusionSampler = new ProfilingSampler("AO 3 - ApplyOcclusion");
        private GraphicsFormat m_occlusionRTFormat = GraphicsFormat.R16G16_SFloat;
        private GraphicsFormat m_accumTemporalRTFormat = GraphicsFormat.R8G8B8A8_UNorm;
        private GraphicsFormat m_motionIntensityRTFormat = GraphicsFormat.R8_UNorm;
        private TargetDesc m_target;
        private global::AmplifyOcclusion.AmplifyOcclusion _settings;
        private RTHandle m_occlusionDepthRT;
        private RTHandle[] m_temporalAccumRT = new RTHandle[2];
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
        private bool m_prevFilterEnabled = true;
        private bool m_prevFilterDownsample = true;
        private bool m_prevHDR = true;
        private bool m_prevMSAA = true;
        private bool m_HDR = true;
        private bool m_MSAA = true;
        private bool m_paramsChanged = true;
        private bool m_clearHistory = true;
        private Material m_occlusionMat;
        private Material m_blurMat;
        private Material m_applyOcclusionMat;
        private AmplifyOcclusionViewProjMatrix m_viewProjMatrix = new AmplifyOcclusionViewProjMatrix();
        private RenderTargetIdentifier[] applyDebugTargetsTemporal = new RenderTargetIdentifier[2];
        private RenderTargetIdentifier[] applyPostEffectTargetsTemporal = new RenderTargetIdentifier[2];
        public bool UsingTemporalFilter(bool isSceneViewCamera)
        {
            return _settings.FilterEnabled.value && !isSceneViewCamera;
        }

        private bool UsingMotionVectors(bool isSceneViewCamera)
        {
            return UsingTemporalFilter(isSceneViewCamera) && _settings.ApplyMethod.value != ApplicationMethod.Deferred;
        }

        private bool UsingFilterDownsample(bool isSceneViewCamera)
        {
            return _settings.Downsample.value && _settings.FilterDownsample.value && UsingTemporalFilter(isSceneViewCamera);
        }

        public AmplifyOcclusionRenderingData(Material occlusionMat, Material blurMat, Material applyOcclusionMat)
        {
            m_occlusionMat = occlusionMat;
            m_blurMat = blurMat;
            m_applyOcclusionMat = applyOcclusionMat;
        }

        private bool CheckRenderTextureFormats()
        {
            GraphicsFormat format = GraphicsFormat.R16G16_SFloat;
            if (!RenderingUtils.SupportsGraphicsFormat(format, FormatUsage.Render))
            {
                format = GraphicsFormat.R16G16B16A16_SFloat;
                if (!RenderingUtils.SupportsGraphicsFormat(format, FormatUsage.Render))
                    return false;
            }
            m_occlusionRTFormat = format;
            return true;
        }

        public bool Initialize()
        {
            bool supported = CheckRenderTextureFormats();
            if (!supported)
                Debug.LogError("[AmplifyOcclusion] Target platform does not meet the minimum requirements for this effect to work properly.");
            return supported;
        }

        public void Dispose()
        {
            if (m_occlusionDepthRT != null) m_occlusionDepthRT.Release();
            if (m_depthMipmap != null) m_depthMipmap.Release();
            if (m_temporalAccumRT != null)
            {
                if (m_temporalAccumRT[0] != null) m_temporalAccumRT[0].Release();
                if (m_temporalAccumRT[1] != null) m_temporalAccumRT[1].Release();
                m_temporalAccumRT = null;
            }
            if (m_tmpSmallOcclusionRT != null) m_tmpSmallOcclusionRT.Release();
            if (m_tmpBlurRT != null) m_tmpBlurRT.Release();
            if (m_tmpMipRTs != null)
            {
                for (int i = 0; i < m_tmpMipRTs.Length; i++)
                {
                    if (m_tmpMipRTs[i] != null) m_tmpMipRTs[i].Release();
                }
                m_tmpMipRTs = null;
            }
            if (m_tmpAOIntensityRT != null) m_tmpAOIntensityRT.Release();
            if (m_tmpAOBlurIntensityRT != null) m_tmpAOBlurIntensityRT.Release();
        }

        public void Setup(global::AmplifyOcclusion.AmplifyOcclusion settings)
        {
            _settings = settings;
            m_cacheAware = _settings.CacheAware.value;
            if (m_cacheAware)
            {
                if (!RenderingUtils.SupportsGraphicsFormat(GraphicsFormat.R32_SFloat, FormatUsage.Render))
                {
                    m_cacheAware = false;
                    Debug.LogWarning("[AmplifyOcclusion] System does not support RFloat RenderTextureFormat. CacheAware will be disabled.");
                }
                else if (SystemInfo.copyTextureSupport == CopyTextureSupport.None)
                {
                    m_cacheAware = false;
                    Debug.LogWarning("[AmplifyOcclusion] System does not support CopyTexture. CacheAware will be disabled.");
                }
            }
        }

        private void CheckParamsChanged(ref CameraData cameraData)
        {
            bool isUsingTemporalFilter = UsingTemporalFilter(cameraData.isSceneViewCamera);
            bool isUsingFilterDownsample = UsingFilterDownsample(cameraData.isSceneViewCamera);
            bool HDR = cameraData.isHdrEnabled;
            bool MSAA = cameraData.camera.allowMSAA && QualitySettings.antiAliasing >= 1;
            int antiAliasing = MSAA ? QualitySettings.antiAliasing : 1;
            if (m_occlusionDepthRT == null
                || new Vector2Int(m_target.width, m_target.height) != m_occlusionDepthRT.referenceSize
                || m_prevMSAA != MSAA
                || m_prevFilterEnabled != isUsingTemporalFilter
                || m_prevFilterDownsample != isUsingFilterDownsample
                || (m_temporalAccumRT != null && (m_temporalAccumRT[0] == null || m_temporalAccumRT[1] == null)))
            {
                m_paramsChanged = true;
            }
            if (m_temporalAccumRT != null && m_temporalAccumRT.Length != 2)
                m_temporalAccumRT = null;
            RenderingUtils.ReAllocateIfNeeded(ref m_occlusionDepthRT, new RenderTextureDescriptor(m_target.width, m_target.height, m_occlusionRTFormat, 0), FilterMode.Bilinear, TextureWrapMode.Clamp, false, 1, 0f, "_AO_OcclusionDepthTexture");
            if (m_temporalAccumRT != null && isUsingTemporalFilter)
            {
                var temporalDescriptor = new RenderTextureDescriptor(m_target.width, m_target.height, m_accumTemporalRTFormat, 0);
                temporalDescriptor.msaaSamples = antiAliasing;
                m_clearHistory |= RenderingUtils.ReAllocateIfNeeded(ref m_temporalAccumRT[0], temporalDescriptor, FilterMode.Bilinear, TextureWrapMode.Clamp, false, 1, 0f, "_AO_TemporalAccum_0");
                m_clearHistory |= RenderingUtils.ReAllocateIfNeeded(ref m_temporalAccumRT[1], temporalDescriptor, FilterMode.Bilinear, TextureWrapMode.Clamp, false, 1, 0f, "_AO_TemporalAccum_1");
            }
            if (m_cacheAware)
                m_numberMips = (int)(Mathf.Log(Mathf.Min(m_target.fullWidth, m_target.fullHeight), 2) + 1.0f) - 1;
            if (m_tmpMipRTs == null)
                m_tmpMipRTs = new RTHandle[m_numberMips];
            else if (m_numberMips > m_tmpMipRTs.Length)
                Array.Resize(ref m_tmpMipRTs, m_numberMips);
            for (int i = 0; i < m_numberMips; i++)
            {
                if (m_tmpMipRTs[i] == null)
                    m_tmpMipRTs[i] = RTHandles.Alloc((RenderTargetIdentifier)("_AO_TmpMip_" + i.ToString()), "_AO_TmpMip_" + i.ToString());
            }
            if (m_prevSampleCount != _settings.SampleCount.value
                || m_prevDownsample != _settings.Downsample.value
                || m_prevCacheAware != m_cacheAware
                || m_prevBlurEnabled != _settings.BlurEnabled.value
                || m_prevBlurPasses != _settings.BlurPasses.value
                || m_prevBlurRadius != _settings.BlurRadius.value
                || m_prevFilterEnabled != isUsingTemporalFilter
                || m_prevFilterDownsample != isUsingFilterDownsample
                || m_prevHDR != HDR
                || m_prevMSAA != MSAA)
            {
                bool prevHDR = m_prevHDR;
                bool prevMSAA = m_prevMSAA;
                m_HDR = HDR;
                m_MSAA = MSAA;
                m_clearHistory |= (prevHDR != HDR) | (prevMSAA != MSAA);
                m_paramsChanged = true;
            }
        }

        private void UpdateGlobalShaderConstants(CommandBuffer cb, ref CameraData cameraData)
        {
            bool isUsingTemporalFilter = UsingTemporalFilter(cameraData.isSceneViewCamera);
            cb.SetGlobalFloat(PropertyID._AO_Radius, _settings.Radius.value);
            cb.SetGlobalFloat(PropertyID._AO_PowExponent, _settings.PowerExponent.value);
            cb.SetGlobalFloat(PropertyID._AO_Bias, _settings.Bias.value * _settings.Bias.value);
            cb.SetGlobalColor(PropertyID._AO_Levels, new Color(_settings.Tint.value.r, _settings.Tint.value.g, _settings.Tint.value.b, _settings.Intensity.value));
            float invThickness = 1.0f - _settings.Thickness.value;
            cb.SetGlobalFloat(PropertyID._AO_ThicknessDecay, (1.0f - invThickness * invThickness) * 0.98f);
            float AO_BufDepthToLinearEye = cameraData.camera.farClipPlane * m_oneOverDepthScale;
            cb.SetGlobalFloat(PropertyID._AO_BufDepthToLinearEye, AO_BufDepthToLinearEye);
            if (_settings.BlurEnabled.value)
                cb.SetGlobalFloat(PropertyID._AO_BlurSharpness, AO_BufDepthToLinearEye * (_settings.BlurSharpness.value * 100f));
            if (_settings.FadeEnabled.value)
            {
                float fadeLength = _settings.FadeLength.value;
                cb.SetGlobalVector(PropertyID._AO_FadeParams, new Vector4(_settings.FadeStart.value, 1.0f / fadeLength, 0f, 0f));
                float invFadeThickness = 1.0f - _settings.FadeToThickness.value;
                cb.SetGlobalVector(PropertyID._AO_FadeValues, new Vector4(_settings.FadeToIntensity.value, _settings.FadeToRadius.value, _settings.FadeToPowerExponent.value, (1.0f - invFadeThickness * invFadeThickness) * 0.98f));
                cb.SetGlobalColor(PropertyID._AO_FadeToTint, new Color(_settings.FadeToTint.value.r, _settings.FadeToTint.value.g, _settings.FadeToTint.value.b, 0f));
            }
            else
            {
                cb.SetGlobalVector(PropertyID._AO_FadeParams, new Vector4(0f, 0f, 0f, 0f));
            }
            if (isUsingTemporalFilter)
            {
                AmplifyOcclusionCommon.CommandBuffer_TemporalFilterDirectionsOffsets(cb, m_sampleStep);
            }
            else
            {
                cb.SetGlobalFloat(PropertyID._AO_TemporalDirections, 0f);
                cb.SetGlobalFloat(PropertyID._AO_TemporalOffsets, 0f);
            }
            m_viewProjMatrix.UpdateGlobalShaderConstants_Matrices(cb, cameraData.camera, isUsingTemporalFilter);
        }

        public void UpdateParams(CommandBuffer cb, ref CameraData cameraData)
        {
            m_curStepIdx = m_sampleStep & 1u;
            bool isUsingFilterDownsample = UsingFilterDownsample(cameraData.isSceneViewCamera);
            AmplifyOcclusionCommon.UpdateGlobalShaderConstants(cb, ref m_target, ref cameraData, _settings.Downsample.value, isUsingFilterDownsample);
            CheckParamsChanged(ref cameraData);
            UpdateGlobalShaderConstants(cb, ref cameraData);
            bool useMotionVectors = UsingMotionVectors(cameraData.isSceneViewCamera) && m_sampleStep > 1;
            CoreUtils.SetKeyword(m_occlusionMat, "_USE_MOTION_VECTORS", useMotionVectors);
            CoreUtils.SetKeyword(m_applyOcclusionMat, "_USE_MOTION_VECTORS", useMotionVectors);
        }

        private void UpdatePrevParams(ref CameraData cameraData)
        {
            bool isUsingTemporalFilter = UsingTemporalFilter(cameraData.isSceneViewCamera);
            bool isUsingFilterDownsample = UsingFilterDownsample(cameraData.isSceneViewCamera);
            m_prevSampleCount = _settings.SampleCount.value;
            m_prevDownsample = _settings.Downsample.value;
            m_prevCacheAware = _settings.CacheAware.value;
            m_prevBlurEnabled = _settings.BlurEnabled.value;
            m_prevBlurPasses = _settings.BlurPasses.value;
            m_prevBlurRadius = _settings.BlurRadius.value;
            m_prevFilterEnabled = isUsingTemporalFilter;
            m_prevFilterDownsample = isUsingFilterDownsample;
            m_prevHDR = m_HDR;
            m_prevMSAA = m_MSAA;
            m_paramsChanged = false;
            m_sampleStep++;
        }

        private void PerformBlit(CommandBuffer cb, RTHandle destination, Material mat, int pass)
        {
            cb.SetRenderTarget(destination, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store);
            Blitter.BlitTexture(cb, Vector2.one, mat, pass);
        }

        private void Blur(CommandBuffer cb, RTHandle aSourceRT, int aSourceWidth, int aSourceHeight)
        {
            using (new ProfilingScope(cb, m_BlurSampler))
            {
                RenderingUtils.ReAllocateIfNeeded(ref m_tmpBlurRT, new RenderTextureDescriptor(aSourceWidth, aSourceHeight, m_occlusionRTFormat, 0), FilterMode.Point, TextureWrapMode.Repeat, false, 1, 0f, "_AO_BlurTmp");
                for (int i = 0; i < _settings.BlurPasses.value; i++)
                {
                    cb.SetGlobalTexture(PropertyID._AO_CurrOcclusionDepth, aSourceRT);
                    PerformBlit(cb, m_tmpBlurRT, m_blurMat, (_settings.BlurRadius.value - 1) * 2);
                    cb.SetGlobalTexture(PropertyID._AO_CurrOcclusionDepth, m_tmpBlurRT);
                    PerformBlit(cb, aSourceRT, m_blurMat, (_settings.BlurRadius.value - 1) * 2 + 1);
                }
            }
        }

        public void ComputeOcclusion(CommandBuffer cb, ref CameraData cameraData, [Optional] RenderTargetIdentifier mipChainBuffer, [Optional] Vector4[] minMaxArray)
        {
            bool isUsingFilterDownsample = UsingFilterDownsample(cameraData.isSceneViewCamera);
            bool downsample = _settings.Downsample.value;
            using (new ProfilingScope(cb, m_ComputeOcclusionSampler))
            {
                SampleCountLevel sampleCount = _settings.SampleCount.value;
                CoreUtils.SetKeyword(m_occlusionMat, "_GTAO_MEDIUM", sampleCount == SampleCountLevel.Medium);
                CoreUtils.SetKeyword(m_occlusionMat, "_GTAO_HIGH", sampleCount == SampleCountLevel.High);
                CoreUtils.SetKeyword(m_occlusionMat, "_GTAO_VERY_HIGH", sampleCount == SampleCountLevel.VeryHigh);
                CoreUtils.SetKeyword(m_occlusionMat, "_USE_DYNAMIC_DEPTH_MIPS", m_cacheAware);
                CoreUtils.SetKeyword(m_occlusionMat, "_GTAO_RECONSTRUCT_NORMAL", _settings.PerPixelNormals.value == PerPixelNormalSource.None);
                if (m_cacheAware)
                {
                    if (minMaxArray != null)
                    {
                        cb.SetGlobalVectorArray("_DepthMipMinMax", minMaxArray);
                        cb.SetGlobalTexture(PropertyID._AO_SourceDepthMipmap, mipChainBuffer);
                    }
                    else
                    {
                        var depthMipmapDescriptor = new RenderTextureDescriptor(m_target.fullWidth >> 1, m_target.fullHeight >> 1, GraphicsFormat.R32_SFloat, 0);
                        depthMipmapDescriptor.autoGenerateMips = false;
                        depthMipmapDescriptor.useMipMap = true;
                        depthMipmapDescriptor.mipCount = m_numberMips;
                        RenderingUtils.ReAllocateIfNeeded(ref m_depthMipmap, depthMipmapDescriptor, FilterMode.Point, TextureWrapMode.Clamp, false, 1, 0f, "_AO_DepthMipmap");
                        var mipDescriptor = new RenderTextureDescriptor(m_target.fullWidth, m_target.fullHeight, GraphicsFormat.R32_SFloat, 0);
                        for (int i = 0; i < m_numberMips; i++)
                        {
                            mipDescriptor.width >>= 1;
                            mipDescriptor.height >>= 1;
                            RenderingUtils.ReAllocateIfNeeded(ref m_tmpMipRTs[i], mipDescriptor, FilterMode.Bilinear, TextureWrapMode.Repeat, false, 1, 0f, m_tmpMipRTs[i].name);
                            cb.SetRenderTarget(m_tmpMipRTs[i]);
                            Blitter.BlitTexture(cb, Vector2.one, m_occlusionMat, i == 0 ? 5 : 4);
                            cb.CopyTexture(m_tmpMipRTs[i], 0, 0, m_depthMipmap, 0, i);
                            cb.SetGlobalTexture(PropertyID._AO_CurrDepthSource, m_tmpMipRTs[i]);
                        }
                        cb.SetGlobalTexture(PropertyID._AO_SourceDepthMipmap, m_depthMipmap);
                    }
                }
                if (!downsample || isUsingFilterDownsample)
                {
                    if (isUsingFilterDownsample)
                    {
                        float halfWidth = m_target.fullWidth * 0.5f;
                        float halfHeight = m_target.fullHeight * 0.5f;
                        cb.SetGlobalVector(PropertyID._AO_Target_TexelSize, new Vector4(1.0f / halfWidth, 1.0f / halfHeight, halfWidth, halfHeight));
                    }
                    else
                    {
                        cb.SetGlobalVector(PropertyID._AO_Target_TexelSize, new Vector4(1.0f / m_target.width, 1.0f / m_target.height, m_target.width, m_target.height));
                    }
                    PerformBlit(cb, m_occlusionDepthRT, m_occlusionMat, 0);
                }
                else
                {
                    RenderingUtils.ReAllocateIfNeeded(ref m_tmpSmallOcclusionRT, new RenderTextureDescriptor(m_target.fullWidth / 2, m_target.fullHeight / 2, m_occlusionRTFormat, 0), FilterMode.Bilinear, TextureWrapMode.Repeat, false, 1, 0f, "_AO_SmallOcclusionTexture");
                    float halfWidth = m_target.fullWidth * 0.5f;
                    float halfHeight = m_target.fullHeight * 0.5f;
                    cb.SetGlobalVector(PropertyID._AO_Target_TexelSize, new Vector4(1.0f / halfWidth, 1.0f / halfHeight, halfWidth, halfHeight));
                    PerformBlit(cb, m_tmpSmallOcclusionRT, m_occlusionMat, 0);
                }
            }
        }

        public void RenderBlurAndCombine(CommandBuffer cb, ref CameraData cameraData)
        {
            if (_settings.Downsample.value && !UsingFilterDownsample(cameraData.isSceneViewCamera))
            {
                int fullWidth = m_target.fullWidth;
                int fullHeight = m_target.fullHeight;
                if (_settings.BlurEnabled.value)
                    Blur(cb, m_tmpSmallOcclusionRT, m_target.fullWidth / 2, m_target.fullHeight / 2);
                using (new ProfilingScope(cb, m_CombineSampler))
                {
                    cb.SetGlobalTexture(PropertyID._AO_CurrOcclusionDepth, m_tmpSmallOcclusionRT);
                    cb.SetGlobalVector(PropertyID._AO_Target_TexelSize, new Vector4(1.0f / fullWidth, 1.0f / fullHeight, fullWidth, fullHeight));
                    PerformBlit(cb, m_occlusionDepthRT, m_occlusionMat, 1);
                }
            }
            else
            {
                if (_settings.BlurEnabled.value)
                    Blur(cb, m_occlusionDepthRT, m_target.width, m_target.height);
            }
        }

        private void ClearHistory(CommandBuffer cb)
        {
            m_clearHistory = false;
            if (m_temporalAccumRT != null && m_occlusionDepthRT != null)
            {
                cb.SetGlobalTexture(PropertyID._AO_CurrOcclusionDepth, m_occlusionDepthRT);
                cb.SetRenderTarget(m_temporalAccumRT[0]);
                Blitter.BlitTexture(cb, Vector2.one, m_occlusionMat, 3);
                cb.SetGlobalTexture(PropertyID._AO_CurrOcclusionDepth, m_occlusionDepthRT);
                cb.SetRenderTarget(m_temporalAccumRT[1]);
                Blitter.BlitTexture(cb, Vector2.one, m_occlusionMat, 3);
            }
        }

        private void TemporalFilter(CommandBuffer cb)
        {
            if (m_clearHistory)
                ClearHistory(cb);
            cb.SetGlobalFloat(PropertyID._AO_TemporalCurveAdj, Mathf.Lerp(0.01f, 0.99f, _settings.FilterBlending.value));
            cb.SetGlobalFloat(PropertyID._AO_TemporalMotionSensibility, _settings.FilterResponse.value * _settings.FilterResponse.value + 0.01f);
            cb.SetGlobalTexture(PropertyID._AO_CurrOcclusionDepth, m_occlusionDepthRT);
            cb.SetGlobalTexture(PropertyID._AO_TemporalAccumm, m_temporalAccumRT[1 - m_curStepIdx]);
        }

        private void NeighborMotionIntensity(CommandBuffer cb, int aSourceWidth, int aSourceHeight)
        {
            var intensityDescriptor = new RenderTextureDescriptor(aSourceWidth / 4, aSourceHeight / 4, m_motionIntensityRTFormat, 0);
            RenderingUtils.ReAllocateIfNeeded(ref m_tmpAOIntensityRT, intensityDescriptor, FilterMode.Bilinear, TextureWrapMode.Repeat, false, 1, 0f, "_AO_IntensityTmp");
            float quarterWidth = aSourceWidth / 4.0f;
            float quarterHeight = aSourceHeight / 4.0f;
            cb.SetGlobalVector("_AO_Target_TexelSize", new Vector4(1.0f / quarterWidth, 1.0f / quarterHeight, quarterWidth, quarterHeight));
            PerformBlit(cb, m_tmpAOIntensityRT, m_occlusionMat, 2);
            RenderingUtils.ReAllocateIfNeeded(ref m_tmpAOBlurIntensityRT, intensityDescriptor, FilterMode.Bilinear, TextureWrapMode.Repeat, false, 1, 0f, "_AO_BlurIntensityTmp");
            cb.SetGlobalTexture(PropertyID._AO_CurrMotionIntensity, m_tmpAOIntensityRT);
            PerformBlit(cb, m_tmpAOBlurIntensityRT, m_blurMat, 8);
            cb.SetGlobalTexture(PropertyID._AO_CurrMotionIntensity, m_tmpAOBlurIntensityRT);
            PerformBlit(cb, m_tmpAOIntensityRT, m_blurMat, 9);
            cb.SetGlobalTexture(PropertyID._AO_CurrMotionIntensity, m_tmpAOIntensityRT);
        }

        public void RenderTemporal(CommandBuffer cb, ref CameraData cameraData)
        {
            using (new ProfilingScope(cb, m_TemporalSampler))
            {
                if (UsingTemporalFilter(cameraData.isSceneViewCamera))
                {
                    TemporalFilter(cb);
                    if (UsingMotionVectors(cameraData.isSceneViewCamera))
                        NeighborMotionIntensity(cb, m_target.fullWidth, m_target.fullHeight);
                    if (UsingFilterDownsample(cameraData.isSceneViewCamera))
                    {
                        RenderTargetIdentifier temporalTarget = m_temporalAccumRT[m_curStepIdx];
                        cb.SetRenderTarget(temporalTarget, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store);
                        Blitter.BlitTexture(cb, Vector2.one, m_occlusionMat, 6);
                        cb.SetGlobalTexture(PropertyID._AO_TemporalAccumm, temporalTarget);
                    }
                }
            }
            UpdatePrevParams(ref cameraData);
        }

        public void ApplyOcclusion(CommandBuffer cb, ref CameraData cameraData, RTHandle aDestinyRT)
        {
            ApplicationMethod applyMethod = _settings.ApplyMethod.value;
            using (new ProfilingScope(cb, m_ApplyOcclusionSampler))
            {
                if (UsingTemporalFilter(cameraData.isSceneViewCamera))
                {
                    if (UsingFilterDownsample(cameraData.isSceneViewCamera))
                    {
                        cb.SetRenderTarget(aDestinyRT);
                        Blitter.BlitTexture(cb, Vector2.one, m_applyOcclusionMat, applyMethod == ApplicationMethod.Debug ? 4 : 5);
                    }
                    else
                    {
                        applyDebugTargetsTemporal[0] = aDestinyRT;
                        applyDebugTargetsTemporal[1] = m_temporalAccumRT[m_curStepIdx];
                        cb.SetRenderTarget(applyDebugTargetsTemporal, applyDebugTargetsTemporal[0]);
                        Blitter.BlitTexture(cb, Vector2.one, m_applyOcclusionMat, applyMethod == ApplicationMethod.Debug ? 1 : 3);
                    }
                }
                else
                {
                    cb.SetGlobalTexture(PropertyID._AO_CurrOcclusionDepth, m_occlusionDepthRT);
                    cb.SetRenderTarget(aDestinyRT);
                    Blitter.BlitTexture(cb, Vector2.one, m_applyOcclusionMat, applyMethod == ApplicationMethod.Debug ? 0 : 2);
                }
            }
        }
    }
}
