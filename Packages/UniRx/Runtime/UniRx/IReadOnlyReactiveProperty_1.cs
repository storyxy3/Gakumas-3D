namespace UniRx
{
    using global::System;

    public interface IReadOnlyReactiveProperty<T> : IObservable<T>
    {
        T Value { get; }

        bool HasValue { get; }
    }
}
