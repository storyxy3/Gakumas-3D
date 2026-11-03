namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment;
    using global::Unity.Collections;
    using global::UnityEngine.Playables;

    public class LiveEquipmentTrackBehaviour : PlayableBehaviour
    {
        public LiveEquipmentStreamJobType jobType;
        public EquipmentValue equipmentValue;
        public NativeArray<LiveEquipmentAnimationData> animationData;
        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        public LiveEquipmentTrackBehaviour()
        {
        }
    }
}
