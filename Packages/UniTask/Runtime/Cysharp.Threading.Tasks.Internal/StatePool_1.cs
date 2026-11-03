namespace Cysharp.Threading.Tasks.Internal
{
    using global::System.Collections.Concurrent;
    using global::System.Runtime.CompilerServices;
    using global::Cysharp.Threading.Tasks.Internal;

    internal static class StatePool<T1>
    {
        private static readonly ConcurrentQueue<StateTuple<T1>> queue;
        [MethodImpl(256)]
        public static StateTuple<T1> Create(T1 item1)
        {
            return null;
        }

        [MethodImpl(256)]
        public static void Return(StateTuple<T1> tuple)
        {
        }
    }
}
