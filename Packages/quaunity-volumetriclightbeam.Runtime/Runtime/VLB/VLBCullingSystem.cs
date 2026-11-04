namespace VLB
{
    using global::Unity.Mathematics;
    using global::Unity.Jobs;
    using global::UnityEngine;
    using global::UnityEngine.Profiling;
    using global::VLB;

    public class VLBCullingSystem
    {
        private VLBEntityManager _entityManager;
        private CustomSampler _sampler;
        public VLBCullingSystem(VLBEntityManager entityManager)
        {
            _entityManager = entityManager;
            _sampler = CustomSampler.Create("VLBCullingSystem.Execute");
        }

        public void Execute(float3 cameraPosition, Matrix4x4 vpMatrix)
        {
            for (int i = 0; i < _entityManager.chunkCount; i++)
            {
                _entityManager.culledChunks[i].cameraPosition = cameraPosition;
                Utils.CalcCullingPlane(_entityManager.culledChunks[i].planes, vpMatrix);
                Execute(_entityManager.cachedChunks[i], _entityManager.culledChunks[i], _entityManager.culledChunks[i].count);
            }
        }

        private void Execute(VLBCachedChunk cachedChunk, VLBCulledChunk culledChunk, int count)
        {
            var initialize = new InitializeCullJob { visibleIndices = culledChunk.visibleIndices };
            var cull = new CullingJob
            {
                planes = culledChunk.planes, enables = cachedChunk.enableds, bounds = cachedChunk.bounds,
                visibleIndices = culledChunk.visibleIndices.AsParallelWriter()
            };
            var handle = cull.Schedule(cachedChunk.count, 16, initialize.Schedule(cachedChunk.currentJobHandle));
            culledChunk.currentJobHandle = handle;
            cachedChunk.currentJobHandle = handle;
        }
    }
}
