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
                return subCallCounts[0];
            }
        }

        public VLBDrawCallChunk()
        {
            subCallCounts = new NativeArray<int>(1, Allocator.Persistent);
        }

        public override void RemoveAtSwapBack(int entityIndex)
        {
            RemoveAtSwapBack(ref localToWorlds, entityIndex, count);
            RemoveAtSwapBack(ref colors, entityIndex, count);
            RemoveAtSwapBack(ref cameraParams, entityIndex, count);
            RemoveAtSwapBack(ref params0, entityIndex, count);
            RemoveAtSwapBack(ref params1, entityIndex, count);
            RemoveAtSwapBack(ref subCalls, entityIndex, count);
            RemoveAtSwapBack(ref instanceIndexToVisibleIndex, entityIndex, count);
            count--;
        }

        public override void SetCapacity(int newCapacity)
        {
            ResizeArray(ref localToWorlds, newCapacity);
            ResizeArray(ref colors, newCapacity);
            ResizeArray(ref cameraParams, newCapacity);
            ResizeArray(ref params0, newCapacity);
            ResizeArray(ref params1, newCapacity);
            ResizeArray(ref subCalls, newCapacity);
            ResizeArray(ref instanceIndexToVisibleIndex, newCapacity);
            capacity = newCapacity;
        }

        public override void Dispose()
        {
            subCallCounts.Dispose();
            if (capacity == 0) return;
            localToWorlds.Dispose();
            colors.Dispose();
            cameraParams.Dispose();
            params0.Dispose();
            params1.Dispose();
            subCalls.Dispose();
            instanceIndexToVisibleIndex.Dispose();
            count = capacity = 0;
        }
    }
}
