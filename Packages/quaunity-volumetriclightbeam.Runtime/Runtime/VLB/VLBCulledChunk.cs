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
