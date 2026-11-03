namespace UniRx
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UniRx;
    using global::UnityEngine;

    [Serializable]
    public class ReactiveProperty<T> : IReactiveProperty<T>, IReadOnlyReactiveProperty<T>, IObservable<T>, IDisposable, IOptimizedObservable<T>, IObserverLinkedList<T>
    {
        private static readonly IEqualityComparer<T> defaultEqualityComparer;
        [SerializeField]
        private T value;
        [NonSerialized]
        private ObserverNode<T> root;
        [NonSerialized]
        private ObserverNode<T> last;
        [NonSerialized]
        private bool isDisposed;
        protected virtual IEqualityComparer<T> EqualityComparer
        {
            get
            {
                return null;
            }
        }

        public T Value
        {
            get
            {
                return default(T);
            }

            set
            {
            }
        }

        public bool HasValue
        {
            get
            {
                return default(bool);
            }
        }

        public ReactiveProperty()
        {
        }

        public ReactiveProperty(T initialValue)
        {
        }

        private void RaiseOnNext(ref T value)
        {
        }

        protected virtual void SetValue(T value)
        {
        }

        public void SetValueAndForceNotify(T value)
        {
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            return null;
        }

        void UniRx.IObserverLinkedList<T>.UnsubscribeNode(ObserverNode<T> node)
        {
        }

        public void Dispose()
        {
        }

        protected virtual void Dispose(bool disposing)
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
