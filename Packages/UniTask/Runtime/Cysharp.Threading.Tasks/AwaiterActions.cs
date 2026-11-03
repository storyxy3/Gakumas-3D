namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;

    internal static class AwaiterActions
    {
        internal static readonly Action<object> InvokeContinuationDelegate;
        [MethodImpl(256)]
        [DebuggerHidden]
        private static void Continuation(object state)
        {
        }
    }
}
