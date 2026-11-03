namespace LibTessDotNet
{
    using global::LibTessDotNet;

    internal struct Vec3
    {
        public static readonly Vec3 Zero;
        public float X;
        public float Y;
        public float Z;
        public float this[int index]
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public Vec3(float x, float y, float z)
        {
            this = default;
        }

        public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
        {
            throw null;
        }

        public static void Neg(ref Vec3 v)
        {
        }

        public static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
        {
            throw null;
        }

        public static int LongAxis(ref Vec3 v)
        {
            return default(int);
        }

        public override string ToString()
        {
            return null;
        }
    }
}
