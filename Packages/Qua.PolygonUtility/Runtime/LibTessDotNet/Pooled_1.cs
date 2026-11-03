namespace LibTessDotNet
{
    using global::LibTessDotNet;

    internal interface Pooled<T>
        where T : class, Pooled<T>, new()
    {
        void Init(IPool pool);
        void Reset(IPool pool);
    }
}
