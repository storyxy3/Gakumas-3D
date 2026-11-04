// TODO(qa-recon): Selected APK bodies still need reconstruction: BindReceiver, Dispose, GetTimelineData, Initialize, InitializeArray, InitializeReceiver, LateUpdate, OnDirectorStopped, OnDisable, OnEnable, Start, Update, get_AnimationData, get_InitialData, get_IsPlaying, get_IsValidPlayableGraph, get_StreamData, get_TimelineData, set_AnimationData, set_InitialData, set_StreamData, set_TimelineData.
namespace Campus.Live.Equipment
{
    using global::System;
    using global::System.Linq;
    using global::Unity.Jobs;
    using global::Campus.Live.Equipment.Timeline;
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
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<PlayableBinding, bool> _003C_003E9__43_0;
            public _003C_003Ec()
            {
            }

            internal bool _003CBindReceiver_003Eb__43_0(PlayableBinding x)
            {
                return x.outputTargetType == typeof(LiveEquipmentReceiver);
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
                return _003CStreamData_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CStreamData_003Ek__BackingField = value;
            }
        }

        public NativeArray<LiveEquipmentInitialData> InitialData
        {
            [CompilerGenerated]
            get
            {
                return _003CInitialData_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CInitialData_003Ek__BackingField = value;
            }
        }

        public NativeArray<LiveEquipmentAnimationData> AnimationData
        {
            [CompilerGenerated]
            get
            {
                return _003CAnimationData_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CAnimationData_003Ek__BackingField = value;
            }
        }

        public NativeArray<LiveEquipmentTimelineData> TimelineData
        {
            [CompilerGenerated]
            get
            {
                return _003CTimelineData_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CTimelineData_003Ek__BackingField = value;
            }
        }

        public bool IsPlaying
        {
            get
            {
                if (_director == null) return false;
                var graph = _director.playableGraph;
                return graph.IsValid() && graph.IsPlaying();
            }
        }

        public bool IsValidPlayableGraph
        {
            get
            {
                return _director != null && _director.playableGraph.IsValid();
            }
        }

        private void InitializeArray()
        {
            if (InitialData.IsCreated && InitialData.Length != 448)
            {
                InitialData.Dispose();
                InitialData = default;
            }
            if (TimelineData.IsCreated && TimelineData.Length != 1)
            {
                TimelineData.Dispose();
                TimelineData = default;
            }
            if (!StreamData.IsCreated) StreamData = new NativeArray<LiveEquipmentStreamData>(448, Allocator.Persistent);
            if (!InitialData.IsCreated) InitialData = new NativeArray<LiveEquipmentInitialData>(448, Allocator.Persistent);
            if (!TimelineData.IsCreated) TimelineData = new NativeArray<LiveEquipmentTimelineData>(1, Allocator.Persistent);
            if (!AnimationData.IsCreated) AnimationData = new NativeArray<LiveEquipmentAnimationData>(448, Allocator.Persistent);
        }

        public void Initialize()
        {
            if (_initialized) return;
            _initialized = true;
            InitializeArray();
            InitializeReceiver();
        }

        private void InitializeReceiver(bool force = false)
        {
            if (_receiver != null) _receiver.StoreInitialData(InitialData, force);
        }

        private void Start()
        {
            Initialize();
        }

        private void Dispose()
        {
            if (StreamData.IsCreated)
            {
                StreamData.Dispose();
                StreamData = default;
            }
            if (InitialData.IsCreated)
            {
                InitialData.Dispose();
                InitialData = default;
            }
            if (AnimationData.IsCreated)
            {
                AnimationData.Dispose();
                AnimationData = default;
            }
            if (TimelineData.IsCreated)
            {
                TimelineData.Dispose();
                TimelineData = default;
            }
        }

        private void OnDirectorStopped(PlayableDirector director)
        {
            if (_receiver != null) _receiver.ClearProperty();
        }

        private void OnDirectorPlayed(PlayableDirector director)
        {
        }

        private void OnEnable()
        {
            transform.localPosition = Vector3.zero;
            TryGetComponent(out _director);
            _director.played += OnDirectorPlayed;
            _director.stopped += OnDirectorStopped;
            _initialized = false;
        }

        private void OnDisable()
        {
            _director.played -= OnDirectorPlayed;
            _director.stopped -= OnDirectorStopped;
            Dispose();
        }

        private LiveEquipmentTimelineData GetTimelineData()
        {
            return new LiveEquipmentTimelineData { time = (float)_director.time };
        }

        private void Update()
        {
            if (TimelineData.IsCreated && TimelineData.Length == 1)
                TimelineData.ReinterpretStore(0, GetTimelineData());
        }

        private void LateUpdate()
        {
            if (!AnimationData.IsCreated || !InitialData.IsCreated || !StreamData.IsCreated || _receiver == null || !IsValidPlayableGraph) return;
            InitializeReceiver();
            var handles = new NativeArray<JobHandle>(_receiver.GetDependencyJobCount() + 1, Allocator.TempJob, NativeArrayOptions.UninitializedMemory);
            var job = new LiveEquipmentStreamJob { animationData = AnimationData, initialData = InitialData, streamData = StreamData };
            var handle = job.Schedule(448, 16);
            handles[handles.Length - 1] = handle;
            _receiver.AddDependencyJob(handle, StreamData, handles);
            JobHandle.CompleteAll(handles);
            handles.Dispose();
            _receiver.UpdateEquipment(StreamData);
        }

        public void BindReceiver(LiveEquipmentReceiver receiver)
        {
            _receiver = receiver;
            Initialize();
            InitializeReceiver(true);
            if (_director.playableAsset != null)
            {
                var binding = _director.playableAsset.outputs.FirstOrDefault(_003C_003Ec._003C_003E9__43_0 ?? (_003C_003Ec._003C_003E9__43_0 = _003C_003Ec._003C_003E9._003CBindReceiver_003Eb__43_0));
                if (binding.sourceObject != null) _director.SetGenericBinding(binding.sourceObject, receiver);
            }
        }

        public LiveEquipmentController()
        {
        }
    }
}
