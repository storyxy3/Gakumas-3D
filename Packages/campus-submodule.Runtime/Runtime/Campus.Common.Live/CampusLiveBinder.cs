namespace Campus.Common.Live
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::Cinemachine;
    using global::VL.Animation;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Common.Live;
    using global::Campus.Timeline;
    using global::Common.Live;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::JetBrains.Annotations;
    using global::TMPro;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.Video;
    using global::VL;
    using global::VL.Timeline;

    [Serializable]
    public class CampusLiveBinder
    {
        [Serializable]
        public class BindParams
        {
            public VLTimelineController timeline;
            public CampusLiveTimelineController campusTimeline;
            public CampusLiveEnvironment environment;
            public CampusActorLayout actorLayout;
            public bool disableActorLayout;
            public List<ICampusActorController> actors;
            public List<CampusVirtualActorController> virtualActors;
            public DirectorUpdateMode overrideDirectorUpdateMode;
            public bool debugMuteTrack;
            public AudioSource bgmAudioSource;
            public AudioSource voiceAudioSource;
            public LayoutMotionDefine exposedLayoutMotion;
            public ActorMotionDefine[] exposedActorMotions;
            public AudioClip bgmAudioClip;
            public float initialTime;
            public TMP_Text subtitleText;
            public VideoClip monitorVideoClip;
            [CanBeNull]
            public CampusLiveOverrideAsset liveOverrideAsset;
            public BindParams()
            {
            }
        }

        public static class DirectorName
        {
            public static readonly string Actor = "Actor";
            public static readonly string Audio = "Audio";
        }

        public static class TrackName
        {
            public static readonly string CinemachineBrain = "Cinemachine";
            public static readonly string Bgm = "BGM";
            public static readonly string Voice = "Voice";
            public static readonly string Actor = "Actor";
            public static readonly string Camera = "Camera";
            public static readonly string Audio = "Audio";
            public static readonly string Light = "Light";
            public static readonly string ActorLayout = "ActorLayout";
            public static readonly string ActorPrefix = "Actor_";
            public static readonly string Subtitle = "Subtitle";
        }

        public static class ReferencePropertyName
        {
            public static readonly string ActorLayout = "ActorLayout";
            public static readonly string ActorPrefix = "Actor_";
            public static string GetActor(int index)
            {
                return string.Format(string.Format("{0}{1:00}", ActorPrefix, index), Array.Empty<object>());
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<PlayableBinding, UnityEngine.Object> _003C_003E9__39_0;
            public static Func<TrackAsset, IEnumerable<TimelineClip>> _003C_003E9__39_1;
            public static Func<TimelineClip, UnityEngine.Object> _003C_003E9__39_2;
            public static Func<PlayableDirector, bool> _003C_003E9__39_4;
            public static Func<PlayableDirector, bool> _003C_003E9__39_7;
            public static Func<PlayableDirector, bool> _003C_003E9__39_6;
            public static Func<OverrideActorMotionClip, bool> _003C_003E9__46_1;
            public static Func<TrackAsset, bool> _003C_003E9__51_0;
            public static Func<PlayableBinding, bool> _003C_003E9__53_0;
            public static Func<PlayableBinding, UnityEngine.Object> _003C_003E9__53_1;
            public static Action<TrackAsset> _003C_003E9__53_2;
            public _003C_003Ec()
            {
            }

            internal UnityEngine.Object _003CSetupAsync_003Eb__39_0(PlayableBinding x)
            {
                return x.sourceObject;
            }

            internal IEnumerable<TimelineClip> _003CSetupAsync_003Eb__39_1(TrackAsset x)
            {
                return x.GetClips();
            }

            internal UnityEngine.Object _003CSetupAsync_003Eb__39_2(TimelineClip x)
            {
                return x.asset;
            }

            internal bool _003CSetupAsync_003Eb__39_4(PlayableDirector x)
            {
                return x != null;
            }

            internal bool _003CSetupAsync_003Eb__39_7(PlayableDirector x)
            {
                return x.name == DirectorName.Audio;
            }

            internal bool _003CSetupAsync_003Eb__39_6(PlayableDirector x)
            {
                return x.name == DirectorName.Actor;
            }

            internal bool _003CHasLiveOverrideActorMotion_003Eb__46_1(OverrideActorMotionClip clip)
            {
                return clip != null && clip.motionDefine != null;
            }

            internal bool _003CReplaceBGM_003Eb__51_0(TrackAsset x)
            {
                return x.name == TrackName.Bgm;
            }

            internal bool _003CDebugSetMuteTracks_003Eb__53_0(PlayableBinding x)
            {
                return x.streamName.StartsWith("Equip");
            }

            internal UnityEngine.Object _003CDebugSetMuteTracks_003Eb__53_1(PlayableBinding x)
            {
                return x.sourceObject;
            }

            internal void _003CDebugSetMuteTracks_003Eb__53_2(TrackAsset x)
            {
                x.muted = true;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass39_0
        {
            public PlayableDirector master;
            public CampusLiveBinder _003C_003E4__this;
            public _003C_003Ec__DisplayClass39_0()
            {
            }

            internal PlayableDirector _003CSetupAsync_003Eb__3(CampusDirectorControlAsset x)
            {
                return master.GetReferenceValue(x.directorReference.exposedName, out _) as PlayableDirector;
            }

            internal void _003CSetupAsync_003Eb__5(PlayableDirector x)
            {
                x.timeUpdateMode = _003C_003E4__this._param.overrideDirectorUpdateMode;
                x.extrapolationMode = DirectorWrapMode.Hold;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass39_1
        {
            public VideoPlayer videoPlayer;
            public _003C_003Ec__DisplayClass39_1()
            {
            }

            internal bool _003CSetupAsync_003Eb__8()
            {
                return videoPlayer.isPrepared;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass46_0
        {
            public string actorTrackName;
            public _003C_003Ec__DisplayClass46_0()
            {
            }

            internal bool _003CHasLiveOverrideActorMotion_003Eb__0(OverrideActorMotionTrack track)
            {
                return track != null && track.trackName == actorTrackName && track.clips != null &&
                    track.clips.Any(_003C_003Ec._003C_003E9__46_1 ?? (_003C_003Ec._003C_003E9__46_1 = _003C_003Ec._003C_003E9._003CHasLiveOverrideActorMotion_003Eb__46_1));
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetupAsync_003Ed__39 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusLiveBinder _003C_003E4__this;
            public CancellationToken ct;
            private List<CampusTimelineCriVideoPlayer>.Enumerator _003C_003E7__wrap1;
            private CampusTimelineCriVideoPlayer _003CcampusTimelineCriVideoPlayer_003E5__3;
            private UniTask.Awaiter _003C_003Eu__1;
            public void MoveNext()
            {
                var binder = _003C_003E4__this;
                try
                {
                    if (_003C_003E1__state == 0) goto MovieDownloaded;
                    if (_003C_003E1__state == 1) goto MovieReady;
                    if (_003C_003E1__state == 2) goto VideoReady;
                    {
                        var closure = new _003C_003Ec__DisplayClass39_0 { _003C_003E4__this = binder };
                        if (binder._cinemachineTracks == null) binder._cinemachineTracks = new List<CinemachineTrack>();
                        binder._cinemachineTracks?.Clear();
                        var param = binder._param;
                        if (param == null)
                        {
                            UnityEngine.Debug.LogError("パラメータが初期化されていません");
                            goto Complete;
                        }
                        if (param.timeline == null)
                        {
                            UnityEngine.Debug.LogError("TimelineControllerは必須です");
                            goto Complete;
                        }
                        if (param.debugMuteTrack) binder.DebugSetMuteTracks();
                        closure.master = param.timeline.master;
                        var master = closure.master;
                        master.timeUpdateMode = param.overrideDirectorUpdateMode;
                        master.extrapolationMode = DirectorWrapMode.Hold;
                        if (master.initialTime == 0 && param.initialTime != 0) master.initialTime = param.initialTime;
                        var directors = master.playableAsset.outputs
                            .Select(_003C_003Ec._003C_003E9__39_0 ?? (_003C_003Ec._003C_003E9__39_0 = _003C_003Ec._003C_003E9._003CSetupAsync_003Eb__39_0))
                            .OfType<TrackAsset>()
                            .SelectMany(_003C_003Ec._003C_003E9__39_1 ?? (_003C_003Ec._003C_003E9__39_1 = _003C_003Ec._003C_003E9._003CSetupAsync_003Eb__39_1))
                            .Select(_003C_003Ec._003C_003E9__39_2 ?? (_003C_003Ec._003C_003E9__39_2 = _003C_003Ec._003C_003E9._003CSetupAsync_003Eb__39_2))
                            .OfType<CampusDirectorControlAsset>()
                            .Select(closure._003CSetupAsync_003Eb__3)
                            .Where(_003C_003Ec._003C_003E9__39_4 ?? (_003C_003Ec._003C_003E9__39_4 = _003C_003Ec._003C_003E9._003CSetupAsync_003Eb__39_4))
                            .ToArray();
                        Campus.Common.Extensions.EnumerableExtensions.ForEach(directors, closure._003CSetupAsync_003Eb__5);
                        binder.Timeline = param.timeline;
                        binder.CampusTimeline = param.campusTimeline;
                        binder.Environment = param.environment;
                        binder.Actors = param.actors;
                        if (param.actors != null)
                        {
                            binder.VirtualActors = null;
                            if (param.campusTimeline != null) binder.VirtualActors = param.campusTimeline.virtualActors;
                            if (param.virtualActors != null) binder.VirtualActors = param.virtualActors;
                            for (int i = 0; i < param.actors.Count; i++)
                            {
                                if (binder.VirtualActors != null && i < binder.VirtualActors.Count && binder.VirtualActors[i] != null)
                                    binder.VirtualActors[i].SetActorController(param.actors[i]);
                            }
                        }
                        binder.ActorLayout = null;
                        if (param.campusTimeline != null) binder.ActorLayout = param.campusTimeline.actorLayout;
                        if (param.actorLayout != null) binder.ActorLayout = param.actorLayout;
                        if (!param.disableActorLayout && binder.ActorLayout != null && param.actors != null)
                            binder.ActorLayout.ApplyToActors(param.actors);
                        if (param.campusTimeline != null && param.campusTimeline.equipmentController != null && param.campusTimeline.equipmentReceiver != null)
                            param.campusTimeline.equipmentController.BindReceiver(param.campusTimeline.equipmentReceiver);
                        if (VLCameraController.HasInstance && param.campusTimeline != null && param.campusTimeline.overlayCanvas != null)
                        {
                            param.campusTimeline.overlayCanvas.renderMode = RenderMode.ScreenSpaceCamera;
                            param.campusTimeline.overlayCanvas.worldCamera = VLCameraController.Instance.mainCamera;
                        }
                        if (VLCameraController.HasInstance && param.campusTimeline != null && param.campusTimeline.BackgroundCanvas != null)
                        {
                            param.campusTimeline.BackgroundCanvas.renderMode = RenderMode.ScreenSpaceCamera;
                            param.campusTimeline.BackgroundCanvas.worldCamera = VLCameraController.Instance.mainCamera;
                        }
                        foreach (var actor in binder.Actors)
                        {
                            var campusActor = actor as CampusActorController;
                            if (campusActor == null) continue;
                            foreach (var pair in binder.CampusTimeline.GetPropAndFieldConstraintTargetPairs(actor.index))
                            {
                                if (pair.propPrefab != null) campusActor.SetPropFieldConstraintTarget(pair.propPrefab.name, pair.fieldConstraintTarget);
                            }
                        }
                        var references = new List<VLTimelineController.ReferenceBindParam>();
                        if (param.bgmAudioClip != null)
                        {
                            var audioDirector = Enumerable.FirstOrDefault(directors, _003C_003Ec._003C_003E9__39_7 ??
                                (_003C_003Ec._003C_003E9__39_7 = _003C_003Ec._003C_003E9._003CSetupAsync_003Eb__39_7));
                            if (audioDirector != null) binder.ReplaceBGM(audioDirector, param.bgmAudioClip);
                        }
                        if (param.exposedLayoutMotion != null)
                            references.Add(new VLTimelineController.ReferenceBindParam(ReferencePropertyName.ActorLayout, param.exposedLayoutMotion));
                        if (!Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(param.exposedActorMotions))
                        {
                            for (int i = 0; i < param.exposedActorMotions.Length; i++)
                                references.Add(new VLTimelineController.ReferenceBindParam(ReferencePropertyName.GetActor(i), param.exposedActorMotions[i]));
                        }
                        binder.DisableJointLimitIfNeeded();
                        param.timeline.BindReference(new Dictionary<string, VLTimelineController.ReferenceBindParam[]>
                        {
                            { DirectorName.Actor, references.ToArray() }
                        });
                        if (param.campusTimeline != null && param.campusTimeline.MonitorVideoPlayer != null && param.monitorVideoClip != null)
                            param.campusTimeline.MonitorVideoPlayer.clip = param.monitorVideoClip;
                        var actorDirector = Enumerable.FirstOrDefault(directors, _003C_003Ec._003C_003E9__39_6 ??
                            (_003C_003Ec._003C_003E9__39_6 = _003C_003Ec._003C_003E9._003CSetupAsync_003Eb__39_6));
                        binder.SetLiveOverrideAsset(actorDirector);
                        param.timeline.Bind(new Dictionary<string, VLTimelineController.BindAction>
                        {
                            { TrackName.Actor, binder.BindActor },
                            { TrackName.Camera, binder.BindCamera },
                            { TrackName.Audio, binder.BindAudio },
                            { TrackName.Subtitle, binder.BindSubtitle }
                        });
                        var criPlayers = binder.CampusTimeline.criVideoPlayers;
                        if (criPlayers == null || criPlayers.Count < 1) goto PrepareVideo;
                        _003C_003E7__wrap1 = criPlayers.GetEnumerator();
                    }
                NextMovie:
                    if (!_003C_003E7__wrap1.MoveNext())
                    {
                        _003C_003E7__wrap1.Dispose();
                        _003C_003E7__wrap1 = default;
                        goto PrepareVideo;
                    }
                    _003CcampusTimelineCriVideoPlayer_003E5__3 = _003C_003E7__wrap1.Current;
                    if (_003CcampusTimelineCriVideoPlayer_003E5__3 == null) goto NextMovie;
                    _003C_003Eu__1 = _003CcampusTimelineCriVideoPlayer_003E5__3.DownloadMovieAsync(ct).GetAwaiter();
                    if (!_003C_003Eu__1.IsCompleted)
                    {
                        _003C_003E1__state = 0;
                        _003C_003Et__builder.AwaitUnsafeOnCompleted(ref _003C_003Eu__1, ref this);
                        return;
                    }
                MovieDownloaded:
                    _003C_003E1__state = -1;
                    _003C_003Eu__1.GetResult();
                    _003C_003Eu__1 = default;
                    _003C_003Eu__1 = _003CcampusTimelineCriVideoPlayer_003E5__3.SetMovieInfo(ct).GetAwaiter();
                    if (!_003C_003Eu__1.IsCompleted)
                    {
                        _003C_003E1__state = 1;
                        _003C_003Et__builder.AwaitUnsafeOnCompleted(ref _003C_003Eu__1, ref this);
                        return;
                    }
                MovieReady:
                    _003C_003E1__state = -1;
                    _003C_003Eu__1.GetResult();
                    _003C_003Eu__1 = default;
                    _003CcampusTimelineCriVideoPlayer_003E5__3 = null;
                    goto NextMovie;
                PrepareVideo:
                    if (binder.CampusTimeline.MonitorVideoPlayer == null) goto Complete;
                    {
                        var video = new _003C_003Ec__DisplayClass39_1 { videoPlayer = binder.CampusTimeline.MonitorVideoPlayer };
                        if (video.videoPlayer.clip == null) goto Complete;
                        video.videoPlayer.Prepare();
                        _003C_003Eu__1 = UniTask.WaitUntil(video._003CSetupAsync_003Eb__8, PlayerLoopTiming.Update, ct).GetAwaiter();
                        if (!_003C_003Eu__1.IsCompleted)
                        {
                            _003C_003E1__state = 2;
                            _003C_003Et__builder.AwaitUnsafeOnCompleted(ref _003C_003Eu__1, ref this);
                            return;
                        }
                    }
                VideoReady:
                    _003C_003E1__state = -1;
                    _003C_003Eu__1.GetResult();
                    _003C_003Eu__1 = default;
                Complete:
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetResult();
                }
                catch (Exception exception)
                {
                    _003C_003E7__wrap1.Dispose();
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetException(exception);
                }
            }

            [DebuggerHidden]
            public void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                _003C_003Et__builder.SetStateMachine(stateMachine);
            }
        }

        private const string AllLiveSceneNamePrefix = "tln_live_all";
        private List<CinemachineTrack> _cinemachineTracks;
        [CompilerGenerated]
        private double _003CMusicStartSeconds_003Ek__BackingField;
        [CompilerGenerated]
        private VLTimelineController _003CTimeline_003Ek__BackingField;
        [CompilerGenerated]
        private CampusLiveTimelineController _003CCampusTimeline_003Ek__BackingField;
        [CompilerGenerated]
        private CampusLiveEnvironment _003CEnvironment_003Ek__BackingField;
        [CompilerGenerated]
        private CampusActorLayout _003CActorLayout_003Ek__BackingField;
        [CompilerGenerated]
        private List<ICampusActorController> _003CActors_003Ek__BackingField;
        [CompilerGenerated]
        private List<CampusVirtualActorController> _003CVirtualActors_003Ek__BackingField;
        [SerializeField]
        private BindParams _param;
        private VLTimelineController Timeline
        {
            [CompilerGenerated]
            set
            {
                _003CTimeline_003Ek__BackingField = value;
            }
        }

        public CampusLiveTimelineController CampusTimeline
        {
            [CompilerGenerated]
            get
            {
                return _003CCampusTimeline_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CCampusTimeline_003Ek__BackingField = value;
            }
        }

        private CampusLiveEnvironment Environment
        {
            [CompilerGenerated]
            set
            {
                _003CEnvironment_003Ek__BackingField = value;
            }
        }

        public CampusActorLayout ActorLayout
        {
            [CompilerGenerated]
            get
            {
                return _003CActorLayout_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CActorLayout_003Ek__BackingField = value;
            }
        }

        public List<ICampusActorController> Actors
        {
            [CompilerGenerated]
            get
            {
                return _003CActors_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CActors_003Ek__BackingField = value;
            }
        }

        public List<CampusVirtualActorController> VirtualActors
        {
            [CompilerGenerated]
            get
            {
                return _003CVirtualActors_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CVirtualActors_003Ek__BackingField = value;
            }
        }

        public CampusLiveBinder(BindParams param)
        {
            _param = param;
        }

        [AsyncStateMachine(typeof(_003CSetupAsync_003Ed__39))]
        public UniTask SetupAsync([Optional] CancellationToken ct)
        {
            var stateMachine = new _003CSetupAsync_003Ed__39
            {
                _003C_003E1__state = -1,
                _003C_003Et__builder = AsyncUniTaskMethodBuilder.Create(),
                _003C_003E4__this = this,
                ct = ct
            };
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
            return stateMachine._003C_003Et__builder.Task;
        }

        private void SetLiveOverrideAsset([CanBeNull] PlayableDirector actorDirector)
        {
            var asset = _param.liveOverrideAsset;
            if (asset == null) return;
            if (asset.videoClip != null && CampusTimeline.MonitorVideoPlayer != null)
                CampusTimeline.MonitorVideoPlayer.clip = asset.videoClip;
            if (asset.overrideMonitorSprites != null && CampusTimeline.OverrideMonitorImages != null)
            {
                foreach (var image in CampusTimeline.OverrideMonitorImages)
                {
                    foreach (var entry in asset.overrideMonitorSprites)
                    {
                        if (!image.gameObject.name.Equals(entry.Key)) continue;
                        if (entry.Value != null) image.sprite = entry.Value;
                        break;
                    }
                }
            }
            if (asset.muteTrackDisableSettings != null && asset.muteTrackDisableSettings.Length > 0)
                CampusTimeline.ApplyMuteFromTrackDisableSettings(asset.muteTrackDisableSettings);
            else if (asset.muteTrackNames != null)
                CampusTimeline.ApplyMuteFromTrackNameList(asset.muteTrackNames);
            if (asset.activeTrackNames != null) CampusTimeline.ApplyActiveFromTrackNameList(asset.activeTrackNames);
            if (asset.overrideActorMotionTracks != null) CampusTimeline.ApplyOverrideMotionTracks(actorDirector, asset.overrideActorMotionTracks);
            if (asset.overrideActorHierarchyTransforms != null) ApplyOverrideActorHierarchyTransforms(asset.overrideActorHierarchyTransforms);
        }

        private void ApplyOverrideActorHierarchyTransforms(OverrideActorHierarchyTransform[] entries)
        {
            foreach (var entry in entries)
            {
                if (entry == null || entry.hierarchyTransforms == null || entry.actorIndex < 0 || entry.actorIndex >= Actors.Count) continue;
                var actor = Actors[entry.actorIndex] as CampusActorController;
                if (actor == null) continue;
                foreach (var setting in entry.hierarchyTransforms)
                {
                    if (setting == null || string.IsNullOrEmpty(setting.hierarchyName)) continue;
                    if (!actor.TryGetBoneTransformByName(setting.hierarchyName, out var bone)) continue;
                    if (setting.applyPosition) bone.localPosition = setting.localPosition;
                    if (setting.applyRotation) bone.localRotation = Quaternion.Euler(setting.localEulerAngles);
                    if (setting.applyScale) bone.localScale = setting.localScale;
                }
            }
        }

        private void DisableJointLimitIfNeeded()
        {
            if (_param.actors == null) return;
            bool allLive = IsAllLiveScene();
            for (int i = 0; i < _param.actors.Count; i++)
            {
                var actor = _param.actors[i];
                if (actor == null) continue;
                bool hasMotion = GetExposedActorMotion(i) != null || HasLiveOverrideActorMotion(i);
                if (!allLive || hasMotion) actor.DisableJointLimitSetting();
            }
        }

        private bool IsAllLiveScene()
        {
            string name = GetTimelineSceneName();
            return !string.IsNullOrEmpty(name) && name.StartsWith(AllLiveSceneNamePrefix, StringComparison.Ordinal);
        }

        private string GetTimelineSceneName()
        {
            if (_param.campusTimeline != null) return _param.campusTimeline.gameObject.scene.name;
            if (_param.timeline != null) return _param.timeline.gameObject.scene.name;
            return string.Empty;
        }

        [CanBeNull]
        private ActorMotionDefine GetExposedActorMotion(int index)
        {
            if (Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(_param.exposedActorMotions)) return null;
            return index < _param.exposedActorMotions.Length ? _param.exposedActorMotions[index] : null;
        }

        private bool HasLiveOverrideActorMotion(int index)
        {
            var closure = new _003C_003Ec__DisplayClass46_0();
            var tracks = _param.liveOverrideAsset?.overrideActorMotionTracks;
            if (tracks == null) return false;
            closure.actorTrackName = ReferencePropertyName.GetActor(index);
            return tracks.Any(closure._003CHasLiveOverrideActorMotion_003Eb__0);
        }

        private UnityEngine.Object BindAudio(PlayableBinding binding)
        {
            if (binding.streamName == TrackName.Bgm && _param.bgmAudioSource != null) return _param.bgmAudioSource;
            if (binding.streamName == TrackName.Voice && _param.voiceAudioSource != null) return _param.voiceAudioSource;
            return null;
        }

        private UnityEngine.Object BindActor(PlayableBinding binding)
        {
            string name = binding.streamName;
            if (_param.actorLayout != null && name == CampusActorLayout.RootName)
            {
                UnityEngine.Debug.Log(string.Format("Bind {0} -> {1}", binding.streamName, _param.actorLayout.player));
                return _param.actorLayout.player as MotionDefinePlayer;
            }
            if (_param.actors == null || name == null || !name.StartsWith(TrackName.ActorPrefix, StringComparison.Ordinal)) return null;
            if (!int.TryParse(name.Substring(TrackName.ActorPrefix.Length), out int index) || index >= _param.actors.Count) return null;
            var actor = _param.actors[index] as CampusActorController;
            if (actor == null) return null;
            UnityEngine.Debug.Log("Bind " + binding.streamName + " -> " + actor.name);
            return actor.GetAnimationPlayerObject();
        }

        private UnityEngine.Object BindCamera(PlayableBinding binding)
        {
            if (binding.outputTargetType != typeof(CinemachineBrain)) return null;
            if (binding.sourceObject is CinemachineTrack track) _cinemachineTracks.Add(track);
            return CinemachineCore.Instance.GetActiveBrain(0);
        }

        private UnityEngine.Object BindSubtitle(PlayableBinding binding)
        {
            return _param.subtitleText != null ? _param.subtitleText : null;
        }

        private void ReplaceBGM(PlayableDirector audioDirector, AudioClip clip)
        {
            var timeline = (TimelineAsset)audioDirector.playableAsset;
            var track = timeline.GetOutputTracks().FirstOrDefault(_003C_003Ec._003C_003E9__51_0 ??
                (_003C_003Ec._003C_003E9__51_0 = _003C_003Ec._003C_003E9._003CReplaceBGM_003Eb__51_0));
            var timelineClip = track.GetClips().FirstOrDefault();
            timelineClip.duration = clip.length;
            ((AudioPlayableAsset)timelineClip.asset).clip = clip;
        }

        private void ReplaceClip(VideoPlayer videoPlayer, VideoClip clip)
        {
            videoPlayer.clip = clip;
        }

        private void DebugSetMuteTracks()
        {
            var tracks = _param.timeline.master.playableAsset.outputs
                .Where(_003C_003Ec._003C_003E9__53_0 ?? (_003C_003Ec._003C_003E9__53_0 = _003C_003Ec._003C_003E9._003CDebugSetMuteTracks_003Eb__53_0))
                .Select(_003C_003Ec._003C_003E9__53_1 ?? (_003C_003Ec._003C_003E9__53_1 = _003C_003Ec._003C_003E9._003CDebugSetMuteTracks_003Eb__53_1))
                .OfType<TrackAsset>();
            Campus.Common.Extensions.EnumerableExtensions.ForEach(tracks,
                _003C_003Ec._003C_003E9__53_2 ?? (_003C_003Ec._003C_003E9__53_2 = _003C_003Ec._003C_003E9._003CDebugSetMuteTracks_003Eb__53_2));
        }
    }
}
