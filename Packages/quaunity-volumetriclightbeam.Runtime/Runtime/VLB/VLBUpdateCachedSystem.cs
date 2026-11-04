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
            float4x4 localToWorld = transform.localToWorldMatrix;
            float4x4 geometryLocalToWorld = math.mul(localToWorld, float4x4.TRS(float3.zero, rotations[index], scales[index]));
            localToWorlds[index] = localToWorld;
            geometryLocalToWorlds[index] = geometryLocalToWorld;
            bounds[index] = Utils.TransformAABB(new Bounds(new Vector3(0f, 0f, 0.5f), new Vector3(2f, 2f, 1f)), geometryLocalToWorld);
        }
        }

        private VLBEntityManager _entityManager;
        private CustomSampler _sampler;
        public VLBUpdateCachedSystem(VLBEntityManager entityManager)
        {
            _entityManager = entityManager;
            _sampler = CustomSampler.Create("UpdateCachedSystem.Execute");
        }

        public void Execute(Camera camera)
        {
            Vector3 forward = camera.transform.forward;
            bool orthographic = camera.orthographic;
            for (int i = 0; i < _entityManager.chunkCount; i++)
            {
                _entityManager.cachedChunks[i].cameraForward = forward;
                _entityManager.cachedChunks[i].orthographic = orthographic;
                Execute(_entityManager.entityChunks[i], _entityManager.cachedChunks[i], _entityManager.entityChunks[i].count);
            }
        }

        private void Execute(VLBEntityChunk entityChunk, VLBCachedChunk cachedChunk, int count)
        {
            if (count == 0) return;
            cachedChunk.currentJobHandle.Complete();
            if (!cachedChunk.isCreated) cachedChunk.isCreated = true;
            var job = new UpdateTransformsJob
            {
                rotations = cachedChunk.rotations, scales = cachedChunk.scales,
                localToWorlds = cachedChunk.localToWorlds, geometryLocalToWorlds = cachedChunk.geometryLocalToWorlds,
                bounds = cachedChunk.bounds
            };
            cachedChunk.currentJobHandle = job.ScheduleReadOnly(entityChunk.transformAccessArray, 16);
        }
    }
}
