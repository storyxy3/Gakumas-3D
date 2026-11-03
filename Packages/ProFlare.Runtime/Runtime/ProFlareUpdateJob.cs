using global::Unity.Burst;
using global::Unity.Collections;
using global::Unity.Mathematics;
using global::UnityEngine.Jobs;

[BurstCompile]
public struct ProFlareUpdateJob : IJobParallelForTransform
{
    public bool reversedZ;
    public float3 cameraPosition;
    public float3 cameraForward;
    public float4x4 vpMatrix;
    public NativeArray<ProFlareUpdateInOutputData> inoutData;
    public void Execute(int index, TransformAccess transform)
    {
    }

    private float Angle(float3 from, float3 to)
    {
        return default(float);
    }

    private float3 WorldToViewportPoint(float3 position)
    {
        return default(float3);
    }
}
