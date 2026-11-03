namespace Campus.Crowd
{
    using global::Campus.Crowd;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::UnityEngine;
    using global::VL.Rendering;

    [BurstCompile]
    public struct CrowdCullJob : IJobParallelFor
    {
        [ReadOnly]
        public NativeArray<OctreeInfo> OctreeInfos;
        [WriteOnly]
        public NativeList<CellSortData>.ParallelWriter Cells;
        public CameraPlanes Planes;
        public Bounds Bounds;
        public Vector4 BoundingSphere;
        public Vector3 CameraPos;
        public void Execute(int index)
        {
        }
    }
}
