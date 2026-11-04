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
            var animation = animationData[index];
            var initial = initialData[index];
            if (initial.count == 0) return;
            switch (animation.jobType)
            {
                case LiveEquipmentStreamJobType.None:
                    streamData.ReinterpretStore(index, LiveEquipmentStreamJobUtility.ConvertNone());
                    break;
                case LiveEquipmentStreamJobType.Copy:
                    streamData.ReinterpretStore(index, LiveEquipmentStreamJobUtility.ConvertSimple(ref animation));
                    break;
                case LiveEquipmentStreamJobType.Basic:
                    streamData.ReinterpretStore(index, LiveEquipmentStreamJobUtility.ConvertBasic(ref animation));
                    break;
                case LiveEquipmentStreamJobType.Light:
                    streamData.ReinterpretStore(index, LiveEquipmentStreamJobUtility.ConvertLight(ref animation, ref initial));
                    break;
                case LiveEquipmentStreamJobType.Laser:
                    streamData.ReinterpretStore(index, LiveEquipmentStreamJobUtility.ConvertLaser(ref animation, ref initial));
                    break;
                case LiveEquipmentStreamJobType.Psyllium:
                    streamData.ReinterpretStore(index, LiveEquipmentStreamJobUtility.ConvertPsyllium(ref animation, ref initial));
                    break;
                case LiveEquipmentStreamJobType.DirectionalLight:
                    streamData.ReinterpretStore(index, LiveEquipmentStreamJobUtility.ConvertDirectionalLight(ref animation));
                    break;
            }
        }
    }
}
