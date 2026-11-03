namespace UniRx
{
    using global::System;
    using global::UniRx;

    [Serializable]
    public struct Unit : IEquatable<Unit>
    {
        private static readonly Unit @default;
        public static Unit Default
        {
            get
            {
                return default(Unit);
            }
        }

        public bool Equals(Unit other)
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

        public override string ToString()
        {
            return null;
        }
    }
}
