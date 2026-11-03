namespace VLB
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Profiling;
    using global::VLB;

    public class VLBDrawCallSystem
    {
        [BurstCompile]
        private struct DrawCallJob : IJob
        {
            [ReadOnly]
            public NativeArray<float4x4> localToWorlds;
            [ReadOnly]
            public NativeArray<float4x4> geometryLocalToWorlds;
            [ReadOnly]
            public NativeArray<Color> colors;
            [ReadOnly]
            public NativeArray<float2> coneRadiuses;
            [ReadOnly]
            public NativeArray<float2> glares;
            [ReadOnly]
            public NativeArray<float4> fallOff;
            [ReadOnly]
            public NativeArray<float4> noiseVelocity;
            [ReadOnly]
            public NativeArray<float2> noiseParameter;
            [ReadOnly]
            public NativeArray<int> entityIndex;
            [ReadOnly]
            public NativeArray<float> coneApexOffsetZ;
            [ReadOnly]
            public NativeArray<float> coneAngle;
            [ReadOnly]
            public NativeArray<float2> intensity;
            [ReadOnly]
            public NativeArray<float> cameraClippingDistance;
            [ReadOnly]
            public NativeArray<float> fresnelPow;
            [ReadOnly]
            public NativeArray<float> depthBlendDistance;
            [ReadOnly]
            public NativeArray<float> shadowIntensity;
            [ReadOnly]
            public NativeArray<Bounds> bounds;
            public float3 cameraPosition;
            public float3 cameraForward;
            public bool orthographic;
            [ReadOnly]
            public NativeArray<int> visibleIndices;
            [WriteOnly]
            public NativeArray<float4x4> localToWorldsDraw;
            [WriteOnly]
            public NativeArray<float4> colorsDraw;
            [WriteOnly]
            public NativeArray<float4> cameraParamsDraw;
            [WriteOnly]
            public NativeArray<float4x4> params0Draw;
            [WriteOnly]
            public NativeArray<float4x4> params1Draw;
            [WriteOnly]
            public NativeArray<SubDrawCall> subCalls;
            [WriteOnly]
            public NativeArray<int> subCallCount;
            [WriteOnly]
            public NativeArray<int> instanceIndexToVisibleIndex;
            public void Execute()
            {
            }

            public float GetInsideBeamFactorFromObjectSpacePos(float3 posOS, float coneApexOffsetZ, float coneAngle)
            {
                return default(float);
            }

            private void UpdateParams(int instanceIndex, int visibleIndex)
            {
            }
        }

        private VLBEntityManager _entityManager;
        private VLBDrawSystem _drawSystem;
        private CustomSampler _sampler;
        public VLBDrawCallSystem(VLBEntityManager entityManager, VLBDrawSystem drawSystem)
        {
        }

        public void Execute()
        {
        }

        private void Execute(VLBCachedChunk cachedChunk, VLBCulledChunk culledChunk, VLBDrawCallChunk drawCallChunk, int count)
        {
        }
    }
}
