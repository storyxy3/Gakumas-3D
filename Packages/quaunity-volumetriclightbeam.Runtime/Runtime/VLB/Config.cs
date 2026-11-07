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
                Debug.LogError("Modifying the RenderPipeline in standalone builds is not permitted");
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
                Debug.LogError("Modifying the RenderingMode in standalone builds is not permitted");
            }
        }

        public bool SD_useSinglePassShader
        {
            get
            {
                return GetActualRenderingMode(ShaderMode.SD) != RenderingMode.MultiPass;
            }
        }

        public bool SD_requiresDoubleSidedMesh
        {
            get
            {
                return GetActualRenderingMode(ShaderMode.SD) != RenderingMode.MultiPass;
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
                return m_DefaultRaymarchingQualityUniqueID;
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
                return renderPipeline == RenderPipeline.HDRP;
            }
        }

        public bool hasRenderPipelineMismatch
        {
            get
            {
                return (SRPHelper.projectRenderPipeline == RenderPipeline.BuiltIn) != (m_RenderPipeline == RenderPipeline.BuiltIn);
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
            return m_RaymarchingQualities[index];
        }

        public RaymarchingQuality GetRaymarchingQualityForUniqueID(int id)
        {
            int index = GetRaymarchingQualityIndexForUniqueID(id);
            if (index >= 0)
                return GetRaymarchingQualityForIndex(index);
            return null;
        }

        public int GetRaymarchingQualityIndexForUniqueID(int id)
        {
            for (int i = 0; i < m_RaymarchingQualities.Length; i++)
            {
                var quality = m_RaymarchingQualities[i];
                if (quality != null && quality.uniqueID == id)
                    return i;
            }
            Debug.LogErrorFormat("Failed to find RaymarchingQualityIndex for Unique ID {0}", id);
            return -1;
        }

        public bool IsRaymarchingQualityUniqueIDValid(int id)
        {
            return GetRaymarchingQualityIndexForUniqueID(id) >= 0;
        }

        private void CreateDefaultRaymarchingQualityPreset(bool onlyIfNeeded)
        {
            if (m_RaymarchingQualities == null || m_RaymarchingQualities.Length == 0 || !onlyIfNeeded)
            {
                m_RaymarchingQualities = new RaymarchingQuality[3];
                m_RaymarchingQualities[0] = RaymarchingQuality.New("Fast", 1, 5);
                m_RaymarchingQualities[1] = RaymarchingQuality.New("Balanced", 2, 10);
                m_RaymarchingQualities[2] = RaymarchingQuality.New("High", 3, 20);
                m_DefaultRaymarchingQualityUniqueID = m_RaymarchingQualities[1].uniqueID;
            }
        }

        [RuntimeInitializeOnLoadMethod]
        private static void OnStartup()
        {
            Instance.m_CachedFadeOutCamera = null;
            Instance.RefreshGlobalShaderProperties();
            if (Instance.hasRenderPipelineMismatch)
                Debug.LogError("It looks like the 'Render Pipeline' is not correctly set in the config. Please make sure to select the proper value depending on your pipeline in use.", Instance);
        }

        public void Reset()
        {
            geometryOverrideLayer = true;
            geometryLayerID = 1;
            geometryTag = "Untagged";
            geometryRenderQueue = 3000;
            geometryRenderQueueHD = 3100;
            sharedMeshSides = 24;
            sharedMeshSegments = 5;
            globalNoiseScale = 0.5f;
            globalNoiseVelocity = Consts.Beam.NoiseVelocityDefault;
            renderPipeline = RenderPipeline.BuiltIn;
            renderingMode = RenderingMode.Default;
            ditheringFactor = 0f;
            useLightColorTemperature = true;
            fadeOutCameraTag = "MainCamera";
            featureEnabledColorGradient = FeatureEnabledColorGradient.HighOnly;
            featureEnabledDepthBlend = true;
            featureEnabledNoise3D = true;
            featureEnabledDynamicOcclusion = true;
            featureEnabledMeshSkewing = true;
            featureEnabledShaderAccuracyHigh = true;
            hdBeamsCameraBlendingDistance = 0.5f;
            CreateDefaultRaymarchingQualityPreset(false);
            ResetInternalData();
        }

        private void RefreshGlobalShaderProperties()
        {
            Shader.SetGlobalFloat(ShaderProperties.GlobalUsesReversedZBuffer, SystemInfo.usesReversedZBuffer ? 1f : 0f);
            Shader.SetGlobalFloat(ShaderProperties.GlobalDitheringFactor, ditheringFactor);
            Shader.SetGlobalTexture(ShaderProperties.GlobalDitheringNoiseTex, ditheringNoiseTexture);
            Shader.SetGlobalTexture(ShaderProperties.GlobalNoiseTex2D, ditheringNoiseTexture);
            Shader.SetGlobalTexture(ShaderProperties.GlobalNoiseTex2D, noiseTexture2D);
            Shader.SetGlobalFloat(ShaderProperties.HD.GlobalCameraBlendingDistance, hdBeamsCameraBlendingDistance);
            Shader.SetGlobalTexture(ShaderProperties.HD.GlobalJitteringNoiseTex, jitteringNoiseTexture);
        }

        public void ResetInternalData()
        {
            noiseTexture3D = Resources.Load("Noise3D_64x64x64") as Texture3D;
            dustParticlesPrefab = Resources.Load("DustParticles", typeof(ParticleSystem)) as ParticleSystem;
            ditheringNoiseTexture = Resources.Load("VLBDitheringNoise", typeof(Texture2D)) as Texture2D;
            jitteringNoiseTexture = Resources.Load("VLBBlueNoise", typeof(Texture2D)) as Texture2D;
        }

        public ParticleSystem NewVolumetricDustParticles()
        {
            if (!dustParticlesPrefab)
            {
                if (Application.isPlaying)
                    Debug.LogError("Failed to instantiate VolumetricDustParticles prefab.");
                return null;
            }
            var instance = Instantiate(dustParticlesPrefab);
            instance.useAutoRandomSeed = false;
            instance.name = "Dust Particles";
            instance.gameObject.hideFlags = Consts.Internal.ProceduralObjectsHideFlags;
            instance.gameObject.SetActive(true);
            return instance;
        }

        private void OnEnable()
        {
            CreateDefaultRaymarchingQualityPreset(true);
            HandleBackwardCompatibility(pluginVersion, 20000);
            pluginVersion = 20000;
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
