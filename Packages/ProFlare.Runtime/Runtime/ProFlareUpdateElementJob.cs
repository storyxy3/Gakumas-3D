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
        var input = InputData[index];
        Color color = GetElementColor(ref input);
        float angle = 0f;
        float multiAngle = 0f;
        float3 position;
        if (input.IsMulti)
        {
            position = input.UseRangeOffset ? GetOffsetPosition(ref input, ref multiAngle) : (float3)(-input.Position * input.LensPosition);
        }
        else position = GetOffsetPosition(ref input, ref angle);
        angle = angle + input.LensPosition.x * input.RotationSpeed + input.RotationSpeed * input.LensPosition.y + input.RotationOverTime + input.Angle;
        FlareElementData[index] = GetElementJobData(ref input, position, angle + multiAngle, color);
    }

    private Color GetElementColor(ref ProFlareUpdateElementData input)
    {
        Color color = input.TintColor * input.GlobalColor;
        color.a = (color.a + input.AddAlpha) * input.MultiplyAlpha;
        return color;
    }

    private float3 GetOffsetPosition(ref ProFlareUpdateElementData input, ref float rotateToFlareAngle)
    {
        float3 position = -input.Position * (float3)input.LensPosition;
        float z = input.LensPosition.z;
        if (VR_Mode) z *= 1f + (-1f - input.Position) * VR_Depth;
        position.x += (input.LensPosition.x - position.x) * input.Anamorphic.x;
        position.y += (input.LensPosition.y - position.y) * input.Anamorphic.y;
        position.x += input.OffsetPostion.x;
        position.y += input.OffsetPostion.y;
        position.z = z + input.OffsetPostion.z;
        if (input.RotateToFlare)
            rotateToFlareAngle = (float)System.Math.Atan2(input.LensPosition.y - position.y, input.LensPosition.x - position.x) * 57.29578f;
        return position;
    }

    private ProFlareElementData GetElementJobData(ref ProFlareUpdateElementData inputData, float3 offsetPosition, float angle, Color finalColor)
    {
        float2 scale = (float2)inputData.Size * inputData.Scale;
        if (scale.x < 0f || scale.y < 0f) scale = float2.zero;
        Color32 color = finalColor;
        if (useBrightnessThreshold && (BrightnessThreshold > color.a || color.r + color.g + color.b < BrightnessThreshold)) scale = float2.zero;
        if (OverdrawDebug) color = new Color32(20, 20, 20, 50);
        return new ProFlareElementData
        {
            flareIndex = (uint)inputData.FlareIndex,
            color = (uint)(color.r | color.g << 8 | color.b << 16 | color.a << 24),
            scale = scale, offset = offsetPosition, angle = angle, uv = UVData[inputData.ElementTextureID]
        };
    }
}
