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
            public _003CCoUpdateFadeOut_003Ed__26(int _003C_003E1__state)
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
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public Mesh coneMesh
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        private bool visible
        {
            get
            {
                return default(bool);
            }

            set
            {
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
                return default(bool);
            }
        }

        private bool isNoiseEnabled
        {
            get
            {
                return default(bool);
            }
        }

        private bool isDepthBlendEnabled
        {
            get
            {
                return default(bool);
            }
        }

        private float ComputeFadeOutFactor(Transform camTransform)
        {
            return default(float);
        }

        [IteratorStateMachine(typeof(_003CCoUpdateFadeOut_003Ed__26))]
        private IEnumerator CoUpdateFadeOut()
        {
            return null;
        }

        private void ComputeFadeOutFactor()
        {
        }

        private void SetFadeOutFactorProp(float value)
        {
        }

        private void StopFadeOutCoroutine()
        {
        }

        public void RestartFadeOutCoroutine()
        {
        }

        private void Start()
        {
        }

        private void OnDestroy()
        {
        }

        public void OnMasterEnable()
        {
        }

        public void OnMasterDisable()
        {
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
            return default(Vector3);
        }

        private MaterialManager.StaticPropertiesSD ComputeMaterialStaticProperties()
        {
            return default(MaterialManager.StaticPropertiesSD);
        }

        private bool ApplyMaterial()
        {
            return default(bool);
        }

        public void SetMaterialProp(int nameID, float value)
        {
        }

        public void SetMaterialProp(int nameID, Vector4 value)
        {
        }

        public void SetMaterialProp(int nameID, Color value)
        {
        }

        public void SetMaterialProp(int nameID, Matrix4x4 value)
        {
        }

        public void SetMaterialProp(int nameID, Texture value)
        {
        }

        private void MaterialChangeStart()
        {
        }

        private void MaterialChangeStop()
        {
        }

        public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
        {
        }

        public void UpdateMaterialAndBounds()
        {
        }

        private void UpdateMatricesPropertiesForGPUInstancingSRP()
        {
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
