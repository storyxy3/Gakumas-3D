namespace VL.Rendering.Skinning
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::Unity.Mathematics;
    using global::VL.Rendering.Skinning;

    [BurstCompile(FloatPrecision.Standard, FloatMode.Fast, OptimizeFor = OptimizeFor.Performance)]
    public struct SkinningJob<TStream0, TSkinning> : IJobParallelFor where TStream0 : struct, IStream0 where TSkinning : struct, ISkinning
    {
        [ReadOnly]
        public NativeArray<TSkinning> skinArray;
        [ReadOnly]
        public NativeArray<float4x4> matricesArray;
        public NativeArray<TStream0> destinationArray;
        public void Execute(int i)
        {
            var vertex = destinationArray[i];
            var skinning = skinArray[i];
            var matrix = skinning.GetBlendedSkinMatrix(ref matricesArray);
            vertex.MultiplySkinMatrix(matrix);
            destinationArray[i] = vertex;
        }
    }
}
