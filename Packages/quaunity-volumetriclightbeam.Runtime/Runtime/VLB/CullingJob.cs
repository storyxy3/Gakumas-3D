namespace VLB
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::UnityEngine;

    [BurstCompile]
    public struct CullingJob : IJobParallelFor
    {
        [ReadOnly]
        public NativeArray<Plane> planes;
        [ReadOnly]
        public NativeArray<bool> enables;
        [ReadOnly]
        public NativeArray<Bounds> bounds;
        [WriteOnly]
        public NativeList<int>.ParallelWriter visibleIndices;
        public void Execute(int index)
        {
        }
    }
}
