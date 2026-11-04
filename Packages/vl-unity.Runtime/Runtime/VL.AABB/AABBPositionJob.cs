namespace VL.AABB
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;

    [BurstCompile]
    public struct AABBPositionJob : IJobParallelForTransform
    {
        [WriteOnly]
        public NativeArray<Vector3> positions;
        public void Execute(int index, TransformAccess transform)
        {
            positions[index] = transform.position;
        }
    }
}
