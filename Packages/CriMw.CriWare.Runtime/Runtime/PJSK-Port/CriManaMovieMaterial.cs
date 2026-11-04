using System.Collections;
using CriWare.CriMana;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriManaMovieMaterialBase (TypeDefIndex 31865): owns a CriMana.Player and keeps its movie material
    // updated; StreamingLive drives it manually (MovieMaterialPlayer: PlayerManualInitialize/Setup/Update/Finalize).
    public abstract class CriManaMovieMaterialBase : CriMonoBehaviour
    {
        public enum MaxFrameDrop
        {
            Disabled = 0,
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Infinite = -1
        }

        public enum RenderMode
        {
            Always = 0,
            OnVisibility = 1,
            Never = 2
        }

        public delegate void OnApplicationPauseCallback(CriManaMovieMaterialBase manaMovieMaterial, bool appPause);

        public bool playOnStart;
        public bool restartOnEnable;
        public RenderMode renderMode;
        public OnApplicationPauseCallback onApplicationPauseCallback;
        private Player.TimerType _timerType = Player.TimerType.Audio;
        [SerializeField]
        private Material _material;
        [SerializeField]
        private MaxFrameDrop _maxFrameDrop;
        private bool materialOwn;
        protected bool isMonoBehaviourStartCalled;
        private bool wasDisabled;
        private bool wasPausedOnDisable;
        private bool previousOnApplicationPauseStatus;
        private WaitForEndOfFrame frameEnd = new WaitForEndOfFrame();
        private bool unpauseOnApplicationUnpause;
        private CriManaMoviePlayerHolder playerHolder;

        public MaxFrameDrop maxFrameDrop
        {
            get => _maxFrameDrop;
            set
            {
                _maxFrameDrop = value;
                if (player != null)
                    player.maxFrameDrop = (int)value;
            }
        }

        public bool isMaterialAvailable { get; private set; }

        public Player player { get; private set; }

        public Material material
        {
            get => _material;
            set
            {
                if (value != _material)
                {
                    DestroyOwnMaterial();
                    _material = value;
                    isMaterialAvailable = false;
                }
            }
        }

        public Player.TimerType timerType
        {
            get => _timerType;
            set
            {
                _timerType = value;
                if (player != null)
                    player.SetMasterTimerType(value);
            }
        }

        protected abstract bool initializeWithAdvancedAudio { get; }

        protected abstract bool initializeWithAmbisonics { get; }

        protected abstract uint FilePathLength { get; }

        protected bool HaveRendererOwner { get; private set; }

        private void DestroyOwnMaterial()
        {
            if (materialOwn && _material != null)
            {
                Destroy(_material);
                _material = null;
            }
            materialOwn = false;
        }

        protected abstract void SetDataToPlayer();

        public void Play()
        {
            player.Start();
            CriInternalUpdate();
        }

        public void Stop()
        {
            player.Stop();
            if (isMaterialAvailable)
            {
                isMaterialAvailable = false;
                OnMaterialAvailableChanged();
            }
        }

        public void Pause(bool sw)
        {
            if (wasDisabled)
                wasPausedOnDisable = sw;
            else
                player.Pause(sw);
        }

        protected virtual void OnMaterialAvailableChanged()
        {
        }

        protected virtual void OnMaterialUpdated()
        {
        }

        public void PlayerManualInitialize()
        {
            if (player != null)
            {
                Debug.LogError("[CRIWARE][Error] CriManaMovieMaterial is already initialized. There is no need to call this function multiple times.");
                return;
            }
            player = new Player(initializeWithAdvancedAudio, initializeWithAmbisonics, FilePathLength);
            player.SetMasterTimerType(_timerType);
            isMaterialAvailable = false;
        }

        public void PlayerManualFinalize()
        {
            if (player != null)
            {
                player.Dispose();
                player = null;
                DestroyOwnMaterial();
            }
        }

        public void PlayerManualSetup()
        {
            HaveRendererOwner = GetComponent<Renderer>() != null;
            if (_material == null)
                CreateMaterial();
            SetDataToPlayer();
            if (playOnStart)
                player.Start();
        }

        public virtual bool RenderTargetManualSetup()
        {
            return true;
        }

        public virtual void RenderTargetManualFinalize()
        {
        }

        public void PlayerManualUpdate()
        {
            if (player == null)
                return;
            if (player.timerType == Player.TimerType.User)
                player.UpdateWithUserTime(0, 1000);
            else
                player.Update();
            if (player.isFrameInfoAvailableForMaterial && player.UpdateMaterial(_material))
            {
                OnMaterialUpdated();
                if (!isMaterialAvailable)
                {
                    isMaterialAvailable = true;
                    OnMaterialAvailableChanged();
                }
            }
            else if (isMaterialAvailable)
            {
                isMaterialAvailable = false;
                OnMaterialAvailableChanged();
            }
        }

        protected virtual void Awake()
        {
            PlayerManualInitialize();
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            if (wasDisabled && player != null && player.isAlive)
            {
                player.Pause(wasPausedOnDisable);
                if (restartOnEnable)
                    StartCoroutine(RestartPlayerRoutine());
            }
            wasDisabled = false;
        }

        private IEnumerator RestartPlayerRoutine()
        {
            if (player.status != Player.Status.Playing && player.status != Player.Status.PlayEnd)
                yield break;
            Stop();
            while (true)
            {
                if (player.status == Player.Status.Stop)
                {
                    Play();
                    player.Pause(wasPausedOnDisable);
                    yield break;
                }
                if (player.status != Player.Status.StopProcessing)
                    yield break;
                yield return frameEnd;
            }
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            if (player != null && player.isAlive)
            {
                wasPausedOnDisable = player.IsPaused();
                player.Pause(true);
            }
            wasDisabled = true;
        }

        protected virtual void OnDestroy()
        {
            RenderTargetManualFinalize();
            PlayerManualFinalize();
        }

        protected virtual void Start()
        {
            PlayerManualSetup();
            isMonoBehaviourStartCalled = true;
            if (!RenderTargetManualSetup())
                Destroy(this);
        }

        public override void CriInternalUpdate()
        {
            PlayerManualUpdate();
        }

        public virtual void RenderMovie()
        {
            player.OnWillRenderObject(this);
        }

        public override void CriInternalLateUpdate()
        {
            if (renderMode == RenderMode.Always)
                player.OnWillRenderObject(this);
        }

        protected virtual void OnWillRenderObject()
        {
            if (renderMode == RenderMode.OnVisibility)
                player.OnWillRenderObject(this);
        }

        private void OnApplicationPause(bool appPause)
        {
            ProcessApplicationPause(appPause);
        }

        private void ProcessApplicationPause(bool appPause)
        {
            if (previousOnApplicationPauseStatus == appPause)
                return;
            previousOnApplicationPauseStatus = appPause;
            if (onApplicationPauseCallback != null)
            {
                onApplicationPauseCallback(this, appPause);
                return;
            }
            if (player == null)
                return;
            if (appPause)
            {
                var isPaused = player.IsPaused();
                unpauseOnApplicationUnpause = !isPaused;
                if (!isPaused)
                    player.PauseOnApplicationPause(true);
            }
            else
            {
                if (unpauseOnApplicationUnpause)
                    player.PauseOnApplicationPause(false);
                unpauseOnApplicationUnpause = false;
            }
        }

        private void CreateMaterial()
        {
            _material = new Material(Shader.Find("CriMana/SofdecPrimeYuv"));
            _material.name = "CriMana-MovieMaterial";
            materialOwn = true;
        }
    }

    // CriWare.CriManaMovieMaterial (TypeDefIndex 31860).
    [AddComponentMenu("CRIWARE/CriManaMovieMaterial")]
    public class CriManaMovieMaterial : CriManaMovieMaterialBase
    {
        [SerializeField]
        private string _moviePath;
        [SerializeField]
        private bool _loop;
        [SerializeField]
        private bool _audioBaseConcatenation = true;
        [SerializeField]
        private bool _additiveMode;
        [SerializeField]
        private bool _advancedAudio = true;
        [SerializeField]
        private bool _ambisonics;
        [SerializeField]
        private bool _applyTargetAlpha;
        [SerializeField]
        private bool _uiRenderMode;
        private GameObject ambisonicSource;

        public string moviePath
        {
            get => _moviePath;
            set
            {
                if (isMonoBehaviourStartCalled)
                    Debug.LogError("[CRIWARE] moviePath can not be changed. Use CriMana::Player::SetFile method.");
                else
                    _moviePath = value;
            }
        }

        public bool loop
        {
            get => _loop;
            set
            {
                if (isMonoBehaviourStartCalled)
                    Debug.LogError("[CRIWARE] loop property can not be changed. Use CriMana::Player::Loop method.");
                else
                    _loop = value;
            }
        }

        public bool audioBaseConcatenation
        {
            get => _audioBaseConcatenation;
            set
            {
                if (isMonoBehaviourStartCalled)
                    Debug.LogError("[CRIWARE] audioBaseConcatenation property can not be changed in running.");
                else
                    _audioBaseConcatenation = value;
            }
        }

        public bool advancedAudio
        {
            get => _advancedAudio;
            set
            {
                if (isMonoBehaviourStartCalled)
                {
                    Debug.LogError("[CRIWARE] advancedAudio property can not be changed in running.");
                    return;
                }
                if (!value)
                    ambisonics = false;
                _advancedAudio = value;
            }
        }

        public bool ambisonics
        {
            get => _ambisonics;
            set
            {
                if (isMonoBehaviourStartCalled)
                {
                    Debug.LogError("[CRIWARE] ambisonics property can not be changed in running.");
                    return;
                }
                if (!_advancedAudio)
                {
                    Debug.LogError("[CRIWARE] ambisonics property needs for advancedAudio property to be true.");
                    return;
                }
                if (value)
                {
                    if (ambisonicSource == null)
                    {
                        ambisonicSource = new GameObject();
                        ambisonicSource.name = "Ambisonic Source";
                        ambisonicSource.transform.parent = gameObject.transform;
                        ambisonicSource.transform.position = gameObject.transform.position;
                        ambisonicSource.transform.rotation = gameObject.transform.rotation;
                        ambisonicSource.transform.localScale = gameObject.transform.localScale;
                        ambisonicSource.AddComponent<CriManaAmbisonicSource>();
                    }
                }
                else if (gameObject.transform.childCount >= 1)
                {
                    var source = ambisonicSource != null
                        ? ambisonicSource
                        : gameObject.transform.Find("Ambisonic Source").gameObject;
                    if (source != null)
                        DestroyImmediate(source);
                }
                _ambisonics = value;
            }
        }

        public bool additiveMode
        {
            get => _additiveMode;
            set
            {
                if (isMonoBehaviourStartCalled)
                    Debug.LogError("[CRIWARE] additiveMode can not be changed. Use CriMana::Player::additiveMode method.");
                else
                    _additiveMode = value;
            }
        }

        public bool applyTargetAlpha
        {
            get => _applyTargetAlpha;
            set
            {
                if (isMonoBehaviourStartCalled)
                    Debug.LogError("[CRIWARE] applyTargetAlpha property can not be changed in running.");
                else
                    _applyTargetAlpha = value;
            }
        }

        public bool uiRenderMode
        {
            get => _uiRenderMode;
            set
            {
                if (isMonoBehaviourStartCalled)
                    Debug.LogError("[CRIWARE] uiRenderMode property can not be changed in running.");
                else
                    _uiRenderMode = value;
            }
        }

        protected override uint FilePathLength
        {
            get
            {
                if (string.IsNullOrEmpty(_moviePath))
                    return 0;
                var length = _moviePath.Length;
                if (Common.IsStreamingAssetsPath(_moviePath))
                    length += Common.streamingAssetsPath.Length + 1;
                return (uint)(length + 1);
            }
        }

        protected override bool initializeWithAdvancedAudio => _advancedAudio;

        protected override bool initializeWithAmbisonics => _ambisonics;

        protected override void SetDataToPlayer()
        {
            if (!string.IsNullOrEmpty(_moviePath))
                player.SetFile(null, _moviePath, Player.SetMode.New);
            player.Loop(_loop);
            player.SetAudioBaseConcatenation(_audioBaseConcatenation);
            player.additiveMode = _additiveMode;
            player.maxFrameDrop = (int)maxFrameDrop;
            player.applyTargetAlpha = _applyTargetAlpha;
            player.uiRenderMode = _uiRenderMode;
        }
    }

    // CriWare.CriManaMoviePlayerHolder (TypeDefIndex 31866): the "CriManaMovieResources" object each player creates;
    // it outlives the player for the native destroy frames.
    public class CriManaMoviePlayerHolder : CriMonoBehaviour
    {
        private Player _player;

        public Player player
        {
            set => _player = value;
        }

        private void Awake()
        {
            DontDestroyOnLoad(this);
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
    }

    // CriWare.CriManaAmbisonicSource (TypeDefIndex 31857): turns the player's ambisonics 3D source with its transform.
    public class CriManaAmbisonicSource : CriMonoBehaviour
    {
        private CriAtomEx3dSource atomEx3DsourceForAmbisonics;
        private Vector3 ambisonicSourceOrientationFront;
        private Vector3 ambisonicSourceOrientationTop;
        private Vector3 lastEulerOfAmbisonicSource;

        protected override void OnEnable()
        {
            base.OnEnable();
            atomEx3DsourceForAmbisonics =
                gameObject.transform.parent.GetComponent<CriManaMovieMaterial>().player.atomEx3Dsource;
            if (atomEx3DsourceForAmbisonics != null)
                ForceUpdateAmbisonicSourceOrientation();
            else
                Debug.LogError("atomEx3DsourceForAmbisonics == null");
        }

        public override void CriInternalUpdate()
        {
            UpdateAmbisonicSourceOrientation();
        }

        public override void CriInternalLateUpdate()
        {
        }

        private void UpdateAmbisonicSourceOrientation()
        {
            var diff = lastEulerOfAmbisonicSource - transform.eulerAngles;
            if (diff.x * diff.x + diff.y * diff.y + diff.z * diff.z >= 1.0e-10f)
                ForceUpdateAmbisonicSourceOrientation();
        }

        private void ForceUpdateAmbisonicSourceOrientation()
        {
            lastEulerOfAmbisonicSource = transform.eulerAngles;
            RoatateAmbisonicSourceOrientationByTransformOfChild(ref lastEulerOfAmbisonicSource);
            atomEx3DsourceForAmbisonics.SetOrientation(ambisonicSourceOrientationFront, ambisonicSourceOrientationTop);
            atomEx3DsourceForAmbisonics.Update();
        }

        // Rotates the front (0, 0, 1) and top (0, 1, 0) vectors by the rotation matrix of the euler angles.
        private void RoatateAmbisonicSourceOrientationByTransformOfChild(ref Vector3 input_euler)
        {
            var q = Quaternion.Euler(input_euler);
            var x2 = q.x * q.x;
            var y2 = q.y * q.y;
            var z2 = q.z * q.z;
            var xy2 = x2 + y2;
            var norm = q.w * q.w + (z2 + xy2);
            var s = norm <= 0f ? 0f : 2f / norm;
            var m = new float[9];
            m[0] = 1f - (y2 + z2) * s;
            m[1] = (q.x * q.y - q.w * q.z) * s;
            m[2] = (q.x * q.z + q.w * q.y) * s;
            m[3] = (q.x * q.y + q.w * q.z) * s;
            m[4] = 1f - (x2 + z2) * s;
            m[5] = (q.y * q.z - q.w * q.x) * s;
            m[6] = (q.x * q.z - q.w * q.y) * s;
            m[7] = (q.y * q.z + q.w * q.x) * s;
            m[8] = 1f - xy2 * s;
            ambisonicSourceOrientationFront.x = m[2] + (m[1] * 0f + m[0] * 0f);
            ambisonicSourceOrientationFront.y = m[5] + (m[3] * 0f + m[4] * 0f);
            ambisonicSourceOrientationFront.z = m[8] + (m[6] * 0f + m[7] * 0f);
            ambisonicSourceOrientationTop.x = m[0] * 0f + m[1] + m[2] * 0f;
            ambisonicSourceOrientationTop.y = m[3] * 0f + m[4] + m[5] * 0f;
            ambisonicSourceOrientationTop.z = m[6] * 0f + m[7] + m[8] * 0f;
        }
    }
}
