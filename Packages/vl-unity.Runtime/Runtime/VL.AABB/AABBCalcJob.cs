namespace VL.AABB
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::VL.AABB;

    [BurstCompile]
    public struct AABBCalcJob : IJobFor
    {
        [ReadOnly]
        public NativeArray<Vector3> positions;
        [ReadOnly]
        public NativeArray<AABBData> aabbs;
        [ReadOnly]
        public NativeArray<float4x4> localToWorlds;
        [WriteOnly]
        public NativeArray<Bounds> localBounds;
        [WriteOnly]
        public NativeArray<Bounds> bounds;
        public void Execute(int index)
        {
            var data = aabbs[index];
            Bounds worldBounds = AABBUtility.MinBounds;
            if (data.aabbCalcType == VLActorAABBCalcType.None) return;
            float4x4 matrix = localToWorlds[index];
            if ((data.aabbCalcType & VLActorAABBCalcType.Local) != 0)
                worldBounds.Encapsulate(AABBUtility.TransformAABB(data.defaultBounds, matrix));
            if ((data.aabbCalcType & VLActorAABBCalcType.Bone) != 0)
                for (int i = 0; i < data.positionLength; ++i)
                    worldBounds.Encapsulate(positions[data.positionIndex + i]);
            if (Mathf.Approximately(matrix.c0.x, 0) || Mathf.Approximately(matrix.c1.y, 0) || Mathf.Approximately(matrix.c2.z, 0))
                localBounds[index] = worldBounds;
            else
                localBounds[index] = AABBUtility.TransformAABB(worldBounds, math.inverse(matrix));
            bounds[index] = worldBounds;
        }
    }
}
