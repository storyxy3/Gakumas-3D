namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::CriWare;
    using global::UnityEngine;

    [AddComponentMenu("CRIWARE/CRI Atom Transceiver")]
    [DisallowMultipleComponent]
    public class CriAtomTransceiver : CriMonoBehaviour
    {
        private delegate void SetControlIdMethod(ushort id);
        [CompilerGenerated]
        private CriAtomEx3dTransceiver _003CtransceiverHn_003Ek__BackingField;
        [CompilerGenerated]
        private Vector3 _003CinputPos_003Ek__BackingField;
        [CompilerGenerated]
        private Vector3 _003CinputFront_003Ek__BackingField;
        [CompilerGenerated]
        private Vector3 _003CinputUp_003Ek__BackingField;
        [SerializeField]
        private CriAtomRegion regionOnStart;
        [SerializeField]
        private bool useDedicatedInput;
        [SerializeField]
        private GameObject dedicatedInput;
        [SerializeField]
        [Range(0f, 1f)]
        private float outputVolume;
        [SerializeField]
        private float directAudioRadius;
        [SerializeField]
        private float crossFadeDistance;
        [SerializeField]
        [Range(0f, 360f)]
        private float coneInsideAngle;
        [SerializeField]
        [Range(0f, 360f)]
        private float coneOutsideAngle;
        [SerializeField]
        [Range(0f, 1f)]
        private float coneOutsideVolume;
        [SerializeField]
        private float transceiverRadius;
        [SerializeField]
        private float interiorDistance;
        [SerializeField]
        public float minAttenuation;
        [SerializeField]
        public float maxAttenuation;
        [SerializeField]
        private string globalAisacName;
        [SerializeField]
        private float maxAngleAisacDelta;
        [SerializeField]
        private string distanceAisacControlId;
        [SerializeField]
        private string listenerAzimuthAisacControlId;
        [SerializeField]
        private string listenerElevationAisacControlId;
        [SerializeField]
        private string outputAzimuthAisacControlId;
        [SerializeField]
        private string outputElevationAisacControlId;
        [NonSerialized]
        public bool inspectorAisacSettingFoldout;
        private bool isInitialized;
        private bool dedicatedInputNotSetWarned;
        private CriAtomRegion currentRegion;
        public CriAtomEx3dTransceiver transceiverHn
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            protected set
            {
            }
        }

        public Vector3 inputPos
        {
            [CompilerGenerated]
            get
            {
                return default(Vector3);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public Vector3 inputFront
        {
            [CompilerGenerated]
            get
            {
                return default(Vector3);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public Vector3 inputUp
        {
            [CompilerGenerated]
            get
            {
                return default(Vector3);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public CriAtomRegion region3d
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private void Awake()
        {
        }

        private void Start()
        {
        }

        protected override void OnEnable()
        {
        }

        private void OnDestroy()
        {
        }

        protected virtual void InternalInitialize()
        {
        }

        protected virtual void InternalFinalize()
        {
        }

        protected virtual void InitializeParameters()
        {
        }

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        private void ApplyCurrentPosition()
        {
        }

        private void ApplyParameters()
        {
        }

        private void TrySetAisacControlId(string strId, SetControlIdMethod callback)
        {
        }

        public CriAtomTransceiver()
        {
        }
    }
}
