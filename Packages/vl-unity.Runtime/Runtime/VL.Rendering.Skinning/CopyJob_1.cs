namespace VL.Rendering.Skinning
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::VL.Rendering.Skinning;

    [BurstCompile(FloatPrecision.Standard, FloatMode.Fast, OptimizeFor = OptimizeFor.Performance)]
    public struct CopyJob<TStream0> : IJobParallelFor where TStream0 : struct, IStream0
    {
        [ReadOnly]
        public NativeArray<TStream0> sourceArray;
        [WriteOnly]
        public NativeArray<VertexLayoutStream2> prevArray;
        public NativeArray<TStream0> destinationArray;
        public void Execute(int index)
        {
            prevArray[index] = new VertexLayoutStream2 { prevPosition = destinationArray[index].Position };
            destinationArray[index] = sourceArray[index];
        }
    }
}
