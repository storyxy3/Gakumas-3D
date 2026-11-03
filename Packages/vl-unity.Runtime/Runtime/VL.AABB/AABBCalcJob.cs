namespace VL.AABB
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::VL.AABB;

    [BurstCompile]
    public struct AABBCalcJob : IJobFor
    {
        [ReadOnly]
        public NativeArray<Vector3> positions;
        [ReadOnly]
        public NativeArray<AABBData> aabbs;
        [ReadOnly]
        public NativeArray<float4x4> localToWorlds;
        [WriteOnly]
        public NativeArray<Bounds> localBounds;
        [WriteOnly]
        public NativeArray<Bounds> bounds;
        public void Execute(int index)
        {
        }
    }
}
