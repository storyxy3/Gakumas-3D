namespace Campus.Gasha.Sequences
{
    using global::System;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;

    [Serializable]
    public struct GashaId : IEquatable<GashaId>
    {
        public GashaStep step;
        public int number;
        public static GashaId Start
        {
            get
            {
                return default(GashaId);
            }
        }

        public static GashaId End
        {
            get
            {
                return default(GashaId);
            }
        }

        public GashaId(GashaStep step, int number)
        {
            this = default;
        }

        public override string ToString()
        {
            return null;
        }

        public bool Equals(GashaId other)
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

        public static bool operator ==(GashaId left, GashaId right)
        {
            return default(bool);
        }

        // TODO(qa-recon): Opposite comparison stripped from game; C# requires paired operator declarations.
        public static bool operator !=(GashaId left, GashaId right)
        {
            return default(bool);
        }
    }
}
