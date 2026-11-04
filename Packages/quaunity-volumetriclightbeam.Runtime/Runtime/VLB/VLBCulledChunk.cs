namespace VLB
{
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::VLB;

    internal class VLBCulledChunk : Chunk
    {
        public float3 cameraPosition;
        public ulong sceneCullingMask;
        public NativeArray<Plane> planes;
        public NativeList<int> visibleIndices;
        public VLBCulledChunk()
        {
            planes = new NativeArray<Plane>(6, Allocator.Persistent);
            visibleIndices = new NativeList<int>(Allocator.Persistent);
        }

        public override void RemoveAtSwapBack(int entityIndex)
        {
            count--;
        }

        public override void SetCapacity(int newCapacity)
        {
            visibleIndices.SetCapacity(newCapacity);
            capacity = newCapacity;
        }

        public override void Dispose()
        {
            if (capacity == 0) return;
            planes.Dispose();
            visibleIndices.Dispose();
            count = capacity = 0;
        }
    }
}
