namespace VL.Rendering.Skinning
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;

    [BurstCompile]
    public struct UpdateMatricesJob : IJobParallelForTransform
    {
        public Matrix4x4 rendererWorldToLocalMatrix;
        [ReadOnly]
        public NativeArray<Matrix4x4> bindposesArray;
        [WriteOnly]
        public NativeArray<Matrix4x4> matricesArray;
        public void Execute(int index, TransformAccess transform)
        {
            if (transform.isValid)
                matricesArray[index] = rendererWorldToLocalMatrix * transform.localToWorldMatrix * bindposesArray[index];
        }
    }
}
