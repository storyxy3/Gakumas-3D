// TODO(qa-recon): Selected APK bodies still need reconstruction: BindReceiver, Dispose, GetTimelineData, Initialize, InitializeArray, InitializeReceiver, LateUpdate, OnDirectorStopped, OnDisable, OnEnable, Start, Update, get_AnimationData, get_InitialData, get_IsPlaying, get_IsValidPlayableGraph, get_StreamData, get_TimelineData, set_AnimationData, set_InitialData, set_StreamData, set_TimelineData.
namespace Campus.Live.Equipment
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Live.Equipment;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [ExecuteAlways]
    [RequireComponent(typeof(PlayableDirector))]
    public class LiveEquipmentController : MonoBehaviour
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<PlayableBinding, bool> _003C_003E9__43_0;
            public _003C_003Ec()
            {
            }

            internal bool _003CBindReceiver_003Eb__43_0(PlayableBinding x)
            {
                return default(bool);
            }
        }

        public const int StreamBufferSize = 448;
        [SerializeField]
        private int serializeFieldWg;
        public const int MaxTrack = 128;
        public const int MaxTrackEquipment = 16;
        [NonSerialized]
        private LiveEquipmentReceiver _receiver;
        [SerializeField]
        private PlayableDirector _director;
        [CompilerGenerated]
        private NativeArray<LiveEquipmentStreamData> _003CStreamData_003Ek__BackingField;
        [CompilerGenerated]
        private NativeArray<LiveEquipmentInitialData> _003CInitialData_003Ek__BackingField;
        [CompilerGenerated]
        private NativeArray<LiveEquipmentAnimationData> _003CAnimationData_003Ek__BackingField;
        [CompilerGenerated]
        private NativeArray<LiveEquipmentTimelineData> _003CTimelineData_003Ek__BackingField;
        private bool _initialized;
        public int s
        {
            get
            {
                return serializeFieldWg;
            }
        }

        public LiveEquipmentReceiver Receiver
        {
            get
            {
                return _receiver;
            }
        }

        public NativeArray<LiveEquipmentStreamData> StreamData
        {
            [CompilerGenerated]
            get
            {
                return default(NativeArray<LiveEquipmentStreamData>);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public NativeArray<LiveEquipmentInitialData> InitialData
        {
            [CompilerGenerated]
            get
            {
                return default(NativeArray<LiveEquipmentInitialData>);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public NativeArray<LiveEquipmentAnimationData> AnimationData
        {
            [CompilerGenerated]
            get
            {
                return default(NativeArray<LiveEquipmentAnimationData>);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public NativeArray<LiveEquipmentTimelineData> TimelineData
        {
            [CompilerGenerated]
            get
            {
                return default(NativeArray<LiveEquipmentTimelineData>);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsPlaying
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsValidPlayableGraph
        {
            get
            {
                return default(bool);
            }
        }

        private void InitializeArray()
        {
        }

        public void Initialize()
        {
        }

        private void InitializeReceiver(bool force = false)
        {
        }

        private void Start()
        {
        }

        private void Dispose()
        {
        }

        private void OnDirectorStopped(PlayableDirector director)
        {
        }

        private void OnDirectorPlayed(PlayableDirector director)
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private LiveEquipmentTimelineData GetTimelineData()
        {
            return default(LiveEquipmentTimelineData);
        }

        private void Update()
        {
        }

        private void LateUpdate()
        {
        }

        public void BindReceiver(LiveEquipmentReceiver receiver)
        {
        }

        public LiveEquipmentController()
        {
        }
    }
}
