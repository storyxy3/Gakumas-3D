namespace LibTessDotNet
{
    using global::LibTessDotNet;

    internal abstract class IPool
    {
        public IPool()
        {
        }

        public abstract void Register<T>(ITypePool typePool)
            where T : class, Pooled<T>, new();
        public abstract T Get<T>()
            where T : class, Pooled<T>, new();
        public abstract void Return<T>(ref T obj)
            where T : class, Pooled<T>, new();
    }
}
