namespace UniRx
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;

    internal sealed class ObserverNode<T> : IObserver<T>, IDisposable
    {
        private readonly IObserver<T> observer;
        private IObserverLinkedList<T> list;
        [CompilerGenerated]
        private ObserverNode<T> _003CPrevious_003Ek__BackingField;
        [CompilerGenerated]
        private ObserverNode<T> _003CNext_003Ek__BackingField;
        public ObserverNode<T> Previous
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            internal set
            {
            }
        }

        public ObserverNode<T> Next
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            internal set
            {
            }
        }

        public ObserverNode(IObserverLinkedList<T> list, IObserver<T> observer)
        {
        }

        public void OnNext(T value)
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnCompleted()
        {
        }

        public void Dispose()
        {
        }
    }
}
