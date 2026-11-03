namespace Campus.Common.Live
{
    using global::System;
    using global::System.Collections.Generic;
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
            public static readonly string Actor;
            public static readonly string Audio;
        }

        public static class TrackName
        {
            public static readonly string CinemachineBrain;
            public static readonly string Bgm;
            public static readonly string Voice;
            public static readonly string Actor;
            public static readonly string Camera;
            public static readonly string Audio;
            public static readonly string Light;
            public static readonly string ActorLayout;
            public static readonly string ActorPrefix;
            public static readonly string Subtitle;
        }

        public static class ReferencePropertyName
        {
            public static readonly string ActorLayout;
            public static readonly string ActorPrefix;
            public static string GetActor(int index)
            {
                return null;
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
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
                return null;
            }

            internal IEnumerable<TimelineClip> _003CSetupAsync_003Eb__39_1(TrackAsset x)
            {
                return null;
            }

            internal UnityEngine.Object _003CSetupAsync_003Eb__39_2(TimelineClip x)
            {
                return null;
            }

            internal bool _003CSetupAsync_003Eb__39_4(PlayableDirector x)
            {
                return default(bool);
            }

            internal bool _003CSetupAsync_003Eb__39_7(PlayableDirector x)
            {
                return default(bool);
            }

            internal bool _003CSetupAsync_003Eb__39_6(PlayableDirector x)
            {
                return default(bool);
            }

            internal bool _003CHasLiveOverrideActorMotion_003Eb__46_1(OverrideActorMotionClip clip)
            {
                return default(bool);
            }

            internal bool _003CReplaceBGM_003Eb__51_0(TrackAsset x)
            {
                return default(bool);
            }

            internal bool _003CDebugSetMuteTracks_003Eb__53_0(PlayableBinding x)
            {
                return default(bool);
            }

            internal UnityEngine.Object _003CDebugSetMuteTracks_003Eb__53_1(PlayableBinding x)
            {
                return null;
            }

            internal void _003CDebugSetMuteTracks_003Eb__53_2(TrackAsset x)
            {
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
                return null;
            }

            internal void _003CSetupAsync_003Eb__5(PlayableDirector x)
            {
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
                return default(bool);
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
                return default(bool);
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
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
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
            }
        }

        public CampusLiveTimelineController CampusTimeline
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

        private CampusLiveEnvironment Environment
        {
            [CompilerGenerated]
            set
            {
            }
        }

        public CampusActorLayout ActorLayout
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

        public List<ICampusActorController> Actors
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

        public List<CampusVirtualActorController> VirtualActors
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

        public CampusLiveBinder(BindParams param)
        {
        }

        [AsyncStateMachine(typeof(_003CSetupAsync_003Ed__39))]
        public UniTask SetupAsync([Optional] CancellationToken ct)
        {
            return default(UniTask);
        }

        private void SetLiveOverrideAsset([CanBeNull] PlayableDirector actorDirector)
        {
        }

        private void ApplyOverrideActorHierarchyTransforms(OverrideActorHierarchyTransform[] entries)
        {
        }

        private void DisableJointLimitIfNeeded()
        {
        }

        private bool IsAllLiveScene()
        {
            return default(bool);
        }

        private string GetTimelineSceneName()
        {
            return null;
        }

        [CanBeNull]
        private ActorMotionDefine GetExposedActorMotion(int index)
        {
            return null;
        }

        private bool HasLiveOverrideActorMotion(int index)
        {
            return default(bool);
        }

        private UnityEngine.Object BindAudio(PlayableBinding binding)
        {
            return null;
        }

        private UnityEngine.Object BindActor(PlayableBinding binding)
        {
            return null;
        }

        private UnityEngine.Object BindCamera(PlayableBinding binding)
        {
            return null;
        }

        private UnityEngine.Object BindSubtitle(PlayableBinding binding)
        {
            return null;
        }

        private void ReplaceBGM(PlayableDirector audioDirector, AudioClip clip)
        {
        }

        private void ReplaceClip(VideoPlayer videoPlayer, VideoClip clip)
        {
        }

        private void DebugSetMuteTracks()
        {
        }
    }
}
