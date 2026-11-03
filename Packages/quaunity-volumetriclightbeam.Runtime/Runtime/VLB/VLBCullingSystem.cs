namespace VLB
{
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Profiling;
    using global::VLB;

    public class VLBCullingSystem
    {
        private VLBEntityManager _entityManager;
        private CustomSampler _sampler;
        public VLBCullingSystem(VLBEntityManager entityManager)
        {
        }

        public void Execute(float3 cameraPosition, Matrix4x4 vpMatrix)
        {
        }

        private void Execute(VLBCachedChunk cachedChunk, VLBCulledChunk culledChunk, int count)
        {
        }
    }
}
