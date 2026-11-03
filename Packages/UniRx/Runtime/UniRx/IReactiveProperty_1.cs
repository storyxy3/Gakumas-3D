namespace UniRx
{
    using global::System;
    using global::UniRx;

    public interface IReactiveProperty<T> : IReadOnlyReactiveProperty<T>, IObservable<T>
    {
        new T Value { get; set; }
    }
}
