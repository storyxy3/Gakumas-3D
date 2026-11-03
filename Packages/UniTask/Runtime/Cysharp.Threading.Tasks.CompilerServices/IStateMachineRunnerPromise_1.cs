namespace Cysharp.Threading.Tasks.CompilerServices
{
    using global::System;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;

    internal interface IStateMachineRunnerPromise<T> : IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>
    {
        Action MoveNext { get; }

        UniTask<T> Task { get; }

        void SetResult(T result);
        void SetException(Exception exception);
    }
}
