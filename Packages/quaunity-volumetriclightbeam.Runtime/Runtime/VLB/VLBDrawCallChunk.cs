namespace VLB
{
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::VLB;

    internal class VLBDrawCallChunk : Chunk
    {
        public NativeArray<float4x4> localToWorlds;
        public NativeArray<float4> colors;
        public NativeArray<float4> cameraParams;
        public NativeArray<float4x4> params0;
        public NativeArray<float4x4> params1;
        public NativeArray<SubDrawCall> subCalls;
        public NativeArray<int> subCallCounts;
        public NativeArray<int> instanceIndexToVisibleIndex;
        public int subCallCount
        {
            get
            {
                return default(int);
            }
        }

        public VLBDrawCallChunk()
        {
        }

        public override void RemoveAtSwapBack(int entityIndex)
        {
        }

        public override void SetCapacity(int newCapacity)
        {
        }

        public override void Dispose()
        {
        }
    }
}
