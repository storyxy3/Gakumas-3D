namespace Campus.Live.Equipment.Timeline
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Timeline;
    using global::Campus.Timeline;
    using global::Unity.Collections;
    using global::Unity.Collections.LowLevel.Unsafe;
    using global::Unity.Mathematics;
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
        private int _idLength = -1;
        private int[] _ids;
        private bool _prepareFrameCalled;
        public bool IsMainTrack
        {
            [CompilerGenerated]
            get
            {
                return _003CIsMainTrack_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CIsMainTrack_003Ek__BackingField = value;
            }
        }

        public bool UseBpm
        {
            [CompilerGenerated]
            get
            {
                return _003CUseBpm_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CUseBpm_003Ek__BackingField = value;
            }
        }

        public LiveEquipmentAnimationCurve Curves
        {
            [CompilerGenerated]
            get
            {
                return _003CCurves_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CCurves_003Ek__BackingField = value;
            }
        }

        public EquipmentValue EquipmentValue
        {
            get
            {
                return _equipmentValue;
            }

            set
            {
                _equipmentValue = value;
                _idLength = -1;
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
            set
            {
                _003CAnimationData_003Ek__BackingField = value;
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
            set
            {
                _003CInitialData_003Ek__BackingField = value;
            }
        }

        public EquipmentValueFlags TrackReverseFlag
        {
            [CompilerGenerated]
            get
            {
                return _003CTrackReverseFlag_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CTrackReverseFlag_003Ek__BackingField = value;
            }
        }

        public EquipmentValueFlags ClipIgnoreReverseFlag
        {
            [CompilerGenerated]
            get
            {
                return _003CClipIgnoreReverseFlag_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CClipIgnoreReverseFlag_003Ek__BackingField = value;
            }
        }

        public FireType FireType
        {
            [CompilerGenerated]
            get
            {
                return _003CFireType_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CFireType_003Ek__BackingField = value;
            }
        }

        public Vector4 FireParameter
        {
            [CompilerGenerated]
            get
            {
                return _003CFireParameter_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CFireParameter_003Ek__BackingField = value;
            }
        }

        protected float Bpm
        {
            get
            {
                return BpmInfo != null ? BpmInfo.EvaluateBpm() : 0f;
            }
        }

        public float TimeScale
        {
            get
            {
                if (UseBpm)
                {
                    if (Beat > 0f) return Bpm / 60f / Beat;
                    Debug.LogWarning("Beatに1以上の値を指定してください");
                }
                return 1f;
            }
        }

        public float Beat
        {
            [CompilerGenerated]
            get
            {
                return _003CBeat_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CBeat_003Ek__BackingField = value;
            }
        }

        public CampusBpmInfo BpmInfo
        {
            [CompilerGenerated]
            get
            {
                return _003CBpmInfo_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CBpmInfo_003Ek__BackingField = value;
            }
        }

        public float TimeOffset
        {
            get
            {
                return Bpm > 0f && BeatOffset != 0f ? (60f / Bpm) * BeatOffset : 0f;
            }
        }

        public float BeatOffset
        {
            [CompilerGenerated]
            get
            {
                return _003CBeatOffset_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CBeatOffset_003Ek__BackingField = value;
            }
        }

        public Transform LookAtTarget
        {
            [CompilerGenerated]
            get
            {
                return _003CLookAtTarget_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CLookAtTarget_003Ek__BackingField = value;
            }
        }

        public MovingMode MovingMode
        {
            [CompilerGenerated]
            get
            {
                return _003CMovingMode_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CMovingMode_003Ek__BackingField = value;
            }
        }

        public FloatCurve RotateSpeed
        {
            [CompilerGenerated]
            get
            {
                return _003CRotateSpeed_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CRotateSpeed_003Ek__BackingField = value;
            }
        }

        public FloatCurve RotateAngle
        {
            [CompilerGenerated]
            get
            {
                return _003CRotateAngle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CRotateAngle_003Ek__BackingField = value;
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
            SampleAllCurve(pData, time, duration, weight, in valueFactor);
        }

        private EquipmentValueFactor GetEquipmentValueFactor(bool reverseById)
        {
            return new EquipmentValueFactor
            {
                v0 = (reverseById || TrackReverseFlag.v0) && !ClipIgnoreReverseFlag.v0 ? -1f : 1f,
                v1 = (reverseById || TrackReverseFlag.v1) && !ClipIgnoreReverseFlag.v1 ? -1f : 1f,
                v2 = (reverseById || TrackReverseFlag.v2) && !ClipIgnoreReverseFlag.v2 ? -1f : 1f,
                v3 = (reverseById || TrackReverseFlag.v3) && !ClipIgnoreReverseFlag.v3 ? -1f : 1f
            };
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
            _prepareFrameCalled = true;
        }

        public unsafe override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            if (!_prepareFrameCalled) return;
            _prepareFrameCalled = false;
            if (Curves == null || !AnimationData.IsCreated || AnimationData.Length < 448 || EquipmentValue == null) return;
            float time = (float)playable.GetTime();
            float duration = (float)playable.GetDuration();
            float weight = info.weight;
            int instanceID = EquipmentValue.GetInstanceID();
            var animation = (LiveEquipmentAnimationData*)AnimationData.GetUnsafePtr();
            var initial = (LiveEquipmentInitialData*)InitialData.GetUnsafePtr();
            float3 targetPosition = float3.zero;
            bool hasTarget = false;
            if (MovingMode == MovingMode.LookAt)
            {
                hasTarget = EquipmentValue.targetTransform != null;
                if (hasTarget) targetPosition = EquipmentValue.targetTransform.position;
                if (LookAtTarget != null)
                {
                    targetPosition = LookAtTarget.position;
                    hasTarget = true;
                }
            }
            if (_idLength < 0)
            {
                using (var ids = EquipmentValue.id.GetIdList())
                {
                    _idLength = ids.Length;
                    if (_ids == null || _ids.Length != _idLength) _ids = new int[_idLength];
                    for (int i = 0; i < _idLength; i++) _ids[i] = ids.GetId(i);
                }
            }
            var reverseIds = EquipmentValue.reverseId;
            for (int i = 0; i < _idLength; i++)
            {
                int id = _ids[i];
                var data = animation + id;
                if (data->processedInstanceID == 0) data->processedInstanceID = instanceID;
                else if (data->processedInstanceID != instanceID) continue;
                float localTime = time;
                if (FireType == FireType.Normal) localTime = FireParameter.y - FireParameter.x * i + time;
                else if (FireType == FireType.Reverse) localTime = FireParameter.y - FireParameter.x * (_idLength - i - 1) + time;
                if (0f > localTime) localTime = 0f; // original keeps NaN (x64 comiss 0,time + jbe)
                var factor = GetEquipmentValueFactor(reverseIds.Exist(id));
                OnUpdateAnimationData(data, initial + id, localTime, duration, weight, in factor);
                if (hasTarget)
                {
                    data->position = targetPosition;
                    (*data).AddFlag(EquipmentValueType.Position);
                }
            }
        }

        protected unsafe bool SampleIntensityCurve(LiveEquipmentAnimationData* pData, float time, float duration, float weight)
        {
            var curve = Curves.intensity;
            if (curve == null || !curve.IsValid) return false;
            pData->intensity += EvaluateCurve(curve, time, duration) * weight;
            (*pData).AddFlag(EquipmentValueType.Intensity);
            return true;
        }

        protected unsafe bool SampleColorCurve(LiveEquipmentAnimationData* pData, float time, float duration, float weight, Color multiply)
        {
            if (!Curves.HasColor) return false;
            float localTime = TimeScale * time + TimeOffset;
            pData->color += Curves.colorGradient.Evaluate(UseBpm ? localTime % 1f : localTime / duration) * weight * multiply;
            (*pData).AddFlag(EquipmentValueType.Color);
            return true;
        }

        [MethodImpl(256)]
        protected float EvaluateCurve(FloatCurve floatCurve, float time, float duration)
        {
            float localTime = TimeScale * time + TimeOffset;
            return floatCurve.Evaluate((UseBpm ? localTime % 1f : localTime / duration) * floatCurve.Duration);
        }

        [MethodImpl(256)]
        protected unsafe bool SampleV0Curve(LiveEquipmentAnimationData* pData, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
            var curve = Curves.Yow;
            if (curve == null || !curve.IsValid) return false;
            pData->v0 += EvaluateCurve(curve, time, duration) * weight * valueFactor.v0;
            (*pData).AddFlag(EquipmentValueType.Yow);
            return true;
        }

        [MethodImpl(256)]
        protected unsafe bool SampleV1Curve(LiveEquipmentAnimationData* pData, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
            var curve = Curves.Pitch;
            if (curve == null || !curve.IsValid) return false;
            pData->v1 += EvaluateCurve(curve, time, duration) * weight * valueFactor.v1;
            (*pData).AddFlag(EquipmentValueType.Pitch);
            return true;
        }

        [MethodImpl(256)]
        protected unsafe bool SampleV2Curve(LiveEquipmentAnimationData* pData, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
            var curve = Curves.v2;
            if (curve == null || !curve.IsValid) return false;
            pData->v2 += EvaluateCurve(curve, time, duration) * weight * valueFactor.v2;
            (*pData).AddFlag(EquipmentValueType.V2);
            return true;
        }

        [MethodImpl(256)]
        protected unsafe bool SampleV3Curve(LiveEquipmentAnimationData* pData, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
            var curve = Curves.v3;
            if (curve == null || !curve.IsValid) return false;
            pData->v3 += EvaluateCurve(curve, time, duration) * weight * valueFactor.v3;
            (*pData).AddFlag(EquipmentValueType.V3);
            return true;
        }

        protected unsafe bool SampleLookAtParam(LiveEquipmentAnimationData* pData, float time, float duration, float weight)
        {
            if (MovingMode != MovingMode.Rotate && MovingMode != MovingMode.RotateIgnoreInitialRoll) return false;
            float rotation = 0f;
            if (RotateSpeed.IsValid)
            {
                float speed = EvaluateCurve(RotateSpeed, time, duration) * weight;
                float scaledTime = TimeScale * time;
                float phase = speed * scaledTime + TimeOffset;
                phase = UseBpm ? phase % 1f : phase / duration;
                rotation = (phase + phase) * math.PI;
            }
            float angle = RotateSpeed.IsValid ? EvaluateCurve(RotateAngle, time, duration) * (2f * math.PI) / 360f : 0f;
            (*pData).AddFlag(EquipmentValueType.Rotate);
            (*pData).AddFlag(EquipmentValueType.Position);
            if (MovingMode == MovingMode.RotateIgnoreInitialRoll) (*pData).AddFlag(EquipmentValueType.RotateIgnoreInitialRoll);
            pData->v3 = 1f;
            pData->lookAtParam.x += angle;
            pData->lookAtParam.y += rotation;
            return true;
        }

        protected unsafe void SampleAllCurve(LiveEquipmentAnimationData* pData, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
            SampleIntensityCurve(pData, time, duration, weight);
            SampleColorCurve(pData, time, duration, weight, Color.white);
            SampleV0Curve(pData, time, duration, weight, in valueFactor);
            SampleV1Curve(pData, time, duration, weight, in valueFactor);
            SampleV2Curve(pData, time, duration, weight, in valueFactor);
            SampleV3Curve(pData, time, duration, weight, in valueFactor);
            SampleLookAtParam(pData, time, duration, weight);
        }

        public LiveEquipmentAssetBehaviour()
        {
        }
    }
}
