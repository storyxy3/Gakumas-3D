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
            RemoveAtSwapBack(ref entities, index, count);
            RemoveAtSwapBack(ref components, index, count);
            transformAccessArray.RemoveAtSwapBack(index);
            count--;
        }

        public override void SetCapacity(int newCapacity)
        {
            ResizeArray(ref entities, newCapacity);
            ResizeNativeArray(ref transformAccessArray, components, newCapacity);
            ResizeArray(ref components, newCapacity);
            capacity = newCapacity;
        }

        public override void Dispose()
        {
            if (capacity == 0) return;
            entities.Dispose();
            transformAccessArray.Dispose();
            components = null;
            count = capacity = 0;
        }

        public VLBEntityChunk()
        {
        }
    }
}
