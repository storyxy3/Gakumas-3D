namespace VLB
{
    using global::UnityEngine;
    using global::UnityEngine.Serialization;
    using global::VLB;

    [HelpURL("http://saladgamer.com/vlb-doc/config/")]
    public class Config : ScriptableObject
    {
        public const string ClassName = "Config";
        public const string kAssetName = "VLBConfigOverride";
        public const string kAssetNameExt = ".asset";
        public bool geometryOverrideLayer = true;
        public int geometryLayerID = 1;
        public string geometryTag = "Untagged";
        public int geometryRenderQueue = 3000;
        public int geometryRenderQueueHD = 3100;
        [FormerlySerializedAs("renderPipeline")]
        [FormerlySerializedAs("_RenderPipeline")]
        [SerializeField]
        private RenderPipeline m_RenderPipeline;
        [FormerlySerializedAs("renderingMode")]
        [FormerlySerializedAs("_RenderingMode")]
        [SerializeField]
        private RenderingMode m_RenderingMode = RenderingMode.Default;
        public float ditheringFactor;
        public bool useLightColorTemperature = true;
        public int sharedMeshSides = 24;
        public int sharedMeshSegments = 5;
        public float hdBeamsCameraBlendingDistance = 0.5f;
        [Range(0.01f, 2f)]
        public float globalNoiseScale = 0.5f;
        public Vector3 globalNoiseVelocity = Consts.Beam.NoiseVelocityDefault;
        public string fadeOutCameraTag = "MainCamera";
        [HighlightNull]
        public Texture3D noiseTexture3D;
        [HighlightNull]
        public ParticleSystem dustParticlesPrefab;
        [HighlightNull]
        public Texture2D ditheringNoiseTexture;
        [HighlightNull]
        public Texture2D jitteringNoiseTexture;
        [HighlightNull]
        public Texture2D noiseTexture2D;
        public FeatureEnabledColorGradient featureEnabledColorGradient = FeatureEnabledColorGradient.HighOnly;
        public bool featureEnabledDepthBlend = true;
        public bool featureEnabledNoise3D = true;
        public bool featureEnabledDynamicOcclusion = true;
        public bool featureEnabledMeshSkewing = true;
        public bool featureEnabledShaderAccuracyHigh = true;
        public bool featureEnabledShadow = true;
        public bool featureEnabledCookie = true;
        [SerializeField]
        private RaymarchingQuality[] m_RaymarchingQualities;
        [SerializeField]
        private int m_DefaultRaymarchingQualityUniqueID;
        [SerializeField]
        private int pluginVersion = -1;
        [SerializeField]
        private Material _DummyMaterial;
        [SerializeField]
        private Shader _BeamShader;
        [SerializeField]
        private Shader _BeamShaderHD;
        private Transform m_CachedFadeOutCamera;
        private static Config ms_Instance;
        public RenderPipeline renderPipeline
        {
            get
            {
                return m_RenderPipeline;
            }

            set
            {
            }
        }

        public RenderingMode renderingMode
        {
            get
            {
                return m_RenderingMode;
            }

            set
            {
            }
        }

        public bool SD_useSinglePassShader
        {
            get
            {
                return default(bool);
            }
        }

        public bool SD_requiresDoubleSidedMesh
        {
            get
            {
                return GetActualRenderingMode(ShaderMode.SD) != RenderingMode.Default;
            }
        }

        public Transform fadeOutCameraTransform
        {
            get
            {
                if (m_CachedFadeOutCamera == null)
                    ForceUpdateFadeOutCamera();
                return m_CachedFadeOutCamera;
            }
        }

        public int defaultRaymarchingQualityUniqueID
        {
            get
            {
                return default(int);
            }
        }

        public int raymarchingQualitiesCount
        {
            get
            {
                return Mathf.Max(m_RaymarchingQualities != null ? m_RaymarchingQualities.Length : 1, 1);
            }
        }

        public bool isHDRPExposureWeightSupported
        {
            get
            {
                return default(bool);
            }
        }

        public bool hasRenderPipelineMismatch
        {
            get
            {
                return default(bool);
            }
        }

        public static Config Instance
        {
            get
            {
                return GetInstance(false);
            }
        }

        public bool IsSRPBatcherSupported()
        {
            if (renderPipeline == RenderPipeline.BuiltIn)
                return false;
            var pipeline = SRPHelper.projectRenderPipeline;
            return pipeline == RenderPipeline.URP || pipeline == RenderPipeline.HDRP;
        }

        public RenderingMode GetActualRenderingMode(ShaderMode shaderMode)
        {
            if (renderingMode == RenderingMode.SRPBatcher && !IsSRPBatcherSupported())
                return RenderingMode.Default;
            if (renderPipeline != RenderPipeline.BuiltIn && renderingMode == RenderingMode.MultiPass)
                return RenderingMode.Default;
            if (shaderMode == ShaderMode.HD && renderingMode == RenderingMode.MultiPass)
                return RenderingMode.Default;
            return renderingMode;
        }

        public Shader GetBeamShader(ShaderMode mode)
        {
            return GetBeamShaderInternal(mode);
        }

        private unsafe ref Shader GetBeamShaderInternal(ShaderMode mode)
        {
            if (mode == ShaderMode.SD)
                return ref _BeamShader;
            return ref _BeamShaderHD;
        }

        private int GetRenderQueueInternal(ShaderMode mode)
        {
            return mode == ShaderMode.SD ? geometryRenderQueue : geometryRenderQueueHD;
        }

        public Material NewMaterialTransient(ShaderMode mode, bool gpuInstanced)
        {
            Material material = MaterialManager.NewMaterialPersistent(GetBeamShader(mode), gpuInstanced);
            if (material)
            {
                material.hideFlags = Consts.Internal.ProceduralObjectsHideFlags;
                material.renderQueue = GetRenderQueueInternal(mode);
            }
            return material;
        }

        public void ForceUpdateFadeOutCamera()
        {
            GameObject camera = GameObject.FindGameObjectWithTag(fadeOutCameraTag);
            if (camera)
                m_CachedFadeOutCamera = camera.transform;
        }

        public RaymarchingQuality GetRaymarchingQualityForIndex(int index)
        {
            return null;
        }

        public RaymarchingQuality GetRaymarchingQualityForUniqueID(int id)
        {
            return null;
        }

        public int GetRaymarchingQualityIndexForUniqueID(int id)
        {
            return default(int);
        }

        public bool IsRaymarchingQualityUniqueIDValid(int id)
        {
            return default(bool);
        }

        private void CreateDefaultRaymarchingQualityPreset(bool onlyIfNeeded)
        {
        }

        [RuntimeInitializeOnLoadMethod]
        private static void OnStartup()
        {
        }

        public void Reset()
        {
        }

        private void RefreshGlobalShaderProperties()
        {
        }

        public void ResetInternalData()
        {
        }

        public ParticleSystem NewVolumetricDustParticles()
        {
            return null;
        }

        private void OnEnable()
        {
        }

        private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
        {
        }

        private static Config LoadAssetInternal(string assetName)
        {
            return Resources.Load<Config>(assetName);
        }

        private static Config GetInstance(bool assertIfNotFound)
        {
            if (ms_Instance == null)
            {
                Config config = LoadAssetInternal(kAssetName + PlatformHelper.GetCurrentPlatformSuffix());
                if (config == null)
                    config = LoadAssetInternal(kAssetName);
                ms_Instance = config;
                _ = ms_Instance == null;
            }
            return ms_Instance;
        }

        public Config()
        {
        }
    }
}
