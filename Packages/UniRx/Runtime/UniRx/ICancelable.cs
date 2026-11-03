namespace UniRx
{
    using global::System;

    public interface ICancelable : IDisposable
    {
        bool IsDisposed { get; }
    }
}
