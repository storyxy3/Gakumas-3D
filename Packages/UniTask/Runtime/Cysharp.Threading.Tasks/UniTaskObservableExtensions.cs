namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Internal;

    public static class UniTaskObservableExtensions
    {
        private class ToUniTaskObserver<T> : IObserver<T>
        {
            private static readonly Action<object> callback;
            private readonly UniTaskCompletionSource<T> promise;
            private readonly SingleAssignmentDisposable disposable;
            private readonly CancellationToken cancellationToken;
            private readonly CancellationTokenRegistration registration;
            private bool hasValue;
            private T latestValue;
            public ToUniTaskObserver(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken)
            {
            }

            private static void OnCanceled(object state)
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

        private class FirstValueToUniTaskObserver<T> : IObserver<T>
        {
            private static readonly Action<object> callback;
            private readonly UniTaskCompletionSource<T> promise;
            private readonly SingleAssignmentDisposable disposable;
            private readonly CancellationToken cancellationToken;
            private readonly CancellationTokenRegistration registration;
            private bool hasValue;
            public FirstValueToUniTaskObserver(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken)
            {
            }

            private static void OnCanceled(object state)
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

        public static UniTask<T> ToUniTask<T>(this IObservable<T> source, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool useFirstValue, [Optional] CancellationToken cancellationToken)
        {
            return default(UniTask<T>);
        }
    }
}
