namespace UniRx
{
    using global::System;

    internal static class Stubs<T>
    {
        public static readonly Action<T> Ignore;
        public static readonly Func<T, T> Identity;
        public static readonly Action<Exception, T> Throw;
    }
}
