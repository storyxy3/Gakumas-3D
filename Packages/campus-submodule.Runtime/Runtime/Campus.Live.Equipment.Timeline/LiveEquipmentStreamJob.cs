namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;

    [BurstCompile]
    public struct LiveEquipmentStreamJob : IJobParallelFor
    {
        [ReadOnly]
        public NativeArray<LiveEquipmentAnimationData> animationData;
        [ReadOnly]
        public NativeArray<LiveEquipmentInitialData> initialData;
        [WriteOnly]
        public NativeArray<LiveEquipmentStreamData> streamData;
        public void Execute(int index)
        {
        }
    }
}
