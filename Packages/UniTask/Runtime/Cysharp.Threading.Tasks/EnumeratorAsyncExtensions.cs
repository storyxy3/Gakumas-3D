namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Reflection;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine;

    public static class EnumeratorAsyncExtensions
    {
        private sealed class EnumeratorPromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<EnumeratorPromise>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }
            }

            [CompilerGenerated]
            private sealed class _003CConsumeEnumerator_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
            {
                private int _003C_003E1__state;
                private object _003C_003E2__current;
                public IEnumerator enumerator;
                private CustomYieldInstruction _003Ccyi_003E5__2;
                private IEnumerator _003CinnerCoroutine_003E5__3;
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
                public _003CConsumeEnumerator_003Ed__19(int _003C_003E1__state)
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

            [CompilerGenerated]
            private sealed class _003CUnwrapWaitAsyncOperation_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
            {
                private int _003C_003E1__state;
                private object _003C_003E2__current;
                public AsyncOperation asyncOperation;
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
                public _003CUnwrapWaitAsyncOperation_003Ed__22(int _003C_003E1__state)
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

            [CompilerGenerated]
            private sealed class _003CUnwrapWaitForSeconds_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
            {
                private int _003C_003E1__state;
                private object _003C_003E2__current;
                public WaitForSeconds waitForSeconds;
                private float _003Csecond_003E5__2;
                private float _003Celapsed_003E5__3;
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
                public _003CUnwrapWaitForSeconds_003Ed__21(int _003C_003E1__state)
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

            private static TaskPool<EnumeratorPromise> pool;
            private EnumeratorPromise nextNode;
            private IEnumerator innerEnumerator;
            private CancellationToken cancellationToken;
            private int initialFrame;
            private bool loopRunning;
            private bool calledGetResult;
            private UniTaskCompletionSourceCore<object> core;
            private static readonly FieldInfo waitForSeconds_Seconds;
            public unsafe ref EnumeratorPromise NextNode
            {
                get
                {
                    throw null;
                }
            }

            static EnumeratorPromise()
            {
            }

            private EnumeratorPromise()
            {
            }

            public static IUniTaskSource Create(IEnumerator innerEnumerator, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
            {
                throw null;
            }

            public void GetResult(short token)
            {
            }

            public UniTaskStatus GetStatus(short token)
            {
                return default(UniTaskStatus);
            }

            public UniTaskStatus UnsafeGetStatus()
            {
                return default(UniTaskStatus);
            }

            public void OnCompleted(Action<object> continuation, object state, short token)
            {
            }

            public bool MoveNext()
            {
                return default(bool);
            }

            private bool TryReturn()
            {
                return default(bool);
            }

            [IteratorStateMachine(typeof(_003CConsumeEnumerator_003Ed__19))]
            private static IEnumerator ConsumeEnumerator(IEnumerator enumerator)
            {
                return null;
            }

            [IteratorStateMachine(typeof(_003CUnwrapWaitForSeconds_003Ed__21))]
            private static IEnumerator UnwrapWaitForSeconds(WaitForSeconds waitForSeconds)
            {
                return null;
            }

            [IteratorStateMachine(typeof(_003CUnwrapWaitAsyncOperation_003Ed__22))]
            private static IEnumerator UnwrapWaitAsyncOperation(AsyncOperation asyncOperation)
            {
                return null;
            }
        }

        public static UniTask ToUniTask(this IEnumerator enumerator, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PlayerLoopTiming.Update)] PlayerLoopTiming timing, [Optional] CancellationToken cancellationToken)
        {
            return default(UniTask);
        }
    }
}
