namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::Cysharp.Threading.Tasks;

    public readonly struct AsyncUnit : IEquatable<AsyncUnit>
    {
        public static readonly AsyncUnit Default;
        public override int GetHashCode()
        {
            return default(int);
        }

        public bool Equals(AsyncUnit other)
        {
            return default(bool);
        }

        public override string ToString()
        {
            return null;
        }
    }
}
