namespace Cysharp.Threading.Tasks.CompilerServices
{
    using global::System;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;

    internal interface IStateMachineRunnerPromise : IUniTaskSource, IValueTaskSource
    {
        Action MoveNext { get; }

        UniTask Task { get; }

        void SetResult();
        void SetException(Exception exception);
    }
}
