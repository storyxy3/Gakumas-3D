namespace Campus.Common.Live
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::UnityEngine.Rendering.Universal;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Common.Live;
    using global::Campus.Common.Panorama;
    using global::Campus.Live.Equipment;
    using global::Campus.Timeline;
    using global::Cinemachine;
    using global::Common.Live;
    using global::JetBrains.Annotations;
    using global::UniRx;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;
    using global::UnityEngine.Video;
    using global::VL.Timeline;

    [ExecuteAlways]
    public class CampusLiveTimelineController : VLTimelineController, IPanoramaCameraController, IForcedCameraController, IForcedCameraInternal, ICurrentActorSignalController, ICurrentActorSignalNotifier, ILookAtProhibitController, ILookAtProhibitSource
    {
        private struct ForcedCameraState
        {
            public ICinemachineCamera camA;
            public ICinemachineCamera camB;
            public float weightB;
            public float deltaTime;
            public bool isActive;
            public bool forceAuto;
        }

        [Serializable]
        public class LiveProp
        {
            public int index;
            public List<LivePropSetting> propSettings;
            public LiveProp()
            {
            }
        }

        [Serializable]
        public class LivePropSetting
        {
            public GameObject propPrefab;
            public GameObject fieldConstraintTarget;
            public LivePropSetting()
            {
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<CampusDirectorControlTrack, IEnumerable<TimelineClip>> _003C_003E9__109_0;
            public static Func<TimelineClip, CampusDirectorControlAsset> _003C_003E9__109_1;
            public static Func<CampusDirectorControlAsset, bool> _003C_003E9__109_2;
            public static Func<PlayableDirector, PlayableAsset> _003C_003E9__112_0;
            public static Func<TimelineAsset, IEnumerable<TrackAsset>> _003C_003E9__112_1;
            public static Func<LiveProp, IEnumerable<LivePropSetting>> _003C_003E9__113_1;
            public static Func<LivePropSetting, GameObject> _003C_003E9__113_2;
            public static Func<LiveProp, IEnumerable<LivePropSetting>> _003C_003E9__114_1;
            public static Func<LivePropSetting, GameObject> _003C_003E9__114_2;
            public static Func<LiveProp, IEnumerable<LivePropSetting>> _003C_003E9__115_1;
            public static Func<GroupTrack, bool> _003C_003E9__116_0;
            public static Func<MuteTrackDisableSetting, bool> _003C_003E9__120_0;
            public static Func<MuteTrackDisableSetting, string> _003C_003E9__120_1;
            public static Func<MuteTrackDisableSetting, bool> _003C_003E9__120_2;
            public static Func<TimelineClip, double> _003C_003E9__129_1;
            public _003C_003Ec()
            {
            }

            internal IEnumerable<TimelineClip> _003Cget_ControlDirectors_003Eb__109_0(CampusDirectorControlTrack x)
            {
                return x.GetClips();
            }

            internal CampusDirectorControlAsset _003Cget_ControlDirectors_003Eb__109_1(TimelineClip x)
            {
                return x.asset as CampusDirectorControlAsset;
            }

            internal bool _003Cget_ControlDirectors_003Eb__109_2(CampusDirectorControlAsset x)
            {
                return x != null;
            }

            internal PlayableAsset _003Cget_ControlledRootTracks_003Eb__112_0(PlayableDirector x)
            {
                return x.playableAsset;
            }

            internal IEnumerable<TrackAsset> _003Cget_ControlledRootTracks_003Eb__112_1(TimelineAsset x)
            {
                return x.GetRootTracks();
            }

            internal IEnumerable<LivePropSetting> _003CGetProps_003Eb__113_1(LiveProp x)
            {
                return x.propSettings;
            }

            internal GameObject _003CGetProps_003Eb__113_2(LivePropSetting x)
            {
                return x.propPrefab;
            }

            internal IEnumerable<LivePropSetting> _003CGetFieldConstraintTargets_003Eb__114_1(LiveProp x)
            {
                return x.propSettings;
            }

            internal GameObject _003CGetFieldConstraintTargets_003Eb__114_2(LivePropSetting x)
            {
                return x.fieldConstraintTarget;
            }

            internal IEnumerable<LivePropSetting> _003CGetPropAndFieldConstraintTargetPairs_003Eb__115_1(LiveProp x)
            {
                return x.propSettings;
            }

            internal bool _003CHasCharacterTrack_003Eb__116_0(GroupTrack x)
            {
                return x.name.StartsWith(CharacterTrackNamePrefix);
            }

            internal bool _003CApplyMuteFromTrackDisableSettings_003Eb__120_0(MuteTrackDisableSetting x)
            {
                return x != null && !string.IsNullOrEmpty(x.trackName);
            }

            internal string _003CApplyMuteFromTrackDisableSettings_003Eb__120_1(MuteTrackDisableSetting x)
            {
                return x.trackName;
            }

            internal bool _003CApplyMuteFromTrackDisableSettings_003Eb__120_2(MuteTrackDisableSetting x)
            {
                return x.disableTrackBinding;
            }

            internal double _003CApplyOverrideMotionTracks_003Eb__129_1(TimelineClip x)
            {
                return x.start;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass113_0
        {
            public int actorIndex;
            public _003C_003Ec__DisplayClass113_0()
            {
            }

            internal bool _003CGetProps_003Eb__0(LiveProp x)
            {
                return x.index == actorIndex;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass114_0
        {
            public int actorIndex;
            public _003C_003Ec__DisplayClass114_0()
            {
            }

            internal bool _003CGetFieldConstraintTargets_003Eb__0(LiveProp x)
            {
                return x.index == actorIndex;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass115_0
        {
            public int actorIndex;
            public _003C_003Ec__DisplayClass115_0()
            {
            }

            internal bool _003CGetPropAndFieldConstraintTargetPairs_003Eb__0(LiveProp x)
            {
                return x.index == actorIndex;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass123_0
        {
            public CampusLiveTimelineController _003C_003E4__this;
            public TimelineAsset masterTimeline;
            public _003C_003Ec__DisplayClass123_0()
            {
            }

            internal TrackAsset _003CCollectTracksResolvedByPaths_003Eb__0(string raw)
            {
                return _003C_003E4__this.ResolveTracksByPathSegments(masterTimeline, raw.Split("/", StringSplitOptions.None));
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass124_0
        {
            public string[] segments;
            public string lastSegment;
            public _003C_003Ec__DisplayClass124_0()
            {
            }

            internal bool _003CResolveTracksByPathSegments_003Eb__0(TrackAsset t)
            {
                return t.name == lastSegment;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass124_1
        {
            public int i;
            public _003C_003Ec__DisplayClass124_0 CS_0024_003C_003E8__locals1;
            public _003C_003Ec__DisplayClass124_1()
            {
            }

            internal bool _003CResolveTracksByPathSegments_003Eb__1(TrackAsset t)
            {
                return t.name == CS_0024_003C_003E8__locals1.segments[i];
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass126_0
        {
            public TrackAsset track;
            public _003C_003Ec__DisplayClass126_0()
            {
            }

            internal bool _003CDisableTrackBinding_003Eb__0(PlayableDirector x)
            {
                return x.playableAsset == track.timelineAsset;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass129_0
        {
            public OverrideActorMotionTrack trackOverride;
            public _003C_003Ec__DisplayClass129_0()
            {
            }

            internal bool _003CApplyOverrideMotionTracks_003Eb__0(TrackAsset x)
            {
                return x.name == trackOverride.trackName;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass129_1
        {
            public OverrideActorMotionClip clipOverride;
            public _003C_003Ec__DisplayClass129_1()
            {
            }

            internal bool _003CApplyOverrideMotionTracks_003Eb__2(TimelineClip c)
            {
                return c.displayName == clipOverride.clipName;
            }
        }

        private int _cameraOverrideId = -1;
        private readonly Dictionary<int, ForcedCameraState> _forcedCameraSources = new Dictionary<int, ForcedCameraState>();
        private ICinemachineCamera _userCamera;
        private readonly Subject<ForcedCameraChangedInfo> _forcedCameraChangedSubject = new Subject<ForcedCameraChangedInfo>();
        private ICinemachineCamera _lastAppliedCamA;
        private ICinemachineCamera _lastAppliedCamB;
        private bool _hasAppliedOverride;
        private PlayState _lastObservedPlayState;
        private PanoramaCameraHolder _cameraHolder;
        private readonly Dictionary<int, int> _currentActorIndices = new Dictionary<int, int>();
        private readonly Subject<CurrentActorSignalData> _currentActorSignalSubject = new Subject<CurrentActorSignalData>();
        private readonly Dictionary<int, HashSet<int>> _lookAtProhibitSources = new Dictionary<int, HashSet<int>>();
        private readonly HashSet<int> _lookAtProhibitAllSources = new HashSet<int>();
        private readonly Dictionary<int, HashSet<int>> _lookAtEnableProhibitSources = new Dictionary<int, HashSet<int>>();
        private readonly HashSet<int> _lookAtEnableProhibitAllSources = new HashSet<int>();
        private readonly Subject<(int actorIndex, bool isProhibited)> _lookAtProhibitChanged = new Subject<(int actorIndex, bool isProhibited)>();
        private readonly Subject<(int actorIndex, bool isEnableProhibited)> _lookAtEnableProhibitChanged = new Subject<(int actorIndex, bool isEnableProhibited)>();
        private readonly bool[] _prevProhibitState = new bool[10];
        private readonly bool[] _prevProhibitEnableState = new bool[10];
        private static readonly string CharacterTrackNamePrefix = "Exclusive_";
        [SerializeField]
        private CampusActorLayout _actorLayout;
        [SerializeField]
        private List<CampusVirtualActorController> _virtualActors;
        [SerializeField]
        private List<LiveProp> _actorPropSettings;
        [SerializeField]
        private bool _isCmmnHeightCorrectionNeededForActorSwing;
        [SerializeField]
        private LiveEquipmentController _equipmentController;
        [SerializeField]
        private LiveEquipmentReceiver _equipmentReceiver;
        [SerializeField]
        private Canvas _overlayCanvas;
        [SerializeField]
        private Canvas _backgroundCanvas;
        [SerializeField]
        private RawImage _overlayImage;
        [SerializeField]
        [CanBeNull]
        private VideoPlayer monitorVideoPlayer;
        [SerializeField]
        private Image[] overrideMonitorImages;
        [SerializeField]
        private List<CampusTimelineCriVideoPlayer> _criVideoPlayers;
        private PlayableDirector[] _controlDirectorsCache;
        private TrackAsset[] _controlledRootTracksCache;
        private PanoramaCameraHolder CameraHolder
        {
            get
            {
                if (_cameraHolder == null) _cameraHolder = GetComponent<PanoramaCameraHolder>();
                return _cameraHolder;
            }
        }

        public bool HasCameraHolder
        {
            get
            {
                return CameraHolder != null;
            }
        }

        public bool IsCameraForced
        {
            get
            {
                foreach (var pair in _forcedCameraSources)
                    if (pair.Value.isActive) return true;
                return false;
            }
        }

        public SwitchPanoramaCamera CurrentForcedCamera
        {
            get
            {
                foreach (var pair in _forcedCameraSources)
                {
                    var state = pair.Value;
                    if (!state.isActive || state.forceAuto) continue;
                    foreach (var camera in GetAllPanoramaCameras())
                        if (camera.Value.VirtualCamera == state.camB) return camera.Value;
                }
                return null;
            }
        }

        public IObservable<ForcedCameraChangedInfo> OnForcedCameraChanged
        {
            get
            {
                return _forcedCameraChangedSubject;
            }
        }

        public IObservable<(int actorIndex, bool isProhibited)> OnLookAtProhibitChanged
        {
            get
            {
                return _lookAtProhibitChanged;
            }
        }

        public IObservable<(int actorIndex, bool isEnableProhibited)> OnLookAtEnableProhibitChanged
        {
            get
            {
                return _lookAtEnableProhibitChanged;
            }
        }

        public CampusActorLayout actorLayout
        {
            get
            {
                return _actorLayout;
            }

            set
            {
                _actorLayout = value;
            }
        }

        public List<CampusVirtualActorController> virtualActors
        {
            get
            {
                return _virtualActors;
            }

            set
            {
                _virtualActors = value;
            }
        }

        public List<LiveProp> actorPropSettings
        {
            get
            {
                return _actorPropSettings;
            }

            set
            {
                _actorPropSettings = value;
            }
        }

        public bool IsCmmnHeightCorrectionNeededForActorSwing
        {
            get
            {
                return _isCmmnHeightCorrectionNeededForActorSwing;
            }
        }

        public LiveEquipmentController equipmentController
        {
            get
            {
                return _equipmentController;
            }

            set
            {
                _equipmentController = value;
            }
        }

        public LiveEquipmentReceiver equipmentReceiver
        {
            get
            {
                return _equipmentReceiver;
            }

            set
            {
                _equipmentReceiver = value;
            }
        }

        public Canvas overlayCanvas
        {
            get
            {
                return _overlayCanvas;
            }
        }

        public Canvas BackgroundCanvas
        {
            get
            {
                return _backgroundCanvas;
            }
        }

        public RawImage overlayImage
        {
            get
            {
                return _overlayImage;
            }
        }

        [CanBeNull]
        public VideoPlayer MonitorVideoPlayer
        {
            get
            {
                return monitorVideoPlayer;
            }
        }

        public Image[] OverrideMonitorImages
        {
            get
            {
                return overrideMonitorImages;
            }
        }

        public List<CampusTimelineCriVideoPlayer> criVideoPlayers
        {
            get
            {
                return _criVideoPlayers;
            }

            set
            {
                _criVideoPlayers = value;
            }
        }

        private PlayableDirector[] ControlDirectors
        {
            get
            {
                if (_controlDirectorsCache == null)
                {
                    if (master == null) return Array.Empty<PlayableDirector>();
                    var timeline = master.playableAsset as TimelineAsset;
                    if (timeline == null) return Array.Empty<PlayableDirector>();
                    _controlDirectorsCache = timeline.GetOutputTracks().OfType<CampusDirectorControlTrack>()
                        .SelectMany((_003C_003Ec._003C_003E9__109_0 ?? (_003C_003Ec._003C_003E9__109_0 = new Func<CampusDirectorControlTrack, IEnumerable<TimelineClip>>(_003C_003Ec._003C_003E9._003Cget_ControlDirectors_003Eb__109_0))))
                        .Select((_003C_003Ec._003C_003E9__109_1 ?? (_003C_003Ec._003C_003E9__109_1 = new Func<TimelineClip, CampusDirectorControlAsset>(_003C_003Ec._003C_003E9._003Cget_ControlDirectors_003Eb__109_1))))
                        .Where((_003C_003Ec._003C_003E9__109_2 ?? (_003C_003Ec._003C_003E9__109_2 = new Func<CampusDirectorControlAsset, bool>(_003C_003Ec._003C_003E9._003Cget_ControlDirectors_003Eb__109_2))))
                        .Select(new Func<CampusDirectorControlAsset, PlayableDirector>(_003Cget_ControlDirectors_003Eb__109_3))
                        .Append(master).Distinct().ToArray();
                }
                return _controlDirectorsCache;
            }
        }

        private TrackAsset[] ControlledRootTracks
        {
            get
            {
                if (_controlledRootTracksCache == null)
                    _controlledRootTracksCache = FasterLinq.Select(ControlDirectors, (_003C_003Ec._003C_003E9__112_0 ?? (_003C_003Ec._003C_003E9__112_0 = new Func<PlayableDirector, PlayableAsset>(_003C_003Ec._003C_003E9._003Cget_ControlledRootTracks_003Eb__112_0))))
                        .OfType<TimelineAsset>()
                        .SelectMany((_003C_003Ec._003C_003E9__112_1 ?? (_003C_003Ec._003C_003E9__112_1 = new Func<TimelineAsset, IEnumerable<TrackAsset>>(_003C_003Ec._003C_003E9._003Cget_ControlledRootTracks_003Eb__112_1)))).ToArray();
                return _controlledRootTracksCache;
            }
        }

        void Campus.Timeline.IForcedCameraInternal.SetForcedCamera(int sourceId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime, bool forceAuto)
        {
            _forcedCameraSources[sourceId] = new ForcedCameraState { camA = camA, camB = camB, weightB = weightB, deltaTime = deltaTime, isActive = camB != null || forceAuto, forceAuto = forceAuto };
            UpdateCameraOverride(deltaTime);
        }

        void Campus.Timeline.IForcedCameraInternal.RemoveForcedCameraSource(int sourceId)
        {
            _forcedCameraSources.Remove(sourceId);
            UpdateCameraOverride(-1f);
        }

        public void SetUserCamera(SwitchPanoramaCamera camera)
        {
            // TODO(qa-recon): SwitchPanoramaCamera.VirtualCamera is outside the selected census.
            if (camera != null && camera.VirtualCamera == null)
                Debug.LogWarning("[PanoramaCamera] SetUserCamera: SwitchPanoramaCamera '" + camera.name + "' に VirtualCamera がアサインされていません。", camera);
            if (camera != null && CinemachineCore.Instance.GetActiveBrain(0) == null)
                Debug.LogWarning("[PanoramaCamera] SetUserCamera: アクティブな CinemachineBrain が存在しません。override は適用されません。シーンに CinemachineBrain が配置されているか確認してください。", this);
            _userCamera = camera != null ? camera.VirtualCamera : null;
            if (!IsCameraForced) UpdateCameraOverride(Time.deltaTime);
        }

        public void SetUserCamera(PanoramaCameraType type, int index)
        {
            if (type == PanoramaCameraType.UnDefined) { SetUserCamera(null); return; }
            var camera = ResolveCamera(type, index);
            if (camera == null)
            {
                Debug.LogWarning(string.Format("[PanoramaCamera] SetUserCamera({0}, {1}): 対象カメラが登録されていません。", type, index) + "PanoramaCameraHolder の設定か index 範囲を確認してください。", this);
                return;
            }
            SetUserCamera(camera);
        }

        public SwitchPanoramaCamera ResolveCamera(PanoramaCameraType type, int index)
        {
            return CameraHolder != null ? CameraHolder.ResolveCamera(type, index) : null;
        }

        public IReadOnlyDictionary<(PanoramaCameraType, int), SwitchPanoramaCamera> GetAllPanoramaCameras()
        {
            return CameraHolder != null ? CameraHolder.GetAllPanoramaCameras() : new Dictionary<(PanoramaCameraType, int), SwitchPanoramaCamera>();
        }

        public void RefreshCameraOverride(bool forceReacquire)
        {
            UpdateCameraOverride(Time.deltaTime, forceReacquire);
        }

        void Campus.Timeline.IForcedCameraInternal.NotifyForcedCameraChanged(ForcedCameraChangedInfo info)
        {
            _forcedCameraChangedSubject.OnNext(info);
        }

        private void UpdateCameraOverride(float deltaTime, bool forceReacquire = false)
        {
            var brain = CinemachineCore.Instance.GetActiveBrain(0);
            if (brain == null) return;
            foreach (var pair in _forcedCameraSources)
            {
                var state = pair.Value;
                if (state.isActive && !state.forceAuto)
                {
                    ApplyCameraOverride(brain, state.camA, state.camB, state.weightB, state.deltaTime, forceReacquire);
                    return;
                }
            }
            foreach (var pair in _forcedCameraSources)
            {
                var state = pair.Value;
                if (state.isActive && state.forceAuto)
                {
                    ClearCameraOverride(brain);
                    return;
                }
            }
            if (_userCamera != null) ApplyCameraOverride(brain, null, _userCamera, 1f, deltaTime, forceReacquire);
            else ClearCameraOverride(brain);
        }

        private void ApplyCameraOverride(CinemachineBrain brain, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime, bool forceReacquire = false)
        {
            bool started = false;
            if (master != null)
            {
                var state = master.state;
                started = _lastObservedPlayState != PlayState.Playing && state == PlayState.Playing;
                _lastObservedPlayState = state;
            }
            bool changed = !_hasAppliedOverride || _lastAppliedCamA != camA || _lastAppliedCamB != camB;
            if ((started || changed || forceReacquire) && _cameraOverrideId >= 0)
            {
                brain.ReleaseCameraOverride(_cameraOverrideId);
                _cameraOverrideId = -1;
            }
            _cameraOverrideId = brain.SetCameraOverride(_cameraOverrideId, camA, camB, weightB, deltaTime);
            _lastAppliedCamA = camA;
            _lastAppliedCamB = camB;
            _hasAppliedOverride = true;
        }

        private void ClearCameraOverride(CinemachineBrain brain)
        {
            if (_cameraOverrideId >= 0)
            {
                brain.ReleaseCameraOverride(_cameraOverrideId);
                _cameraOverrideId = -1;
            }
            _lastAppliedCamA = null;
            _lastAppliedCamB = null;
            _hasAppliedOverride = false;
        }

        private void DisposeForcedCameraChanged()
        {
            _forcedCameraChangedSubject.Dispose();
        }

        public int GetCurrentActorIndex(int slotIndex)
        {
            return _currentActorIndices.TryGetValue(slotIndex, out int index) ? index : slotIndex;
        }

        public IObservable<CurrentActorSignalData> OnCurrentActorSignalAsObservable()
        {
            return _currentActorSignalSubject;
        }

        void Campus.Timeline.ICurrentActorSignalNotifier.InitializeSlotDefault(int slotIndex, int defaultActorIndex)
        {
            _currentActorIndices[slotIndex] = defaultActorIndex;
            _currentActorSignalSubject.OnNext(new CurrentActorSignalData(slotIndex, defaultActorIndex, defaultActorIndex));
        }

        void Campus.Timeline.ICurrentActorSignalNotifier.NotifyCurrentActorSignal(int slotIndex, int nextActorIndex)
        {
            int before = GetCurrentActorIndex(slotIndex);
            _currentActorIndices[slotIndex] = nextActorIndex;
            _currentActorSignalSubject.OnNext(new CurrentActorSignalData(slotIndex, before, nextActorIndex));
        }

        private void DisposeCurrentActorSignal()
        {
            _currentActorSignalSubject.Dispose();
            _currentActorIndices.Clear();
        }

        void Campus.Timeline.ILookAtProhibitSource.BeginLookAtProhibitSource(int sourceId)
        {
            _lookAtProhibitAllSources.Remove(sourceId);
            if (_lookAtProhibitSources.TryGetValue(sourceId, out var sources)) sources.Clear();
            else _lookAtProhibitSources[sourceId] = new HashSet<int>(10);
            _lookAtEnableProhibitAllSources.Remove(sourceId);
            if (_lookAtEnableProhibitSources.TryGetValue(sourceId, out var enableSources)) enableSources.Clear();
            else _lookAtEnableProhibitSources[sourceId] = new HashSet<int>(10);
        }

        void Campus.Timeline.ILookAtProhibitSource.SetLookAtProhibitAll(int sourceId)
        {
            _lookAtProhibitAllSources.Add(sourceId);
        }

        void Campus.Timeline.ILookAtProhibitSource.SetLookAtEnableProhibitAll(int sourceId)
        {
            _lookAtEnableProhibitAllSources.Add(sourceId);
        }

        void Campus.Timeline.ILookAtProhibitSource.AddLookAtProhibitedActor(int sourceId, int actorIndex)
        {
            if (_lookAtProhibitSources.TryGetValue(sourceId, out var sources)) sources.Add(actorIndex);
        }

        void Campus.Timeline.ILookAtProhibitSource.AddLookAtEnableProhibitedActor(int sourceId, int actorIndex)
        {
            if (_lookAtEnableProhibitSources.TryGetValue(sourceId, out var sources)) sources.Add(actorIndex);
        }

        void Campus.Timeline.ILookAtProhibitSource.RemoveLookAtProhibitSource(int sourceId)
        {
            _lookAtProhibitAllSources.Remove(sourceId);
            _lookAtProhibitSources.Remove(sourceId);
            _lookAtEnableProhibitAllSources.Remove(sourceId);
            _lookAtEnableProhibitSources.Remove(sourceId);
            FlushProhibitState();
        }

        void Campus.Timeline.ILookAtProhibitSource.FlushLookAtProhibitSource(int sourceId)
        {
            FlushProhibitState();
        }

        public bool IsLookAtProhibited(int actorIndex)
        {
            if (_lookAtProhibitAllSources.Count > 0) return true;
            foreach (var pair in _lookAtProhibitSources)
                if (pair.Value.Contains(actorIndex)) return true;
            return false;
        }

        public bool IsLookAtEnableProhibited(int actorIndex)
        {
            if (_lookAtEnableProhibitAllSources.Count > 0) return true;
            foreach (var pair in _lookAtEnableProhibitSources)
                if (pair.Value.Contains(actorIndex)) return true;
            return false;
        }

        private void FlushProhibitState()
        {
            for (int i = 0; i < 10; i++)
            {
                bool prohibited = IsLookAtProhibited(i);
                if (prohibited != _prevProhibitState[i])
                {
                    _prevProhibitState[i] = prohibited;
                    _lookAtProhibitChanged.OnNext((i, prohibited));
                }
                bool enableProhibited = IsLookAtEnableProhibited(i);
                if (enableProhibited != _prevProhibitEnableState[i])
                {
                    _prevProhibitEnableState[i] = enableProhibited;
                    _lookAtEnableProhibitChanged.OnNext((i, enableProhibited));
                }
            }
        }

        private void DestroyLookAtProhibit()
        {
            _lookAtProhibitChanged.Dispose();
            _lookAtEnableProhibitChanged.Dispose();
        }

        public GameObject[] GetProps(int actorIndex)
        {
            var closure = new _003C_003Ec__DisplayClass113_0 { actorIndex = actorIndex };
            return _actorPropSettings.Where(new Func<LiveProp, bool>(closure._003CGetProps_003Eb__0))
                .SelectMany((_003C_003Ec._003C_003E9__113_1 ?? (_003C_003Ec._003C_003E9__113_1 = new Func<LiveProp, IEnumerable<LivePropSetting>>(_003C_003Ec._003C_003E9._003CGetProps_003Eb__113_1))))
                .Select((_003C_003Ec._003C_003E9__113_2 ?? (_003C_003Ec._003C_003E9__113_2 = new Func<LivePropSetting, GameObject>(_003C_003Ec._003C_003E9._003CGetProps_003Eb__113_2)))).ToArray();
        }

        public GameObject[] GetFieldConstraintTargets(int actorIndex)
        {
            var closure = new _003C_003Ec__DisplayClass114_0 { actorIndex = actorIndex };
            return _actorPropSettings.Where(new Func<LiveProp, bool>(closure._003CGetFieldConstraintTargets_003Eb__0))
                .SelectMany((_003C_003Ec._003C_003E9__114_1 ?? (_003C_003Ec._003C_003E9__114_1 = new Func<LiveProp, IEnumerable<LivePropSetting>>(_003C_003Ec._003C_003E9._003CGetFieldConstraintTargets_003Eb__114_1))))
                .Select((_003C_003Ec._003C_003E9__114_2 ?? (_003C_003Ec._003C_003E9__114_2 = new Func<LivePropSetting, GameObject>(_003C_003Ec._003C_003E9._003CGetFieldConstraintTargets_003Eb__114_2)))).ToArray();
        }

        public LivePropSetting[] GetPropAndFieldConstraintTargetPairs(int actorIndex)
        {
            var closure = new _003C_003Ec__DisplayClass115_0 { actorIndex = actorIndex };
            return _actorPropSettings.Where(new Func<LiveProp, bool>(closure._003CGetPropAndFieldConstraintTargetPairs_003Eb__0))
                .SelectMany((_003C_003Ec._003C_003E9__115_1 ?? (_003C_003Ec._003C_003E9__115_1 = new Func<LiveProp, IEnumerable<LivePropSetting>>(_003C_003Ec._003C_003E9._003CGetPropAndFieldConstraintTargetPairs_003Eb__115_1)))).ToArray();
        }

        public bool HasCharacterTrack()
        {
            return ControlledRootTracks.OfType<GroupTrack>().Any((_003C_003Ec._003C_003E9__116_0 ?? (_003C_003Ec._003C_003E9__116_0 = new Func<GroupTrack, bool>(_003C_003Ec._003C_003E9._003CHasCharacterTrack_003Eb__116_0))));
        }

        public void EnableCharacterTrack(string characteId)
        {
            bool changed = false;
            foreach (var track in ControlledRootTracks.OfType<GroupTrack>())
            {
                if (!track.name.StartsWith(CharacterTrackNamePrefix)) continue;
                bool mute = track.name != CharacterTrackNamePrefix + characteId;
                if (track.muted != mute) { ChangeTrackMute(track, mute); changed = true; }
            }
            if (changed) master?.RebuildGraph();
        }

        public void DisableAllCharacterTracks()
        {
            bool changed = false;
            foreach (var track in ControlledRootTracks.OfType<GroupTrack>())
            {
                if (track.name.StartsWith(CharacterTrackNamePrefix) && !track.muted)
                {
                    ChangeTrackMute(track, true);
                    changed = true;
                }
            }
            if (changed) master?.RebuildGraph();
        }

        public void ApplyMuteFromTrackNameList([CanBeNull] string[] muteTrackNames)
        {
            ApplyTrackMuteState(muteTrackNames, true);
        }

        public void ApplyMuteFromTrackDisableSettings([CanBeNull] MuteTrackDisableSetting[] muteTrackDisableSettings)
        {
            if (muteTrackDisableSettings == null || muteTrackDisableSettings.Length == 0) return;
            var settings = muteTrackDisableSettings.Where((_003C_003Ec._003C_003E9__120_0 ?? (_003C_003Ec._003C_003E9__120_0 = new Func<MuteTrackDisableSetting, bool>(_003C_003Ec._003C_003E9._003CApplyMuteFromTrackDisableSettings_003Eb__120_0)))).ToArray();
            ApplyMuteFromTrackNameList(FasterLinq.Select(settings, (_003C_003Ec._003C_003E9__120_1 ?? (_003C_003Ec._003C_003E9__120_1 = new Func<MuteTrackDisableSetting, string>(_003C_003Ec._003C_003E9._003CApplyMuteFromTrackDisableSettings_003Eb__120_1)))).ToArray());
            foreach (var setting in settings.Where((_003C_003Ec._003C_003E9__120_2 ?? (_003C_003Ec._003C_003E9__120_2 = new Func<MuteTrackDisableSetting, bool>(_003C_003Ec._003C_003E9._003CApplyMuteFromTrackDisableSettings_003Eb__120_2)))))
                foreach (var track in CollectTracksResolvedByPaths(new[] { setting.trackName }))
                    DisableTrackBinding(track, setting.componentDisableTarget);
        }

        public void ApplyActiveFromTrackNameList([CanBeNull] string[] activeTrackNames)
        {
            ApplyTrackMuteState(activeTrackNames, false);
        }

        private void ApplyTrackMuteState([CanBeNull] string[] trackNames, bool mute)
        {
            if (trackNames == null || trackNames.Length == 0) return;
            bool changed = false;
            foreach (var track in CollectTracksResolvedByPaths(trackNames))
            {
                if (track.muted != mute) { ChangeTrackMute(track, mute); changed = true; }
            }
            if (changed) master?.RebuildGraph();
        }

        private HashSet<TrackAsset> CollectTracksResolvedByPaths([NotNull] string[] pathStrings)
        {
            var closure = new _003C_003Ec__DisplayClass123_0 { _003C_003E4__this = this };
            if (master == null) return new HashSet<TrackAsset>();
            closure.masterTimeline = master.playableAsset as TimelineAsset;
            if (closure.masterTimeline is null) return new HashSet<TrackAsset>();
            return FasterLinq.Select(pathStrings, new Func<string, TrackAsset>(closure._003CCollectTracksResolvedByPaths_003Eb__0)).OfType<TrackAsset>().ToHashSet();
        }

        private TrackAsset ResolveTracksByPathSegments(TimelineAsset timeline, string[] segments)
        {
            var closure = new _003C_003Ec__DisplayClass124_0 { segments = segments };
            if (timeline == null || closure.segments == null || closure.segments.Length == 0) return null;
            IEnumerable<TrackAsset> tracks = timeline.GetRootTracks();
            var loop = new _003C_003Ec__DisplayClass124_1 { CS_0024_003C_003E8__locals1 = closure };
            for (loop.i = 0; loop.i < closure.segments.Length - 1; loop.i++)
            {
                var parent = tracks.FirstOrDefault(new Func<TrackAsset, bool>(loop._003CResolveTracksByPathSegments_003Eb__1));
                if (parent == null) return null;
                var children = parent.GetChildTracks().ToArray();
                tracks = children;
                if (children.Length == 0)
                {
                    var controlled = TryGetControlledTimeline(parent);
                    if (controlled == null) return null;
                    tracks = controlled.GetRootTracks();
                }
            }
            closure.lastSegment = closure.segments[closure.segments.Length - 1];
            return tracks.FirstOrDefault(new Func<TrackAsset, bool>(closure._003CResolveTracksByPathSegments_003Eb__0));
        }

        private TimelineAsset TryGetControlledTimeline(TrackAsset controlTrack)
        {
            if (master == null) return null;
            foreach (var clip in controlTrack.GetClips())
            {
                if (clip.asset is CampusDirectorControlAsset control)
                {
                    if (control.directorReference.Resolve(master)?.playableAsset is TimelineAsset timeline) return timeline;
                }
            }
            return null;
        }

        private void DisableTrackBinding(TrackAsset track, MuteTrackComponentDisableTarget componentDisableTarget)
        {
            var closure = new _003C_003Ec__DisplayClass126_0 { track = track };
            var director = closure.track == null ? null : Enumerable.FirstOrDefault(ControlDirectors, new Func<PlayableDirector, bool>(closure._003CDisableTrackBinding_003Eb__0));
            if (director == null) return;
            var binding = director.GetGenericBinding(closure.track);
            if (binding is GameObject go) go.SetActive(false);
            else if (binding is Component component) DisableComponentBinding(component, componentDisableTarget);
        }

        private static void DisableComponentBinding(Component component, MuteTrackComponentDisableTarget componentDisableTarget)
        {
            if (componentDisableTarget == MuteTrackComponentDisableTarget.GameObject)
            {
                component.gameObject.SetActive(false);
                return;
            }
            var property = component.GetType().GetProperty("enabled", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            if (property?.PropertyType == typeof(bool) && property.CanWrite) property.SetValue(component, false);
        }

        private void ChangeTrackMute(TrackAsset track, bool mute)
        {
            track.muted = mute;
        }

        public void ApplyOverrideMotionTracks([CanBeNull] PlayableDirector actorDirector, OverrideActorMotionTrack[] overrideActorMotionTracks)
        {
            if (actorDirector == null) return;
            var timeline = actorDirector.playableAsset as TimelineAsset;
            if (timeline == null) return;
            foreach (var trackOverride in overrideActorMotionTracks)
            {
                var closure = new _003C_003Ec__DisplayClass129_0 { trackOverride = trackOverride };
                var track = timeline.GetOutputTracks().FirstOrDefault(new Func<TrackAsset, bool>(closure._003CApplyOverrideMotionTracks_003Eb__0));
                if (track == null || closure.trackOverride.clips == null) continue;
                var clips = track.GetClips().OrderBy((_003C_003Ec._003C_003E9__129_1 ?? (_003C_003Ec._003C_003E9__129_1 = new Func<TimelineClip, double>(_003C_003Ec._003C_003E9._003CApplyOverrideMotionTracks_003Eb__129_1)))).ToArray();
                foreach (var clipOverride in closure.trackOverride.clips)
                {
                    var clipClosure = new _003C_003Ec__DisplayClass129_1 { clipOverride = clipOverride };
                    if (clipClosure.clipOverride.motionDefine == null) continue;
                    int index = Array.FindIndex(clips, new Predicate<TimelineClip>(clipClosure._003CApplyOverrideMotionTracks_003Eb__2));
                    if (index < 0) continue;
                    var asset = clips[index].asset as VL.Animation.Timeline.MotionDefinePlayerTimelineAsset;
                    if (asset == null) continue;
                    var referenceName = new PropertyName(string.Format("{0}_{1:D3}", closure.trackOverride.trackName, index));
                    if (asset.exposedMotion.exposedName != referenceName)
                        asset.exposedMotion = new ExposedReference<VL.MotionDefine> { exposedName = referenceName };
                    actorDirector.SetReferenceValue(referenceName, clipClosure.clipOverride.motionDefine);
                }
            }
        }

        private void Update()
        {
            // TODO(qa-recon): needs VLTimelineController.master outside the owned assemblies.
            ShaderTimeManager.SetCustomTime((float)master.time);
        }

        protected override void Destroy()
        {
            ShaderTimeManager.ResetCustomTime();
            DisposeCurrentActorSignal();
            DestroyLookAtProhibit();
            DisposeForcedCameraChanged();
        }

        public CampusLiveTimelineController()
        {
        }

        [CompilerGenerated]
        private PlayableDirector _003Cget_ControlDirectors_003Eb__109_3(CampusDirectorControlAsset x)
        {
            return x.directorReference.Resolve(master);
        }
    }
}
