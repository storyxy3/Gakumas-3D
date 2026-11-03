using global::System;
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Diagnostics;
using global::System.Runtime.CompilerServices;
using global::Octo;

public static class IBulkDownloaderExtensions
{
    [CompilerGenerated]
    private sealed class _003CWaitForTaskComplete_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
    {
        private int _003C_003E1__state;
        private object _003C_003E2__current;
        public IBulkDownloader bulkDownloader;
        object System.Collections.Generic.IEnumerator<System.Object>.Current
        {
            [DebuggerHidden]
            get
            {
                return null;
            }
        }

        object System.Collections.IEnumerator.Current
        {
            [DebuggerHidden]
            get
            {
                return null;
            }
        }

        [DebuggerHidden]
        public _003CWaitForTaskComplete_003Ed__0(int _003C_003E1__state)
        {
        }

        [DebuggerHidden]
        void System.IDisposable.Dispose()
        {
        }

        bool global::System.Collections.IEnumerator.MoveNext()
        {
            return default(bool);
        }

        [DebuggerHidden]
        void System.Collections.IEnumerator.Reset()
        {
        }
    }

    [IteratorStateMachine(typeof(_003CWaitForTaskComplete_003Ed__0))]
    public static IEnumerator WaitForTaskComplete(this IBulkDownloader bulkDownloader)
    {
        return null;
    }
}
