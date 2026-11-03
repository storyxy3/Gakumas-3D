namespace Campus.DecalLight
{
    using global::Unity.Collections;
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
        }

        public override void SetCapacity(int newCapacity)
        {
        }

        public override void Dispose()
        {
        }
    }
}
