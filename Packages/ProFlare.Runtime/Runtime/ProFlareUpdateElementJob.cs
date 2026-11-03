using global::Unity.Burst;
using global::Unity.Collections;
using global::Unity.Jobs;
using global::Unity.Mathematics;
using global::UnityEngine;

[BurstCompile]
public struct ProFlareUpdateElementJob : IJobParallelFor
{
    public bool VR_Mode;
    public float VR_Depth;
    public bool useBrightnessThreshold;
    public int BrightnessThreshold;
    public bool OverdrawDebug;
    [ReadOnly]
    public NativeArray<ProFlareUpdateElementData> InputData;
    [WriteOnly]
    public NativeArray<ProFlareElementData> FlareElementData;
    [ReadOnly]
    public NativeArray<float4> UVData;
    public void Execute(int index)
    {
    }

    private Color GetElementColor(ref ProFlareUpdateElementData input)
    {
        return default(Color);
    }

    private float3 GetOffsetPosition(ref ProFlareUpdateElementData input, ref float rotateToFlareAngle)
    {
        return default(float3);
    }

    private ProFlareElementData GetElementJobData(ref ProFlareUpdateElementData inputData, float3 offsetPosition, float angle, Color finalColor)
    {
        return default(ProFlareElementData);
    }
}
