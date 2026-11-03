namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::CriWare;
    using global::UnityEngine;

    public abstract class CriAtomSourceBase : CriMonoBehaviour
    {
        public enum Status
        {
            Stop,
            Prep,
            Playing,
            PlayEnd,
            Error
        }

        [CompilerGenerated]
        private CriAtomExPlayer _003Cplayer_003Ek__BackingField;
        [CompilerGenerated]
        private CriAtomEx3dSource _003Csource_003Ek__BackingField;
        protected bool initialized;
        protected Vector3 lastPosition;
        protected bool hasValidPosition;
        private CriAtomRegion currentRegion;
        private CriAtomListener currentListener;
        [SerializeField]
        private bool _playOnStart;
        [SerializeField]
        private CriAtomRegion _regionOnStart;
        [SerializeField]
        private CriAtomListener _listenerOnStart;
        [SerializeField]
        private bool _use3dPositioning;
        [SerializeField]
        private bool _freezeOrientation;
        [SerializeField]
        private bool _loop;
        [SerializeField]
        private float _volume;
        [SerializeField]
        private float _pitch;
        [SerializeField]
        private bool _androidUseLowLatencyVoicePool;
        [SerializeField]
        private bool need_to_player_update_all;
        [SerializeField]
        private bool _use3dRandomization;
        [SerializeField]
        private uint _randomPositionListMaxLength;
        [SerializeField]
        private CriAtomEx.Randomize3dConfig randomize3dConfig;
        public CriAtomExPlayer player
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

        public CriAtomEx3dSource source
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

        public bool playOnStart
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool use3dPositioning
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool freezeOrientation
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool use3dRandomization
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public uint randomPositionListMaxLength
        {
            get
            {
                return default(uint);
            }

            set
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

        public CriAtomListener listener
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public CriAtomRegion regionOnStart
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public CriAtomListener listenerOnStart
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool loop
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public float volume
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float pitch
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float pan3dAngle
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float pan3dDistance
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public int startTime
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public long time
        {
            get
            {
                return default(long);
            }
        }

        public Status status
        {
            get
            {
                return default(Status);
            }
        }

        public bool attenuationDistanceSetting
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool androidUseLowLatencyVoicePool
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        protected void SetNeedToPlayerUpdateAll()
        {
        }

        protected virtual void InternalInitialize()
        {
        }

        protected virtual void InternalFinalize()
        {
        }

        private void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        private void OnDestroy()
        {
        }

        protected bool SetInitialSourcePosition()
        {
            return default(bool);
        }

        protected virtual void SetInitialParameters()
        {
        }

        protected virtual void UpdatePosition()
        {
        }

        private void Start()
        {
        }

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        public abstract CriAtomExPlayback Play();
        protected abstract CriAtomExAcb GetAcb();
        protected abstract void PlayOnStart();
        public CriAtomExPlayback Play(string cueName)
        {
            return default(CriAtomExPlayback);
        }

        public CriAtomExPlayback Play(int cueId)
        {
            return default(CriAtomExPlayback);
        }

        protected CriAtomExPlayback InternalPlayCue()
        {
            return default(CriAtomExPlayback);
        }

        public void Stop()
        {
        }

        public void Pause(bool sw)
        {
        }

        public bool IsPaused()
        {
            return default(bool);
        }

        public void SetBusSendLevel(string busName, float level)
        {
        }

        [Obsolete("Use CriAtomSource.SetBusSendLevel(string, float)")]
        public void SetBusSendLevel(int busId, float level)
        {
        }

        public void SetBusSendLevelOffset(string busName, float levelOffset)
        {
        }

        [Obsolete("Use CriAtomSource.SetBusSendLevelOffset(string, float)")]
        public void SetBusSendLevelOffset(int busId, float levelOffset)
        {
        }

        public void SetAisacControl(string controlName, float value)
        {
        }

        [Obsolete("Use CriAtomSource.SetAisacControl")]
        public void SetAisac(string controlName, float value)
        {
        }

        public void SetAisacControl(uint controlId, float value)
        {
        }

        [Obsolete("Use CriAtomSource.SetAisacControl")]
        public void SetAisac(uint controlId, float value)
        {
        }

        public void AttachToAnalyzer(CriAtomExOutputAnalyzer analyzer)
        {
        }

        public void DetachFromAnalyzer(CriAtomExOutputAnalyzer analyzer)
        {
        }

        protected CriAtomSourceBase()
        {
        }
    }
}
