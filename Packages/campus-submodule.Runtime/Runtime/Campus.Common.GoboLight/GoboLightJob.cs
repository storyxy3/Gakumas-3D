namespace Campus.Common.GoboLight
{
    using global::Campus.Common.GoboLight;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::Unity.Mathematics;

    [BurstCompile]
    public struct GoboLightJob : IJobParallelFor
    {
        [ReadOnly]
        public NativeArray<GoboData> data;
        [ReadOnly]
        public NativeArray<float4> sourceVertices;
        [ReadOnly]
        public NativeArray<float3> sourceUVs;
        public NativeArray<VertexLayout> vertexData;
        public int2 split;
        public void Execute(int index)
        {
        }
    }
}
