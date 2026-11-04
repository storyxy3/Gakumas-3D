namespace VL.Rendering.Skinning
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::VL.Core;
    using global::VL.Rendering.Skinning;

    [BurstCompile(FloatPrecision.Standard, FloatMode.Fast, OptimizeFor = OptimizeFor.Performance)]
    public struct BlendShapeJob<TStream0> : IJob where TStream0 : struct, IStream0
    {
        public int length;
        [ReadOnly]
        public NativeArray<BlendShapeInfo> blendShapeInfoArray;
        [ReadOnly]
        public NativeArray<BlendShapeLayout> blendShapeArray;
        public NativeArray<TStream0> destinationArray;
        public void Execute()
        {
            for (int i = 0; i < length; i++)
            {
                var info = blendShapeInfoArray[i];
                for (int j = 0; j < info.length; j++)
                {
                    var shape = blendShapeArray[info.start + j];
                    var vertex = destinationArray[shape.vertIndex];
                    vertex.Position += shape.position * info.weight;
                    destinationArray[shape.vertIndex] = vertex;
                }
            }
        }
    }
}
