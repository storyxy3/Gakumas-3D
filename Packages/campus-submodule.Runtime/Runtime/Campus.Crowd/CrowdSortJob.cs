namespace Campus.Crowd
{
    using global::Campus.Crowd;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Collections.LowLevel.Unsafe;
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
            if (!Cells.IsCreated || Cells.Length < 1) return;
            Cells.Sort(new CellSortDataComparer());
            var subMeshes = new NativeArray<UnsafeList<uint>>(8, Allocator.Temp);
            for (int i = 0; i < 8; i++)
            {
                subMeshes[i] = new UnsafeList<uint>(MaxInstanceCountsPerSubMesh, Allocator.Temp);
                InstanceCountsPerSubMesh[i] = 0;
            }
            var billboards = new UnsafeList<uint>(PersonInfos.Length - 8 * MaxInstanceCountsPerSubMesh, Allocator.Temp);
            unsafe
            {
                var lists = (UnsafeList<uint>*)subMeshes.GetUnsafePtr();
                for (int cellIndex = 0; cellIndex < Cells.Length; cellIndex++)
                {
                    var cell = Cells[cellIndex];
                    int end = cell.personIndexOffset + cell.personInfoLength;
                    for (ushort personIndex = cell.personIndexOffset; personIndex < end; personIndex++)
                    {
                        var person = PersonInfos[personIndex];
                        if ((person.flags & 1) == 0 || IsCulledBoundingSphere(person.position) || IsCulledOcclusionSphere(person.position)) continue;
                        ref var list = ref lists[(person.flags >> 20) & 7];
                        if (list.Length < MaxInstanceCountsPerSubMesh) list.Add(personIndex);
                        else billboards.Add(personIndex);
                    }
                }
                var destination = (uint*)PersonIndexes.GetUnsafePtr();
                for (int i = 0; i < subMeshes.Length; i++)
                {
                    int count = lists[i].Length;
                    InstanceCountsPerSubMesh[i] = count;
                    UnsafeUtility.MemCpy(destination, lists[i].Ptr, count * sizeof(uint));
                    lists[i].Dispose();
                    destination += count;
                }
                subMeshes.Dispose();
                BillboardInstanceCount.Value = billboards.Length;
                UnsafeUtility.MemCpy(destination, billboards.Ptr, BillboardInstanceCount.Value * sizeof(uint));
            }
            billboards.Dispose();
        }

        private bool IsCulledBoundingSphere(float3 position)
        {
            return Planes.TestBoundingSphere(new float4(position + new float3(BoundingSphere.x, BoundingSphere.y, BoundingSphere.z), BoundingSphere.w));
        }

        private bool IsCulledOcclusionSphere(float3 position)
        {
            return OcclusionSphereRadius > 0f && math.lengthsq(OcclusionSphereCenter - position) <= OcclusionSphereRadius * OcclusionSphereRadius;
        }
    }
}
