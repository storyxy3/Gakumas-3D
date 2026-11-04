namespace Campus.DecalLight
{
    using global::Campus.DecalLight;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class CampusDecalLightResultSystem
    {
        [BurstCompile]
        public struct ResultJob : IJob
        {
            public CampusDecalLight.LightShapeType lightType;
            public float3 worldSpaceCameraPos;
            public int count;
            public NativeArray<int> visibleIndices;
            [ReadOnly]
            public NativeArray<float4> lightParams;
            [ReadOnly]
            public NativeArray<Color> colors;
            [ReadOnly]
            public NativeArray<float4> uvScaleBiases;
            [ReadOnly]
            public NativeArray<float4x4> lightToWorlds;
            [ReadOnly]
            public NativeArray<float4x4> normalToWorlds;
            [WriteOnly]
            public NativeArray<float4x4> lightToWorldsDraw;
            [WriteOnly]
            public NativeArray<float4> positionAndAttensDraw;
            [WriteOnly]
            public NativeArray<float4x4> paramsDraw;
            [WriteOnly]
            public NativeArray<float4> colorsDraw;
            [WriteOnly]
            public NativeArray<float4> uvScaleOffsetsDraw;
            [WriteOnly]
            public NativeArray<int> culledCount;
            public void Execute()
            {
                int visibleCount = 0;
                for (int i = 0; i < count; i++)
                {
                    int index = visibleIndices[i];
                    if (index < 0) continue;
                    UpdateParams(index, visibleCount);
                    visibleIndices[visibleCount++] = index;
                }
                culledCount[0] = visibleCount;
            }

            private void UpdateParams(int index, int culledIndex)
            {
                var lightToWorld = lightToWorlds[index];
                lightToWorldsDraw[culledIndex] = lightToWorld;
                var light = lightParams[index];
                var normalToWorld = normalToWorlds[index];
                float radiusSquared = light.x * light.x;
                float attenuation = 1f / (radiusSquared < 0.0001f ? 0.0001f : radiusSquared);
                float3 position = normalToWorld.c3.xyz;
                switch (lightType)
                {
                    case CampusDecalLight.LightShapeType.Box:
                        positionAndAttensDraw[culledIndex] = new float4(position, attenuation);
                        paramsDraw[culledIndex] = new float4x4(
                            new float4(lightToWorld.c0.x, lightToWorld.c2.x * light.z, normalToWorld.c2.x, light.y - 1f),
                            new float4(lightToWorld.c0.y, lightToWorld.c2.y * light.z, normalToWorld.c2.y, light.z - 1f),
                            new float4(lightToWorld.c0.z, lightToWorld.c2.z * light.z, normalToWorld.c2.z, light.y * 0.5f + 0.5f),
                            new float4(light.y, light.z, light.w, light.z * 0.5f + 0.5f));
                        break;
                    case CampusDecalLight.LightShapeType.Capsule:
                        float3 axis = normalToWorld.c0.xyz * light.y;
                        float3 start = position + axis * -0.5f;
                        float inverseLengthSquared;
                        if (light.y < 0.001f)
                        {
                            inverseLengthSquared = 0f;
                            axis = normalToWorld.c0.xyz;
                        }
                        else inverseLengthSquared = 1f / math.lengthsq(axis);
                        positionAndAttensDraw[culledIndex] = new float4(start, attenuation);
                        paramsDraw[culledIndex] = new float4x4(
                            new float4(axis.x, radiusSquared, 0f, 0f),
                            new float4(axis.y, 0f, 0f, 0f),
                            new float4(axis.z, 0f, 0f, 0f),
                            new float4(inverseLengthSquared, light.w, 0f, 0f));
                        break;
                    case CampusDecalLight.LightShapeType.Sphere:
                        positionAndAttensDraw[culledIndex] = new float4(position, attenuation);
                        paramsDraw[culledIndex] = new float4x4(
                            new float4(radiusSquared, 0f, 0f, 0f), new float4(0f), new float4(0f), new float4(light.w, 0f, 0f, 0f));
                        break;
                }
                Color color = colors[index];
                colorsDraw[culledIndex] = new float4(color.r, color.g, color.b, color.a);
                uvScaleOffsetsDraw[culledIndex] = uvScaleBiases[index];
            }
        }

        private CampusDecalLightEntityManager _entityManager;
        private CampusDecalLightDrawSystem _drawSystem;
        private ProfilingSampler _sampler;
        public CampusDecalLightResultSystem(CampusDecalLightEntityManager entityManager, CampusDecalLightDrawSystem drawSystem)
        {
            _entityManager = entityManager;
            _drawSystem = drawSystem;
            _sampler = new ProfilingSampler("CampusDecalLight.Result");
        }

        public void Execute(Vector3 cameraPosition, Matrix4x4 viewMatrix)
        {
            using (new ProfilingScope(null, _sampler))
            {
                if (_entityManager.combinedChunksList != null)
                {
                    foreach (var chunks in _entityManager.combinedChunksList)
                    {
                        if (chunks != null)
                            Execute(chunks.CachedChunk, chunks.CulledChunk, chunks.ResultChunk,
                                (CampusDecalLight.LightShapeType)chunks.entityChunk.chunkKey, cameraPosition);
                    }
                }
            }
            _drawSystem.isSystemExecuted = true;
        }

        private void Execute(CampusDecalLightCachedChunk cachedChunk, CampusDecalLightCulledChunk culledChunk, CampusDecalLightResultChunk resultChunk, CampusDecalLight.LightShapeType lightType, Vector3 cameraPosition)
        {
            if (cachedChunk.count == 0) return;
            var job = new ResultJob
            {
                lightType = lightType,
                worldSpaceCameraPos = cameraPosition,
                count = cachedChunk.count,
                visibleIndices = culledChunk.visibleIndices,
                lightParams = cachedChunk.lightParams,
                colors = cachedChunk.colors,
                uvScaleBiases = cachedChunk.uvScaleBias,
                lightToWorlds = cachedChunk.lightToWorlds,
                normalToWorlds = cachedChunk.normalToWorlds,
                lightToWorldsDraw = resultChunk.lightToWorldsDraw,
                positionAndAttensDraw = resultChunk.positionAndAttensDraw,
                paramsDraw = resultChunk.paramsDraw,
                colorsDraw = resultChunk.colorsDraw,
                uvScaleOffsetsDraw = resultChunk.uvScaleOffsetsDraw,
                culledCount = culledChunk.culledCount
            };
            var handle = job.Schedule(culledChunk.currentJobHandle);
            cachedChunk.currentJobHandle = handle;
            culledChunk.currentJobHandle = handle;
            resultChunk.currentJobHandle = handle;
        }
    }
}
