namespace Campus.Live.Equipment.Timeline
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Timeline;
    using global::Campus.Timeline;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class LiveEquipmentAssetBehaviour : PlayableBehaviour, IPlayableBehaviour
    {
        [CompilerGenerated]
        private bool _003CIsMainTrack_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CUseBpm_003Ek__BackingField;
        [CompilerGenerated]
        private LiveEquipmentAnimationCurve _003CCurves_003Ek__BackingField;
        [CompilerGenerated]
        private NativeArray<LiveEquipmentAnimationData> _003CAnimationData_003Ek__BackingField;
        [CompilerGenerated]
        private NativeArray<LiveEquipmentInitialData> _003CInitialData_003Ek__BackingField;
        [CompilerGenerated]
        private EquipmentValueFlags _003CTrackReverseFlag_003Ek__BackingField;
        [CompilerGenerated]
        private EquipmentValueFlags _003CClipIgnoreReverseFlag_003Ek__BackingField;
        [CompilerGenerated]
        private FireType _003CFireType_003Ek__BackingField;
        [CompilerGenerated]
        private Vector4 _003CFireParameter_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CBeat_003Ek__BackingField;
        [CompilerGenerated]
        private CampusBpmInfo _003CBpmInfo_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CBeatOffset_003Ek__BackingField;
        [CompilerGenerated]
        private Transform _003CLookAtTarget_003Ek__BackingField;
        [CompilerGenerated]
        private MovingMode _003CMovingMode_003Ek__BackingField;
        [CompilerGenerated]
        private FloatCurve _003CRotateSpeed_003Ek__BackingField;
        [CompilerGenerated]
        private FloatCurve _003CRotateAngle_003Ek__BackingField;
        private EquipmentValue _equipmentValue;
        private int _idLength;
        private int[] _ids;
        private bool _prepareFrameCalled;
        public bool IsMainTrack
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool UseBpm
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public LiveEquipmentAnimationCurve Curves
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public EquipmentValue EquipmentValue
        {
            get
            {
                return null;
            }

            set
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
            set
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
            set
            {
            }
        }

        public EquipmentValueFlags TrackReverseFlag
        {
            [CompilerGenerated]
            get
            {
                return default(EquipmentValueFlags);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public EquipmentValueFlags ClipIgnoreReverseFlag
        {
            [CompilerGenerated]
            get
            {
                return default(EquipmentValueFlags);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public FireType FireType
        {
            [CompilerGenerated]
            get
            {
                return default(FireType);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public Vector4 FireParameter
        {
            [CompilerGenerated]
            get
            {
                return default(Vector4);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        protected float Bpm
        {
            get
            {
                return default(float);
            }
        }

        public float TimeScale
        {
            get
            {
                return default(float);
            }
        }

        public float Beat
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public CampusBpmInfo BpmInfo
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public float TimeOffset
        {
            get
            {
                return default(float);
            }
        }

        public float BeatOffset
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public Transform LookAtTarget
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public MovingMode MovingMode
        {
            [CompilerGenerated]
            get
            {
                return default(MovingMode);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public FloatCurve RotateSpeed
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public FloatCurve RotateAngle
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        protected unsafe virtual void OnUpdateAnimationData(LiveEquipmentAnimationData* pData, LiveEquipmentInitialData* pInitial, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
        }

        private EquipmentValueFactor GetEquipmentValueFactor(bool reverseById)
        {
            return default(EquipmentValueFactor);
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        protected unsafe bool SampleIntensityCurve(LiveEquipmentAnimationData* pData, float time, float duration, float weight)
        {
            return default(bool);
        }

        protected unsafe bool SampleColorCurve(LiveEquipmentAnimationData* pData, float time, float duration, float weight, Color multiply)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        protected float EvaluateCurve(FloatCurve floatCurve, float time, float duration)
        {
            return default(float);
        }

        [MethodImpl(256)]
        protected unsafe bool SampleV0Curve(LiveEquipmentAnimationData* pData, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        protected unsafe bool SampleV1Curve(LiveEquipmentAnimationData* pData, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        protected unsafe bool SampleV2Curve(LiveEquipmentAnimationData* pData, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        protected unsafe bool SampleV3Curve(LiveEquipmentAnimationData* pData, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
            return default(bool);
        }

        protected unsafe bool SampleLookAtParam(LiveEquipmentAnimationData* pData, float time, float duration, float weight)
        {
            return default(bool);
        }

        protected unsafe void SampleAllCurve(LiveEquipmentAnimationData* pData, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
        }

        public LiveEquipmentAssetBehaviour()
        {
        }
    }
}
