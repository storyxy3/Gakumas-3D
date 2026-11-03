namespace Campus.DecalLight
{
    using global::Unity.Collections;
    using global::VL.EntitySystem;

    public class CampusDecalLightCulledChunk : Chunk
    {
        public NativeArray<int> visibleIndices;
        public NativeArray<int> culledCount;
        public CampusDecalLightCulledChunk()
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
