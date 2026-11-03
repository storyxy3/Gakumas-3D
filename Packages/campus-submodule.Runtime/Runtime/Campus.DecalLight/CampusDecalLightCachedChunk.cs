namespace Campus.DecalLight
{
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::VL.EntitySystem;

    public class CampusDecalLightCachedChunk : Chunk
    {
        public MaterialPropertyBlock propertyBlock;
        public NativeArray<float3> positions;
        public NativeArray<quaternion> rotations;
        public NativeArray<Bounds> bounds;
        public NativeArray<float4x4> normalToWorlds;
        public NativeArray<float4x4> lightToWorlds;
        public NativeArray<Color> colors;
        public NativeArray<float4> uvScaleBias;
        public NativeArray<float4> lightParams;
        public NativeArray<float4x4> sizeOffsets;
        public override void RemoveAtSwapBack(int entityIndex)
        {
        }

        public override void SetCapacity(int newCapacity)
        {
        }

        public override void Dispose()
        {
        }

        public CampusDecalLightCachedChunk()
        {
        }
    }
}
