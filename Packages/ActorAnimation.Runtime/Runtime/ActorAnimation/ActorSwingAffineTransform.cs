namespace ActorAnimation
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::Unity.Mathematics;

    [Serializable]
    public struct ActorSwingAffineTransform
    {
        public float3 translation;
        public quaternion rotation;
        [CompilerGenerated]
        private static readonly ActorSwingAffineTransform _003Cidentity_003Ek__BackingField;
        public static ActorSwingAffineTransform identity
        {
            [CompilerGenerated]
            get
            {
                return default(ActorSwingAffineTransform);
            }
        }

        public ActorSwingAffineTransform(float3 t, quaternion r)
        {
            this = default;
        }

        public void Set(float3 t, quaternion r)
        {
        }

        public void Set(ActorSwingAffineTransform transform)
        {
        }

        public float3 Transform(float3 p)
        {
            return default(float3);
        }

        public ActorSwingAffineTransform Inverse()
        {
            return default(ActorSwingAffineTransform);
        }

        public static float3 operator *(ActorSwingAffineTransform lhs, float3 rhs)
        {
            return default(float3);
        }

        public static ActorSwingAffineTransform operator *(ActorSwingAffineTransform lhs, ActorSwingAffineTransform rhs)
        {
            return default(ActorSwingAffineTransform);
        }

        public static ActorSwingAffineTransform operator *(ActorSwingAffineTransform lhs, quaternion rhs)
        {
            return default(ActorSwingAffineTransform);
        }
    }
}
