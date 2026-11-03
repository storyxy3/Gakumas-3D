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
                return default(int);
            }
        }

        public LiveEquipmentReceiver Receiver
        {
            get
            {
                return null;
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
