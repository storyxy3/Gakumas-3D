namespace Campus.Common.Live
{
    using global::System;
    using global::System.Collections.Generic;
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
            public static readonly _003C_003Ec _003C_003E9;
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
                return null;
            }

            internal CampusDirectorControlAsset _003Cget_ControlDirectors_003Eb__109_1(TimelineClip x)
            {
                return null;
            }

            internal bool _003Cget_ControlDirectors_003Eb__109_2(CampusDirectorControlAsset x)
            {
                return default(bool);
            }

            internal PlayableAsset _003Cget_ControlledRootTracks_003Eb__112_0(PlayableDirector x)
            {
                return null;
            }

            internal IEnumerable<TrackAsset> _003Cget_ControlledRootTracks_003Eb__112_1(TimelineAsset x)
            {
                return null;
            }

            internal IEnumerable<LivePropSetting> _003CGetProps_003Eb__113_1(LiveProp x)
            {
                return null;
            }

            internal GameObject _003CGetProps_003Eb__113_2(LivePropSetting x)
            {
                return null;
            }

            internal IEnumerable<LivePropSetting> _003CGetFieldConstraintTargets_003Eb__114_1(LiveProp x)
            {
                return null;
            }

            internal GameObject _003CGetFieldConstraintTargets_003Eb__114_2(LivePropSetting x)
            {
                return null;
            }

            internal IEnumerable<LivePropSetting> _003CGetPropAndFieldConstraintTargetPairs_003Eb__115_1(LiveProp x)
            {
                return null;
            }

            internal bool _003CHasCharacterTrack_003Eb__116_0(GroupTrack x)
            {
                return default(bool);
            }

            internal bool _003CApplyMuteFromTrackDisableSettings_003Eb__120_0(MuteTrackDisableSetting x)
            {
                return default(bool);
            }

            internal string _003CApplyMuteFromTrackDisableSettings_003Eb__120_1(MuteTrackDisableSetting x)
            {
                return null;
            }

            internal bool _003CApplyMuteFromTrackDisableSettings_003Eb__120_2(MuteTrackDisableSetting x)
            {
                return default(bool);
            }

            internal double _003CApplyOverrideMotionTracks_003Eb__129_1(TimelineClip x)
            {
                return default(double);
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
                return default(bool);
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
                return default(bool);
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
                return default(bool);
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
                return null;
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
                return default(bool);
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
                return default(bool);
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
                return default(bool);
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
                return default(bool);
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
                return default(bool);
            }
        }

        private int _cameraOverrideId;
        private readonly Dictionary<int, ForcedCameraState> _forcedCameraSources;
        private ICinemachineCamera _userCamera;
        private readonly Subject<ForcedCameraChangedInfo> _forcedCameraChangedSubject;
        private ICinemachineCamera _lastAppliedCamA;
        private ICinemachineCamera _lastAppliedCamB;
        private bool _hasAppliedOverride;
        private PlayState _lastObservedPlayState;
        private PanoramaCameraHolder _cameraHolder;
        private readonly Dictionary<int, int> _currentActorIndices;
        private readonly Subject<CurrentActorSignalData> _currentActorSignalSubject;
        private readonly Dictionary<int, HashSet<int>> _lookAtProhibitSources;
        private readonly HashSet<int> _lookAtProhibitAllSources;
        private readonly Dictionary<int, HashSet<int>> _lookAtEnableProhibitSources;
        private readonly HashSet<int> _lookAtEnableProhibitAllSources;
        private readonly Subject<(int actorIndex, bool isProhibited)> _lookAtProhibitChanged;
        private readonly Subject<(int actorIndex, bool isEnableProhibited)> _lookAtEnableProhibitChanged;
        private readonly bool[] _prevProhibitState;
        private readonly bool[] _prevProhibitEnableState;
        private static readonly string CharacterTrackNamePrefix;
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
                return null;
            }
        }

        public bool HasCameraHolder
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsCameraForced
        {
            get
            {
                return default(bool);
            }
        }

        public SwitchPanoramaCamera CurrentForcedCamera
        {
            get
            {
                return null;
            }
        }

        public IObservable<ForcedCameraChangedInfo> OnForcedCameraChanged
        {
            get
            {
                return null;
            }
        }

        public IObservable<(int actorIndex, bool isProhibited)> OnLookAtProhibitChanged
        {
            get
            {
                return null;
            }
        }

        public IObservable<(int actorIndex, bool isEnableProhibited)> OnLookAtEnableProhibitChanged
        {
            get
            {
                return null;
            }
        }

        public CampusActorLayout actorLayout
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public List<CampusVirtualActorController> virtualActors
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public List<LiveProp> actorPropSettings
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool IsCmmnHeightCorrectionNeededForActorSwing
        {
            get
            {
                return default(bool);
            }
        }

        public LiveEquipmentController equipmentController
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public LiveEquipmentReceiver equipmentReceiver
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public Canvas overlayCanvas
        {
            get
            {
                return null;
            }
        }

        public Canvas BackgroundCanvas
        {
            get
            {
                return null;
            }
        }

        public RawImage overlayImage
        {
            get
            {
                return null;
            }
        }

        [CanBeNull]
        public VideoPlayer MonitorVideoPlayer
        {
            get
            {
                return null;
            }
        }

        public Image[] OverrideMonitorImages
        {
            get
            {
                return null;
            }
        }

        public List<CampusTimelineCriVideoPlayer> criVideoPlayers
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private PlayableDirector[] ControlDirectors
        {
            get
            {
                return null;
            }
        }

        private TrackAsset[] ControlledRootTracks
        {
            get
            {
                return null;
            }
        }

        void Campus.Timeline.IForcedCameraInternal.SetForcedCamera(int sourceId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime, bool forceAuto)
        {
        }

        void Campus.Timeline.IForcedCameraInternal.RemoveForcedCameraSource(int sourceId)
        {
        }

        public void SetUserCamera(SwitchPanoramaCamera camera)
        {
        }

        public void SetUserCamera(PanoramaCameraType type, int index)
        {
        }

        public SwitchPanoramaCamera ResolveCamera(PanoramaCameraType type, int index)
        {
            return null;
        }

        public IReadOnlyDictionary<(PanoramaCameraType, int), SwitchPanoramaCamera> GetAllPanoramaCameras()
        {
            return null;
        }

        public void RefreshCameraOverride(bool forceReacquire)
        {
        }

        void Campus.Timeline.IForcedCameraInternal.NotifyForcedCameraChanged(ForcedCameraChangedInfo info)
        {
        }

        private void UpdateCameraOverride(float deltaTime, bool forceReacquire = false)
        {
        }

        private void ApplyCameraOverride(CinemachineBrain brain, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime, bool forceReacquire = false)
        {
        }

        private void ClearCameraOverride(CinemachineBrain brain)
        {
        }

        private void DisposeForcedCameraChanged()
        {
        }

        public int GetCurrentActorIndex(int slotIndex)
        {
            return default(int);
        }

        public IObservable<CurrentActorSignalData> OnCurrentActorSignalAsObservable()
        {
            return null;
        }

        void Campus.Timeline.ICurrentActorSignalNotifier.InitializeSlotDefault(int slotIndex, int defaultActorIndex)
        {
        }

        void Campus.Timeline.ICurrentActorSignalNotifier.NotifyCurrentActorSignal(int slotIndex, int nextActorIndex)
        {
        }

        private void DisposeCurrentActorSignal()
        {
        }

        void Campus.Timeline.ILookAtProhibitSource.BeginLookAtProhibitSource(int sourceId)
        {
        }

        void Campus.Timeline.ILookAtProhibitSource.SetLookAtProhibitAll(int sourceId)
        {
        }

        void Campus.Timeline.ILookAtProhibitSource.SetLookAtEnableProhibitAll(int sourceId)
        {
        }

        void Campus.Timeline.ILookAtProhibitSource.AddLookAtProhibitedActor(int sourceId, int actorIndex)
        {
        }

        void Campus.Timeline.ILookAtProhibitSource.AddLookAtEnableProhibitedActor(int sourceId, int actorIndex)
        {
        }

        void Campus.Timeline.ILookAtProhibitSource.RemoveLookAtProhibitSource(int sourceId)
        {
        }

        void Campus.Timeline.ILookAtProhibitSource.FlushLookAtProhibitSource(int sourceId)
        {
        }

        public bool IsLookAtProhibited(int actorIndex)
        {
            return default(bool);
        }

        public bool IsLookAtEnableProhibited(int actorIndex)
        {
            return default(bool);
        }

        private void FlushProhibitState()
        {
        }

        private void DestroyLookAtProhibit()
        {
        }

        public GameObject[] GetProps(int actorIndex)
        {
            return null;
        }

        public GameObject[] GetFieldConstraintTargets(int actorIndex)
        {
            return null;
        }

        public LivePropSetting[] GetPropAndFieldConstraintTargetPairs(int actorIndex)
        {
            return null;
        }

        public bool HasCharacterTrack()
        {
            return default(bool);
        }

        public void EnableCharacterTrack(string characteId)
        {
        }

        public void DisableAllCharacterTracks()
        {
        }

        public void ApplyMuteFromTrackNameList([CanBeNull] string[] muteTrackNames)
        {
        }

        public void ApplyMuteFromTrackDisableSettings([CanBeNull] MuteTrackDisableSetting[] muteTrackDisableSettings)
        {
        }

        public void ApplyActiveFromTrackNameList([CanBeNull] string[] activeTrackNames)
        {
        }

        private void ApplyTrackMuteState([CanBeNull] string[] trackNames, bool mute)
        {
        }

        private HashSet<TrackAsset> CollectTracksResolvedByPaths([NotNull] string[] pathStrings)
        {
            return null;
        }

        private TrackAsset ResolveTracksByPathSegments(TimelineAsset timeline, string[] segments)
        {
            return null;
        }

        private TimelineAsset TryGetControlledTimeline(TrackAsset controlTrack)
        {
            return null;
        }

        private void DisableTrackBinding(TrackAsset track, MuteTrackComponentDisableTarget componentDisableTarget)
        {
        }

        private static void DisableComponentBinding(Component component, MuteTrackComponentDisableTarget componentDisableTarget)
        {
        }

        private void ChangeTrackMute(TrackAsset track, bool mute)
        {
        }

        public void ApplyOverrideMotionTracks([CanBeNull] PlayableDirector actorDirector, OverrideActorMotionTrack[] overrideActorMotionTracks)
        {
        }

        private void Update()
        {
        }

        protected override void Destroy()
        {
        }

        public CampusLiveTimelineController()
        {
        }

        [CompilerGenerated]
        private PlayableDirector _003Cget_ControlDirectors_003Eb__109_3(CampusDirectorControlAsset x)
        {
            return null;
        }
    }
}
