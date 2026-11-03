namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::Unity.Mathematics;

    public static class ActorSwingUtility
    {
        [MethodImpl(256)]
        public static float3 UpdateSpringPosition(float3 selfPosition, float3 childPosition, float length)
        {
            return default(float3);
        }

        [MethodImpl(256)]
        public static float3 ToUnityEuler(quaternion q)
        {
            return default(float3);
        }

        public static quaternion ToUnityQuaternion(float3 euler)
        {
            return default(quaternion);
        }

        public static quaternion FromToRotation(float3 from, float3 to)
        {
            return default(quaternion);
        }

        public static float3 GetRootCorrectionCancelPosition(float3 hipsTranslation, float manageRootWeight, float manageRootHorizontalWeight, float manageRootVerticalWeight, float boneRootHorizontalWeight, float boneRootVerticalWeight)
        {
            return default(float3);
        }
    }
}
