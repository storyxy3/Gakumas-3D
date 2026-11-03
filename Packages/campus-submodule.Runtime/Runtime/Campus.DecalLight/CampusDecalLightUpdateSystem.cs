namespace Campus.DecalLight
{
    using global::Campus.DecalLight;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;
    using global::UnityEngine.Rendering;

    public class CampusDecalLightUpdateSystem
    {
        [BurstCompile]
        private struct UpdateJob : IJobParallelForTransform
        {
            private static readonly quaternion MinusYtoZRotation;
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
            }
        }

        private CampusDecalLightEntityManager _entityManager;
        private ProfilingSampler _sampler;
        private ProfilingSampler _samplerJob;
        public CampusDecalLightUpdateSystem(CampusDecalLightEntityManager entityManager)
        {
        }

        public void Execute()
        {
        }

        private void Execute(CampusDecalLightEntityChunk entityChunk, CampusDecalLightCachedChunk cachedChunk)
        {
        }
    }
}
