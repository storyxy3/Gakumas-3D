namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::Unity.Mathematics;

    public static class ActorSwingUtility
    {
        [MethodImpl(256)]
        public static float3 UpdateSpringPosition(float3 selfPosition, float3 childPosition, float length)
        {
            float3 delta = childPosition - selfPosition;
            float lengthSquared = math.lengthsq(delta);
            if (lengthSquared > 0.00001f * 0.00001f) return selfPosition + delta / math.sqrt(lengthSquared) * length;
            return selfPosition;
        }

        [MethodImpl(256)]
        public static float3 ToUnityEuler(quaternion q)
        {
            float x = q.value.x;
            float y = q.value.y;
            float z = q.value.z;
            float w = q.value.w;
            return new float3(math.asin(2f * (y * z - w * x)),
                math.atan2(-2f * (x * z + w * y), w * w - x * x - y * y + z * z),
                math.atan2(-2f * (x * y + w * z), w * w - x * x + y * y - z * z)) * -57.29578f;
        }

        public static quaternion ToUnityQuaternion(float3 euler)
        {
            float3 half = math.radians(euler) * 0.5f;
            float3 s = math.sin(half);
            float3 c = math.cos(half);
            return new quaternion(s.x * c.y * c.z + s.y * s.z * c.x,
                s.y * c.x * c.z - s.z * s.x * c.y,
                s.z * c.x * c.y - s.y * s.x * c.z,
                s.x * s.y * s.z + c.x * c.y * c.z);
        }

        public static quaternion FromToRotation(float3 from, float3 to)
        {
            float dot = math.dot(math.normalizesafe(from), math.normalizesafe(to));
            if (dot >= 1f) return quaternion.identity;
            if (dot <= -1f)
            {
                float3 axis = math.cross(from, new float3(1f, 0f, 0f));
                if (math.lengthsq(axis) < 1e-10f) axis = math.cross(from, new float3(0f, 1f, 0f));
                return quaternion.AxisAngle(axis, math.PI);
            }
            return quaternion.AxisAngle(math.normalizesafe(math.cross(from, to)), math.acos(dot));
        }

        public static float3 GetRootCorrectionCancelPosition(float3 hipsTranslation, float manageRootWeight, float manageRootHorizontalWeight, float manageRootVerticalWeight, float boneRootHorizontalWeight, float boneRootVerticalWeight)
        {
            float horizontal = 1f - manageRootWeight * manageRootHorizontalWeight * boneRootHorizontalWeight;
            float vertical = 1f - manageRootWeight * manageRootVerticalWeight * boneRootVerticalWeight;
            return new float3(hipsTranslation.x * horizontal, hipsTranslation.y * vertical, hipsTranslation.z * horizontal);
        }
    }
}
