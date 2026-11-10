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
                    return _003C_003E2__current;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return _003C_003E2__current;
                }
            }

            [DebuggerHidden]
            public _003CCoPlaytimeUpdate_003Ed__221(int _003C_003E1__state)
            {
                this._003C_003E1__state = _003C_003E1__state;
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            public bool MoveNext()
            {
                int state = _003C_003E1__state;
                VolumetricLightBeamSD beam = _003C_003E4__this;
                if (state != 0 && state != 1)
                    return false;
                _003C_003E1__state = -1;
                if (beam.trackChangesDuringPlaytime && beam.enabled)
                {
                    beam.UpdateAfterManualPropertyChange();
                    _003C_003E2__current = null;
                    _003C_003E1__state = 1;
                    return true;
                }
                beam.m_CoPlaytimeUpdate = null;
                return false;
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }
        }

        public new const string ClassName = "VolumetricLightBeamSD";
        public bool colorFromLight = true;
        public ColorMode colorMode;
        [ColorUsage(false, true)]
        [FormerlySerializedAs("colorValue")]
        public Color color = Consts.Beam.FlatColor;
        public Gradient colorGradient;
        public bool intensityFromLight = true;
        public bool intensityModeAdvanced;
        [FormerlySerializedAs("alphaInside")]
        [Min(0f)]
        public float intensityInside = 1f;
        [FormerlySerializedAs("alphaOutside")]
        [FormerlySerializedAs("alpha")]
        [Min(0f)]
        public float intensityOutside = 1f;
        [Min(0f)]
        public float intensityMultiplier = 1f;
        [Range(0f, 1f)]
        public float hdrpExposureWeight;
        public BlendingMode blendingMode;
        [FormerlySerializedAs("angleFromLight")]
        public bool spotAngleFromLight = true;
        [Range(0.1f, 179.9f)]
        public float spotAngle = 35f;
        [Min(0f)]
        public float spotAngleMultiplier = 1f;
        [FormerlySerializedAs("radiusStart")]
        public float coneRadiusStart = 0.1f;
        public ShaderAccuracy shaderAccuracy;
        public MeshType geomMeshType;
        [FormerlySerializedAs("geomSides")]
        public int geomCustomSides = 18;
        public int geomCustomSegments = 5;
        public Vector3 skewingLocalForwardDirection = Consts.Beam.SD.SkewingLocalForwardDirectionDefault;
        public Transform clippingPlaneTransform;
        public bool geomCap;
        public AttenuationEquation attenuationEquation = AttenuationEquation.Quadratic;
        [Range(0f, 1f)]
        public float attenuationCustomBlending = 0.5f;
        [FormerlySerializedAs("fadeStart")]
        public float fallOffStart;
        [FormerlySerializedAs("fadeEnd")]
        public float fallOffEnd = 3f;
        [FormerlySerializedAs("fadeEndFromLight")]
        public bool fallOffEndFromLight = true;
        [Min(0f)]
        public float fallOffEndMultiplier = 1f;
        public float depthBlendDistance = 2f;
        public float cameraClippingDistance = 0.5f;
        [Range(0f, 1f)]
        public float glareFrontal = 0.5f;
        [Range(0f, 1f)]
        public float glareBehind = 0.5f;
        [FormerlySerializedAs("fresnelPowOutside")]
        public float fresnelPow = 8f;
        public NoiseMode noiseMode;
        [Range(0f, 1f)]
        public float noiseIntensity = 0.5f;
        public bool noiseScaleUseGlobal = true;
        [Range(0.01f, 2f)]
        public float noiseScaleLocal = 0.5f;
        public bool noiseVelocityUseGlobal = true;
        public Vector3 noiseVelocityLocal = Consts.Beam.NoiseVelocityDefault;
        public Dimensions dimensions;
        public Vector2 tiltFactor = Consts.Beam.SD.TiltDefault;
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
        private float _FadeOutBegin = -150f;
        [FormerlySerializedAs("fadeOutEnd")]
        [SerializeField]
        private float _FadeOutEnd = -200f;
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
                return Config.Instance.featureEnabledColorGradient != FeatureEnabledColorGradient.Off ? colorMode : ColorMode.Flat;
            }
        }

        private bool useColorFromAttachedLightSpot
        {
            get
            {
                return colorFromLight && lightSpotAttached != null;
            }
        }

        private bool useColorTemperatureFromAttachedLightSpot
        {
            get
            {
                return useColorFromAttachedLightSpot && lightSpotAttached.useColorTemperature && Config.Instance.useLightColorTemperature;
            }
        }

        [Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
        public float alphaInside
        {
            get
            {
                return intensityInside;
            }

            set
            {
                intensityInside = value;
            }
        }

        [Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
        public float alphaOutside
        {
            get
            {
                return intensityOutside;
            }

            set
            {
                intensityOutside = value;
            }
        }

        public float intensityGlobal
        {
            get
            {
                return intensityOutside;
            }

            set
            {
                intensityInside = intensityOutside = value;
            }
        }

        public bool useIntensityFromAttachedLightSpot
        {
            get
            {
                return intensityFromLight && lightSpotAttached != null;
            }
        }

        public bool useSpotAngleFromAttachedLightSpot
        {
            get
            {
                return spotAngleFromLight && lightSpotAttached != null;
            }
        }

        public float coneAngle
        {
            get
            {
                return Utils.ComputeSpotAngle(maxGeometryDistance, coneRadiusEnd - coneRadiusStart);
            }
        }

        public float coneRadiusEnd
        {
            get
            {
                return Utils.ComputeConeRadiusEnd(maxGeometryDistance, spotAngle);
            }

            set
            {
                spotAngle = Utils.ComputeSpotAngle(maxGeometryDistance, value);
            }
        }

        public float coneVolume
        {
            get
            {
                float radiusEnd = coneRadiusEnd;
                return (coneRadiusStart * coneRadiusStart + coneRadiusStart * radiusEnd + radiusEnd * radiusEnd) * (Mathf.PI / 3f) * fallOffEnd;
            }
        }

        public float coneApexOffsetZ
        {
            get
            {
                float ratio = coneRadiusStart / coneRadiusEnd;
                return ratio == 1f ? float.MaxValue : maxGeometryDistance * ratio / (1f - ratio);
            }
        }

        public Vector3 coneApexPositionLocal
        {
            get
            {
                return new Vector3(0f, 0f, -coneApexOffsetZ);
            }
        }

        public Vector3 coneApexPositionGlobal
        {
            get
            {
                return transform.localToWorldMatrix.MultiplyPoint(coneApexPositionLocal);
            }
        }

        public int geomSides
        {
            get
            {
                return geomMeshType == MeshType.Custom ? geomCustomSides : Config.Instance.sharedMeshSides;
            }

            set
            {
                geomCustomSides = value;
                UnityEngine.Debug.LogWarningFormat("The setter VLB.{0}.geomSides is OBSOLETE and has been renamed to geomCustomSides.", ClassName);
            }
        }

        public int geomSegments
        {
            get
            {
                return geomMeshType == MeshType.Custom ? geomCustomSegments : Config.Instance.sharedMeshSegments;
            }

            set
            {
                geomCustomSegments = value;
                UnityEngine.Debug.LogWarningFormat("The setter VLB.{0}.geomSegments is OBSOLETE and has been renamed to geomCustomSegments.", ClassName);
            }
        }

        public Vector3 skewingLocalForwardDirectionNormalized
        {
            get
            {
                if (Mathf.Approximately(skewingLocalForwardDirection.z, 0f))
                {
                    UnityEngine.Debug.LogErrorFormat("Beam {0} has a skewingLocalForwardDirection with a null Z, which is forbidden", name);
                    return Vector3.forward;
                }
                return skewingLocalForwardDirection.normalized;
            }
        }

        public bool canHaveMeshSkewing
        {
            get
            {
                return geomMeshType == MeshType.Custom;
            }
        }

        public bool hasMeshSkewing
        {
            get
            {
                return Config.Instance.featureEnabledMeshSkewing && canHaveMeshSkewing && !Mathf.Approximately(Vector3.Dot(skewingLocalForwardDirectionNormalized, Vector3.forward), 1f);
            }
        }

        public Vector4 additionalClippingPlane
        {
            get
            {
                if (clippingPlaneTransform == null)
                    return Vector4.zero;
                return Utils.PlaneEquation(clippingPlaneTransform.forward, clippingPlaneTransform.position);
            }
        }

        public float attenuationLerpLinearQuad
        {
            get
            {
                if (attenuationEquation == AttenuationEquation.Linear)
                    return 0f;
                if (attenuationEquation == AttenuationEquation.Quadratic)
                    return 1f;
                return attenuationCustomBlending;
            }
        }

        [Obsolete("Use 'fallOffStart' instead")]
        public float fadeStart
        {
            get
            {
                return fallOffStart;
            }

            set
            {
                fallOffStart = value;
            }
        }

        [Obsolete("Use 'fallOffEnd' instead")]
        public float fadeEnd
        {
            get
            {
                return fallOffEnd;
            }

            set
            {
                fallOffEnd = value;
            }
        }

        [Obsolete("Use 'fallOffEndFromLight' instead")]
        public bool fadeEndFromLight
        {
            get
            {
                return fallOffEndFromLight;
            }

            set
            {
                fallOffEndFromLight = value;
            }
        }

        public bool useFallOffEndFromAttachedLightSpot
        {
            get
            {
                return fallOffEndFromLight && lightSpotAttached != null;
            }
        }

        public float maxGeometryDistance
        {
            get
            {
                return fallOffEnd + Mathf.Max(Mathf.Abs(tiltFactor.x), Mathf.Abs(tiltFactor.y));
            }
        }

        public bool isNoiseEnabled
        {
            get
            {
                return noiseMode != NoiseMode.Disabled;
            }
        }

        [Obsolete("Use 'noiseMode' instead")]
        public bool noiseEnabled
        {
            get
            {
                return isNoiseEnabled;
            }

            set
            {
                noiseMode = value ? NoiseMode.WorldSpace : NoiseMode.Disabled;
            }
        }

        public float fadeOutBegin
        {
            get
            {
                return _FadeOutBegin;
            }

            set
            {
                SetFadeOutValue(ref _FadeOutBegin, value);
            }
        }

        public float fadeOutEnd
        {
            get
            {
                return _FadeOutEnd;
            }

            set
            {
                SetFadeOutValue(ref _FadeOutEnd, value);
            }
        }

        public bool isFadeOutEnabled
        {
            get
            {
                return _FadeOutBegin >= 0f && _FadeOutEnd >= 0f;
            }
        }

        public bool isTilted
        {
            get
            {
                return !tiltFactor.Approximately(Vector2.zero);
            }
        }

        public int sortingLayerID
        {
            get
            {
                return _SortingLayerID;
            }

            set
            {
                _SortingLayerID = value;
                if (m_BeamGeom)
                    m_BeamGeom.sortingLayerID = value;
            }
        }

        public string sortingLayerName
        {
            get
            {
                return SortingLayer.IDToName(_SortingLayerID);
            }

            set
            {
                sortingLayerID = SortingLayer.NameToID(value);
            }
        }

        public int sortingOrder
        {
            get
            {
                return _SortingOrder;
            }

            set
            {
                _SortingOrder = value;
                if (m_BeamGeom)
                    m_BeamGeom.sortingOrder = value;
            }
        }

        public bool trackChangesDuringPlaytime
        {
            get
            {
                return _TrackChangesDuringPlaytime;
            }

            set
            {
                _TrackChangesDuringPlaytime = value;
                StartPlaytimeUpdateIfNeeded();
            }
        }

        public bool isCurrentlyTrackingChanges
        {
            get
            {
                return m_CoPlaytimeUpdate != null;
            }
        }

        public int blendingModeAsInt
        {
            get
            {
                return Mathf.Clamp((int)blendingMode, 0, Enum.GetValues(typeof(BlendingMode)).Length);
            }
        }

        public Quaternion beamInternalLocalRotation
        {
            get
            {
                return dimensions == Dimensions.Dim3D ? Quaternion.identity : Quaternion.LookRotation(Vector3.right, Vector3.up);
            }
        }

        public Vector3 beamLocalForward
        {
            get
            {
                return dimensions == Dimensions.Dim3D ? Vector3.forward : Vector3.right;
            }
        }

        public Vector3 beamGlobalForward
        {
            get
            {
                return transform.TransformDirection(beamLocalForward);
            }
        }

        public float raycastDistance
        {
            get
            {
                if (hasMeshSkewing)
                {
                    float z = skewingLocalForwardDirectionNormalized.z;
                    return Mathf.Approximately(z, 0f) ? maxGeometryDistance : maxGeometryDistance / z;
                }
                return maxGeometryDistance;
            }
        }

        public Vector3 raycastGlobalForward
        {
            get
            {
                return ComputeRaycastGlobalVector(hasMeshSkewing ? skewingLocalForwardDirectionNormalized : Vector3.forward);
            }
        }

        public Vector3 raycastGlobalUp
        {
            get
            {
                return ComputeRaycastGlobalVector(Vector3.up);
            }
        }

        public Vector3 raycastGlobalRight
        {
            get
            {
                return ComputeRaycastGlobalVector(Vector3.right);
            }
        }

        public MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
        {
            get
            {
                return Config.Instance.featureEnabledDynamicOcclusion ? m_INTERNAL_DynamicOcclusionMode : MaterialManager.SD.DynamicOcclusion.Off;
            }

            set
            {
                m_INTERNAL_DynamicOcclusionMode = value;
            }
        }

        public MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
        {
            get
            {
                return m_INTERNAL_DynamicOcclusionMode_Runtime ? _INTERNAL_DynamicOcclusionMode : MaterialManager.SD.DynamicOcclusion.Off;
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

        public string meshStats
        {
            get
            {
                Mesh mesh = m_BeamGeom ? m_BeamGeom.coneMesh : null;
                return mesh ? string.Format("Cone angle: {0:0.0} degrees\nMesh: {1} vertices, {2} triangles", coneAngle, mesh.vertexCount, mesh.triangles.Length / 3) : "no mesh available";
            }
        }

        public int meshVerticesCount
        {
            get
            {
                return m_BeamGeom && m_BeamGeom.coneMesh ? m_BeamGeom.coneMesh.vertexCount : 0;
            }
        }

        public int meshTrianglesCount
        {
            get
            {
                return m_BeamGeom && m_BeamGeom.coneMesh ? m_BeamGeom.coneMesh.triangles.Length / 3 : 0;
            }
        }

        internal Entity entity
        {
            [CompilerGenerated]
            get
            {
                return _003Centity_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003Centity_003Ek__BackingField = value;
            }
        }

        private int materialID
        {
            [CompilerGenerated]
            get
            {
                return _003CmaterialID_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CmaterialID_003Ek__BackingField = value;
            }
        }

        public event OnWillCameraRenderCB onWillCameraRenderThisBeam
        {
            [CompilerGenerated]
            add
            {
                OnWillCameraRenderCB previous = m_onWillCameraRenderThisBeam;
                OnWillCameraRenderCB current;
                do
                {
                    current = previous;
                    var updated = (OnWillCameraRenderCB)Delegate.Combine(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onWillCameraRenderThisBeam, updated, current);
                }
                while ((object)previous != current);
            }

            [CompilerGenerated]
            remove
            {
                OnWillCameraRenderCB previous = m_onWillCameraRenderThisBeam;
                OnWillCameraRenderCB current;
                do
                {
                    current = previous;
                    var updated = (OnWillCameraRenderCB)Delegate.Remove(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onWillCameraRenderThisBeam, updated, current);
                }
                while ((object)previous != current);
            }
        }

        internal static event VolumetricLightBeamAction onVLBAdd
        {
            [CompilerGenerated]
            add
            {
                VolumetricLightBeamAction previous = m_onVLBAdd;
                VolumetricLightBeamAction current;
                do
                {
                    current = previous;
                    var updated = (VolumetricLightBeamAction)Delegate.Combine(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onVLBAdd, updated, current);
                }
                while ((object)previous != current);
            }

            [CompilerGenerated]
            remove
            {
                VolumetricLightBeamAction previous = m_onVLBAdd;
                VolumetricLightBeamAction current;
                do
                {
                    current = previous;
                    var updated = (VolumetricLightBeamAction)Delegate.Remove(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onVLBAdd, updated, current);
                }
                while ((object)previous != current);
            }
        }

        internal static event VolumetricLightBeamAction onVLBRemove
        {
            [CompilerGenerated]
            add
            {
                VolumetricLightBeamAction previous = m_onVLBRemove;
                VolumetricLightBeamAction current;
                do
                {
                    current = previous;
                    var updated = (VolumetricLightBeamAction)Delegate.Combine(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onVLBRemove, updated, current);
                }
                while ((object)previous != current);
            }

            [CompilerGenerated]
            remove
            {
                VolumetricLightBeamAction previous = m_onVLBRemove;
                VolumetricLightBeamAction current;
                do
                {
                    current = previous;
                    var updated = (VolumetricLightBeamAction)Delegate.Remove(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onVLBRemove, updated, current);
                }
                while ((object)previous != current);
            }
        }

        internal static event VolumetricLightBeamAction onVLBPropertyChange
        {
            [CompilerGenerated]
            add
            {
                VolumetricLightBeamAction previous = m_onVLBPropertyChange;
                VolumetricLightBeamAction current;
                do
                {
                    current = previous;
                    var updated = (VolumetricLightBeamAction)Delegate.Combine(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onVLBPropertyChange, updated, current);
                }
                while ((object)previous != current);
            }

            [CompilerGenerated]
            remove
            {
                VolumetricLightBeamAction previous = m_onVLBPropertyChange;
                VolumetricLightBeamAction current;
                do
                {
                    current = previous;
                    var updated = (VolumetricLightBeamAction)Delegate.Remove(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onVLBPropertyChange, updated, current);
                }
                while ((object)previous != current);
            }
        }

        internal static event VolumetricLightBeamAction onVLBMaterialChange
        {
            [CompilerGenerated]
            add
            {
                VolumetricLightBeamAction previous = m_onVLBMaterialChange;
                VolumetricLightBeamAction current;
                do
                {
                    current = previous;
                    var updated = (VolumetricLightBeamAction)Delegate.Combine(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onVLBMaterialChange, updated, current);
                }
                while ((object)previous != current);
            }

            [CompilerGenerated]
            remove
            {
                VolumetricLightBeamAction previous = m_onVLBMaterialChange;
                VolumetricLightBeamAction current;
                do
                {
                    current = previous;
                    var updated = (VolumetricLightBeamAction)Delegate.Remove(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onVLBMaterialChange, updated, current);
                }
                while ((object)previous != current);
            }
        }

        public void GetInsideAndOutsideIntensity(out float inside, out float outside)
        {
            if (intensityModeAdvanced)
            {
                inside = intensityInside;
                outside = intensityOutside;
            }
            else
            {
                inside = outside = intensityGlobal;
            }
        }

        public override bool IsScalable()
        {
            return true;
        }

        public override BeamGeometryAbstractBase GetBeamGeometry()
        {
            return m_BeamGeom;
        }

        public override Vector3 GetLossyScale()
        {
            return dimensions == Dimensions.Dim3D ? transform.lossyScale : new Vector3(transform.lossyScale.z, transform.lossyScale.y, transform.lossyScale.x);
        }

        private Vector3 ComputeRaycastGlobalVector(Vector3 localVec)
        {
            return (transform.rotation * beamInternalLocalRotation) * localVec;
        }

        public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
        {
            m_INTERNAL_DynamicOcclusionMode_Runtime = cb != null;
            if (m_BeamGeom)
                m_BeamGeom.SetDynamicOcclusionCallback(shaderKeyword, cb);
        }

        public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
        {
            m_onWillCameraRenderThisBeam?.Invoke(cam);
        }

        public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
        {
            m_OnBeamGeometryInitialized += cb;
            if (m_BeamGeom)
                CallOnBeamGeometryInitializedCallback();
        }

        private void CallOnBeamGeometryInitializedCallback()
        {
            if (m_OnBeamGeometryInitialized != null)
            {
                m_OnBeamGeometryInitialized();
                m_OnBeamGeometryInitialized = null;
            }
        }

        private void SetFadeOutValue(ref float propToChange, float value)
        {
            bool wasEnabled = isFadeOutEnabled;
            propToChange = value;
            if (wasEnabled != isFadeOutEnabled)
                OnFadeOutStateChanged();
        }

        private void OnFadeOutStateChanged()
        {
            if (isFadeOutEnabled && m_BeamGeom)
                m_BeamGeom.RestartFadeOutCoroutine();
        }

        public float GetInsideBeamFactor(Vector3 posWS)
        {
            return GetInsideBeamFactorFromObjectSpacePos(transform.InverseTransformPoint(posWS));
        }

        public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
        {
            if (dimensions == Dimensions.Dim2D)
                posOS = new Vector3(posOS.z, posOS.y, posOS.x);
            if (posOS.z < 0f)
                return -1f;
            if (hasMeshSkewing)
            {
                Vector3 forward = skewingLocalForwardDirectionNormalized;
                posOS.x -= forward.x * (posOS.z / forward.z);
                posOS.y -= forward.y * (posOS.z / forward.z);
            }
            Vector2 direction = new Vector2(new Vector2(posOS.x, posOS.y).magnitude, posOS.z + coneApexOffsetZ).normalized;
            float slope = Mathf.Sin(coneAngle * Mathf.Deg2Rad * 0.5f);
            return Mathf.Clamp((Mathf.Abs(slope) - Mathf.Abs(direction.x)) / 0.1f, -1f, 1f);
        }

        [Obsolete("Use 'GenerateGeometry()' instead")]
        public void Generate()
        {
            GenerateGeometry();
        }

        public virtual void GenerateGeometry()
        {
            HandleBackwardCompatibility(pluginVersion, 20000);
            pluginVersion = 20000;
            ValidateProperties();
        }

        public virtual void UpdateAfterManualPropertyChange()
        {
            ValidateProperties();
            if (m_BeamGeom)
                m_BeamGeom.UpdateMaterialAndBounds();
        }

        private void Start()
        {
            InitLightSpotAttachedCached();
            GenerateGeometry();
        }

        public MaterialManager.StaticPropertiesSD GetStaticProps()
        {
            bool noise = isNoiseEnabled && noiseIntensity > 0f && Noise3D.isSupported;
            bool depthBlend = BatchingHelper.forceEnableDepthBlend || depthBlendDistance > 0f;
            Light light = lightSpotAttached;
            bool shadow = light != null && shadowIntensity > 0f && light.shadows != LightShadows.None;
            return new MaterialManager.StaticPropertiesSD
            {
                blendingMode = (MaterialManager.BlendingMode)blendingMode,
                noise3D = noise ? MaterialManager.Noise3D.On : MaterialManager.Noise3D.Off,
                depthBlend = depthBlend ? MaterialManager.SD.DepthBlend.On : MaterialManager.SD.DepthBlend.Off,
                colorGradient = MaterialManager.ColorGradient.Off,
                dynamicOcclusion = _INTERNAL_DynamicOcclusionMode_Runtime,
                meshSkewing = hasMeshSkewing ? MaterialManager.SD.MeshSkewing.On : MaterialManager.SD.MeshSkewing.Off,
                shaderAccuracy = shaderAccuracy == ShaderAccuracy.Fast ? MaterialManager.SD.ShaderAccuracy.Fast : MaterialManager.SD.ShaderAccuracy.High,
                depthShadow = shadow
            };
        }

        private void OnEnable()
        {
            if (Application.isPlaying)
                InitLightSpotAttachedCached();
            if (m_BeamGeom)
                m_BeamGeom.OnMasterEnable();
            m_onVLBAdd?.Invoke(this);
        }

        private void OnDisable()
        {
            if (m_BeamGeom)
                m_BeamGeom.OnMasterDisable();
            m_CoPlaytimeUpdate = null;
            m_onVLBRemove?.Invoke(this);
        }

        private void StartPlaytimeUpdateIfNeeded()
        {
            if (Application.isPlaying && _TrackChangesDuringPlaytime && m_CoPlaytimeUpdate == null)
                m_CoPlaytimeUpdate = StartCoroutine(CoPlaytimeUpdate());
        }

        [IteratorStateMachine(typeof(_003CCoPlaytimeUpdate_003Ed__221))]
        private IEnumerator CoPlaytimeUpdate()
        {
            return new _003CCoPlaytimeUpdate_003Ed__221(0) { _003C_003E4__this = this };
        }

        private void OnDestroy()
        {
            DestroyBeam();
        }

        private void DestroyBeam()
        {
            if (m_BeamGeom)
                DestroyImmediate(m_BeamGeom.gameObject);
            m_BeamGeom = null;
        }

        private void AssignPropertiesFromAttachedSpotLight()
        {
            Light light = lightSpotAttached;
            if (light)
            {
                _ = light.type;
                if (intensityFromLight)
                {
                    intensityModeAdvanced = false;
                    intensityGlobal = SpotLightHelper.GetIntensity(light) * intensityMultiplier;
                }
                if (fallOffEndFromLight)
                    fallOffEnd = SpotLightHelper.GetFallOffEnd(light) * fallOffEndMultiplier;
                if (spotAngleFromLight)
                    spotAngle = Mathf.Clamp(SpotLightHelper.GetSpotAngle(light) * spotAngleMultiplier, 0.1f, 179.9f);
                if (colorFromLight)
                {
                    colorMode = ColorMode.Flat;
                    color = useColorTemperatureFromAttachedLightSpot
                        ? (Mathf.CorrelatedColorTemperatureToRGB(light.colorTemperature) * light.color.linear).gamma
                        : light.color;
                }
            }
        }

        private void ClampProperties()
        {
            intensityInside = Mathf.Max(intensityInside, 0f);
            intensityOutside = Mathf.Max(intensityOutside, 0f);
            intensityMultiplier = Mathf.Max(intensityMultiplier, 0f);
            fallOffEnd = Mathf.Max(0.01f, fallOffEnd);
            spotAngle = Mathf.Clamp(spotAngle, 0.1f, 179.9f);
            spotAngleMultiplier = Mathf.Max(spotAngleMultiplier, 0f);
            coneRadiusStart = Mathf.Max(coneRadiusStart, 0f);
            geomCustomSides = Mathf.Clamp(geomCustomSides, 3, 256);
            geomCustomSegments = Mathf.Clamp(geomCustomSegments, 0, 64);
            attenuationCustomBlending = Mathf.Clamp01(attenuationCustomBlending);
            fallOffStart = Mathf.Clamp(fallOffStart, 0f, fallOffEnd - 0.01f);
            fallOffEndMultiplier = Mathf.Max(fallOffEndMultiplier, 0f);
            depthBlendDistance = Mathf.Max(depthBlendDistance, 0f);
            cameraClippingDistance = Mathf.Max(cameraClippingDistance, 0f);
            glareFrontal = Mathf.Clamp01(glareFrontal);
            glareBehind = Mathf.Clamp01(glareBehind);
            fresnelPow = Mathf.Max(0f, fresnelPow); // original maxss(0, fresnelPow): NaN kept
            noiseIntensity = Mathf.Clamp01(noiseIntensity);
        }

        private void ValidateProperties()
        {
            AssignPropertiesFromAttachedSpotLight();
            ClampProperties();
        }

        private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
        {
            if (serializedVersion == -1 || serializedVersion == newVersion)
                return;
            if (serializedVersion <= 1300)
                attenuationEquation = AttenuationEquation.Linear;
            if (serializedVersion <= 1500)
            {
                geomMeshType = MeshType.Custom;
                geomCustomSegments = 5;
            }
            if (serializedVersion <= 1609)
            {
                intensityFromLight = false;
                intensityModeAdvanced = !Mathf.Approximately(intensityInside, intensityOutside);
            }
            if (serializedVersion <= 1909 && !intensityModeAdvanced && !Mathf.Approximately(intensityInside, intensityOutside))
                intensityInside = intensityOutside;
        }

        public VolumetricLightBeamSD()
        {
        }
    }
}
