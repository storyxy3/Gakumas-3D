namespace VLB
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;
    using global::UnityEngine.Profiling;
    using global::VLB;

    public class VLBUpdateCachedSystem
    {
        [BurstCompile]
        public struct UpdateTransformsJob : IJobParallelForTransform
        {
            [ReadOnly]
            public NativeArray<quaternion> rotations;
            [ReadOnly]
            public NativeArray<float3> scales;
            [WriteOnly]
            public NativeArray<float4x4> localToWorlds;
            [WriteOnly]
            public NativeArray<float4x4> geometryLocalToWorlds;
            [WriteOnly]
            public NativeArray<Bounds> bounds;
            public void Execute(int index, TransformAccess transform)
            {
            }
        }

        private VLBEntityManager _entityManager;
        private CustomSampler _sampler;
        public VLBUpdateCachedSystem(VLBEntityManager entityManager)
        {
        }

        public void Execute(Camera camera)
        {
        }

        private void Execute(VLBEntityChunk entityChunk, VLBCachedChunk cachedChunk, int count)
        {
        }
    }
}
