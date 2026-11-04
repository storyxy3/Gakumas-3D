namespace Campus.Live.Equipment.Timeline
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::Unity.Mathematics;
    using global::Campus.Common;
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Environment;
    using global::Campus.Live.Equipment.Timeline;

    public class LiveEquipmentLaserAssetBehaviour : LiveEquipmentAssetBehaviour
    {
        [CompilerGenerated]
        private LiveLaser.LaserType _003CLaserType_003Ek__BackingField;
        [CompilerGenerated]
        private LiveLaser.LightType _003CLightType_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CLaserLength_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CLaserCount_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CLaserRadius_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CRandomSpeed_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CLightOnTime_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CLightOffTime_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CLightDelay_003Ek__BackingField;
        [CompilerGenerated]
        private FloatCurve _003CLaserAngle_003Ek__BackingField;
        public LiveLaser.LaserType LaserType
        {
            [CompilerGenerated]
            get
            {
                return _003CLaserType_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CLaserType_003Ek__BackingField = value;
            }
        }

        public LiveLaser.LightType LightType
        {
            [CompilerGenerated]
            get
            {
                return _003CLightType_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CLightType_003Ek__BackingField = value;
            }
        }

        public int LaserLength
        {
            [CompilerGenerated]
            get
            {
                return _003CLaserLength_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CLaserLength_003Ek__BackingField = value;
            }
        }

        public int LaserCount
        {
            [CompilerGenerated]
            get
            {
                return _003CLaserCount_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CLaserCount_003Ek__BackingField = value;
            }
        }

        public int LaserRadius
        {
            [CompilerGenerated]
            get
            {
                return _003CLaserRadius_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CLaserRadius_003Ek__BackingField = value;
            }
        }

        public float RandomSpeed
        {
            [CompilerGenerated]
            get
            {
                return _003CRandomSpeed_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CRandomSpeed_003Ek__BackingField = value;
            }
        }

        public float LightOnTime
        {
            [CompilerGenerated]
            get
            {
                return _003CLightOnTime_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CLightOnTime_003Ek__BackingField = value;
            }
        }

        public float LightOffTime
        {
            [CompilerGenerated]
            get
            {
                return _003CLightOffTime_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CLightOffTime_003Ek__BackingField = value;
            }
        }

        public float LightDelay
        {
            [CompilerGenerated]
            get
            {
                return _003CLightDelay_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CLightDelay_003Ek__BackingField = value;
            }
        }

        public FloatCurve LaserAngle
        {
            [CompilerGenerated]
            get
            {
                return _003CLaserAngle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CLaserAngle_003Ek__BackingField = value;
            }
        }

        protected unsafe override void OnUpdateAnimationData(LiveEquipmentAnimationData* pData, LiveEquipmentInitialData* pInitial, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
            SampleAllCurve(pData, time, duration, weight, in valueFactor);
            if (!IsMainTrack) return;
            var value = pData->valueInt;
            value.x = (int)LaserType | ((int)LightType << 8) | (LaserCount << 16);
            value.y += Mathf.RoundToInt(LaserRadius * weight);
            value.z += Mathf.RoundToInt(LaserLength * 1000f * weight);
            value.w += Mathf.RoundToInt(EvaluateCurve(LaserAngle, time, duration) * weight);
            pData->valueInt = value;
            pData->bpmTime = time;
            pData->valueFloat = LightType != global::Campus.Live.Equipment.Environment.LiveLaser.LightType.Always
                ? new float4(LightOnTime, LightOffTime, LightDelay, RandomSpeed)
                : new float4(0f, 0f, 0f, RandomSpeed);
        }

        public LiveEquipmentLaserAssetBehaviour()
        {
        }
    }
}
