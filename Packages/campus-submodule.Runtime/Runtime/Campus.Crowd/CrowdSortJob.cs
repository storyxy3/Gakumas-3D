namespace Campus.Crowd
{
    using global::Campus.Crowd;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::VL.Rendering;

    [BurstCompile]
    public struct CrowdSortJob : IJob
    {
        public NativeArray<CellSortData> Cells;
        [ReadOnly]
        public NativeArray<PersonInfo> PersonInfos;
        public NativeArray<uint> PersonIndexes;
        public NativeArray<int> InstanceCountsPerSubMesh;
        public NativeReference<int> BillboardInstanceCount;
        public CameraPlanes Planes;
        public Vector4 BoundingSphere;
        public float3 OcclusionSphereCenter;
        public float OcclusionSphereRadius;
        public int MaxInstanceCountsPerSubMesh;
        public void Execute()
        {
        }

        private bool IsCulledBoundingSphere(float3 position)
        {
            return default(bool);
        }

        private bool IsCulledOcclusionSphere(float3 position)
        {
            return default(bool);
        }
    }
}
