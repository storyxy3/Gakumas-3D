namespace ClipperLib
{
    using global::ClipperLib;

    internal struct Int128
    {
        private long hi;
        private ulong lo;
        public Int128(long _hi, ulong _lo)
        {
            this = default;
        }

        public static bool operator ==(Int128 val1, Int128 val2)
        {
            return default(bool);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return default(int);
        }

        public static Int128 operator -(Int128 val)
        {
            return default(Int128);
        }

        public static Int128 Int128Mul(long lhs, long rhs)
        {
            return default(Int128);
        }

        // TODO(qa-recon): Opposite comparison stripped from game; C# requires paired operator declarations.
        public static bool operator !=(Int128 val1, Int128 val2)
        {
            return default(bool);
        }
    }
}
