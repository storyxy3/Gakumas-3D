namespace VLB
{
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;
    using global::VLB;

    internal class VLBEntityChunk : Chunk
    {
        public NativeArray<Entity> entities;
        public VolumetricLightBeamSD[] components;
        public TransformAccessArray transformAccessArray;
        public int materialID;
        public Material material;
        public override void RemoveAtSwapBack(int index)
        {
        }

        public override void SetCapacity(int newCapacity)
        {
        }

        public override void Dispose()
        {
        }

        public VLBEntityChunk()
        {
        }
    }
}
