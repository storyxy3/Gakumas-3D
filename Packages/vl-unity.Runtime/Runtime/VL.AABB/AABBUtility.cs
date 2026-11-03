namespace VL.AABB
{
    using global::Unity.Mathematics;
    using global::UnityEngine;

    public static class AABBUtility
    {
        public static readonly Vector3 MinVector3;
        public static readonly Vector3 MaxVector3;
        public static readonly Bounds MinBounds;
        public static Bounds TransformAABB(Bounds bounds, Matrix4x4 transform)
        {
            return default(Bounds);
        }

        public static Bounds TransformAABB(Bounds bounds, float4x4 transform)
        {
            return default(Bounds);
        }
    }
}
