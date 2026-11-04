namespace Campus.DecalLight
{
    using global::Unity.Collections;
    using global::UnityEngine.Rendering;
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
            RemoveAtSwapBack(ref positions, entityIndex, count);
            RemoveAtSwapBack(ref rotations, entityIndex, count);
            RemoveAtSwapBack(ref bounds, entityIndex, count);
            RemoveAtSwapBack(ref normalToWorlds, entityIndex, count);
            RemoveAtSwapBack(ref lightToWorlds, entityIndex, count);
            RemoveAtSwapBack(ref colors, entityIndex, count);
            RemoveAtSwapBack(ref uvScaleBias, entityIndex, count);
            RemoveAtSwapBack(ref lightParams, entityIndex, count);
            RemoveAtSwapBack(ref sizeOffsets, entityIndex, count);
            count--;
        }

        public override void SetCapacity(int newCapacity)
        {
            ArrayExtensions.ResizeArray(ref positions, newCapacity);
            ArrayExtensions.ResizeArray(ref rotations, newCapacity);
            ArrayExtensions.ResizeArray(ref bounds, newCapacity);
            ArrayExtensions.ResizeArray(ref normalToWorlds, newCapacity);
            ArrayExtensions.ResizeArray(ref lightToWorlds, newCapacity);
            ArrayExtensions.ResizeArray(ref colors, newCapacity);
            ArrayExtensions.ResizeArray(ref uvScaleBias, newCapacity);
            ArrayExtensions.ResizeArray(ref lightParams, newCapacity);
            ArrayExtensions.ResizeArray(ref sizeOffsets, newCapacity);
            capacity = newCapacity;
        }

        public override void Dispose()
        {
            if (capacity == 0) return;
            positions.Dispose();
            rotations.Dispose();
            bounds.Dispose();
            normalToWorlds.Dispose();
            lightToWorlds.Dispose();
            colors.Dispose();
            uvScaleBias.Dispose();
            lightParams.Dispose();
            sizeOffsets.Dispose();
            count = 0;
            capacity = 0;
        }

        public CampusDecalLightCachedChunk()
        {
        }
    }
}
