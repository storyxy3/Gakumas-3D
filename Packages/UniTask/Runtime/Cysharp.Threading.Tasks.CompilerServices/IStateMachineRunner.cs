namespace Cysharp.Threading.Tasks.CompilerServices
{
    using global::System;

    internal interface IStateMachineRunner
    {
        Action MoveNext { get; }

        Action ReturnAction { get; }
    }
}
