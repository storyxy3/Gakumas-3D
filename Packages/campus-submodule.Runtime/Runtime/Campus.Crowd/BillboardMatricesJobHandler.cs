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
            }

            private Matrix4x4 CalculateObjToWorldMatrix(int sumMeshIndex, int forwardIndex, Matrix4x4 rotateMatrix, Bounds rotatedBounds)
            {
                return default(Matrix4x4);
            }

            private Matrix4x4 CalculateBillboardMatrix(Bounds rotatedBounds)
            {
                return default(Matrix4x4);
            }
        }

        public static JobHandle Schedule(ICrowdAnimation animation, BillboardMeshRenderSystem billboardMeshRenderSystem)
        {
            return default(JobHandle);
        }
    }
}
