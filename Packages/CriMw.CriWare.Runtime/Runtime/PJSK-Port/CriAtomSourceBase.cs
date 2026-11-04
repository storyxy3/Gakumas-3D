using UnityEngine;

namespace CriWare
{
    // CriWare.CriAtomSourceBase (TypeDefIndex 31678), the Android build's members on the game's paths (StageSoundManager's
    // CriAtomSource objects bound to the SekaiAtom timeline tracks).
    public abstract class CriAtomSourceBase : CriMonoBehaviour
    {
        public enum Status
        {
            Stop = 0,
            Prep = 1,
            Playing = 2,
            PlayEnd = 3,
            Error = 4
        }

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
        private bool _use3dPositioning = true;
        [SerializeField]
        private bool _freezeOrientation;
        [SerializeField]
        private bool _loop;
        [SerializeField]
        private float _volume = 1f;
        [SerializeField]
        private float _pitch;
        [SerializeField]
        private bool _androidUseLowLatencyVoicePool;
        [SerializeField]
        private bool need_to_player_update_all = true;
        [SerializeField]
        private bool _use3dRandomization;
        [SerializeField]
        private uint _randomPositionListMaxLength;
        [SerializeField]
        private CriAtomEx.Randomize3dConfig randomize3dConfig = new CriAtomEx.Randomize3dConfig(0);

        public CriAtomExPlayer player { get; protected set; }

        public CriAtomEx3dSource source { get; protected set; }

        public bool playOnStart
        {
            get => _playOnStart;
            set => _playOnStart = value;
        }

        public bool use3dPositioning
        {
            set
            {
                _use3dPositioning = value;
                if (player != null)
                {
                    player.Set3dSource(value ? source : null);
                    SetNeedToPlayerUpdateAll();
                }
            }
            get => _use3dPositioning;
        }

        public bool freezeOrientation
        {
            get => _freezeOrientation;
            set => _freezeOrientation = value;
        }

        public bool use3dRandomization
        {
            set
            {
                _use3dRandomization = value;
                if (source != null)
                    source.SetRandomPositionConfig(value ? randomize3dConfig : (CriAtomEx.Randomize3dConfig?)null);
            }
            get => _use3dRandomization;
        }

        public CriAtomRegion region3d
        {
            get => currentRegion;
            set
            {
                if (currentRegion == value)
                    return;
                if (!_use3dPositioning)
                {
                    Debug.LogWarning("[CRIWARE] Cannot set 3D Region on audio source with 3d positioning disabled.");
                    return;
                }
                if (currentRegion != null)
                    currentRegion.referringSources.Remove(this);
                var regionHn = value == null ? null : value.region3dHn;
                if (source == null)
                {
                    Debug.LogError("[CRIWARE] Internal: 3D Positioning is not initialized correctly.");
                    currentRegion = null;
                    return;
                }
                source.Set3dRegion(regionHn);
                source.Update();
                currentRegion = value;
                if (currentRegion != null)
                    currentRegion.referringSources.Add(this);
            }
        }

        public CriAtomListener listener
        {
            get => currentListener;
            set
            {
                if (!_use3dPositioning)
                {
                    Debug.LogWarning("[CRIWARE] Cannot set 3D Listener on audio source with 3d positioning disabled.");
                    return;
                }
                currentListener = value;
                player.Set3dListener(value == null ? null : value.nativeListener);
            }
        }

        public bool loop
        {
            set => _loop = value;
            get => _loop;
        }

        public float volume
        {
            set
            {
                _volume = value;
                if (player != null)
                {
                    player.SetVolume(value);
                    SetNeedToPlayerUpdateAll();
                }
            }
            get => _volume;
        }

        public float pitch
        {
            set
            {
                _pitch = value;
                if (player != null)
                {
                    player.SetPitch(value);
                    SetNeedToPlayerUpdateAll();
                }
            }
            get => _pitch;
        }

        public Status status => player != null ? (Status)player.GetStatus() : Status.Error;

        public bool androidUseLowLatencyVoicePool
        {
            get => _androidUseLowLatencyVoicePool;
            set => _androidUseLowLatencyVoicePool = value;
        }

        protected void SetNeedToPlayerUpdateAll()
        {
            need_to_player_update_all = true;
        }

        protected virtual void InternalInitialize()
        {
            CriAtomPlugin.InitializeLibrary();
            player = new CriAtomExPlayer();
            source = new CriAtomEx3dSource(false, _randomPositionListMaxLength);
            initialized = true;
        }

        protected virtual void InternalFinalize()
        {
            initialized = false;
            region3d = null;
            player.Dispose();
            player = null;
            source.Dispose();
            source = null;
            CriAtomPlugin.FinalizeLibrary();
        }

        private void Awake()
        {
            InternalInitialize();
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            hasValidPosition = false;
            SetInitialParameters();
            SetNeedToPlayerUpdateAll();
        }

        private void OnDestroy()
        {
            InternalFinalize();
        }

        protected bool SetInitialSourcePosition()
        {
            var position = transform.position;
            lastPosition = position;
            if (source != null)
            {
                source.SetPosition(position.x, position.y, position.z);
                source.Update();
                return true;
            }
            return false;
        }

        protected virtual void SetInitialParameters()
        {
            if (player != null)
            {
                player.Set3dSource(_use3dPositioning ? source : null);
                SetNeedToPlayerUpdateAll();
            }
            use3dRandomization = _use3dRandomization;
            if (!SetInitialSourcePosition())
                Debug.LogError("[ADX][SetInitialParameters] source is null.", this);
            player.SetVolume(_volume);
            player.SetPitch(_pitch);
        }

        protected virtual void UpdatePosition()
        {
            var position = transform.position;
            source.SetPosition(position.x, position.y, position.z);
            if (hasValidPosition)
            {
                var velocity = (position - lastPosition) / Time.deltaTime;
                source.SetVelocity(velocity.x, velocity.y, velocity.z);
            }
            if (!_freezeOrientation)
                source.SetOrientation(transform.forward, transform.up);
            source.Update();
            lastPosition = position;
            hasValidPosition = true;
        }

        private void Start()
        {
            if (_use3dPositioning && _regionOnStart != null)
                region3d = _regionOnStart;
            if (_use3dPositioning && _listenerOnStart != null)
                listener = _listenerOnStart;
            PlayOnStart();
        }

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
            if (_use3dPositioning)
                UpdatePosition();
            if (need_to_player_update_all)
            {
                player.UpdateAll();
                need_to_player_update_all = false;
            }
        }

        public abstract CriAtomExPlayback Play();

        protected abstract CriAtomExAcb GetAcb();

        protected abstract void PlayOnStart();

        public CriAtomExPlayback Play(string cueName)
        {
            if (player == null)
                return new CriAtomExPlayback(CriAtomExPlayback.invalidId);
            var acb = GetAcb();
            player.SetCue(acb, cueName);
            return InternalPlayCue();
        }

        // 官方 7.0.0 iOS CriAtomSourceBase$$InternalPlayCue 0x44AC130：[!hasValidPosition 时设初始位置] → 状态为 Stop 时 Loop
        // → Start。Android 版每次 Start 前按 _androidUseLowLatencyVoicePool 调 SetSoundRendererType，iOS 版没有这一步。
        protected CriAtomExPlayback InternalPlayCue()
        {
#if !UNITY_IOS
            // JP 7.0.0 Android 0x66AA6D4–0x66AA71C selects the renderer before every Start.
            player.SetSoundRendererType(_androidUseLowLatencyVoicePool
                ? CriAtomEx.SoundRendererType.Native
                : CriAtomEx.androidDefaultSoundRendererType);
#endif
            if (!hasValidPosition)
            {
                SetInitialSourcePosition();
                hasValidPosition = true;
            }
            if (player.GetStatus() == CriAtomExPlayer.Status.Stop)
                player.Loop(_loop);
            return player.Start();
        }

        public void Stop()
        {
            if (player != null)
                player.Stop();
        }

        public void SetAisacControl(string controlName, float value)
        {
            if (player != null)
            {
                player.SetAisacControl(controlName, value);
                SetNeedToPlayerUpdateAll();
            }
        }
    }
}
