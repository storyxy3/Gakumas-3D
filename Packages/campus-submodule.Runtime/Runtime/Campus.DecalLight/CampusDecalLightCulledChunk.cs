namespace Campus.DecalLight
{
    using global::Unity.Collections;
    using global::UnityEngine.Rendering;
    using global::VL.EntitySystem;

    public class CampusDecalLightCulledChunk : Chunk
    {
        public NativeArray<int> visibleIndices;
        public NativeArray<int> culledCount;
        public CampusDecalLightCulledChunk()
        {
            culledCount = new NativeArray<int>(1, Allocator.Persistent);
        }

        public override void RemoveAtSwapBack(int entityIndex)
        {
            RemoveAtSwapBack(ref visibleIndices, entityIndex, count);
            count--;
        }

        public override void SetCapacity(int newCapacity)
        {
            ArrayExtensions.ResizeArray(ref visibleIndices, newCapacity);
            capacity = newCapacity;
        }

        public override void Dispose()
        {
            if (capacity == 0) return;
            visibleIndices.Dispose();
            culledCount.Dispose();
            count = 0;
            capacity = 0;
        }
    }
}
