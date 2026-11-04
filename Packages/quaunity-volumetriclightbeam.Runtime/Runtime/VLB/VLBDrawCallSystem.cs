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
            int instanceIndex = 0;
            int batchStart = 0;
            int batchCount = 0;
            for (int i = 0; i < visibleIndices.Length; i++)
            {
                int index = visibleIndices[i];
                Bounds bound = bounds[index];
                float distance = math.distance(cameraPosition, bound.center);
                float3 extents = bound.extents;
                if (distance <= math.cmax(extents) + 1000f)
                {
                    localToWorldsDraw[instanceIndex] = geometryLocalToWorlds[index];
                    UpdateParams(instanceIndex, index);
                    instanceIndexToVisibleIndex[instanceIndex] = index;
                    instanceIndex++;
                    if (instanceIndex - batchStart >= 200)
                    {
                        subCalls[batchCount++] = new SubDrawCall { start = batchStart, end = instanceIndex };
                        batchStart = instanceIndex;
                    }
                }
            }
            if (instanceIndex != batchStart) subCalls[batchCount++] = new SubDrawCall { start = batchStart, end = instanceIndex };
            subCallCount[0] = batchCount;
        }

            public float GetInsideBeamFactorFromObjectSpacePos(float3 posOS, float coneApexOffsetZ, float coneAngle)
            {
            if (posOS.z < 0f) return -1f;
            float radialDistance = math.sqrt(posOS.x * posOS.x + posOS.y * posOS.y);
            float distance = posOS.z + coneApexOffsetZ;
            float normalizedRadius = radialDistance / math.sqrt(distance * distance + radialDistance * radialDistance);
            float halfAngle = coneAngle * 0.017453292f * 0.5f;
            return math.clamp((math.abs(math.sin(halfAngle)) - math.abs(normalizedRadius)) / 0.1f, -1f, 1f);
        }

            private void UpdateParams(int instanceIndex, int visibleIndex)
            {
            Color color = colors[visibleIndex];
            colorsDraw[instanceIndex] = new float4(Mathf.GammaToLinearSpace(color.r), Mathf.GammaToLinearSpace(color.g), Mathf.GammaToLinearSpace(color.b), color.a);
            float4x4 inverse = math.inverse(localToWorlds[visibleIndex]);
            float inside = orthographic ? -1f : GetInsideBeamFactorFromObjectSpacePos(math.transform(inverse, cameraPosition), coneApexOffsetZ[visibleIndex], coneAngle[visibleIndex]);
            cameraParamsDraw[instanceIndex] = new float4(math.normalize(math.transform(inverse, cameraForward)), inside);
            float2 radiuses = coneRadiuses[visibleIndex];
            float2 glare = glares[visibleIndex];
            float4 falloff = fallOff[visibleIndex];
            float4 velocity = noiseVelocity[visibleIndex];
            float2 noiseParams = noiseParameter[visibleIndex];
            float seed = noise.snoise(geometryLocalToWorlds[visibleIndex].c3.xyz);
            params0Draw[instanceIndex] = new float4x4(
                new float4(math.max(radiuses.x, 0.0001f), falloff.x, velocity.x, noiseParams.x),
                new float4(math.max(radiuses.y, 0.0001f), falloff.y, velocity.y, noiseParams.y),
                new float4(glare.x, falloff.z, velocity.z, 0f),
                new float4(glare.y, falloff.w, velocity.w, seed));
            float apex = coneApexOffsetZ[visibleIndex];
            float safeApex = math.max(math.abs(apex), 0.0001f);
            if (apex < 0f) safeApex = -safeApex;
            float halfAngle = coneAngle[visibleIndex] * 0.017453292f * 0.5f;
            float2 intensities = intensity[visibleIndex];
            params1Draw[instanceIndex] = new float4x4(
                new float4(safeApex, intensities.x, 0f, 0f),
                new float4(0f, intensities.y, 0f, 0f),
                new float4(math.cos(halfAngle), cameraClippingDistance[visibleIndex], 0f, 0f),
                new float4(math.sin(halfAngle), math.max(fresnelPow[visibleIndex], 0.001f), depthBlendDistance[visibleIndex], 0f));
        }
        }

        private VLBEntityManager _entityManager;
        private VLBDrawSystem _drawSystem;
        private CustomSampler _sampler;
        public VLBDrawCallSystem(VLBEntityManager entityManager, VLBDrawSystem drawSystem)
        {
            _entityManager = entityManager;
            _drawSystem = drawSystem;
            _sampler = CustomSampler.Create("VLBCreateDrawCallSystem.Execute");
        }

        public void Execute()
        {
            for (int i = 0; i < _entityManager.chunkCount; i++)
                Execute(_entityManager.cachedChunks[i], _entityManager.culledChunks[i], _entityManager.drawCallChunks[i], _entityManager.cachedChunks[i].count);
            _drawSystem.isDrawCallSystemExecuted = true;
        }

        private void Execute(VLBCachedChunk cachedChunk, VLBCulledChunk culledChunk, VLBDrawCallChunk drawCallChunk, int count)
        {
            if (count == 0) return;
            var job = new DrawCallJob
            {
                localToWorlds = cachedChunk.localToWorlds, geometryLocalToWorlds = cachedChunk.geometryLocalToWorlds,
                colors = cachedChunk.colors, coneRadiuses = cachedChunk.coneRadiuses, glares = cachedChunk.glares,
                fallOff = cachedChunk.fallOff, noiseVelocity = cachedChunk.noiseVelocity, noiseParameter = cachedChunk.noiseParameter,
                entityIndex = cachedChunk.entityIndex, coneApexOffsetZ = cachedChunk.coneApexOffsetZ, coneAngle = cachedChunk.coneAngle,
                intensity = cachedChunk.intensity, cameraClippingDistance = cachedChunk.cameraClippingDistance,
                fresnelPow = cachedChunk.fresnelPow, depthBlendDistance = cachedChunk.depthBlendDistance, shadowIntensity = cachedChunk.shadowIntensity,
                bounds = cachedChunk.bounds, cameraPosition = culledChunk.cameraPosition, cameraForward = cachedChunk.cameraForward,
                orthographic = cachedChunk.orthographic, visibleIndices = culledChunk.visibleIndices.AsDeferredJobArray(),
                localToWorldsDraw = drawCallChunk.localToWorlds, colorsDraw = drawCallChunk.colors, cameraParamsDraw = drawCallChunk.cameraParams,
                params0Draw = drawCallChunk.params0, params1Draw = drawCallChunk.params1, subCalls = drawCallChunk.subCalls,
                subCallCount = drawCallChunk.subCallCounts, instanceIndexToVisibleIndex = drawCallChunk.instanceIndexToVisibleIndex
            };
            var handle = job.Schedule(cachedChunk.currentJobHandle);
            drawCallChunk.currentJobHandle = handle;
            cachedChunk.currentJobHandle = handle;
        }
    }
}
