namespace Campus.Common.GoboLight
{
    using global::Campus.Common.GoboLight;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine.Jobs;

    [BurstCompile]
    public struct GoboLightUpdateJob : IJobParallelForTransform
    {
        public NativeArray<GoboData> goboData;
        [ReadOnly]
        public NativeArray<LightData> lightData;
        public float4 plane;
        public void Execute(int index, TransformAccess transform)
        {
        }
    }
}
