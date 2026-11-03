namespace VLB
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VLB;

    [AddComponentMenu("")]
    [ExecuteInEditMode]
    [HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
    public class BeamGeometryHD : BeamGeometryAbstractBase
    {
        private VolumetricLightBeamHD m_Master;
        private Matrix4x4 m_ColorGradientMatrix;
        private Material m_CustomMaterial;
        private VolumetricCookieHD m_Cookie;
        private VolumetricShadowHD m_Shadow;
        [CompilerGenerated]
        private MeshFilter _003CmeshFilter_003Ek__BackingField;
        [CompilerGenerated]
        private Mesh _003CconeMesh_003Ek__BackingField;
        private Camera m_CurrentCameraRenderingSRP;
        private DirtyProps m_DirtyProps;
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

        public bool visible
        {
            set
            {
            }
        }

        public int sortingLayerID
        {
            set
            {
            }
        }

        public int sortingOrder
        {
            set
            {
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

        private void Start()
        {
        }

        private void OnDestroy()
        {
        }

        private void OnDisable()
        {
        }

        private void OnEnable()
        {
        }

        public void Initialize(VolumetricLightBeamHD master)
        {
        }

        public void RegenerateMesh()
        {
        }

        private Vector3 ComputeLocalMatrix()
        {
            return default(Vector3);
        }

        private MaterialManager.StaticPropertiesHD ComputeMaterialStaticProperties()
        {
            return default(MaterialManager.StaticPropertiesHD);
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

        public void SetPropertyDirty(DirtyProps prop)
        {
        }

        private void UpdateMaterialAndBounds()
        {
        }

        private void UpdateMatricesPropertiesForGPUInstancingSRP()
        {
        }

        private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
        {
        }

        private void OnWillRenderObject()
        {
        }

        private void OnWillCameraRenderThisBeam(Camera cam)
        {
        }

        private void UpdateDirtyMaterialProperties()
        {
        }

        private void UpdateMaterialPropertiesForCamera(Camera cam)
        {
        }

        public BeamGeometryHD()
        {
        }
    }
}
