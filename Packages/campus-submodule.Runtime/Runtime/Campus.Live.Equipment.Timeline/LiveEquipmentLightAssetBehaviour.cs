namespace Campus.Live.Equipment.Timeline
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Timeline;

    public class LiveEquipmentLightAssetBehaviour : LiveEquipmentAssetBehaviour
    {
        [CompilerGenerated]
        private int _003CSpotAngle_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CSideThickness_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CRangeLimit_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CNoiseIntensity_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CFlareIndex_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CFlareScale_003Ek__BackingField;
        [CompilerGenerated]
        private FloatCurve _003CSpecularStrength_003Ek__BackingField;
        [CompilerGenerated]
        private FloatCurve _003CRealLightMultiplier_003Ek__BackingField;
        public int SpotAngle
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

        public float SideThickness
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

        public float RangeLimit
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

        public float NoiseIntensity
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

        public int FlareIndex
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

        public float FlareScale
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

        public FloatCurve SpecularStrength
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

        public FloatCurve RealLightMultiplier
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

        public LiveEquipmentLightAssetBehaviour()
        {
        }
    }
}
