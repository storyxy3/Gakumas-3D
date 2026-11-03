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
        public bool geometryOverrideLayer;
        public int geometryLayerID;
        public string geometryTag;
        public int geometryRenderQueue;
        public int geometryRenderQueueHD;
        [FormerlySerializedAs("renderPipeline")]
        [FormerlySerializedAs("_RenderPipeline")]
        [SerializeField]
        private RenderPipeline m_RenderPipeline;
        [FormerlySerializedAs("renderingMode")]
        [FormerlySerializedAs("_RenderingMode")]
        [SerializeField]
        private RenderingMode m_RenderingMode;
        public float ditheringFactor;
        public bool useLightColorTemperature;
        public int sharedMeshSides;
        public int sharedMeshSegments;
        public float hdBeamsCameraBlendingDistance;
        [Range(0.01f, 2f)]
        public float globalNoiseScale;
        public Vector3 globalNoiseVelocity;
        public string fadeOutCameraTag;
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
        public FeatureEnabledColorGradient featureEnabledColorGradient;
        public bool featureEnabledDepthBlend;
        public bool featureEnabledNoise3D;
        public bool featureEnabledDynamicOcclusion;
        public bool featureEnabledMeshSkewing;
        public bool featureEnabledShaderAccuracyHigh;
        public bool featureEnabledShadow;
        public bool featureEnabledCookie;
        [SerializeField]
        private RaymarchingQuality[] m_RaymarchingQualities;
        [SerializeField]
        private int m_DefaultRaymarchingQualityUniqueID;
        [SerializeField]
        private int pluginVersion;
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
                return default(RenderPipeline);
            }

            set
            {
            }
        }

        public RenderingMode renderingMode
        {
            get
            {
                return default(RenderingMode);
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
                return default(bool);
            }
        }

        public Transform fadeOutCameraTransform
        {
            get
            {
                return null;
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
                return default(int);
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
                return null;
            }
        }

        public bool IsSRPBatcherSupported()
        {
            return default(bool);
        }

        public RenderingMode GetActualRenderingMode(ShaderMode shaderMode)
        {
            return default(RenderingMode);
        }

        public Shader GetBeamShader(ShaderMode mode)
        {
            return null;
        }

        private unsafe ref Shader GetBeamShaderInternal(ShaderMode mode)
        {
            throw null;
        }

        private int GetRenderQueueInternal(ShaderMode mode)
        {
            return default(int);
        }

        public Material NewMaterialTransient(ShaderMode mode, bool gpuInstanced)
        {
            return null;
        }

        public void ForceUpdateFadeOutCamera()
        {
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
            return null;
        }

        private static Config GetInstance(bool assertIfNotFound)
        {
            return null;
        }

        public Config()
        {
        }
    }
}
