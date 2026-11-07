namespace VLB
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VLB;

    [AddComponentMenu("")]
    [ExecuteInEditMode]
    [HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-sd/")]
    public class BeamGeometrySD : BeamGeometryAbstractBase, MaterialModifier.Interface
    {
        [CompilerGenerated]
        private sealed class _003CCoUpdateFadeOut_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public BeamGeometrySD _003C_003E4__this;
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
            public _003CCoUpdateFadeOut_003Ed__26(int _003C_003E1__state)
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
                BeamGeometrySD geometry = _003C_003E4__this;
                if (state != 0 && state != 1)
                    return false;
                _003C_003E1__state = -1;
                if (geometry.m_Master.isFadeOutEnabled)
                {
                    geometry.ComputeFadeOutFactor();
                    _003C_003E2__current = null;
                    _003C_003E1__state = 1;
                    return true;
                }
                geometry.SetFadeOutFactorProp(1f);
                geometry.m_CoFadeOut = null;
                return false;
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }
        }

        private VolumetricLightBeamSD m_Master;
        private Matrix4x4 m_ColorGradientMatrix;
        private MeshType m_CurrentMeshType;
        private Material m_CustomMaterial;
        private MaterialModifier.Callback m_MaterialModifierCallback;
        private Coroutine m_CoFadeOut;
        [CompilerGenerated]
        private MeshFilter _003CmeshFilter_003Ek__BackingField;
        [CompilerGenerated]
        private Mesh _003CconeMesh_003Ek__BackingField;
        private Camera m_CurrentCameraRenderingSRP;
        public MeshFilter meshFilter
        {
            [CompilerGenerated]
            get
            {
                return _003CmeshFilter_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CmeshFilter_003Ek__BackingField = value;
            }
        }

        public Mesh coneMesh
        {
            [CompilerGenerated]
            get
            {
                return _003CconeMesh_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CconeMesh_003Ek__BackingField = value;
            }
        }

        private bool visible
        {
            get
            {
                return meshRenderer.enabled;
            }

            set
            {
                meshRenderer.enabled = value;
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
                meshRenderer.sortingLayerID = value;
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
                meshRenderer.sortingOrder = value;
            }
        }

        public bool _INTERNAL_IsFadeOutCoroutineRunning
        {
            get
            {
                return default(bool);
            }
        }

        public static bool isCustomRenderPipelineSupported
        {
            get
            {
                return default(bool);
            }
        }

        private bool shouldUseGPUInstancedMaterial
        {
            get
            {
                return m_Master._INTERNAL_DynamicOcclusionMode != MaterialManager.SD.DynamicOcclusion.DepthTexture && Config.Instance.GetActualRenderingMode(ShaderMode.SD) == RenderingMode.GPUInstancing;
            }
        }

        private bool isNoiseEnabled
        {
            get
            {
                return m_Master.isNoiseEnabled && m_Master.noiseIntensity > 0f && Noise3D.isSupported;
            }
        }

        private bool isDepthBlendEnabled
        {
            get
            {
                return BatchingHelper.forceEnableDepthBlend || m_Master.depthBlendDistance > 0f;
            }
        }

        private float ComputeFadeOutFactor(Transform camTransform)
        {
            if (!m_Master.isFadeOutEnabled)
                return 1f;
            float distance = (meshRenderer.bounds.center - camTransform.position).sqrMagnitude;
            return Mathf.InverseLerp(m_Master.fadeOutEnd * m_Master.fadeOutEnd, m_Master.fadeOutBegin * m_Master.fadeOutBegin, distance);
        }

        [IteratorStateMachine(typeof(_003CCoUpdateFadeOut_003Ed__26))]
        private IEnumerator CoUpdateFadeOut()
        {
            return new _003CCoUpdateFadeOut_003Ed__26(0) { _003C_003E4__this = this };
        }

        private void ComputeFadeOutFactor()
        {
            Transform cameraTransform = Config.Instance.fadeOutCameraTransform;
            SetFadeOutFactorProp(cameraTransform ? ComputeFadeOutFactor(cameraTransform) : 1f);
        }

        private void SetFadeOutFactorProp(float value)
        {
            if (value <= 0f)
            {
                visible = false;
                return;
            }
            visible = true;
            MaterialChangeStart();
            SetMaterialProp(ShaderProperties.SD.FadeOutFactor, value);
            MaterialChangeStop();
        }

        private void StopFadeOutCoroutine()
        {
            if (m_CoFadeOut != null)
            {
                StopCoroutine(m_CoFadeOut);
                m_CoFadeOut = null;
            }
        }

        public void RestartFadeOutCoroutine()
        {
            StopFadeOutCoroutine();
            if (m_Master && m_Master.isFadeOutEnabled)
                m_CoFadeOut = StartCoroutine(CoUpdateFadeOut());
        }

        private void Start()
        {
        }

        private void OnDestroy()
        {
        }

        public void OnMasterEnable()
        {
            visible = true;
            RestartFadeOutCoroutine();
        }

        public void OnMasterDisable()
        {
            StopFadeOutCoroutine();
            visible = false;
        }

        private void OnDisable()
        {
        }

        private void OnEnable()
        {
        }

        public void Initialize(VolumetricLightBeamSD master)
        {
        }

        public void RegenerateMesh(bool masterEnabled)
        {
        }

        private Vector3 ComputeLocalMatrix()
        {
            float radius = Mathf.Max(m_Master.coneRadiusStart, m_Master.coneRadiusEnd);
            transform.localScale = new Vector3(radius, radius, m_Master.maxGeometryDistance);
            transform.localRotation = m_Master.beamInternalLocalRotation;
            return transform.localScale;
        }

        private MaterialManager.StaticPropertiesSD ComputeMaterialStaticProperties()
        {
            MaterialManager.ColorGradient gradient = MaterialManager.ColorGradient.Off;
            if (m_Master.colorMode == ColorMode.Gradient)
                gradient = Utils.GetFloatPackingPrecision() == Utils.FloatPackingPrecision.High ? MaterialManager.ColorGradient.MatrixHigh : MaterialManager.ColorGradient.MatrixLow;
            return new MaterialManager.StaticPropertiesSD
            {
                blendingMode = (MaterialManager.BlendingMode)m_Master.blendingMode,
                noise3D = isNoiseEnabled ? MaterialManager.Noise3D.On : MaterialManager.Noise3D.Off,
                depthBlend = isDepthBlendEnabled ? MaterialManager.SD.DepthBlend.On : MaterialManager.SD.DepthBlend.Off,
                colorGradient = gradient,
                dynamicOcclusion = m_Master._INTERNAL_DynamicOcclusionMode_Runtime,
                meshSkewing = m_Master.hasMeshSkewing ? MaterialManager.SD.MeshSkewing.On : MaterialManager.SD.MeshSkewing.Off,
                shaderAccuracy = m_Master.shaderAccuracy == ShaderAccuracy.Fast ? MaterialManager.SD.ShaderAccuracy.Fast : MaterialManager.SD.ShaderAccuracy.High
            };
        }

        private bool ApplyMaterial()
        {
            MaterialManager.StaticPropertiesSD properties = ComputeMaterialStaticProperties();
            Material material;
            if (shouldUseGPUInstancedMaterial)
                material = MaterialManager.GetInstancedMaterial(m_Master._INTERNAL_InstancedMaterialGroupID, ref properties);
            else
            {
                material = m_CustomMaterial;
                if (material)
                    properties.ApplyToMaterial(material);
            }
            meshRenderer.material = material;
            return material != null;
        }

        public void SetMaterialProp(int nameID, float value)
        {
            if (m_CustomMaterial)
                m_CustomMaterial.SetFloat(nameID, value);
            else
                MaterialManager.materialPropertyBlock.SetFloat(nameID, value);
        }

        public void SetMaterialProp(int nameID, Vector4 value)
        {
            if (m_CustomMaterial)
                m_CustomMaterial.SetVector(nameID, value);
            else
                MaterialManager.materialPropertyBlock.SetVector(nameID, value);
        }

        public void SetMaterialProp(int nameID, Color value)
        {
            if (m_CustomMaterial)
                m_CustomMaterial.SetColor(nameID, value);
            else
                MaterialManager.materialPropertyBlock.SetColor(nameID, value);
        }

        public void SetMaterialProp(int nameID, Matrix4x4 value)
        {
            if (m_CustomMaterial)
                m_CustomMaterial.SetMatrix(nameID, value);
            else
                MaterialManager.materialPropertyBlock.SetMatrix(nameID, value);
        }

        public void SetMaterialProp(int nameID, Texture value)
        {
            if (m_CustomMaterial)
                m_CustomMaterial.SetTexture(nameID, value);
            else
                UnityEngine.Debug.LogError("Setting a Texture property to a GPU instanced material is not supported");
        }

        private void MaterialChangeStart()
        {
            if (m_CustomMaterial == null)
                meshRenderer.GetPropertyBlock(MaterialManager.materialPropertyBlock);
        }

        private void MaterialChangeStop()
        {
            if (m_CustomMaterial == null)
                meshRenderer.SetPropertyBlock(MaterialManager.materialPropertyBlock);
        }

        public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
        {
            m_MaterialModifierCallback = cb;
            if (m_CustomMaterial)
            {
                m_CustomMaterial.SetKeywordEnabled(shaderKeyword, cb != null);
                cb?.Invoke(this);
            }
            else
                UpdateMaterialAndBounds();
        }

        public void UpdateMaterialAndBounds()
        {
            if (!ApplyMaterial())
                return;
            MaterialChangeStart();
            if (m_CustomMaterial == null)
                m_MaterialModifierCallback?.Invoke(this);
            float slope = m_Master.coneAngle * Mathf.Deg2Rad * 0.5f;
            SetMaterialProp(ShaderProperties.SD.ConeSlopeCosSin, new Vector4(Mathf.Cos(slope), Mathf.Sin(slope), 0f, 0f));
            // The protected branch at 0xe0d9008 loads this constant through 0xe1b831c.
            float radiusStart = Mathf.Max(m_Master.coneRadiusStart, 0.0001f);
            float radiusEnd = Mathf.Max(m_Master.coneRadiusEnd, 0.0001f);
            SetMaterialProp(ShaderProperties.ConeRadius, new Vector4(radiusStart, radiusEnd, 0f, 0f));
            float apexOffset = Mathf.Sign(m_Master.coneApexOffsetZ) * Mathf.Max(Mathf.Abs(m_Master.coneApexOffsetZ), 0.0001f);
            SetMaterialProp(ShaderProperties.ConeGeomProps, new Vector4(apexOffset, m_Master.geomSides, 0f, 0f));
            if (m_Master.usedColorMode == ColorMode.Flat)
                SetMaterialProp(ShaderProperties.ColorFlat, m_Master.color);
            else
            {
                int precision = (int)Utils.GetFloatPackingPrecision();
                m_ColorGradientMatrix = m_Master.colorGradient.SampleInMatrix(precision);
            }
            m_Master.GetInsideAndOutsideIntensity(out float inside, out float outside);
            SetMaterialProp(ShaderProperties.SD.AlphaInside, inside);
            SetMaterialProp(ShaderProperties.SD.AlphaOutside, outside);
            SetMaterialProp(ShaderProperties.SD.AttenuationLerpLinearQuad, m_Master.attenuationLerpLinearQuad);
            SetMaterialProp(ShaderProperties.DistanceFallOff, new Vector4(m_Master.fallOffStart, m_Master.fallOffEnd, m_Master.maxGeometryDistance, 0f));
            SetMaterialProp(ShaderProperties.SD.DistanceCamClipping, m_Master.cameraClippingDistance);
            SetMaterialProp(ShaderProperties.SD.FresnelPow, Mathf.Max(0.001f, m_Master.fresnelPow));
            SetMaterialProp(ShaderProperties.SD.GlareBehind, m_Master.glareBehind);
            SetMaterialProp(ShaderProperties.SD.GlareFrontal, m_Master.glareFrontal);
            SetMaterialProp(ShaderProperties.SD.DrawCap, m_Master.geomCap ? 1f : 0f);
            SetMaterialProp(ShaderProperties.SD.TiltVector, new Vector4(m_Master.tiltFactor.x, m_Master.tiltFactor.y, 0f, 0f));
            SetMaterialProp(ShaderProperties.SD.AdditionalClippingPlaneWS, m_Master.additionalClippingPlane);
            if (Config.Instance.renderPipeline == RenderPipeline.HDRP)
                SetMaterialProp(ShaderProperties.HDRPExposureWeight, m_Master.hdrpExposureWeight);
            if (isDepthBlendEnabled)
                SetMaterialProp(ShaderProperties.SD.DepthBlendDistance, m_Master.depthBlendDistance);
            if (isNoiseEnabled)
            {
                Noise3D.LoadIfNeeded();
                Vector3 velocity = m_Master.noiseVelocityUseGlobal ? Config.Instance.globalNoiseVelocity : m_Master.noiseVelocityLocal;
                float scale = m_Master.noiseScaleUseGlobal ? Config.Instance.globalNoiseScale : m_Master.noiseScaleLocal;
                SetMaterialProp(ShaderProperties.NoiseVelocityAndScale, new Vector4(velocity.x, velocity.y, velocity.z, scale));
                SetMaterialProp(ShaderProperties.NoiseParam, new Vector4(m_Master.noiseIntensity, m_Master.noiseMode == NoiseMode.WorldSpace ? 0f : 1f, 0f, 0f));
            }
            Vector3 localScale = ComputeLocalMatrix();
            if (m_Master.hasMeshSkewing)
            {
                Vector3 forward = m_Master.skewingLocalForwardDirectionNormalized;
                SetMaterialProp(ShaderProperties.SD.LocalForwardDirection, (Vector4)forward);
                if (coneMesh != null)
                {
                    float offsetX = forward.x / forward.z * m_Master.fallOffEnd / localScale.x;
                    float offsetY = forward.y / forward.z * m_Master.fallOffEnd / localScale.y;
                    Bounds bounds = new Bounds(new Vector3(0f, 0f, 0.5f), new Vector3(2f, 2f, 1f));
                    bounds.min = new Vector3(offsetX > 0f ? -1f : offsetX - 1f, offsetY > 0f ? -1f : offsetY - 1f, 0f);
                    bounds.max = new Vector3(offsetX > 0f ? offsetX + 1f : 1f, offsetY > 0f ? offsetY + 1f : 1f, 1f);
                    coneMesh.bounds = bounds;
                }
            }
            UpdateMatricesPropertiesForGPUInstancingSRP();
            MaterialChangeStop();
        }

        private void UpdateMatricesPropertiesForGPUInstancingSRP()
        {
            if (SRPHelper.IsUsingCustomRenderPipeline() && Config.Instance.GetActualRenderingMode(ShaderMode.SD) == RenderingMode.GPUInstancing)
            {
                SetMaterialProp(ShaderProperties.LocalToWorldMatrix, transform.localToWorldMatrix);
                SetMaterialProp(ShaderProperties.WorldToLocalMatrix, transform.worldToLocalMatrix);
            }
        }

        private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
        {
        }

        private void OnWillCameraRenderThisBeam(Camera cam)
        {
        }

        private void UpdateCameraRelatedProperties(Camera cam)
        {
        }

        public BeamGeometrySD()
        {
        }
    }
}
