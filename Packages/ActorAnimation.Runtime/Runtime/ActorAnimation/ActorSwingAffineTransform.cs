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
        private static readonly ActorSwingAffineTransform _003Cidentity_003Ek__BackingField = new ActorSwingAffineTransform(float3.zero, quaternion.identity);
        public static ActorSwingAffineTransform identity
        {
            [CompilerGenerated]
            get
            {
                return _003Cidentity_003Ek__BackingField;
            }
        }

        public ActorSwingAffineTransform(float3 t, quaternion r)
        {
            translation = t;
            rotation = r;
        }

        public void Set(float3 t, quaternion r)
        {
            translation = t;
            rotation = r;
        }

        public void Set(ActorSwingAffineTransform transform)
        {
            translation = transform.translation;
            rotation = transform.rotation;
        }

        public float3 Transform(float3 p)
        {
            return translation + math.rotate(rotation, p);
        }

        public ActorSwingAffineTransform Inverse()
        {
            quaternion inverse = math.inverse(rotation);
            return new ActorSwingAffineTransform(math.rotate(inverse, -translation), inverse);
        }

        public static float3 operator *(ActorSwingAffineTransform lhs, float3 rhs)
        {
            return lhs.translation + math.rotate(lhs.rotation, rhs);
        }

        public static ActorSwingAffineTransform operator *(ActorSwingAffineTransform lhs, ActorSwingAffineTransform rhs)
        {
            return new ActorSwingAffineTransform(lhs.Transform(rhs.translation), math.mul(lhs.rotation, rhs.rotation));
        }

        public static ActorSwingAffineTransform operator *(ActorSwingAffineTransform lhs, quaternion rhs)
        {
            return new ActorSwingAffineTransform(lhs.translation, math.mul(lhs.rotation, rhs));
        }
    }
}
