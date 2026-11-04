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
        var data = inoutData[index];
        if (!transform.isValid || !data.isVisible) return;
        float3 position = transform.position;
        float3 lens = WorldToViewportPoint(position);
        float fade = data.offScreenFadeDist;
        data.isVisible = lens.x + fade > 0f && lens.x - fade < 1f && lens.y + fade > 0f && lens.y - fade < 1f && (reversedZ ? lens.z < 1f : lens.z > 0f);
        data.lensPosition = lens;
        data.horizDiffAngle = Angle(math.mul((quaternion)transform.rotation, new float3(0f, 0f, 1f)), cameraPosition - position);
        data.distance = math.dot(position - cameraPosition, cameraForward);
        data.localScale = transform.localScale.x;
        inoutData[index] = data;
    }

    private float Angle(float3 from, float3 to)
    {
        float dot = math.dot(math.normalize(from), math.normalize(to));
        double angle = System.Math.Acos(math.clamp(dot, -1f, 1f)) * 57.29577951308232;
        return angle < 1e-15 ? 0f : (float)angle;
    }

    private float3 WorldToViewportPoint(float3 position)
    {
        float4 projected = math.mul(vpMatrix, new float4(position, 1f));
        float3 normalized = projected.xyz / projected.w;
        return new float3(normalized.xy * 0.5f + 0.5f, normalized.z);
    }
}
