namespace UniRx
{
    using global::System;

    public static class Observer
    {
        private class Subscribe<T> : IObserver<T>
        {
            private readonly Action<T> onNext;
            private readonly Action<Exception> onError;
            private readonly Action onCompleted;
            private int isStopped;
            public Subscribe(Action<T> onNext, Action<Exception> onError, Action onCompleted)
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
        }

        private class Subscribe_<T> : IObserver<T>
        {
            private readonly Action<Exception> onError;
            private readonly Action onCompleted;
            private int isStopped;
            public Subscribe_(Action<Exception> onError, Action onCompleted)
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
        }

        internal static IObserver<T> CreateSubscribeObserver<T>(Action<T> onNext, Action<Exception> onError, Action onCompleted)
        {
            return null;
        }
    }
}
