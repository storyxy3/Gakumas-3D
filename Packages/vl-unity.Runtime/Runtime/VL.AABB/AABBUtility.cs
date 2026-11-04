namespace VL.AABB
{
    using global::Unity.Mathematics;
    using global::UnityEngine;

    public static class AABBUtility
    {
        public static readonly Vector3 MinVector3 = new Vector3(float.MinValue, float.MinValue, float.MinValue);
        public static readonly Vector3 MaxVector3 = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
        public static readonly Bounds MinBounds = new Bounds(Vector3.zero, MinVector3);
        public static Bounds TransformAABB(Bounds bounds, Matrix4x4 transform)
        {
            Vector3 lo = bounds.min, hi = bounds.max;
            Vector3 min = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
            Vector3 max = new Vector3(float.MinValue, float.MinValue, float.MinValue);
            for (int i = 0; i < 8; ++i)
            {
                Vector3 corner = new Vector3((i & 1) != 0 ? hi.x : lo.x, (i & 2) != 0 ? hi.y : lo.y, (i & 4) != 0 ? hi.z : lo.z);
                Vector3 point = transform.MultiplyPoint3x4(corner);
                min = Vector3.Min(min, point);
                max = Vector3.Max(max, point);
            }
            bounds.SetMinMax(min, max);
            return bounds;
        }

        public static Bounds TransformAABB(Bounds bounds, float4x4 transform)
        {
            Vector3 lo = bounds.min, hi = bounds.max;
            float3 min = new float3(float.MaxValue, float.MaxValue, float.MaxValue);
            float3 max = new float3(float.MinValue, float.MinValue, float.MinValue);
            for (int i = 0; i < 8; ++i)
            {
                float3 corner = new float3((i & 1) != 0 ? hi.x : lo.x, (i & 2) != 0 ? hi.y : lo.y, (i & 4) != 0 ? hi.z : lo.z);
                float3 point = math.transform(transform, corner);
                min = math.min(min, point);
                max = math.max(max, point);
            }
            bounds.SetMinMax(min, max);
            return bounds;
        }
    }
}
