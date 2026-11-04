namespace Campus.Live.Equipment.Timeline
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::Unity.Mathematics;
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
                return _003CSpotAngle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CSpotAngle_003Ek__BackingField = value;
            }
        }

        public float SideThickness
        {
            [CompilerGenerated]
            get
            {
                return _003CSideThickness_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CSideThickness_003Ek__BackingField = value;
            }
        }

        public float RangeLimit
        {
            [CompilerGenerated]
            get
            {
                return _003CRangeLimit_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CRangeLimit_003Ek__BackingField = value;
            }
        }

        public float NoiseIntensity
        {
            [CompilerGenerated]
            get
            {
                return _003CNoiseIntensity_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CNoiseIntensity_003Ek__BackingField = value;
            }
        }

        public int FlareIndex
        {
            [CompilerGenerated]
            get
            {
                return _003CFlareIndex_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CFlareIndex_003Ek__BackingField = value;
            }
        }

        public float FlareScale
        {
            [CompilerGenerated]
            get
            {
                return _003CFlareScale_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CFlareScale_003Ek__BackingField = value;
            }
        }

        public FloatCurve SpecularStrength
        {
            [CompilerGenerated]
            get
            {
                return _003CSpecularStrength_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CSpecularStrength_003Ek__BackingField = value;
            }
        }

        public FloatCurve RealLightMultiplier
        {
            [CompilerGenerated]
            get
            {
                return _003CRealLightMultiplier_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CRealLightMultiplier_003Ek__BackingField = value;
            }
        }

        protected unsafe override void OnUpdateAnimationData(LiveEquipmentAnimationData* pData, LiveEquipmentInitialData* pInitial, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
            SampleAllCurve(pData, time, duration, weight, in valueFactor);
            if (!IsMainTrack) return;
            float initialSideThickness = pInitial->v1.x;
            float initialRange = pInitial->v1.z;
            float initialAngle = pInitial->v1.w;
            int angle = SpotAngle != 0 ? SpotAngle : (int)initialAngle;
            pData->valueInt = new int4(0, FlareIndex, 0, pData->valueInt.w + Mathf.RoundToInt(angle * weight));
            float sideThickness = SideThickness < 0.01f ? initialSideThickness : SideThickness;
            float range = RangeLimit < 0.01f ? initialRange : RangeLimit;
            pData->valueFloat += new float4(sideThickness, FlareScale, range, NoiseIntensity) * weight;
            var light = pData->lightParam;
            if (RealLightMultiplier.IsValid) light.x += EvaluateCurve(RealLightMultiplier, time, duration) * weight;
            if (SpecularStrength.IsValid) light.y += EvaluateCurve(SpecularStrength, time, duration) * weight;
            pData->lightParam = light;
        }

        public LiveEquipmentLightAssetBehaviour()
        {
        }
    }
}
