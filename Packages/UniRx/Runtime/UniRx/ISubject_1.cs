namespace UniRx
{
    using global::System;

    public interface ISubject<T> : IObserver<T>, IObservable<T>
    {
    }
}
