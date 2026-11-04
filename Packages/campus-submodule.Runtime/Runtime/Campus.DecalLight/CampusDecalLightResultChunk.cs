namespace Campus.DecalLight
{
    using global::Unity.Collections;
    using global::UnityEngine.Rendering;
    using global::Unity.Mathematics;
    using global::VL.EntitySystem;

    public class CampusDecalLightResultChunk : Chunk
    {
        public NativeArray<float4x4> lightToWorldsDraw;
        public NativeArray<float4> positionAndAttensDraw;
        public NativeArray<float4x4> paramsDraw;
        public NativeArray<float4> colorsDraw;
        public NativeArray<float4> uvScaleOffsetsDraw;
        public CampusDecalLightResultChunk()
        {
        }

        public override void RemoveAtSwapBack(int entityIndex)
        {
            RemoveAtSwapBack(ref lightToWorldsDraw, entityIndex, count);
            RemoveAtSwapBack(ref positionAndAttensDraw, entityIndex, count);
            RemoveAtSwapBack(ref paramsDraw, entityIndex, count);
            RemoveAtSwapBack(ref colorsDraw, entityIndex, count);
            RemoveAtSwapBack(ref uvScaleOffsetsDraw, entityIndex, count);
            count--;
        }

        public override void SetCapacity(int newCapacity)
        {
            ArrayExtensions.ResizeArray(ref lightToWorldsDraw, newCapacity);
            ArrayExtensions.ResizeArray(ref positionAndAttensDraw, newCapacity);
            ArrayExtensions.ResizeArray(ref paramsDraw, newCapacity);
            ArrayExtensions.ResizeArray(ref colorsDraw, newCapacity);
            ArrayExtensions.ResizeArray(ref uvScaleOffsetsDraw, newCapacity);
            capacity = newCapacity;
        }

        public override void Dispose()
        {
            if (capacity == 0) return;
            lightToWorldsDraw.Dispose();
            positionAndAttensDraw.Dispose();
            paramsDraw.Dispose();
            colorsDraw.Dispose();
            uvScaleOffsetsDraw.Dispose();
            count = 0;
            capacity = 0;
        }
    }
}
