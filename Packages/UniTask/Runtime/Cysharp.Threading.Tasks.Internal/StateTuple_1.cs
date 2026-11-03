namespace Cysharp.Threading.Tasks.Internal
{
    using global::System;

    internal class StateTuple<T1> : IDisposable
    {
        public T1 Item1;
        public void Dispose()
        {
        }

        public StateTuple()
        {
        }
    }
}
