namespace Campus.DecalLight
{
    using global::Campus.DecalLight;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::VL.Rendering;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;
    using global::UnityEngine.Rendering;

    public class CampusDecalLightUpdateSystem
    {
        [BurstCompile]
        private struct UpdateJob : IJobParallelForTransform
        {
            private static readonly quaternion MinusYtoZRotation = quaternion.EulerXYZ(new float3(-90f, 0f, 0f) * 0.017453292f);
            [ReadOnly]
            public NativeArray<float4x4> sizeOffsets;
            [WriteOnly]
            public NativeArray<float3> positions;
            [WriteOnly]
            public NativeArray<quaternion> rotations;
            [WriteOnly]
            public NativeArray<Bounds> bounds;
            [WriteOnly]
            public NativeArray<float4x4> normalToWorlds;
            [WriteOnly]
            public NativeArray<float4x4> lightToWorlds;
            public void Execute(int index, TransformAccess transform)
            {
                if (!transform.isValid) return;
                float3 position = transform.position;
                quaternion rotation = math.mul((quaternion)transform.rotation, MinusYtoZRotation);
                var normalToWorld = new float4x4(new float3x3(rotation), position);
                positions[index] = position;
                rotations[index] = rotation;
                normalToWorlds[index] = normalToWorld;
                var lightToWorld = math.mul(normalToWorld, sizeOffsets[index]);
                lightToWorlds[index] = lightToWorld;
                bounds[index] = AABBUtility.TransformAABB(new Bounds(Vector3.zero, Vector3.one), lightToWorld);
            }
        }

        private CampusDecalLightEntityManager _entityManager;
        private ProfilingSampler _sampler;
        private ProfilingSampler _samplerJob;
        public CampusDecalLightUpdateSystem(CampusDecalLightEntityManager entityManager)
        {
            _entityManager = entityManager;
            _sampler = new ProfilingSampler("CampusDecalLight.Update");
            _samplerJob = new ProfilingSampler("CampusDecalLight.UpdateJob");
        }

        public void Execute()
        {
            if (_entityManager.combinedChunksList == null) return;
            using (new ProfilingScope(null, _sampler))
            {
                foreach (var chunks in _entityManager.combinedChunksList)
                    Execute(chunks.entityChunk, chunks.CachedChunk);
            }
        }

        private void Execute(CampusDecalLightEntityChunk entityChunk, CampusDecalLightCachedChunk cachedChunk)
        {
            if (entityChunk.count == 0) return;
            cachedChunk.currentJobHandle.Complete();
            using (new ProfilingScope(null, _samplerJob))
            {
                var job = new UpdateJob
                {
                    positions = cachedChunk.positions,
                    rotations = cachedChunk.rotations,
                    sizeOffsets = cachedChunk.sizeOffsets,
                    bounds = cachedChunk.bounds,
                    normalToWorlds = cachedChunk.normalToWorlds,
                    lightToWorlds = cachedChunk.lightToWorlds
                };
                cachedChunk.currentJobHandle = job.ScheduleReadOnly(entityChunk.transformAccessArray, 16);
            }
        }
    }
}
