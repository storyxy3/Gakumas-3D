namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Timeline;

    public class LiveEquipmentDirectionalLightAssetBehaviour : LiveEquipmentAssetBehaviour
    {
        protected unsafe override void OnUpdateAnimationData(LiveEquipmentAnimationData* pData, LiveEquipmentInitialData* pInitial, float time, float duration, float weight, in EquipmentValueFactor valueFactor)
        {
            SampleV0Curve(pData, time, duration, weight, in valueFactor);
            SampleV1Curve(pData, time, duration, weight, in valueFactor);
            SampleIntensityCurve(pData, time, duration, weight);
            if (IsMainTrack) pData->valueInt.w = 1;
        }

        public LiveEquipmentDirectionalLightAssetBehaviour()
        {
        }
    }
}
