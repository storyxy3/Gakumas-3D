namespace UniRx
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UniRx;

    public class ReadOnlyReactiveProperty<T> : IReadOnlyReactiveProperty<T>, IObservable<T>, IDisposable, IOptimizedObservable<T>, IObserverLinkedList<T>, IObserver<T>
    {
        private static readonly IEqualityComparer<T> defaultEqualityComparer;
        private readonly bool distinctUntilChanged;
        private bool canPublishValueOnSubscribe;
        private bool isDisposed;
        private bool isSourceCompleted;
        private T latestValue;
        private Exception lastException;
        private IDisposable sourceConnection;
        private ObserverNode<T> root;
        private ObserverNode<T> last;
        public T Value
        {
            get
            {
                return default(T);
            }
        }

        public bool HasValue
        {
            get
            {
                return default(bool);
            }
        }

        protected virtual IEqualityComparer<T> EqualityComparer
        {
            get
            {
                return null;
            }
        }

        public ReadOnlyReactiveProperty(IObservable<T> source)
        {
        }

        public ReadOnlyReactiveProperty(IObservable<T> source, bool distinctUntilChanged)
        {
        }

        public ReadOnlyReactiveProperty(IObservable<T> source, T initialValue)
        {
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            return null;
        }

        public void Dispose()
        {
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        void UniRx.IObserverLinkedList<T>.UnsubscribeNode(ObserverNode<T> node)
        {
        }

        void System.IObserver<T>.OnNext(T value)
        {
        }

        void System.IObserver<T>.OnError(Exception error)
        {
        }

        void System.IObserver<T>.OnCompleted()
        {
        }

        public override string ToString()
        {
            return null;
        }

        public bool IsRequiredSubscribeOnCurrentThread()
        {
            return default(bool);
        }
    }
}
