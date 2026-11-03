namespace LibTessDotNet
{
    using global::System;
    using global::System.Collections.Generic;
    using global::LibTessDotNet;

    internal class DefaultTypePool<T> : ITypePool where T : class, Pooled<T>, new()
    {
        private Queue<T> _pool;
        private static readonly Func<T> Creator;
        public object Get()
        {
            return null;
        }

        public void Return(object obj)
        {
        }

        public DefaultTypePool()
        {
        }
    }
}
