namespace VLB
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VLB;

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    [SelectionBase]
    [HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
    public class VolumetricLightBeamHD : VolumetricLightBeamAbstractBase
    {
        public new const string ClassName = "VolumetricLightBeamHD";
        [SerializeField]
        private bool m_ColorFromLight;
        [SerializeField]
        private ColorMode m_ColorMode;
        [SerializeField]
        private Color m_ColorFlat;
        [SerializeField]
        private Gradient m_ColorGradient;
        [SerializeField]
        private BlendingMode m_BlendingMode;
        [SerializeField]
        private float m_Intensity;
        [SerializeField]
        private float m_IntensityMultiplier;
        [SerializeField]
        private float m_HDRPExposureWeight;
        [SerializeField]
        private float m_SpotAngle;
        [SerializeField]
        private float m_SpotAngleMultiplier;
        [SerializeField]
        private float m_ConeRadiusStart;
        [SerializeField]
        private bool m_Scalable;
        [SerializeField]
        private float m_FallOffStart;
        [SerializeField]
        private float m_FallOffEnd;
        [SerializeField]
        private float m_FallOffEndMultiplier;
        [SerializeField]
        private AttenuationEquationHD m_AttenuationEquation;
        [SerializeField]
        private float m_SideSoftness;
        [SerializeField]
        private int m_RaymarchingQualityID;
        [SerializeField]
        private float m_JitteringFactor;
        [SerializeField]
        private int m_JitteringFrameRate;
        [MinMaxRange(0f, 1f)]
        [SerializeField]
        private MinMaxRangeFloat m_JitteringLerpRange;
        [SerializeField]
        private NoiseMode m_NoiseMode;
        [SerializeField]
        private float m_NoiseIntensity;
        [SerializeField]
        private bool m_NoiseScaleUseGlobal;
        [SerializeField]
        private float m_NoiseScaleLocal;
        [SerializeField]
        private bool m_NoiseVelocityUseGlobal;
        [SerializeField]
        private Vector3 m_NoiseVelocityLocal;
        [CompilerGenerated]
        private uint _003C_INTERNAL_InstancedMaterialGroupID_003Ek__BackingField;
        protected BeamGeometryHD m_BeamGeom;
        public bool colorFromLight
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public ColorMode colorMode
        {
            get
            {
                return default(ColorMode);
            }

            set
            {
            }
        }

        public Color colorFlat
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public Gradient colorGradient
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private bool useColorFromAttachedLightSpot
        {
            get
            {
                return default(bool);
            }
        }

        private bool useColorTemperatureFromAttachedLightSpot
        {
            get
            {
                return default(bool);
            }
        }

        public float intensity
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float intensityMultiplier
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public bool useIntensityFromAttachedLightSpot
        {
            get
            {
                return default(bool);
            }
        }

        public float hdrpExposureWeight
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public BlendingMode blendingMode
        {
            get
            {
                return default(BlendingMode);
            }

            set
            {
            }
        }

        public float spotAngle
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float spotAngleMultiplier
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public bool useSpotAngleFromAttachedLightSpot
        {
            get
            {
                return default(bool);
            }
        }

        public float coneAngle
        {
            get
            {
                return default(float);
            }
        }

        public float coneRadiusStart
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float coneRadiusEnd
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float coneVolume
        {
            get
            {
                return default(float);
            }
        }

        public bool scalable
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public AttenuationEquationHD attenuationEquation
        {
            get
            {
                return default(AttenuationEquationHD);
            }

            set
            {
            }
        }

        public float fallOffStart
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float fallOffEnd
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float maxGeometryDistance
        {
            get
            {
                return default(float);
            }
        }

        public float fallOffEndMultiplier
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public bool useFallOffEndFromAttachedLightSpot
        {
            get
            {
                return default(bool);
            }
        }

        public float sideSoftness
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float jitteringFactor
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public int jitteringFrameRate
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public MinMaxRangeFloat jitteringLerpRange
        {
            get
            {
                return default(MinMaxRangeFloat);
            }

            set
            {
            }
        }

        public NoiseMode noiseMode
        {
            get
            {
                return default(NoiseMode);
            }

            set
            {
            }
        }

        public bool isNoiseEnabled
        {
            get
            {
                return default(bool);
            }
        }

        public float noiseIntensity
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public bool noiseScaleUseGlobal
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public float noiseScaleLocal
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public bool noiseVelocityUseGlobal
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public Vector3 noiseVelocityLocal
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public int raymarchingQualityID
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public int raymarchingQualityIndex
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public int blendingModeAsInt
        {
            get
            {
                return default(int);
            }
        }

        public Quaternion beamInternalLocalRotation
        {
            get
            {
                return default(Quaternion);
            }
        }

        public Vector3 beamLocalForward
        {
            get
            {
                return default(Vector3);
            }
        }

        public Vector3 beamGlobalForward
        {
            get
            {
                return default(Vector3);
            }
        }

        public uint _INTERNAL_InstancedMaterialGroupID
        {
            [CompilerGenerated]
            get
            {
                return _003C_INTERNAL_InstancedMaterialGroupID_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003C_INTERNAL_InstancedMaterialGroupID_003Ek__BackingField = value;
            }
        }

        public float GetConeApexOffsetZ(bool counterApplyScaleForUnscalableBeam)
        {
            return default(float);
        }

        public override bool IsScalable()
        {
            return default(bool);
        }

        public override BeamGeometryAbstractBase GetBeamGeometry()
        {
            return null;
        }

        public override Vector3 GetLossyScale()
        {
            return default(Vector3);
        }

        public VolumetricCookieHD GetAdditionalComponentCookie()
        {
            return null;
        }

        public VolumetricShadowHD GetAdditionalComponentShadow()
        {
            return null;
        }

        public void SetPropertyDirty(DirtyProps flags)
        {
        }

        public virtual Dimensions GetDimensions()
        {
            return default(Dimensions);
        }

        public virtual bool DoesSupportSorting2D()
        {
            return default(bool);
        }

        public virtual int GetSortingLayerID()
        {
            return default(int);
        }

        public virtual int GetSortingOrder()
        {
            return default(int);
        }

        public float GetInsideBeamFactor(Vector3 posWS)
        {
            return default(float);
        }

        public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
        {
            return default(float);
        }

        public virtual void GenerateGeometry()
        {
        }

        public virtual void UpdateAfterManualPropertyChange()
        {
        }

        private void Start()
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void OnDidApplyAnimationProperties()
        {
        }

        private void OnDestroy()
        {
        }

        private void DestroyBeam()
        {
        }

        public void AssignPropertiesFromAttachedSpotLight()
        {
        }

        private void ClampProperties()
        {
        }

        private void ValidateProperties()
        {
        }

        private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
        {
        }

        public VolumetricLightBeamHD()
        {
        }
    }
}
