namespace VL.Core
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Collections.LowLevel.Unsafe;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;
    using global::VL;
    using global::VL.Core;

    [BurstCompile]
    public struct UpdateBlendShapeBindVertexJob : IJobParallelForTransform
    {
        [ReadOnly]
        public NativeArray<JobUtility.Array2DInfo> bindVertexArray2DInfos;
        [ReadOnly]
        public NativeArray<Vector3> bindVertexBasePositions;
        [ReadOnly]
        [NativeDisableParallelForRestriction]
        public NativeArray<BlendShapeBindVertexData> bindVertexData;
        [NativeDisableUnsafePtrRestriction]
        public unsafe float* pBlendShapeWeights;
        public void Execute(int index, TransformAccess transform)
        {
        }
    }
}
