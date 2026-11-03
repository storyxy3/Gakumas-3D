namespace UniRx
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;

    [Serializable]
    public class ReactiveCollection<T> : Collection<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyReactiveCollection<T>, IDisposable
    {
        [NonSerialized]
        private bool isDisposed;
        [NonSerialized]
        private Subject<int> countChanged;
        [NonSerialized]
        private Subject<Unit> collectionReset;
        [NonSerialized]
        private Subject<CollectionAddEvent<T>> collectionAdd;
        [NonSerialized]
        private Subject<CollectionMoveEvent<T>> collectionMove;
        [NonSerialized]
        private Subject<CollectionRemoveEvent<T>> collectionRemove;
        [NonSerialized]
        private Subject<CollectionReplaceEvent<T>> collectionReplace;
        private bool disposedValue;
        public ReactiveCollection()
        {
        }

        protected override void ClearItems()
        {
        }

        protected override void InsertItem(int index, T item)
        {
        }

        protected override void RemoveItem(int index)
        {
        }

        protected override void SetItem(int index, T item)
        {
        }

        public IObservable<int> ObserveCountChanged(bool notifyCurrentCount = false)
        {
            return null;
        }

        public IObservable<CollectionMoveEvent<T>> ObserveMove()
        {
            return null;
        }

        public IObservable<CollectionReplaceEvent<T>> ObserveReplace()
        {
            return null;
        }

        private void DisposeSubject<TSubject>(ref Subject<TSubject> subject)
        {
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
        }

        [CompilerGenerated]
        private int _003CObserveCountChanged_003Eb__11_0()
        {
            return default(int);
        }
    }
}
