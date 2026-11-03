namespace UniRx
{
    using global::System;

    public interface IConnectableObservable<T> : IObservable<T>
    {
        IDisposable Connect();
    }
}
