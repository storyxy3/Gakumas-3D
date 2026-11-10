// TODO(qa-recon): Native parity is incomplete: URP MipChainBuffer/RenderingUtility dependencies, compiler helper names, SSAO/SSR and shadow branch code still have semantic flags; see TASK_D_REPORT.md.
namespace VL.Rendering
{
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Experimental.Rendering;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::UnityEngine.Rendering.Universal.Internal;
    using global::VL;
    using global::VL.Rendering;
    using global::VL.Rendering.Shaders;

    public class DownscalePass : ScriptableRenderPass
    {
        // DMM PC (D32) vs APK (D24): the platform switch of UniversalRenderer.k_DepthStencilFormat.
#if (UNITY_SWITCH || UNITY_ANDROID) && !UNITY_EDITOR
        const GraphicsFormat k_DepthStencilFormat = GraphicsFormat.D24_UNorm_S8_UInt;
#else
        const GraphicsFormat k_DepthStencilFormat = GraphicsFormat.D32_SFloat_S8_UInt;
#endif
        public enum SSAOBlurTypes
        {
            Bilateral,
            Gaussian,
            Kawase
        }

        public enum SSAOShaderPasses
        {
            AmbientOcclusion,
            BilateralBlurHorizontal,
            BilateralBlurVertical,
            BilateralBlurFinal,
            BilateralAfterOpaque,
            GaussianBlurHorizontal,
            GaussianBlurVertical,
            GaussianAfterOpaque,
            KawaseBlur,
            KawaseAfterOpaque
        }

        public static readonly string _SCREEN_SPACE_REFLECTION = "_SCREEN_SPACE_REFLECTION";
        public static readonly string _DIRECT_REFLECTION = "_DIRECT_REFLECTION";
        public static readonly string _USE_HIZ_DEPTH = "_USE_HIZ_DEPTH";
        public static readonly int ShaderVariablesScreenSpaceReflection = Shader.PropertyToID("ShaderVariablesScreenSpaceReflection");
        private static readonly int _LitColorTexture = Shader.PropertyToID("_LitColorTexture");
        private static readonly int _ActorAOCapsuleA = Shader.PropertyToID("_ActorAOCapsuleA");
        private static readonly int _ActorAOCapsuleB = Shader.PropertyToID("_ActorAOCapsuleB");
        private static readonly int _TaaParams = Shader.PropertyToID("_TaaParams");
        private static readonly int _TaaAccumulationTex = Shader.PropertyToID("_TaaAccumulationTex");
        private static readonly ProfilingSampler _ssrTraceProfilingSampler = new ProfilingSampler("SSR Trace");
        private static readonly ProfilingSampler _resolveReflectionProfilingSampler = new ProfilingSampler("Resolve Reflection");
        private static readonly ProfilingSampler _renderReflectionProfilingSampler = new ProfilingSampler("Render Reflection");
        private static readonly ProfilingSampler _renderShadowAndOcclusionProfilingSampler = new ProfilingSampler("Render Shadow And Occlusion");
        private readonly Material _downscaleBufferMaterial;
        private readonly Mesh _boxMesh;
        private readonly Vector4[] _actorAOCapsuleAArray = new Vector4[2];
        private readonly Vector4[] _actorAOCapsuleBArray = new Vector4[2];
        private MaterialPropertyBlock _actorAOPropertyBlock;
        public ShaderVariablesScreenSpaceReflection shaderVariablesScreenSpaceReflectionCB;
        private DownscaleBuffers _buffers;
        private bool _isDeferredRenderingMode;
        private Vector2 _lastJitterOffset;
        private DeferredLights _deferredLights;
        private MipChainBuffer _hizDepthBuffer;
        private PlanarReflectionDrawSystem _planarReflectionDrawSystem;
        private VLSSRQualitySetting _ssrQuality;
        private Matrix4x4 _reflectionMatrix;
        private Matrix4x4 _projectionMatrix;
        private ConvolutionBlur _reflectionBlur;
        private CustomRenderPassData _downscaleRenderPass;
        private CustomSubPassData[] _downscaleSubPasses;
        private CustomRenderPassData _downscaleNonReflectionRenderPass;
        private CustomSubPassData[] _downscaleNonReflectionSubPasses;
        private Texture2D _clearTexture;
        private int _resolveReflectionShaderPass = 7;
        private int _traceSSRShaderPass = 5;
        private AmplifyOcclusionRenderingData _amplifiedOcclusion;
        private Vector4[] _mipMinMaxArray = new Vector4[14];
        private const string k_AOInterleavedGradientKeyword = "_INTERLEAVED_GRADIENT";
        private const string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC";
        private const string k_SourceDepthLowKeyword = "_SOURCE_DEPTH_LOW";
        private const string k_SourceDepthMediumKeyword = "_SOURCE_DEPTH_MEDIUM";
        private const string k_SourceDepthHighKeyword = "_SOURCE_DEPTH_HIGH";
        private const string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS";
        private const string k_SampleCountLowKeyword = "_SAMPLE_COUNT_LOW";
        private const string k_SampleCountMediumKeyword = "_SAMPLE_COUNT_MEDIUM";
        private const string k_SampleCountHighKeyword = "_SAMPLE_COUNT_HIGH";
        private bool m_SupportsR8RenderTextureFormat = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.R8);
        private Material m_Material;
        private Vector4[] m_CameraTopLeftCorner = new Vector4[2];
        private Vector4[] m_CameraXExtent = new Vector4[2];
        private Vector4[] m_CameraYExtent = new Vector4[2];
        private Vector4[] m_CameraZExtent = new Vector4[2];
        private RTHandle[] m_SSAOTextures = new RTHandle[4];
        private SSAOBlurTypes m_BlurType;
        private Matrix4x4[] m_CameraViewProjections = new Matrix4x4[2];
        private RenderTextureDescriptor m_AOPassDescriptor;
        private const int k_FinalTexID = 3;
        private const string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture";
        private const string k_SSAOAmbientOcclusionParamName = "_AmbientOcclusionParam";
        private static readonly int s_SSAOParamsID = Shader.PropertyToID("_SSAOParams");
        private static readonly int s_LastKawasePass = Shader.PropertyToID("_LastKawasePass");
        private static readonly int s_CameraViewXExtentID = Shader.PropertyToID("_CameraViewXExtent");
        private static readonly int s_CameraViewYExtentID = Shader.PropertyToID("_CameraViewYExtent");
        private static readonly int s_CameraViewZExtentID = Shader.PropertyToID("_CameraViewZExtent");
        private static readonly int s_ProjectionParams2ID = Shader.PropertyToID("_ProjectionParams2");
        private static readonly int s_KawaseBlurIterationID = Shader.PropertyToID("_KawaseBlurIteration");
        private static readonly int s_CameraViewProjectionsID = Shader.PropertyToID("_CameraViewProjections");
        private static readonly int s_CameraViewTopLeftCornerID = Shader.PropertyToID("_CameraViewTopLeftCorner");
        private static readonly int[] m_BilateralTexturesIndices = new[] { 0, 1, 2, 3 };
        private static readonly SSAOShaderPasses[] m_BilateralPasses = new[] { SSAOShaderPasses.BilateralBlurHorizontal, SSAOShaderPasses.BilateralBlurVertical, SSAOShaderPasses.BilateralBlurFinal };
        private static readonly SSAOShaderPasses[] m_BilateralAfterOpaquePasses = new[] { SSAOShaderPasses.BilateralBlurHorizontal, SSAOShaderPasses.BilateralBlurVertical, SSAOShaderPasses.BilateralAfterOpaque };
        private static readonly int[] m_GaussianTexturesIndices = new[] { 0, 1, 3, 3 };
        private static readonly SSAOShaderPasses[] m_GaussianPasses = new[] { SSAOShaderPasses.GaussianBlurHorizontal, SSAOShaderPasses.GaussianBlurVertical };
        private static readonly SSAOShaderPasses[] m_GaussianAfterOpaquePasses = new[] { SSAOShaderPasses.GaussianBlurHorizontal, SSAOShaderPasses.GaussianAfterOpaque };
        private static readonly int[] m_KawaseTexturesIndices = new[] { 0, 3 };
        private static readonly SSAOShaderPasses[] m_KawasePasses = new[] { SSAOShaderPasses.KawaseBlur };
        private static readonly SSAOShaderPasses[] m_KawaseAfterOpaquePasses = new[] { SSAOShaderPasses.KawaseAfterOpaque };
        private bool _isSSAOActive;
        private ProfilingSampler _ssaoProfilingSampler = new ProfilingSampler("Downscale SSAO");
        private Material _ssaoMaterial;
        public DownscalePass(Mesh boxMesh, Material downscaleBufferMaterial, DownscaleBuffers buffers)
        {
            if (SystemInfo.deviceModel.Contains("Pixel 10"))
            {
                _resolveReflectionShaderPass = 8;
                _traceSSRShaderPass = 6;
            }
            profilingSampler = new ProfilingSampler("DownscalePass");
            _boxMesh = boxMesh;
            _downscaleBufferMaterial = downscaleBufferMaterial;
            _buffers = buffers;
            _reflectionBlur = new ConvolutionBlur(_downscaleBufferMaterial, 11, 2);
            var attachments = new[]
            {
                new AttachmentDescriptor((GraphicsFormat)48) { loadAction = RenderBufferLoadAction.Clear, storeAction = RenderBufferStoreAction.DontCare, clearColor = Color.clear },
                new AttachmentDescriptor((GraphicsFormat)48) { loadAction = RenderBufferLoadAction.Clear, storeAction = RenderBufferStoreAction.Store, clearColor = Color.clear },
                new AttachmentDescriptor((GraphicsFormat)6) { loadAction = RenderBufferLoadAction.DontCare, storeAction = RenderBufferStoreAction.Store },
                new AttachmentDescriptor(k_DepthStencilFormat) { loadAction = RenderBufferLoadAction.Clear, storeAction = RenderBufferStoreAction.Store, clearStencil = 2 }
            };
            _downscaleRenderPass = new CustomRenderPassData { attachmentDescriptors = attachments, depthAttachmentIndex = attachments.Length - 1, memoryless = new[] { true, false, false, false } };
            _downscaleSubPasses = new[]
            {
                new CustomSubPassData { colors = new[] { 2 }, renderAction = RenderShadowAndOcclusion },
                new CustomSubPassData { colors = new[] { 0 }, renderAction = RenderDirectReflection },
                new CustomSubPassData { colors = new[] { 1 }, inputs = new[] { 0 }, renderAction = ResolveDirectReflection }
            };
            _downscaleNonReflectionRenderPass = new CustomRenderPassData
            {
                attachmentDescriptors = new[]
                {
                    new AttachmentDescriptor((GraphicsFormat)6) { loadAction = RenderBufferLoadAction.DontCare, storeAction = RenderBufferStoreAction.Store },
                    new AttachmentDescriptor(k_DepthStencilFormat) { loadAction = RenderBufferLoadAction.Clear, storeAction = RenderBufferStoreAction.Store }
                },
                depthAttachmentIndex = 1
            };
            _downscaleNonReflectionSubPasses = new[] { new CustomSubPassData { colors = new[] { 0 }, renderAction = RenderShadowAndOcclusion } };
            _clearTexture = new Texture2D(1, 1, DefaultFormat.LDR, UnityEngine.Experimental.Rendering.TextureCreationFlags.None)
            {
                wrapMode = TextureWrapMode.Clamp, filterMode = FilterMode.Point, anisoLevel = 0, hideFlags = HideFlags.HideAndDontSave
            };
            _clearTexture.SetPixel(0, 0, Color.clear);
            _clearTexture.Apply(false, true);
        }

        public void Dispose()
        {
            DisposeSSAO();
            if (_clearTexture != null) Object.DestroyImmediate(_clearTexture);
            _reflectionBlur?.Dispose();
            _hizDepthBuffer?.Dispose();
        }

        public void InitializeHiZ(ComputeShader hizCompute)
        {
            if (MipChainBuffer.IsSupported(hizCompute, (GraphicsFormat)49))
                _hizDepthBuffer = new MipChainBuffer(hizCompute, (GraphicsFormat)49, "_DepthMipChain");
        }

        public void Setup(DeferredLights deferredLights, VLSSRQualitySetting ssrQuality)
        {
            _deferredLights = deferredLights;
            _ssrQuality = ssrQuality;
        }

        public void SetPlanarReflectionDrawSystem(PlanarReflectionDrawSystem planarReflectionDrawSystem)
        {
            _planarReflectionDrawSystem = planarReflectionDrawSystem;
        }

        public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
        {
            OnCameraSetupSSAO(cmd, ref renderingData);
            ResetTarget();
        }

        public override void OnCameraCleanup(CommandBuffer cmd)
        {
            CoreUtils.SetKeyword(cmd, _SCREEN_SPACE_REFLECTION, false);
            CoreUtils.SetKeyword(cmd, _DIRECT_REFLECTION, false);
            CoreUtils.SetKeyword(cmd, _USE_HIZ_DEPTH, false);
            _deferredLights.renderedDirectReflection = false;
            OnCameraCleanupSSAO(cmd);
            OnCameraCleanupAmplifyOcclusion(cmd);
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, profilingSampler))
            {
                bool flipped = renderingData.cameraData.IsCameraProjectionMatrixFlipped();
                float sign = flipped ? -1f : 1f;
                cmd.SetGlobalVector(ShaderPropertyId.scaleBiasRt, new Vector4(sign, flipped ? 1f : 0f, sign, 1f));
                VLRenderingCompatibility.SetGlobalMipBias(cmd, ref renderingData.cameraData, 0.5f);
                if ((_ssrQuality != 0 || _amplifiedOcclusion != null) && _hizDepthBuffer != null)
                {
                    int width = renderingData.cameraData.cameraTargetDescriptor.width >> 1;
                    int height = renderingData.cameraData.cameraTargetDescriptor.height >> 1;
                    _hizDepthBuffer.UpdateMipChainParams(width, height);
                    _hizDepthBuffer.Execute(cmd, width, height, null);
                    CoreUtils.SetKeyword(cmd, _USE_HIZ_DEPTH, true);
                }
                else CoreUtils.SetKeyword(cmd, _USE_HIZ_DEPTH, false);
                RenderSSAO(cmd);
                RenderAmplifyOcclusion(cmd, ref renderingData.cameraData);
                context.ExecuteCommandBuffer(cmd);
                cmd.Clear();
                RenderDownscale(context, ref renderingData, cmd);
                RegisterAfterCommand(cmd, ref renderingData.cameraData);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        private void RenderDownscale(ScriptableRenderContext context, ref RenderingData renderingData, CommandBuffer cmd)
        {
            _planarReflectionDrawSystem?.CompleteJob();
            int cameraId = renderingData.cameraData.camera.GetHashCode();
            bool hasAlpha = GraphicsFormatUtility.HasAlphaChannel(renderingData.cameraData.cameraTargetDescriptor.graphicsFormat);
            RenderTargetIdentifier litColor = default;
            var renderer = renderingData.cameraData.renderer as VLSRPRenderer;
            if (renderer != null && renderer.renderingModeActual != RenderingMode.Forward && !hasAlpha && _hizDepthBuffer != null)
            {
                renderer.deferredLights.storeLitColor = _ssrQuality != 0;
                if (renderer.IsLitColorRendered(cameraId)) litColor = renderer.GetLitColorTexture(cameraId).nameID;
                else _ssrQuality = 0;
            }
            else _ssrQuality = 0;
            _deferredLights.renderedDirectReflection = _ssrQuality != 0 || (_planarReflectionDrawSystem != null && _planarReflectionDrawSystem.IsActive);
            var descriptor = renderingData.cameraData.cameraTargetDescriptor;
            descriptor.width >>= 1;
            descriptor.height >>= 1;
            descriptor.msaaSamples = 1;
            descriptor.depthStencilFormat = GraphicsFormat.None;
            descriptor.graphicsFormat = (GraphicsFormat)6;
            RenderingUtils.ReAllocateIfNeeded(ref _buffers.shadowAndOcclusion, descriptor, FilterMode.Bilinear, TextureWrapMode.Repeat, name: _buffers.shadowAndOcclusion.name);
            cmd.SetGlobalTexture(_buffers.shadowAndOcclusion.name, _buffers.shadowAndOcclusion.nameID);
            var reflectionDescriptor = descriptor;
            reflectionDescriptor.graphicsFormat = (GraphicsFormat)48;
            RenderingUtils.ReAllocateIfNeeded(ref _buffers.tmpDirectReflection, reflectionDescriptor, FilterMode.Bilinear, TextureWrapMode.Repeat, name: _buffers.tmpDirectReflection.name);
            _buffers.accumulation.ReAllocateIfNeeded(cameraId, reflectionDescriptor, FilterMode.Bilinear, TextureWrapMode.Clamp, "_TaaAccumulationTex");
            reflectionDescriptor.useMipMap = true;
            reflectionDescriptor.mipCount = 3;
            reflectionDescriptor.autoGenerateMips = false;
            RenderingUtils.ReAllocateIfNeeded(ref _buffers.directReflection, reflectionDescriptor, FilterMode.Trilinear, TextureWrapMode.Repeat, name: _buffers.directReflection.name);
            cmd.SetGlobalTexture(_buffers.directReflection.name, _buffers.directReflection.nameID);
            descriptor.graphicsFormat = GraphicsFormat.None;
            descriptor.depthStencilFormat = k_DepthStencilFormat;
            RenderingUtils.ReAllocateIfNeeded(ref _buffers.depthTexture, descriptor, FilterMode.Point, TextureWrapMode.Clamp, name: _buffers.depthTexture.name);
            cmd.SetGlobalTexture(_buffers.depthTexture.name, _buffers.depthTexture.nameID);
            int resetHistoryFrames = renderingData.cameraData.taaSettings.resetHistoryFrames;
            float blend = 1f;
            if (resetHistoryFrames <= 0)
            {
                blend = VLRenderingCompatibility.GetFrameInfluence(ref renderingData.cameraData.taaSettings);
                if (_ssrQuality != 0)
                {
                    SetupTraceSSR(cmd, ref renderingData.cameraData);
                    cmd.SetGlobalTexture(_LitColorTexture, litColor);
                    CoreUtils.SetKeyword(cmd, _SCREEN_SPACE_REFLECTION, true);
                }
                else CoreUtils.SetKeyword(cmd, _SCREEN_SPACE_REFLECTION, false);
            }
            else CoreUtils.SetKeyword(cmd, _SCREEN_SPACE_REFLECTION, false);
            CoreUtils.SetKeyword(cmd, _DIRECT_REFLECTION, _deferredLights.renderedDirectReflection);
            context.ExecuteCommandBuffer(cmd);
            cmd.Clear();
            if (_deferredLights.renderedDirectReflection)
            {
                _downscaleRenderPass.width = descriptor.width;
                _downscaleRenderPass.height = descriptor.height;
                var cameraType = renderingData.cameraData.cameraType;
                _downscaleRenderPass.attachmentDescriptors[1].loadStoreTarget = cameraType == CameraType.Game ? _buffers.tmpDirectReflection.nameID : _buffers.directReflection.nameID;
                _downscaleRenderPass.attachmentDescriptors[2].loadStoreTarget = _buffers.shadowAndOcclusion.nameID;
                _downscaleRenderPass.attachmentDescriptors[3].loadStoreTarget = _buffers.depthTexture.nameID;
                CustomRenderPassUtility.Execute(context, ref renderingData, _downscaleRenderPass, _downscaleSubPasses);
                if (cameraType == CameraType.Game)
                {
                    var accumulation = _buffers.accumulation.GetTexture(cameraId);
                    _downscaleBufferMaterial.SetTexture(_TaaAccumulationTex, _buffers.accumulation.IsRendered(cameraId) ? (Texture)accumulation : _clearTexture);
                    if (resetHistoryFrames > 0 || renderingData.cameraData.antialiasing != AntialiasingMode.TemporalAntiAliasing) _lastJitterOffset = Vector2.zero;
                    _downscaleBufferMaterial.SetVector(_TaaParams, new Vector4(_lastJitterOffset.x, _lastJitterOffset.y, 0f, blend));
                    int frame = Time.frameCount & 1023;
                    _lastJitterOffset = new Vector2((HaltonSequence.Get(frame + 1, 2) - 0.5f) / renderingData.cameraData.cameraTargetDescriptor.width,
                        (HaltonSequence.Get(frame + 1, 3) - 0.5f) / renderingData.cameraData.cameraTargetDescriptor.height);
                    Blitter.BlitCameraTexture(cmd, _buffers.tmpDirectReflection, _buffers.directReflection, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store, _downscaleBufferMaterial, 9);
                    CoreUtils.SetRenderTarget(cmd, accumulation, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store, ClearFlag.None, Color.clear);
                    Blitter.BlitTexture2D(cmd, _buffers.directReflection, new Vector4(1f, 1f, 0f, 0f), 0f, false);
                }
                _reflectionBlur.Execute(cmd, _buffers.directReflection, reflectionDescriptor);
                _buffers.accumulation.MarkAsRendered(cameraId);
            }
            else
            {
                CoreUtils.SetRenderTarget(cmd, (RenderTargetIdentifier)_buffers.shadowAndOcclusion, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store,
                    (RenderTargetIdentifier)_buffers.depthTexture, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, ClearFlag.DepthStencil);
                RenderShadowAndOcclusion(cmd, ref renderingData);
            }
        }

        private void SetupTraceSSR(CommandBuffer cmd, ref CameraData cameraData)
        {
            float steps;
            switch ((int)_ssrQuality)
            {
                case 1: steps = 32f; break;
                case 2: steps = 48f; break;
                case 3: steps = 96f; break;
                default: throw new System.ArgumentOutOfRangeException();
            }
            var camera = cameraData.camera;
            var motion = VLRenderingCompatibility.GetMotionVectorData(ref cameraData);
            shaderVariablesScreenSpaceReflectionCB._SSRPrevVPMatrix = motion != null ? motion.previousViewProjection : camera.previousViewProjectionMatrix;
            shaderVariablesScreenSpaceReflectionCB._Params = new Vector4(_hizDepthBuffer.MipCount - 1, steps, 0f, 0f);
            _hizDepthBuffer.CopyToMipMinMax(shaderVariablesScreenSpaceReflectionCB.MipMinMaxSpan);
            ConstantBuffer.Push(cmd, shaderVariablesScreenSpaceReflectionCB, _downscaleBufferMaterial, ShaderVariablesScreenSpaceReflection);
        }

        private void RenderDirectReflection(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, _renderReflectionProfilingSampler))
            {
                _planarReflectionDrawSystem?.DrawPlanarReflections(cmd, context, ref renderingData);
                if (_ssrQuality != 0)
                {
                    using (new ProfilingScope(cmd, _ssrTraceProfilingSampler))
                    {
                        Vector2 scale = Vector2.one;
                        Blitter.BlitTexture(cmd, new Vector4(scale.x, scale.y, 0f, 0f), _downscaleBufferMaterial, _traceSSRShaderPass);
                    }
                }
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        private void ResolveDirectReflection(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, _resolveReflectionProfilingSampler))
            {
                Vector2 scale = Vector2.one;
                Blitter.BlitTexture(cmd, new Vector4(scale.x, scale.y, 0f, 0f), _downscaleBufferMaterial, _resolveReflectionShaderPass);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        private void RenderShadowAndOcclusion(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var cmd = CommandBufferPool.Get();
            RenderShadowAndOcclusion(cmd, ref renderingData);
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        private void RenderShadowAndOcclusion(CommandBuffer cmd, ref RenderingData renderingData)
        {
            using (new ProfilingScope(cmd, _renderShadowAndOcclusionProfilingSampler))
            {
                bool shadows = renderingData.shadowData.supportsMainLightShadows;
                int cascades = renderingData.shadowData.mainLightShadowCascadesCount;
                CoreUtils.SetKeyword(cmd, "_MAIN_LIGHT_SHADOWS", cascades == 1 && shadows);
                CoreUtils.SetKeyword(cmd, "_MAIN_LIGHT_SHADOWS_CASCADE", cascades > 1 && shadows);
                Vector2 scale = Vector2.one;
                Blitter.BlitTexture(cmd, new Vector4(scale.x, scale.y, 0f, 0f), _downscaleBufferMaterial, 13);
                CoreUtils.SetKeyword(cmd, "_MAIN_LIGHT_SHADOWS", false);
                CoreUtils.SetKeyword(cmd, "_MAIN_LIGHT_SHADOWS_CASCADE", false);
                CoreUtils.SetKeyword(cmd, "_MAIN_LIGHT_SHADOWS_SCREEN", true);
                RenderActorAOs(cmd, renderingData.cameraData.camera);
            }
        }

        private void RenderActorAOs(CommandBuffer cmd, Camera camera)
        {
            var actors = VL.Core.VLActorController.actorControllers;
            if (actors == null) return;
            var view = camera.worldToCameraMatrix;
            var vp = camera.projectionMatrix * view;
            var planes = new CameraPlanes(vp);
            int count = actors.Count;
            for (int i = 0; i < count; i++) RenderActorAO(cmd, actors[i], ref planes);
        }

        private void RenderActorAO(CommandBuffer cmd, IVLActorController actorController, ref CameraPlanes cullingPlanes)
        {
            if (actorController == null || !actorController.IsRendererActive()) return;
            var bounds = actorController.bounds;
            bounds.Expand(0.5f);
            if (!cullingPlanes.TestAABB(bounds) || !actorController.TryGetComponent<VLActorAO>(out var ao)) return;
            var matrix = Matrix4x4.TRS(bounds.center, Quaternion.identity, bounds.size);
            if (_actorAOPropertyBlock == null) _actorAOPropertyBlock = new MaterialPropertyBlock();
            Unity.Collections.NativeArray<Vector4>.Copy(ao.capsuleA, _actorAOCapsuleAArray);
            Unity.Collections.NativeArray<Vector4>.Copy(ao.capsuleB, _actorAOCapsuleBArray);
            _actorAOPropertyBlock.SetVectorArray(_ActorAOCapsuleA, _actorAOCapsuleAArray);
            _actorAOPropertyBlock.SetVectorArray(_ActorAOCapsuleB, _actorAOCapsuleBArray);
            cmd.DrawMesh(_boxMesh, matrix, _downscaleBufferMaterial, 0, 2);
            cmd.DrawMesh(_boxMesh, matrix, _downscaleBufferMaterial, 0, 4, _actorAOPropertyBlock);
        }

        private void RegisterAfterCommand(CommandBuffer cmd, ref CameraData cameraData)
        {
            VLRenderingCompatibility.SetGlobalMipBias(cmd, ref cameraData, 1f);
        }

        public void SetupAmplifyOcclusion(AmplifyOcclusionRenderingData amplifyOcclusionRenderingData)
        {
            _amplifiedOcclusion = amplifyOcclusionRenderingData;
        }

        private void OnCameraCleanupAmplifyOcclusion(CommandBuffer cmd)
        {
            CoreUtils.SetKeyword(cmd, "_AMPLIFY_OCCLUSION", false);
            CoreUtils.SetKeyword(cmd, "_AMPLIFY_OCCLUSION_TEMPORAL", false);
        }

        private void RenderAmplifyOcclusion(CommandBuffer cmd, ref CameraData cameraData)
        {
            CoreUtils.SetKeyword(cmd, "_AMPLIFY_OCCLUSION", _hizDepthBuffer != null && _amplifiedOcclusion != null && !_amplifiedOcclusion.UsingTemporalFilter(cameraData.isSceneViewCamera));
            CoreUtils.SetKeyword(cmd, "_AMPLIFY_OCCLUSION_TEMPORAL", _hizDepthBuffer != null && _amplifiedOcclusion != null && _amplifiedOcclusion.UsingTemporalFilter(cameraData.isSceneViewCamera));
            if (_amplifiedOcclusion == null || _hizDepthBuffer == null) return;
            _amplifiedOcclusion.UpdateParams(cmd, ref cameraData);
            _hizDepthBuffer.CopyToMipMinMax(System.MemoryExtensions.AsSpan(_mipMinMaxArray));
            _amplifiedOcclusion.ComputeOcclusion(cmd, ref cameraData, _hizDepthBuffer.nameID, _mipMinMaxArray);
            _amplifiedOcclusion.RenderBlurAndCombine(cmd, ref cameraData);
            _amplifiedOcclusion.RenderTemporal(cmd, ref cameraData);
        }

        public void InitializeSSAO(Material ssaoMaterial)
        {
            _ssaoMaterial = ssaoMaterial;
        }

        private void DisposeSSAO()
        {
            for (int i = 0; i < m_SSAOTextures.Length; i++) m_SSAOTextures[i]?.Release();
        }

        public void SetupSSAO(bool isSSAOActive)
        {
            _isSSAOActive = isSSAOActive;
        }

        private void OnCameraSetupSSAO(CommandBuffer cmd, ref RenderingData renderingData)
        {
            if (!_isSSAOActive || _ssaoMaterial == null) return;
            var descriptor = renderingData.cameraData.cameraTargetDescriptor;
            var settings = VolumeManager.instance.stack.GetComponent<VLScreenSpaceAmbientOcclusion>();
            var view = renderingData.cameraData.GetViewMatrix();
            var projection = renderingData.cameraData.GetProjectionMatrix();
            m_CameraViewProjections[0] = projection * view;
            var rotationView = view;
            rotationView.SetColumn(3, new Vector4(0f, 0f, 0f, 1f));
            var vp = projection * rotationView;
            var inverse = vp.inverse;
            var topLeft = inverse.MultiplyPoint(new Vector3(-1f, 1f, -1f));
            var topRight = inverse.MultiplyPoint(new Vector3(1f, 1f, -1f));
            var bottomLeft = inverse.MultiplyPoint(new Vector3(-1f, -1f, -1f));
            var farCenter = inverse.MultiplyPoint(new Vector3(0f, 0f, 1f));
            m_CameraTopLeftCorner[0] = topLeft;
            m_CameraXExtent[0] = topRight - topLeft;
            m_CameraYExtent[0] = bottomLeft - topLeft;
            m_CameraZExtent[0] = farCenter;
            _ssaoMaterial.SetVector(s_ProjectionParams2ID, new Vector4(1f / renderingData.cameraData.camera.nearClipPlane, 0f, 0f, 0f));
            _ssaoMaterial.SetMatrixArray(s_CameraViewProjectionsID, m_CameraViewProjections);
            _ssaoMaterial.SetVectorArray(s_CameraViewTopLeftCornerID, m_CameraTopLeftCorner);
            _ssaoMaterial.SetVectorArray(s_CameraViewXExtentID, m_CameraXExtent);
            _ssaoMaterial.SetVectorArray(s_CameraViewYExtentID, m_CameraYExtent);
            _ssaoMaterial.SetVectorArray(s_CameraViewZExtentID, m_CameraZExtent);
            CoreUtils.SetKeyword(_ssaoMaterial, k_OrthographicCameraKeyword, renderingData.cameraData.camera.orthographic);
            CoreUtils.SetKeyword(_ssaoMaterial, k_AOInterleavedGradientKeyword, true);
            _ssaoMaterial.SetVector(s_SSAOParamsID, new Vector4(settings.intensity.value, settings.radius.value, 0.5f, settings.falloff.value));
            CoreUtils.SetKeyword(_ssaoMaterial, k_SampleCountLowKeyword, false);
            CoreUtils.SetKeyword(_ssaoMaterial, k_SampleCountMediumKeyword, false);
            CoreUtils.SetKeyword(_ssaoMaterial, k_SampleCountHighKeyword, false);
            switch ((int)settings.samples.value)
            {
                case 0: CoreUtils.SetKeyword(_ssaoMaterial, k_SampleCountHighKeyword, true); break;
                case 1: CoreUtils.SetKeyword(_ssaoMaterial, k_SampleCountMediumKeyword, true); break;
                default: CoreUtils.SetKeyword(_ssaoMaterial, k_SampleCountLowKeyword, true); break;
            }
            CoreUtils.SetKeyword(_ssaoMaterial, k_OrthographicCameraKeyword, renderingData.cameraData.camera.orthographic);
            CoreUtils.SetKeyword(_ssaoMaterial, k_SourceDepthLowKeyword, false);
            CoreUtils.SetKeyword(_ssaoMaterial, k_SourceDepthMediumKeyword, false);
            CoreUtils.SetKeyword(_ssaoMaterial, k_SourceDepthHighKeyword, false);
            CoreUtils.SetKeyword(_ssaoMaterial, k_SourceDepthNormalsKeyword, true);
            switch ((int)settings.blurType.value)
            {
                case 0: m_BlurType = SSAOBlurTypes.Bilateral; break;
                case 1: m_BlurType = SSAOBlurTypes.Gaussian; break;
                case 2: m_BlurType = SSAOBlurTypes.Kawase; break;
                default: throw new System.ArgumentOutOfRangeException();
            }
            var aoDescriptor = descriptor;
            aoDescriptor.msaaSamples = 1;
            aoDescriptor.depthBufferBits = 0;
            m_AOPassDescriptor = aoDescriptor;
            m_AOPassDescriptor.width /= 2;
            m_AOPassDescriptor.height /= 2;
            m_AOPassDescriptor.colorFormat = m_SupportsR8RenderTextureFormat && m_BlurType > SSAOBlurTypes.Bilateral ? RenderTextureFormat.R8 : RenderTextureFormat.ARGB32;
            RenderingUtils.ReAllocateIfNeeded(ref m_SSAOTextures[0], m_AOPassDescriptor, FilterMode.Bilinear, TextureWrapMode.Clamp, name: "_SSAO_OcclusionTexture0");
            if (m_BlurType <= SSAOBlurTypes.Gaussian)
            {
                RenderingUtils.ReAllocateIfNeeded(ref m_SSAOTextures[1], m_AOPassDescriptor, FilterMode.Bilinear, TextureWrapMode.Clamp, name: "_SSAO_OcclusionTexture1");
                if (m_BlurType == SSAOBlurTypes.Bilateral)
                    RenderingUtils.ReAllocateIfNeeded(ref m_SSAOTextures[2], m_AOPassDescriptor, FilterMode.Bilinear, TextureWrapMode.Clamp, name: "_SSAO_OcclusionTexture2");
            }
            m_AOPassDescriptor.colorFormat = m_SupportsR8RenderTextureFormat ? RenderTextureFormat.R8 : RenderTextureFormat.ARGB32;
            RenderingUtils.ReAllocateIfNeeded(ref m_SSAOTextures[3], m_AOPassDescriptor, FilterMode.Bilinear, TextureWrapMode.Clamp, name: "_SSAO_OcclusionTexture");
            cmd.SetGlobalVector(k_SSAOAmbientOcclusionParamName, new Vector4(0f, 0f, 0f, settings.directLightingStrength.value));
        }

        private void RenderSSAO(CommandBuffer cmd)
        {
            if (!_isSSAOActive || _ssaoMaterial == null) return;
            using (new ProfilingScope(cmd, _ssaoProfilingSampler))
            {
                CoreUtils.SetKeyword(cmd, "_SCREEN_SPACE_OCCLUSION", true);
                PostProcessUtils.SetSourceSize(cmd, m_AOPassDescriptor);
                cmd.SetGlobalTexture(k_SSAOTextureName, m_SSAOTextures[3].nameID);
                if (m_BlurType == SSAOBlurTypes.Kawase)
                {
                    cmd.SetGlobalInt(s_LastKawasePass, 1);
                    cmd.SetGlobalFloat(s_KawaseBlurIterationID, 0f);
                }
                GetPassOrder(m_BlurType, out var indices, out var passes);
                RenderSSAOPassAndSetBaseMap(ref cmd, ref _ssaoMaterial, ref m_SSAOTextures[0], ref m_SSAOTextures[0], SSAOShaderPasses.AmbientOcclusion);
                for (int i = 0; i < passes.Length; i++)
                {
                    int source = indices[i];
                    int target = indices[i + 1];
                    RenderSSAOPassAndSetBaseMap(ref cmd, ref _ssaoMaterial, ref m_SSAOTextures[source], ref m_SSAOTextures[target], passes[i]);
                }
            }
        }

        private void OnCameraCleanupSSAO(CommandBuffer cmd)
        {
            CoreUtils.SetKeyword(cmd, "_SCREEN_SPACE_OCCLUSION", false);
        }

        private static void RenderSSAOPassAndSetBaseMap(ref CommandBuffer cmd, ref Material mat, ref RTHandle baseMap, ref RTHandle target, SSAOShaderPasses pass)
        {
            if (baseMap.rt == null)
            {
                Vector2 scale = baseMap.useScaling ? new Vector2(baseMap.rtHandleProperties.rtHandleScale.x, baseMap.rtHandleProperties.rtHandleScale.y) : Vector2.one;
                CoreUtils.SetRenderTarget(cmd, target, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store, ClearFlag.None, Color.clear);
                Blitter.BlitTexture(cmd, baseMap.nameID, new Vector4(scale.x, scale.y, 0f, 0f), mat, (int)pass);
            }
            else Blitter.BlitCameraTexture(cmd, baseMap, target, mat, (int)pass);
        }

        private static void GetPassOrder(SSAOBlurTypes blurType, out int[] textureIndices, out SSAOShaderPasses[] shaderPasses)
        {
            switch (blurType)
            {
                case SSAOBlurTypes.Bilateral: textureIndices = m_BilateralTexturesIndices; shaderPasses = m_BilateralPasses; return;
                case SSAOBlurTypes.Gaussian: textureIndices = m_GaussianTexturesIndices; shaderPasses = m_GaussianPasses; return;
                case SSAOBlurTypes.Kawase: textureIndices = m_KawaseTexturesIndices; shaderPasses = m_KawasePasses; return;
                default: throw new System.ArgumentOutOfRangeException();
            }
        }
    }
}
