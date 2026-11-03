namespace Cysharp.Threading.Tasks.Internal
{
    using global::System;

    internal class StateTuple<T1, T2> : IDisposable
    {
        public T1 Item1;
        public T2 Item2;
        public void Dispose()
        {
        }

        public StateTuple()
        {
        }
    }
}
