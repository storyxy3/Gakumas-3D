namespace VLB
{
    using global::UnityEngine;
    using global::VLB;

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(VolumetricLightBeamHD))]
    [HelpURL("http://saladgamer.com/vlb-doc/comp-shadow-hd/")]
    public class VolumetricShadowHD : MonoBehaviour
    {
        private enum ProcessOcclusionSource
        {
            RenderLoop,
            OnEnable,
            EditorUpdate,
            User
        }

        public const string ClassName = "VolumetricShadowHD";
        [SerializeField]
        private float m_Strength;
        [SerializeField]
        private ShadowUpdateRate m_UpdateRate;
        [SerializeField]
        private int m_WaitXFrames;
        [SerializeField]
        private LayerMask m_LayerMask;
        [SerializeField]
        private bool m_UseOcclusionCulling;
        [SerializeField]
        private int m_DepthMapResolution;
        private VolumetricLightBeamHD m_Master;
        private TransformUtils.Packed m_TransformPacked;
        private int m_LastFrameRendered;
        private Camera m_DepthCamera;
        private bool m_NeedToUpdateOcclusionNextFrame;
        public static bool _INTERNAL_ApplyRandomFrameOffset;
        public float strength
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public ShadowUpdateRate updateRate
        {
            get
            {
                return default(ShadowUpdateRate);
            }

            set
            {
            }
        }

        public int waitXFrames
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public LayerMask layerMask
        {
            get
            {
                return default(LayerMask);
            }

            set
            {
            }
        }

        public bool useOcclusionCulling
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public int depthMapResolution
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public int _INTERNAL_LastFrameRendered
        {
            get
            {
                return default(int);
            }
        }

        public void ProcessOcclusionManually()
        {
        }

        public void UpdateDepthCameraProperties()
        {
        }

        private void ProcessOcclusion(ProcessOcclusionSource source)
        {
        }

        public static void ApplyMaterialProperties(VolumetricShadowHD instance, BeamGeometryHD geom)
        {
        }

        private void Awake()
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void OnDestroy()
        {
        }

        private void ProcessOcclusionInternal()
        {
        }

        private void OnBeamEnabled()
        {
        }

        public void OnWillCameraRenderThisBeam(Camera cam, BeamGeometryHD beamGeom)
        {
        }

        private void Update()
        {
        }

        private void UpdateDepthCameraPropertiesAccordingToBeam()
        {
        }

        private void InstantiateOrActivateDepthCamera()
        {
        }

        private void DestroyDepthCamera()
        {
        }

        private void OnValidateProperties()
        {
        }

        private void SetDirty()
        {
        }

        public VolumetricShadowHD()
        {
        }
    }
}
