namespace VL.Rendering
{
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::UnityEngine.Rendering.Universal.Internal;
    using global::VL;
    using global::VL.Rendering;
    using global::VL.Rendering.Shaders;

    public class DownscalePass : ScriptableRenderPass
    {
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

        public static readonly string _SCREEN_SPACE_REFLECTION;
        public static readonly string _DIRECT_REFLECTION;
        public static readonly string _USE_HIZ_DEPTH;
        public static readonly int ShaderVariablesScreenSpaceReflection;
        private static readonly int _LitColorTexture;
        private static readonly int _ActorAOCapsuleA;
        private static readonly int _ActorAOCapsuleB;
        private static readonly int _TaaParams;
        private static readonly int _TaaAccumulationTex;
        private static readonly ProfilingSampler _ssrTraceProfilingSampler;
        private static readonly ProfilingSampler _resolveReflectionProfilingSampler;
        private static readonly ProfilingSampler _renderReflectionProfilingSampler;
        private static readonly ProfilingSampler _renderShadowAndOcclusionProfilingSampler;
        private readonly Material _downscaleBufferMaterial;
        private readonly Mesh _boxMesh;
        private readonly Vector4[] _actorAOCapsuleAArray;
        private readonly Vector4[] _actorAOCapsuleBArray;
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
        private int _resolveReflectionShaderPass;
        private int _traceSSRShaderPass;
        private AmplifyOcclusionRenderingData _amplifiedOcclusion;
        private Vector4[] _mipMinMaxArray;
        private const string k_AOInterleavedGradientKeyword = "_INTERLEAVED_GRADIENT";
        private const string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC";
        private const string k_SourceDepthLowKeyword = "_SOURCE_DEPTH_LOW";
        private const string k_SourceDepthMediumKeyword = "_SOURCE_DEPTH_MEDIUM";
        private const string k_SourceDepthHighKeyword = "_SOURCE_DEPTH_HIGH";
        private const string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS";
        private const string k_SampleCountLowKeyword = "_SAMPLE_COUNT_LOW";
        private const string k_SampleCountMediumKeyword = "_SAMPLE_COUNT_MEDIUM";
        private const string k_SampleCountHighKeyword = "_SAMPLE_COUNT_HIGH";
        private bool m_SupportsR8RenderTextureFormat;
        private Material m_Material;
        private Vector4[] m_CameraTopLeftCorner;
        private Vector4[] m_CameraXExtent;
        private Vector4[] m_CameraYExtent;
        private Vector4[] m_CameraZExtent;
        private RTHandle[] m_SSAOTextures;
        private SSAOBlurTypes m_BlurType;
        private Matrix4x4[] m_CameraViewProjections;
        private RenderTextureDescriptor m_AOPassDescriptor;
        private const int k_FinalTexID = 3;
        private const string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture";
        private const string k_SSAOAmbientOcclusionParamName = "_AmbientOcclusionParam";
        private static readonly int s_SSAOParamsID;
        private static readonly int s_LastKawasePass;
        private static readonly int s_CameraViewXExtentID;
        private static readonly int s_CameraViewYExtentID;
        private static readonly int s_CameraViewZExtentID;
        private static readonly int s_ProjectionParams2ID;
        private static readonly int s_KawaseBlurIterationID;
        private static readonly int s_CameraViewProjectionsID;
        private static readonly int s_CameraViewTopLeftCornerID;
        private static readonly int[] m_BilateralTexturesIndices;
        private static readonly SSAOShaderPasses[] m_BilateralPasses;
        private static readonly SSAOShaderPasses[] m_BilateralAfterOpaquePasses;
        private static readonly int[] m_GaussianTexturesIndices;
        private static readonly SSAOShaderPasses[] m_GaussianPasses;
        private static readonly SSAOShaderPasses[] m_GaussianAfterOpaquePasses;
        private static readonly int[] m_KawaseTexturesIndices;
        private static readonly SSAOShaderPasses[] m_KawasePasses;
        private static readonly SSAOShaderPasses[] m_KawaseAfterOpaquePasses;
        private bool _isSSAOActive;
        private ProfilingSampler _ssaoProfilingSampler;
        private Material _ssaoMaterial;
        public DownscalePass(Mesh boxMesh, Material downscaleBufferMaterial, DownscaleBuffers buffers)
        {
        }

        public void Dispose()
        {
        }

        public void InitializeHiZ(ComputeShader hizCompute)
        {
        }

        public void Setup(DeferredLights deferredLights, VLSSRQualitySetting ssrQuality)
        {
        }

        public void SetPlanarReflectionDrawSystem(PlanarReflectionDrawSystem planarReflectionDrawSystem)
        {
        }

        public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
        {
        }

        public override void OnCameraCleanup(CommandBuffer cmd)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        private void RenderDownscale(ScriptableRenderContext context, ref RenderingData renderingData, CommandBuffer cmd)
        {
        }

        private void SetupTraceSSR(CommandBuffer cmd, ref CameraData cameraData)
        {
        }

        private void RenderDirectReflection(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        private void ResolveDirectReflection(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        private void RenderShadowAndOcclusion(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        private void RenderShadowAndOcclusion(CommandBuffer cmd, ref RenderingData renderingData)
        {
        }

        private void RenderActorAOs(CommandBuffer cmd, Camera camera)
        {
        }

        private void RenderActorAO(CommandBuffer cmd, IVLActorController actorController, ref CameraPlanes cullingPlanes)
        {
        }

        private void RegisterAfterCommand(CommandBuffer cmd, ref CameraData cameraData)
        {
        }

        public void SetupAmplifyOcclusion(AmplifyOcclusionRenderingData amplifyOcclusionRenderingData)
        {
        }

        private void OnCameraCleanupAmplifyOcclusion(CommandBuffer cmd)
        {
        }

        private void RenderAmplifyOcclusion(CommandBuffer cmd, ref CameraData cameraData)
        {
        }

        public void InitializeSSAO(Material ssaoMaterial)
        {
        }

        private void DisposeSSAO()
        {
        }

        public void SetupSSAO(bool isSSAOActive)
        {
        }

        private void OnCameraSetupSSAO(CommandBuffer cmd, ref RenderingData renderingData)
        {
        }

        private void RenderSSAO(CommandBuffer cmd)
        {
        }

        private void OnCameraCleanupSSAO(CommandBuffer cmd)
        {
        }

        private static void RenderSSAOPassAndSetBaseMap(ref CommandBuffer cmd, ref Material mat, ref RTHandle baseMap, ref RTHandle target, SSAOShaderPasses pass)
        {
        }

        private static void GetPassOrder(SSAOBlurTypes blurType, out int[] textureIndices, out SSAOShaderPasses[] shaderPasses)
        {
            throw null;
        }
    }
}
