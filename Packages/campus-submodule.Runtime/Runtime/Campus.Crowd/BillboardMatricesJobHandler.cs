namespace Campus.Crowd
{
    using global::Campus.Crowd;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::UnityEngine;

    public static class BillboardMatricesJobHandler
    {
        [BurstCompile]
        private struct BillboardMatricesJob : IJobParallelFor
        {
            [ReadOnly]
            public NativeArray<Matrix4x4> RotateMatrices;
            [ReadOnly]
            public NativeArray<Bounds> Bounds;
            [WriteOnly]
            public NativeArray<Matrix4x4> ObjToWorldMatrices;
            [WriteOnly]
            public NativeArray<Matrix4x4> BillboardMatrices;
            public void Execute(int index)
            {
            if (index > 31) return;
            int subMeshIndex = index / 4;
            int forwardIndex = index % 4;
            var bounds = Bounds[index / 32];
            bounds.SetMinMax(bounds.min - Vector3.one * 0.1f, bounds.max);
            bounds.SetMinMax(bounds.min, bounds.max + Vector3.one * 0.1f);
            var rotation = RotateMatrices[forwardIndex];
            var rotatedBounds = global::VL.AABB.AABBUtility.TransformAABB(bounds, rotation);
            ObjToWorldMatrices[index] = CalculateObjToWorldMatrix(subMeshIndex, forwardIndex, rotation, rotatedBounds);
            BillboardMatrices[index] = CalculateBillboardMatrix(rotatedBounds);
        }

            private Matrix4x4 CalculateObjToWorldMatrix(int sumMeshIndex, int forwardIndex, Matrix4x4 rotateMatrix, Bounds rotatedBounds)
            {
            float scaleX = 1f / (rotatedBounds.size.x * 32f);
            float scaleY = 1f / rotatedBounds.size.y;
            var position = new Vector3(sumMeshIndex / 8f + (forwardIndex + 0.5f) / 32f - rotatedBounds.center.x * scaleX - 0.5f,
                -rotatedBounds.center.y * scaleY, 0f);
            return Matrix4x4.TRS(position, Quaternion.identity, new Vector3(scaleX, scaleY, scaleX)) * rotateMatrix;
        }

            private Matrix4x4 CalculateBillboardMatrix(Bounds rotatedBounds)
            {
            return Matrix4x4.TRS(new Vector3(-rotatedBounds.center.x, rotatedBounds.center.y, 0f), Quaternion.identity,
                new Vector3(rotatedBounds.size.x, rotatedBounds.size.y, 1f));
        }
        }

        public static JobHandle Schedule(ICrowdAnimation animation, BillboardMeshRenderSystem billboardMeshRenderSystem)
        {
            if (animation == null || !animation.Bounds.IsCreated) return default;
            if (!billboardMeshRenderSystem.BillboardRotateMatrices.IsCreated || !billboardMeshRenderSystem.ObjToWorldMatrices.IsCreated || !billboardMeshRenderSystem.BillboardMatrices.IsCreated) return default;
            return new BillboardMatricesJob
            {
                RotateMatrices = billboardMeshRenderSystem.BillboardRotateMatrices,
                Bounds = animation.Bounds,
                ObjToWorldMatrices = billboardMeshRenderSystem.ObjToWorldMatrices,
                BillboardMatrices = billboardMeshRenderSystem.BillboardMatrices
            }.Schedule(32, 4);
        }
    }
}
