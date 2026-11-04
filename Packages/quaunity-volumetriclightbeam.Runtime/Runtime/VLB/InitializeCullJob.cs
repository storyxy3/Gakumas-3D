namespace VLB
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;

    [BurstCompile]
    public struct InitializeCullJob : IJob
    {
        [WriteOnly]
        public NativeList<int> visibleIndices;
        public void Execute()
        {
            visibleIndices.Clear();
        }
    }
}
