namespace VLB
{
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::VLB;

    internal class VLBCachedChunk : Chunk
    {
        public MaterialPropertyBlock propertyBlock;
        public bool isCreated;
        public float3 cameraForward;
        public bool orthographic;
        public NativeArray<float4x4> localToWorlds;
        public NativeArray<float4x4> geometryLocalToWorlds;
        public NativeArray<Bounds> bounds;
        public NativeArray<bool> enableds;
        public NativeArray<Color> colors;
        public NativeArray<float2> coneRadiuses;
        public NativeArray<float2> glares;
        public NativeArray<float4> fallOff;
        public NativeArray<float4> noiseVelocity;
        public NativeArray<float2> noiseParameter;
        public NativeArray<int> entityIndex;
        public NativeArray<float> coneApexOffsetZ;
        public NativeArray<float> coneAngle;
        public NativeArray<float2> intensity;
        public NativeArray<float> cameraClippingDistance;
        public NativeArray<float> fresnelPow;
        public NativeArray<float> depthBlendDistance;
        public NativeArray<float> shadowIntensity;
        public NativeArray<quaternion> rotations;
        public NativeArray<float3> scales;
        public override void RemoveAtSwapBack(int index)
        {
            RemoveAtSwapBack(ref localToWorlds, index, count);
            RemoveAtSwapBack(ref geometryLocalToWorlds, index, count);
            RemoveAtSwapBack(ref bounds, index, count);
            RemoveAtSwapBack(ref enableds, index, count);
            RemoveAtSwapBack(ref colors, index, count);
            RemoveAtSwapBack(ref coneRadiuses, index, count);
            RemoveAtSwapBack(ref glares, index, count);
            RemoveAtSwapBack(ref fallOff, index, count);
            RemoveAtSwapBack(ref noiseVelocity, index, count);
            RemoveAtSwapBack(ref noiseParameter, index, count);
            RemoveAtSwapBack(ref entityIndex, index, count);
            RemoveAtSwapBack(ref coneApexOffsetZ, index, count);
            RemoveAtSwapBack(ref coneAngle, index, count);
            RemoveAtSwapBack(ref intensity, index, count);
            RemoveAtSwapBack(ref cameraClippingDistance, index, count);
            RemoveAtSwapBack(ref fresnelPow, index, count);
            RemoveAtSwapBack(ref depthBlendDistance, index, count);
            RemoveAtSwapBack(ref shadowIntensity, index, count);
            RemoveAtSwapBack(ref rotations, index, count);
            RemoveAtSwapBack(ref scales, index, count);
            count--;
        }

        public override void SetCapacity(int newCapacity)
        {
            ResizeArray(ref localToWorlds, newCapacity);
            ResizeArray(ref geometryLocalToWorlds, newCapacity);
            ResizeArray(ref bounds, newCapacity);
            ResizeArray(ref enableds, newCapacity);
            ResizeArray(ref colors, newCapacity);
            ResizeArray(ref coneRadiuses, newCapacity);
            ResizeArray(ref glares, newCapacity);
            ResizeArray(ref fallOff, newCapacity);
            ResizeArray(ref noiseVelocity, newCapacity);
            ResizeArray(ref noiseParameter, newCapacity);
            ResizeArray(ref entityIndex, newCapacity);
            ResizeArray(ref coneApexOffsetZ, newCapacity);
            ResizeArray(ref coneAngle, newCapacity);
            ResizeArray(ref intensity, newCapacity);
            ResizeArray(ref cameraClippingDistance, newCapacity);
            ResizeArray(ref fresnelPow, newCapacity);
            ResizeArray(ref depthBlendDistance, newCapacity);
            ResizeArray(ref shadowIntensity, newCapacity);
            ResizeArray(ref rotations, newCapacity);
            ResizeArray(ref scales, newCapacity);
            capacity = newCapacity;
        }

        public override void Dispose()
        {
            if (capacity == 0) return;
            localToWorlds.Dispose();
            geometryLocalToWorlds.Dispose();
            bounds.Dispose();
            enableds.Dispose();
            colors.Dispose();
            coneRadiuses.Dispose();
            glares.Dispose();
            fallOff.Dispose();
            noiseVelocity.Dispose();
            noiseParameter.Dispose();
            entityIndex.Dispose();
            coneApexOffsetZ.Dispose();
            coneAngle.Dispose();
            intensity.Dispose();
            cameraClippingDistance.Dispose();
            fresnelPow.Dispose();
            depthBlendDistance.Dispose();
            shadowIntensity.Dispose();
            rotations.Dispose();
            scales.Dispose();
            count = capacity = 0;
        }

        public VLBCachedChunk()
        {
        }
    }
}
