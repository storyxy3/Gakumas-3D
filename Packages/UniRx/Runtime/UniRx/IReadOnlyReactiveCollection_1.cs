namespace UniRx
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Reflection;
    using global::UniRx;

    [DefaultMember("Item")]
    public interface IReadOnlyReactiveCollection<T> : IEnumerable<T>, IEnumerable
    {
        int Count { get; }

        IObservable<int> ObserveCountChanged(bool notifyCurrentCount = false);
        IObservable<CollectionMoveEvent<T>> ObserveMove();
        IObservable<CollectionReplaceEvent<T>> ObserveReplace();
    }
}
