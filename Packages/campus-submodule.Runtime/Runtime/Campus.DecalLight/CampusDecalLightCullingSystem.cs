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
            }
        }

        private CampusDecalLightEntityManager _entityManager;
        private ProfilingSampler _sampler;
        public CampusDecalLightCullingSystem(CampusDecalLightEntityManager entityManager)
        {
        }

        public void Execute(Matrix4x4 vpMatrix)
        {
        }

        private void Execute(CampusDecalLightCachedChunk cachedChunk, CampusDecalLightCulledChunk culledChunk, ref CameraPlanes planes)
        {
        }
    }
}
