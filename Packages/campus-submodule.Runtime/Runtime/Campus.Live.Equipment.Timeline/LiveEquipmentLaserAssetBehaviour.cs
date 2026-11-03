namespace Campus.Live.Equipment.Timeline
{
    using global::System.Runtime.CompilerServices;
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
                return default(LiveLaser.LaserType);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public LiveLaser.LightType LightType
        {
            [CompilerGenerated]
            get
            {
                return default(LiveLaser.LightType);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public int LaserLength
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public int LaserCount
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public int LaserRadius
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public float RandomSpeed
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

        public float LightOnTime
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

        public float LightOffTime
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

        public float LightDelay
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

        public FloatCurve LaserAngle
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

        protected unsafe override void OnUpdateAnimationData(LiveEquipmentAnimationData* pData, LiveEquipmentInitialData* pInitial, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
        }

        public LiveEquipmentLaserAssetBehaviour()
        {
        }
    }
}
