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
        }

        public override void SetCapacity(int newCapacity)
        {
        }

        public override void Dispose()
        {
        }

        public VLBCachedChunk()
        {
        }
    }
}
