namespace ClipperLib
{
    using global::ClipperLib;

    internal struct IntPoint
    {
        public long X;
        public long Y;
        public IntPoint(long X, long Y)
        {
            this = default;
        }

        public IntPoint(double x, double y)
        {
            this = default;
        }

        public IntPoint(IntPoint pt)
        {
            this = default;
        }

        public static bool operator ==(IntPoint a, IntPoint b)
        {
            return default(bool);
        }

        public static bool operator !=(IntPoint a, IntPoint b)
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
    }
}
