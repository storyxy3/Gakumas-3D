namespace Campus.DecalLight
{
    using global::Campus.DecalLight;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.Rendering;

    public class CampusDecalLightCullingSystem
    {
        [BurstCompile]
        private struct CullingJob : IJobParallelFor
        {
            public CameraPlanes planes;
            [ReadOnly]
            public NativeArray<Bounds> bounds;
            [WriteOnly]
            public NativeArray<int> visibleIndices;
            public void Execute(int index)
            {
                visibleIndices[index] = planes.TestAABB(bounds[index]) ? index : -1;
            }
        }

        private CampusDecalLightEntityManager _entityManager;
        private ProfilingSampler _sampler;
        public CampusDecalLightCullingSystem(CampusDecalLightEntityManager entityManager)
        {
            _entityManager = entityManager;
            _sampler = new ProfilingSampler("CampusDecalLight.Cull");
        }

        public void Execute(Matrix4x4 vpMatrix)
        {
            if (_entityManager.combinedChunksList == null) return;
            using (new ProfilingScope(null, _sampler))
            {
                var planes = new CameraPlanes(vpMatrix);
                foreach (var chunks in _entityManager.combinedChunksList)
                    Execute(chunks.CachedChunk, chunks.CulledChunk, ref planes);
            }
        }

        private void Execute(CampusDecalLightCachedChunk cachedChunk, CampusDecalLightCulledChunk culledChunk, ref CameraPlanes planes)
        {
            if (cachedChunk.count == 0) return;
            var job = new CullingJob
            {
                planes = planes,
                bounds = cachedChunk.bounds,
                visibleIndices = culledChunk.visibleIndices
            };
            var handle = job.Schedule(cachedChunk.count, 16, cachedChunk.currentJobHandle);
            culledChunk.currentJobHandle = handle;
            cachedChunk.currentJobHandle = handle;
        }
    }
}
