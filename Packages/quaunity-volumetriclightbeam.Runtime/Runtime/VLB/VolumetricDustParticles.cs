namespace VLB
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VLB;

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(VolumetricLightBeamAbstractBase))]
    [HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles/")]
    public class VolumetricDustParticles : MonoBehaviour
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Action<ParticleSystem> _003C_003E9__37_0;
            public _003C_003Ec()
            {
            }

            internal void _003CInstantiateParticleSystem_003Eb__37_0(ParticleSystem ps)
            {
            }
        }

        public const string ClassName = "VolumetricDustParticles";
        [Range(0f, 1f)]
        public float alpha;
        [Range(0.0001f, 0.1f)]
        public float size;
        public ParticlesDirection direction;
        public Vector3 velocity;
        [Obsolete("Use 'velocity' instead")]
        public float speed;
        public float density;
        [MinMaxRange(0f, 1f)]
        public MinMaxRangeFloat spawnDistanceRange;
        [Obsolete("Use 'spawnDistanceRange' instead")]
        public float spawnMinDistance;
        [Obsolete("Use 'spawnDistanceRange' instead")]
        public float spawnMaxDistance;
        public bool cullingEnabled;
        public float cullingMaxDistance;
        [CompilerGenerated]
        private bool _003CisCulled_003Ek__BackingField;
        [SerializeField]
        private float m_AlphaAdditionalRuntime;
        private ParticleSystem m_Particles;
        private ParticleSystemRenderer m_Renderer;
        private Material m_Material;
        private Gradient m_GradientCached;
        private bool m_RuntimePropertiesDirty;
        private static bool ms_NoMainCameraLogged;
        private static Camera ms_MainCamera;
        private VolumetricLightBeamAbstractBase m_Master;
        public bool isCulled
        {
            [CompilerGenerated]
            get
            {
                return _003CisCulled_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CisCulled_003Ek__BackingField = value;
            }
        }

        public float alphaAdditionalRuntime
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public bool particlesAreInstantiated
        {
            get
            {
                return default(bool);
            }
        }

        public int particlesCurrentCount
        {
            get
            {
                return default(int);
            }
        }

        public int particlesMaxCount
        {
            get
            {
                return default(int);
            }
        }

        public Camera mainCamera
        {
            get
            {
                return null;
            }
        }

        private void Start()
        {
        }

        private void InstantiateParticleSystem()
        {
        }

        private void OnEnable()
        {
        }

        private void SetActive(bool active)
        {
        }

        private void SetActiveAndPlay()
        {
        }

        private void Play()
        {
        }

        private void OnDisable()
        {
        }

        private void OnDestroy()
        {
        }

        private void Update()
        {
        }

        private void SetParticleProperties()
        {
        }

        private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
        {
        }

        private void UpdateCulling()
        {
        }

        public VolumetricDustParticles()
        {
        }
    }
}
