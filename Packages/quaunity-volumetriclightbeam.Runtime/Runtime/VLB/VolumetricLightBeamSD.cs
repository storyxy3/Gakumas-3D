namespace VLB
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Serialization;
    using global::VLB;

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    [SelectionBase]
    [HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-sd/")]
    public class VolumetricLightBeamSD : VolumetricLightBeamAbstractBase
    {
        public delegate void OnWillCameraRenderCB(Camera cam);
        public delegate void OnBeamGeometryInitialized();
        internal delegate void VolumetricLightBeamAction(VolumetricLightBeamSD volumetricLightBeam);
        [CompilerGenerated]
        private sealed class _003CCoPlaytimeUpdate_003Ed__221 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public VolumetricLightBeamSD _003C_003E4__this;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CCoPlaytimeUpdate_003Ed__221(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        public new const string ClassName = "VolumetricLightBeamSD";
        public bool colorFromLight;
        public ColorMode colorMode;
        [ColorUsage(false, true)]
        [FormerlySerializedAs("colorValue")]
        public Color color;
        public Gradient colorGradient;
        public bool intensityFromLight;
        public bool intensityModeAdvanced;
        [FormerlySerializedAs("alphaInside")]
        [Min(0f)]
        public float intensityInside;
        [FormerlySerializedAs("alphaOutside")]
        [FormerlySerializedAs("alpha")]
        [Min(0f)]
        public float intensityOutside;
        [Min(0f)]
        public float intensityMultiplier;
        [Range(0f, 1f)]
        public float hdrpExposureWeight;
        public BlendingMode blendingMode;
        [FormerlySerializedAs("angleFromLight")]
        public bool spotAngleFromLight;
        [Range(0.1f, 179.9f)]
        public float spotAngle;
        [Min(0f)]
        public float spotAngleMultiplier;
        [FormerlySerializedAs("radiusStart")]
        public float coneRadiusStart;
        public ShaderAccuracy shaderAccuracy;
        public MeshType geomMeshType;
        [FormerlySerializedAs("geomSides")]
        public int geomCustomSides;
        public int geomCustomSegments;
        public Vector3 skewingLocalForwardDirection;
        public Transform clippingPlaneTransform;
        public bool geomCap;
        public AttenuationEquation attenuationEquation;
        [Range(0f, 1f)]
        public float attenuationCustomBlending;
        [FormerlySerializedAs("fadeStart")]
        public float fallOffStart;
        [FormerlySerializedAs("fadeEnd")]
        public float fallOffEnd;
        [FormerlySerializedAs("fadeEndFromLight")]
        public bool fallOffEndFromLight;
        [Min(0f)]
        public float fallOffEndMultiplier;
        public float depthBlendDistance;
        public float cameraClippingDistance;
        [Range(0f, 1f)]
        public float glareFrontal;
        [Range(0f, 1f)]
        public float glareBehind;
        [FormerlySerializedAs("fresnelPowOutside")]
        public float fresnelPow;
        public NoiseMode noiseMode;
        [Range(0f, 1f)]
        public float noiseIntensity;
        public bool noiseScaleUseGlobal;
        [Range(0.01f, 2f)]
        public float noiseScaleLocal;
        public bool noiseVelocityUseGlobal;
        public Vector3 noiseVelocityLocal;
        public Dimensions dimensions;
        public Vector2 tiltFactor;
        private MaterialManager.SD.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode;
        private bool m_INTERNAL_DynamicOcclusionMode_Runtime;
        [CompilerGenerated]
        private OnWillCameraRenderCB m_onWillCameraRenderThisBeam;
        private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;
        [FormerlySerializedAs("trackChangesDuringPlaytime")]
        [SerializeField]
        private bool _TrackChangesDuringPlaytime;
        [SerializeField]
        private int _SortingLayerID;
        [SerializeField]
        private int _SortingOrder;
        [FormerlySerializedAs("fadeOutBegin")]
        [SerializeField]
        private float _FadeOutBegin;
        [FormerlySerializedAs("fadeOutEnd")]
        [SerializeField]
        private float _FadeOutEnd;
        [CompilerGenerated]
        private uint _003C_INTERNAL_InstancedMaterialGroupID_003Ek__BackingField;
        private BeamGeometrySD m_BeamGeom;
        private Coroutine m_CoPlaytimeUpdate;
        [CompilerGenerated]
        private static VolumetricLightBeamAction m_onVLBAdd;
        [CompilerGenerated]
        private static VolumetricLightBeamAction m_onVLBRemove;
        [CompilerGenerated]
        private static VolumetricLightBeamAction m_onVLBPropertyChange;
        [CompilerGenerated]
        private static VolumetricLightBeamAction m_onVLBMaterialChange;
        [CompilerGenerated]
        private Entity _003Centity_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CmaterialID_003Ek__BackingField;
        [Range(0f, 1f)]
        public float shadowIntensity;
        public ColorMode usedColorMode
        {
            get
            {
                return default(ColorMode);
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

        [Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
        public float alphaInside
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        [Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
        public float alphaOutside
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float intensityGlobal
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

        public float coneApexOffsetZ
        {
            get
            {
                return default(float);
            }
        }

        public Vector3 coneApexPositionLocal
        {
            get
            {
                return default(Vector3);
            }
        }

        public Vector3 coneApexPositionGlobal
        {
            get
            {
                return default(Vector3);
            }
        }

        public int geomSides
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public int geomSegments
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public Vector3 skewingLocalForwardDirectionNormalized
        {
            get
            {
                return default(Vector3);
            }
        }

        public bool canHaveMeshSkewing
        {
            get
            {
                return default(bool);
            }
        }

        public bool hasMeshSkewing
        {
            get
            {
                return default(bool);
            }
        }

        public Vector4 additionalClippingPlane
        {
            get
            {
                return default(Vector4);
            }
        }

        public float attenuationLerpLinearQuad
        {
            get
            {
                return default(float);
            }
        }

        [Obsolete("Use 'fallOffStart' instead")]
        public float fadeStart
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        [Obsolete("Use 'fallOffEnd' instead")]
        public float fadeEnd
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        [Obsolete("Use 'fallOffEndFromLight' instead")]
        public bool fadeEndFromLight
        {
            get
            {
                return default(bool);
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

        public float maxGeometryDistance
        {
            get
            {
                return default(float);
            }
        }

        public bool isNoiseEnabled
        {
            get
            {
                return default(bool);
            }
        }

        [Obsolete("Use 'noiseMode' instead")]
        public bool noiseEnabled
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public float fadeOutBegin
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float fadeOutEnd
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public bool isFadeOutEnabled
        {
            get
            {
                return default(bool);
            }
        }

        public bool isTilted
        {
            get
            {
                return default(bool);
            }
        }

        public int sortingLayerID
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public string sortingLayerName
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public int sortingOrder
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public bool trackChangesDuringPlaytime
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool isCurrentlyTrackingChanges
        {
            get
            {
                return default(bool);
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

        public float raycastDistance
        {
            get
            {
                return default(float);
            }
        }

        public Vector3 raycastGlobalForward
        {
            get
            {
                return default(Vector3);
            }
        }

        public Vector3 raycastGlobalUp
        {
            get
            {
                return default(Vector3);
            }
        }

        public Vector3 raycastGlobalRight
        {
            get
            {
                return default(Vector3);
            }
        }

        public MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
        {
            get
            {
                return default(MaterialManager.SD.DynamicOcclusion);
            }

            set
            {
            }
        }

        public MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
        {
            get
            {
                return default(MaterialManager.SD.DynamicOcclusion);
            }
        }

        public uint _INTERNAL_InstancedMaterialGroupID
        {
            [CompilerGenerated]
            get
            {
                return default(uint);
            }

            [CompilerGenerated]
            protected set
            {
            }
        }

        public string meshStats
        {
            get
            {
                return null;
            }
        }

        public int meshVerticesCount
        {
            get
            {
                return default(int);
            }
        }

        public int meshTrianglesCount
        {
            get
            {
                return default(int);
            }
        }

        internal Entity entity
        {
            [CompilerGenerated]
            get
            {
                return default(Entity);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        private int materialID
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public event OnWillCameraRenderCB onWillCameraRenderThisBeam
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        internal static event VolumetricLightBeamAction onVLBAdd
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        internal static event VolumetricLightBeamAction onVLBRemove
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        internal static event VolumetricLightBeamAction onVLBPropertyChange
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        internal static event VolumetricLightBeamAction onVLBMaterialChange
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public void GetInsideAndOutsideIntensity(out float inside, out float outside)
        {
            throw null;
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

        private Vector3 ComputeRaycastGlobalVector(Vector3 localVec)
        {
            return default(Vector3);
        }

        public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
        {
        }

        public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
        {
        }

        public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
        {
        }

        private void CallOnBeamGeometryInitializedCallback()
        {
        }

        private void SetFadeOutValue(ref float propToChange, float value)
        {
        }

        private void OnFadeOutStateChanged()
        {
        }

        public float GetInsideBeamFactor(Vector3 posWS)
        {
            return default(float);
        }

        public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
        {
            return default(float);
        }

        [Obsolete("Use 'GenerateGeometry()' instead")]
        public void Generate()
        {
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

        public MaterialManager.StaticPropertiesSD GetStaticProps()
        {
            return default(MaterialManager.StaticPropertiesSD);
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void StartPlaytimeUpdateIfNeeded()
        {
        }

        [IteratorStateMachine(typeof(_003CCoPlaytimeUpdate_003Ed__221))]
        private IEnumerator CoPlaytimeUpdate()
        {
            return null;
        }

        private void OnDestroy()
        {
        }

        private void DestroyBeam()
        {
        }

        private void AssignPropertiesFromAttachedSpotLight()
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

        public VolumetricLightBeamSD()
        {
        }
    }
}
