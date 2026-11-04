namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment;
    using global::Unity.Collections;
    using global::Unity.Collections.LowLevel.Unsafe;
    using global::Unity.Mathematics;
    using global::UnityEngine.Playables;

    public class LiveEquipmentTrackBehaviour : PlayableBehaviour
    {
        public LiveEquipmentStreamJobType jobType;
        public EquipmentValue equipmentValue;
        public NativeArray<LiveEquipmentAnimationData> animationData;
        public override void OnPlayableCreate(Playable playable)
        {
        }

        public unsafe override void PrepareFrame(Playable playable, FrameData info)
        {
            if (equipmentValue == null) return;
            var data = (LiveEquipmentAnimationData*)animationData.GetUnsafePtr();
            using (var ids = equipmentValue.id.GetIdList())
            {
                for (int i = 0; i < ids.Length; i++)
                    data[ids.GetId(i)] = new LiveEquipmentAnimationData { jobType = jobType, position = float3.zero };
            }
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        public LiveEquipmentTrackBehaviour()
        {
        }
    }
}
