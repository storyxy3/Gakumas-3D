namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.ExceptionServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Cysharp.Threading.Tasks.Internal;
    using global::UnityEngine;

    [StructLayout((LayoutKind)3)]
    [AsyncMethodBuilder(typeof(AsyncUniTaskMethodBuilder))]
    public readonly struct UniTask
    {
        private sealed class YieldPromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<YieldPromise>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__10_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__10_0(object state)
                {
                }
            }

            private static TaskPool<YieldPromise> pool;
            private YieldPromise nextNode;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            private UniTaskCompletionSourceCore<object> core;
            public unsafe ref YieldPromise NextNode
            {
                get
                {
                    throw null;
                }
            }

            static YieldPromise()
            {
            }

            private YieldPromise()
            {
            }

            public static IUniTaskSource Create(PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
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
        }

        private sealed class NextFramePromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<NextFramePromise>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__11_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__11_0(object state)
                {
                }
            }

            private static TaskPool<NextFramePromise> pool;
            private NextFramePromise nextNode;
            private int frameCount;
            private UniTaskCompletionSourceCore<AsyncUnit> core;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            public unsafe ref NextFramePromise NextNode
            {
                get
                {
                    throw null;
                }
            }

            static NextFramePromise()
            {
            }

            private NextFramePromise()
            {
            }

            public static IUniTaskSource Create(PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
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
        }

        private sealed class WaitForEndOfFramePromise : IUniTaskSource, IValueTaskSource, ITaskPoolNode<WaitForEndOfFramePromise>, IEnumerator
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__10_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__10_0(object state)
                {
                }
            }

            private static TaskPool<WaitForEndOfFramePromise> pool;
            private WaitForEndOfFramePromise nextNode;
            private UniTaskCompletionSourceCore<object> core;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            private static readonly WaitForEndOfFrame waitForEndOfFrameYieldInstruction;
            private bool isFirst;
            public unsafe ref WaitForEndOfFramePromise NextNode
            {
                get
                {
                    throw null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                get
                {
                    return null;
                }
            }

            static WaitForEndOfFramePromise()
            {
            }

            private WaitForEndOfFramePromise()
            {
            }

            public static IUniTaskSource Create(MonoBehaviour coroutineRunner, CancellationToken cancellationToken, bool cancelImmediately, out short token)
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

            private bool TryReturn()
            {
                return default(bool);
            }

            bool System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            public void Reset()
            {
            }
        }

        private sealed class DelayFramePromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayFramePromise>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__13_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__13_0(object state)
                {
                }
            }

            private static TaskPool<DelayFramePromise> pool;
            private DelayFramePromise nextNode;
            private int initialFrame;
            private int delayFrameCount;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            private int currentFrameCount;
            private UniTaskCompletionSourceCore<AsyncUnit> core;
            public unsafe ref DelayFramePromise NextNode
            {
                get
                {
                    throw null;
                }
            }

            static DelayFramePromise()
            {
            }

            private DelayFramePromise()
            {
            }

            public static IUniTaskSource Create(int delayFrameCount, PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
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
        }

        private sealed class DelayPromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayPromise>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__13_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__13_0(object state)
                {
                }
            }

            private static TaskPool<DelayPromise> pool;
            private DelayPromise nextNode;
            private int initialFrame;
            private float delayTimeSpan;
            private float elapsed;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            private UniTaskCompletionSourceCore<object> core;
            public unsafe ref DelayPromise NextNode
            {
                get
                {
                    throw null;
                }
            }

            static DelayPromise()
            {
            }

            private DelayPromise()
            {
            }

            public static IUniTaskSource Create(TimeSpan delayTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
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
        }

        private sealed class DelayIgnoreTimeScalePromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayIgnoreTimeScalePromise>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__13_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__13_0(object state)
                {
                }
            }

            private static TaskPool<DelayIgnoreTimeScalePromise> pool;
            private DelayIgnoreTimeScalePromise nextNode;
            private float delayFrameTimeSpan;
            private float elapsed;
            private int initialFrame;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            private UniTaskCompletionSourceCore<object> core;
            public unsafe ref DelayIgnoreTimeScalePromise NextNode
            {
                get
                {
                    throw null;
                }
            }

            static DelayIgnoreTimeScalePromise()
            {
            }

            private DelayIgnoreTimeScalePromise()
            {
            }

            public static IUniTaskSource Create(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
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
        }

        private sealed class DelayRealtimePromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayRealtimePromise>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__12_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__12_0(object state)
                {
                }
            }

            private static TaskPool<DelayRealtimePromise> pool;
            private DelayRealtimePromise nextNode;
            private long delayTimeSpanTicks;
            private ValueStopwatch stopwatch;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            private UniTaskCompletionSourceCore<AsyncUnit> core;
            public unsafe ref DelayRealtimePromise NextNode
            {
                get
                {
                    throw null;
                }
            }

            static DelayRealtimePromise()
            {
            }

            private DelayRealtimePromise()
            {
            }

            public static IUniTaskSource Create(TimeSpan delayTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
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
        }

        private static class CanceledUniTaskCache<T>
        {
            public static readonly UniTask<T> Task;
            static CanceledUniTaskCache()
            {
            }
        }

        private sealed class ExceptionResultSource : IUniTaskSource, IValueTaskSource
        {
            private readonly ExceptionDispatchInfo exception;
            private bool calledGet;
            public ExceptionResultSource(Exception exception)
            {
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

            ~ExceptionResultSource()
            {
            }
        }

        private sealed class ExceptionResultSource<T> : IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>
        {
            private readonly ExceptionDispatchInfo exception;
            private bool calledGet;
            public ExceptionResultSource(Exception exception)
            {
            }

            public T GetResult(short token)
            {
                return default(T);
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
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

            ~ExceptionResultSource()
            {
            }
        }

        private sealed class CanceledResultSource : IUniTaskSource, IValueTaskSource
        {
            private readonly CancellationToken cancellationToken;
            public CanceledResultSource(CancellationToken cancellationToken)
            {
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
        }

        private sealed class CanceledResultSource<T> : IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>
        {
            private readonly CancellationToken cancellationToken;
            public CanceledResultSource(CancellationToken cancellationToken)
            {
            }

            public T GetResult(short token)
            {
                return default(T);
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
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
        }

        private sealed class NeverPromise<T> : IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>
        {
            private static readonly Action<object> cancellationCallback;
            private CancellationToken cancellationToken;
            private UniTaskCompletionSourceCore<T> core;
            public NeverPromise(CancellationToken cancellationToken)
            {
            }

            private static void CancellationCallback(object state)
            {
            }

            public T GetResult(short token)
            {
                return default(T);
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

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
            {
            }
        }

        private sealed class WaitUntilPromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitUntilPromise>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__11_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__11_0(object state)
                {
                }
            }

            private static TaskPool<WaitUntilPromise> pool;
            private WaitUntilPromise nextNode;
            private Func<bool> predicate;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            private UniTaskCompletionSourceCore<object> core;
            public unsafe ref WaitUntilPromise NextNode
            {
                get
                {
                    throw null;
                }
            }

            static WaitUntilPromise()
            {
            }

            private WaitUntilPromise()
            {
            }

            public static IUniTaskSource Create(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
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
        }

        private sealed class WaitWhilePromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitWhilePromise>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__11_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__11_0(object state)
                {
                }
            }

            private static TaskPool<WaitWhilePromise> pool;
            private WaitWhilePromise nextNode;
            private Func<bool> predicate;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            private UniTaskCompletionSourceCore<object> core;
            public unsafe ref WaitWhilePromise NextNode
            {
                get
                {
                    throw null;
                }
            }

            static WaitWhilePromise()
            {
            }

            private WaitWhilePromise()
            {
            }

            public static IUniTaskSource Create(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
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
        }

        private sealed class WaitUntilCanceledPromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitUntilCanceledPromise>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__10_0;
                public _003C_003Ec()
                {
                }

                internal int _003C_002Ecctor_003Eb__4_0()
                {
                    return default(int);
                }

                internal void _003CCreate_003Eb__10_0(object state)
                {
                }
            }

            private static TaskPool<WaitUntilCanceledPromise> pool;
            private WaitUntilCanceledPromise nextNode;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration cancellationTokenRegistration;
            private bool cancelImmediately;
            private UniTaskCompletionSourceCore<object> core;
            public unsafe ref WaitUntilCanceledPromise NextNode
            {
                get
                {
                    throw null;
                }
            }

            static WaitUntilCanceledPromise()
            {
            }

            private WaitUntilCanceledPromise()
            {
            }

            public static IUniTaskSource Create(CancellationToken cancellationToken, PlayerLoopTiming timing, bool cancelImmediately, out short token)
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
        }

        private sealed class WhenAllPromise<T1, T2> : IUniTaskSource<(T1, T2)>, IUniTaskSource, IValueTaskSource, IValueTaskSource<(T1, T2)>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__4_0;
                public static Action<object> _003C_003E9__4_1;
                public _003C_003Ec()
                {
                }

                internal void _003C_002Ector_003Eb__4_0(object state)
                {
                }

                internal void _003C_002Ector_003Eb__4_1(object state)
                {
                }
            }

            private T1 t1;
            private T2 t2;
            private int completedCount;
            private UniTaskCompletionSourceCore<(T1, T2)> core;
            public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2)
            {
            }

            private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2> self, in UniTask<T1>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2> self, in UniTask<T2>.Awaiter awaiter)
            {
            }

            public (T1, T2) GetResult(short token)
            {
                return default((T1, T2));
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
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
        }

        private sealed class WhenAllPromise<T1, T2, T3> : IUniTaskSource<(T1, T2, T3)>, IUniTaskSource, IValueTaskSource, IValueTaskSource<(T1, T2, T3)>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__5_0;
                public static Action<object> _003C_003E9__5_1;
                public static Action<object> _003C_003E9__5_2;
                public _003C_003Ec()
                {
                }

                internal void _003C_002Ector_003Eb__5_0(object state)
                {
                }

                internal void _003C_002Ector_003Eb__5_1(object state)
                {
                }

                internal void _003C_002Ector_003Eb__5_2(object state)
                {
                }
            }

            private T1 t1;
            private T2 t2;
            private T3 t3;
            private int completedCount;
            private UniTaskCompletionSourceCore<(T1, T2, T3)> core;
            public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3)
            {
            }

            private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3> self, in UniTask<T1>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3> self, in UniTask<T2>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3> self, in UniTask<T3>.Awaiter awaiter)
            {
            }

            public (T1, T2, T3) GetResult(short token)
            {
                return default((T1, T2, T3));
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
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
        }

        private sealed class WhenAllPromise<T1, T2, T3, T4> : IUniTaskSource<(T1, T2, T3, T4)>, IUniTaskSource, IValueTaskSource, IValueTaskSource<(T1, T2, T3, T4)>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__6_0;
                public static Action<object> _003C_003E9__6_1;
                public static Action<object> _003C_003E9__6_2;
                public static Action<object> _003C_003E9__6_3;
                public _003C_003Ec()
                {
                }

                internal void _003C_002Ector_003Eb__6_0(object state)
                {
                }

                internal void _003C_002Ector_003Eb__6_1(object state)
                {
                }

                internal void _003C_002Ector_003Eb__6_2(object state)
                {
                }

                internal void _003C_002Ector_003Eb__6_3(object state)
                {
                }
            }

            private T1 t1;
            private T2 t2;
            private T3 t3;
            private T4 t4;
            private int completedCount;
            private UniTaskCompletionSourceCore<(T1, T2, T3, T4)> core;
            public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4)
            {
            }

            private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4> self, in UniTask<T1>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4> self, in UniTask<T2>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4> self, in UniTask<T3>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4> self, in UniTask<T4>.Awaiter awaiter)
            {
            }

            public (T1, T2, T3, T4) GetResult(short token)
            {
                return default((T1, T2, T3, T4));
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
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
        }

        private sealed class WhenAllPromise<T1, T2, T3, T4, T5> : IUniTaskSource<(T1, T2, T3, T4, T5)>, IUniTaskSource, IValueTaskSource, IValueTaskSource<(T1, T2, T3, T4, T5)>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__7_0;
                public static Action<object> _003C_003E9__7_1;
                public static Action<object> _003C_003E9__7_2;
                public static Action<object> _003C_003E9__7_3;
                public static Action<object> _003C_003E9__7_4;
                public _003C_003Ec()
                {
                }

                internal void _003C_002Ector_003Eb__7_0(object state)
                {
                }

                internal void _003C_002Ector_003Eb__7_1(object state)
                {
                }

                internal void _003C_002Ector_003Eb__7_2(object state)
                {
                }

                internal void _003C_002Ector_003Eb__7_3(object state)
                {
                }

                internal void _003C_002Ector_003Eb__7_4(object state)
                {
                }
            }

            private T1 t1;
            private T2 t2;
            private T3 t3;
            private T4 t4;
            private T5 t5;
            private int completedCount;
            private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5)> core;
            public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5)
            {
            }

            private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5> self, in UniTask<T1>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5> self, in UniTask<T2>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5> self, in UniTask<T3>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5> self, in UniTask<T4>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5> self, in UniTask<T5>.Awaiter awaiter)
            {
            }

            public (T1, T2, T3, T4, T5) GetResult(short token)
            {
                return default((T1, T2, T3, T4, T5));
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
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
        }

        private sealed class WhenAllPromise<T1, T2, T3, T4, T5, T6> : IUniTaskSource<(T1, T2, T3, T4, T5, T6)>, IUniTaskSource, IValueTaskSource, IValueTaskSource<(T1, T2, T3, T4, T5, T6)>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__8_0;
                public static Action<object> _003C_003E9__8_1;
                public static Action<object> _003C_003E9__8_2;
                public static Action<object> _003C_003E9__8_3;
                public static Action<object> _003C_003E9__8_4;
                public static Action<object> _003C_003E9__8_5;
                public _003C_003Ec()
                {
                }

                internal void _003C_002Ector_003Eb__8_0(object state)
                {
                }

                internal void _003C_002Ector_003Eb__8_1(object state)
                {
                }

                internal void _003C_002Ector_003Eb__8_2(object state)
                {
                }

                internal void _003C_002Ector_003Eb__8_3(object state)
                {
                }

                internal void _003C_002Ector_003Eb__8_4(object state)
                {
                }

                internal void _003C_002Ector_003Eb__8_5(object state)
                {
                }
            }

            private T1 t1;
            private T2 t2;
            private T3 t3;
            private T4 t4;
            private T5 t5;
            private T6 t6;
            private int completedCount;
            private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5, T6)> core;
            public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6)
            {
            }

            private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T1>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T2>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T3>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T4>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T5>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T6>.Awaiter awaiter)
            {
            }

            public (T1, T2, T3, T4, T5, T6) GetResult(short token)
            {
                return default((T1, T2, T3, T4, T5, T6));
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
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
        }

        private sealed class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> : IUniTaskSource<(T1, T2, T3, T4, T5, T6, T7)>, IUniTaskSource, IValueTaskSource, IValueTaskSource<(T1, T2, T3, T4, T5, T6, T7)>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__9_0;
                public static Action<object> _003C_003E9__9_1;
                public static Action<object> _003C_003E9__9_2;
                public static Action<object> _003C_003E9__9_3;
                public static Action<object> _003C_003E9__9_4;
                public static Action<object> _003C_003E9__9_5;
                public static Action<object> _003C_003E9__9_6;
                public _003C_003Ec()
                {
                }

                internal void _003C_002Ector_003Eb__9_0(object state)
                {
                }

                internal void _003C_002Ector_003Eb__9_1(object state)
                {
                }

                internal void _003C_002Ector_003Eb__9_2(object state)
                {
                }

                internal void _003C_002Ector_003Eb__9_3(object state)
                {
                }

                internal void _003C_002Ector_003Eb__9_4(object state)
                {
                }

                internal void _003C_002Ector_003Eb__9_5(object state)
                {
                }

                internal void _003C_002Ector_003Eb__9_6(object state)
                {
                }
            }

            private T1 t1;
            private T2 t2;
            private T3 t3;
            private T4 t4;
            private T5 t5;
            private T6 t6;
            private T7 t7;
            private int completedCount;
            private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5, T6, T7)> core;
            public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7)
            {
            }

            private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T1>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T2>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T3>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T4>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T5>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T6>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T7>.Awaiter awaiter)
            {
            }

            public (T1, T2, T3, T4, T5, T6, T7) GetResult(short token)
            {
                return default((T1, T2, T3, T4, T5, T6, T7));
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
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
        }

        private sealed class WhenAllPromise<T> : IUniTaskSource<T[]>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T[]>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__3_0;
                public _003C_003Ec()
                {
                }

                internal void _003C_002Ector_003Eb__3_0(object state)
                {
                }
            }

            private T[] result;
            private int completeCount;
            private UniTaskCompletionSourceCore<T[]> core;
            public WhenAllPromise(UniTask<T>[] tasks, int tasksLength)
            {
            }

            private static void TryInvokeContinuation(WhenAllPromise<T> self, in UniTask<T>.Awaiter awaiter, int i)
            {
            }

            public T[] GetResult(short token)
            {
                return null;
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
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
        }

        private sealed class WhenAllPromise : IUniTaskSource, IValueTaskSource
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__3_0;
                public _003C_003Ec()
                {
                }

                internal void _003C_002Ector_003Eb__3_0(object state)
                {
                }
            }

            private int completeCount;
            private int tasksLength;
            private UniTaskCompletionSourceCore<AsyncUnit> core;
            public WhenAllPromise(UniTask[] tasks, int tasksLength)
            {
            }

            private static void TryInvokeContinuation(WhenAllPromise self, in Awaiter awaiter)
            {
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
        }

        private sealed class WhenAnyPromise<T1, T2> : IUniTaskSource<(int, T1, T2)>, IUniTaskSource, IValueTaskSource, IValueTaskSource<(int, T1, T2)>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__2_0;
                public static Action<object> _003C_003E9__2_1;
                public _003C_003Ec()
                {
                }

                internal void _003C_002Ector_003Eb__2_0(object state)
                {
                }

                internal void _003C_002Ector_003Eb__2_1(object state)
                {
                }
            }

            private int completedCount;
            private UniTaskCompletionSourceCore<(int, T1 result1, T2 result2)> core;
            public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2)
            {
            }

            private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2> self, in UniTask<T1>.Awaiter awaiter)
            {
            }

            private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2> self, in UniTask<T2>.Awaiter awaiter)
            {
            }

            public (int, T1, T2) GetResult(short token)
            {
                return default((int, T1, T2));
            }

            public UniTaskStatus GetStatus(short token)
            {
                return default(UniTaskStatus);
            }

            public void OnCompleted(Action<object> continuation, object state, short token)
            {
            }

            public UniTaskStatus UnsafeGetStatus()
            {
                return default(UniTaskStatus);
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
            {
            }
        }

        private sealed class WhenAnyLRPromise<T> : IUniTaskSource<(bool, T)>, IUniTaskSource, IValueTaskSource, IValueTaskSource<(bool, T)>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__2_0;
                public static Action<object> _003C_003E9__2_1;
                public _003C_003Ec()
                {
                }

                internal void _003C_002Ector_003Eb__2_0(object state)
                {
                }

                internal void _003C_002Ector_003Eb__2_1(object state)
                {
                }
            }

            private int completedCount;
            private UniTaskCompletionSourceCore<(bool, T)> core;
            public WhenAnyLRPromise(UniTask<T> leftTask, UniTask rightTask)
            {
            }

            private static void TryLeftInvokeContinuation(WhenAnyLRPromise<T> self, in UniTask<T>.Awaiter awaiter)
            {
            }

            private static void TryRightInvokeContinuation(WhenAnyLRPromise<T> self, in Awaiter awaiter)
            {
            }

            public (bool, T) GetResult(short token)
            {
                return default((bool, T));
            }

            public UniTaskStatus GetStatus(short token)
            {
                return default(UniTaskStatus);
            }

            public void OnCompleted(Action<object> continuation, object state, short token)
            {
            }

            public UniTaskStatus UnsafeGetStatus()
            {
                return default(UniTaskStatus);
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
            {
            }
        }

        private sealed class WhenAnyPromise : IUniTaskSource<int>, IUniTaskSource, IValueTaskSource, IValueTaskSource<int>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Action<object> _003C_003E9__2_0;
                public _003C_003Ec()
                {
                }

                internal void _003C_002Ector_003Eb__2_0(object state)
                {
                }
            }

            private int completedCount;
            private UniTaskCompletionSourceCore<int> core;
            public WhenAnyPromise(UniTask[] tasks, int tasksLength)
            {
            }

            private static void TryInvokeContinuation(WhenAnyPromise self, in Awaiter awaiter, int i)
            {
            }

            public int GetResult(short token)
            {
                return default(int);
            }

            public UniTaskStatus GetStatus(short token)
            {
                return default(UniTaskStatus);
            }

            public void OnCompleted(Action<object> continuation, object state, short token)
            {
            }

            public UniTaskStatus UnsafeGetStatus()
            {
                return default(UniTaskStatus);
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
            {
            }
        }

        private sealed class AsyncUnitSource : IUniTaskSource<AsyncUnit>, IUniTaskSource, IValueTaskSource, IValueTaskSource<AsyncUnit>
        {
            private readonly IUniTaskSource source;
            public AsyncUnitSource(IUniTaskSource source)
            {
            }

            public AsyncUnit GetResult(short token)
            {
                return default(AsyncUnit);
            }

            public UniTaskStatus GetStatus(short token)
            {
                return default(UniTaskStatus);
            }

            public void OnCompleted(Action<object> continuation, object state, short token)
            {
            }

            public UniTaskStatus UnsafeGetStatus()
            {
                return default(UniTaskStatus);
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
            {
            }
        }

        private sealed class IsCanceledSource : IUniTaskSource<bool>, IUniTaskSource, IValueTaskSource, IValueTaskSource<bool>
        {
            private readonly IUniTaskSource source;
            public IsCanceledSource(IUniTaskSource source)
            {
            }

            public bool GetResult(short token)
            {
                return default(bool);
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
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
        }

        public readonly struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
        {
            private readonly UniTask task;
            public bool IsCompleted
            {
                [MethodImpl(256)]
                [DebuggerHidden]
                get
                {
                    return default(bool);
                }
            }

            [MethodImpl(256)]
            [DebuggerHidden]
            public Awaiter(in UniTask task)
            {
                this = default;
            }

            [MethodImpl(256)]
            [DebuggerHidden]
            public void GetResult()
            {
            }

            [MethodImpl(256)]
            [DebuggerHidden]
            public void OnCompleted(Action continuation)
            {
            }

            [MethodImpl(256)]
            [DebuggerHidden]
            public void UnsafeOnCompleted(Action continuation)
            {
            }

            [MethodImpl(256)]
            [DebuggerHidden]
            public void SourceOnCompleted(Action<object> continuation, object state)
            {
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public _003C_003Ec()
            {
            }

            internal UniTask _003C_002Ecctor_003Eb__201_0()
            {
                return default(UniTask);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CRunOnThreadPool_003Ed__82 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken cancellationToken;
            public bool configureAwait;
            public Action action;
            private SwitchToThreadPoolAwaitable.Awaiter _003C_003Eu__1;
            private object _003C_003E7__wrap1;
            private int _003C_003E7__wrap2;
            private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CRunOnThreadPool_003Ed__84 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken cancellationToken;
            public bool configureAwait;
            public Func<UniTask> action;
            private SwitchToThreadPoolAwaitable.Awaiter _003C_003Eu__1;
            private object _003C_003E7__wrap1;
            private int _003C_003E7__wrap2;
            private Awaiter _003C_003Eu__2;
            private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__3;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CRunOnThreadPool_003Ed__87<T> : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;
            public CancellationToken cancellationToken;
            public bool configureAwait;
            public Func<UniTask<T>> func;
            private SwitchToThreadPoolAwaitable.Awaiter _003C_003Eu__1;
            private object _003C_003E7__wrap1;
            private int _003C_003E7__wrap2;
            private T _003C_003E7__wrap3;
            private UniTask<T>.Awaiter _003C_003Eu__2;
            private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__3;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private static readonly UniTask CanceledUniTask;
        public static readonly UniTask CompletedTask;
        private readonly IUniTaskSource source;
        private readonly short token;
        public UniTaskStatus Status
        {
            [MethodImpl(256)]
            [DebuggerHidden]
            get
            {
                return default(UniTaskStatus);
            }
        }

        public static Cysharp.Threading.Tasks.YieldAwaitable Yield()
        {
            return default(Cysharp.Threading.Tasks.YieldAwaitable);
        }

        public static UniTask Yield(CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask);
        }

        public static UniTask Yield(PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask);
        }

        public static UniTask NextFrame(CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask);
        }

        public static UniTask NextFrame(PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask);
        }

        public static UniTask WaitForEndOfFrame(MonoBehaviour coroutineRunner, CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask);
        }

        public static UniTask DelayFrame(int delayFrameCount, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PlayerLoopTiming.Update)] PlayerLoopTiming delayTiming, [Optional] CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask);
        }

        public static UniTask Delay(int millisecondsDelay, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool ignoreTimeScale, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PlayerLoopTiming.Update)] PlayerLoopTiming delayTiming, [Optional] CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask);
        }

        public static UniTask Delay(TimeSpan delayTimeSpan, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool ignoreTimeScale, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PlayerLoopTiming.Update)] PlayerLoopTiming delayTiming, [Optional] CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask);
        }

        public static UniTask Delay(TimeSpan delayTimeSpan, DelayType delayType, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PlayerLoopTiming.Update)] PlayerLoopTiming delayTiming, [Optional] CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask);
        }

        public static UniTask FromException(Exception ex)
        {
            return default(UniTask);
        }

        public static UniTask<T> FromException<T>(Exception ex)
        {
            return default(UniTask<T>);
        }

        public static UniTask<T> FromResult<T>(T value)
        {
            return default(UniTask<T>);
        }

        public static UniTask FromCanceled([Optional] CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public static UniTask<T> FromCanceled<T>([Optional] CancellationToken cancellationToken)
        {
            return default(UniTask<T>);
        }

        public static UniTask Create(Func<UniTask> factory)
        {
            return default(UniTask);
        }

        public static AsyncLazy Lazy(Func<UniTask> factory)
        {
            return null;
        }

        public static UniTask Never(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CRunOnThreadPool_003Ed__82))]
        public static UniTask RunOnThreadPool(Action action, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(true)] bool configureAwait, [Optional] CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CRunOnThreadPool_003Ed__84))]
        public static UniTask RunOnThreadPool(Func<UniTask> action, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(true)] bool configureAwait, [Optional] CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CRunOnThreadPool_003Ed__87<>))]
        public static UniTask<T> RunOnThreadPool<T>(Func<UniTask<T>> func, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(true)] bool configureAwait, [Optional] CancellationToken cancellationToken)
        {
            return default(UniTask<T>);
        }

        public static SwitchToMainThreadAwaitable SwitchToMainThread([Optional] CancellationToken cancellationToken)
        {
            return default(SwitchToMainThreadAwaitable);
        }

        public static SwitchToThreadPoolAwaitable SwitchToThreadPool()
        {
            return default(SwitchToThreadPoolAwaitable);
        }

        public static UniTask WaitUntil(Func<bool> predicate, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PlayerLoopTiming.Update)] PlayerLoopTiming timing, [Optional] CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask);
        }

        public static UniTask WaitWhile(Func<bool> predicate, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PlayerLoopTiming.Update)] PlayerLoopTiming timing, [Optional] CancellationToken cancellationToken, bool cancelImmediately = false)
        {
            return default(UniTask);
        }

        public static UniTask WaitUntilCanceled(CancellationToken cancellationToken, PlayerLoopTiming timing = PlayerLoopTiming.Update, bool completeImmediately = false)
        {
            return default(UniTask);
        }

        public static UniTask<(T1, T2)> WhenAll<T1, T2>(UniTask<T1> task1, UniTask<T2> task2)
        {
            return default(UniTask<(T1, T2)>);
        }

        public static UniTask<(T1, T2, T3)> WhenAll<T1, T2, T3>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3)
        {
            return default(UniTask<(T1, T2, T3)>);
        }

        public static UniTask<(T1, T2, T3, T4)> WhenAll<T1, T2, T3, T4>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4)
        {
            return default(UniTask<(T1, T2, T3, T4)>);
        }

        public static UniTask<(T1, T2, T3, T4, T5)> WhenAll<T1, T2, T3, T4, T5>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5)
        {
            return default(UniTask<(T1, T2, T3, T4, T5)>);
        }

        public static UniTask<(T1, T2, T3, T4, T5, T6)> WhenAll<T1, T2, T3, T4, T5, T6>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6)
        {
            return default(UniTask<(T1, T2, T3, T4, T5, T6)>);
        }

        public static UniTask<(T1, T2, T3, T4, T5, T6, T7)> WhenAll<T1, T2, T3, T4, T5, T6, T7>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7)
        {
            return default(UniTask<(T1, T2, T3, T4, T5, T6, T7)>);
        }

        public static UniTask<T[]> WhenAll<T>(IEnumerable<UniTask<T>> tasks)
        {
            return default(UniTask<T[]>);
        }

        public static UniTask WhenAll(params UniTask[] tasks)
        {
            return default(UniTask);
        }

        public static UniTask WhenAll(IEnumerable<UniTask> tasks)
        {
            return default(UniTask);
        }

        public static UniTask<(int, T1, T2)> WhenAny<T1, T2>(UniTask<T1> task1, UniTask<T2> task2)
        {
            return default(UniTask<(int, T1, T2)>);
        }

        public static UniTask<(bool, T)> WhenAny<T>(UniTask<T> leftTask, UniTask rightTask)
        {
            return default(UniTask<(bool, T)>);
        }

        public static UniTask<int> WhenAny(params UniTask[] tasks)
        {
            return default(UniTask<int>);
        }

        public static UniTask<int> WhenAny(IEnumerable<UniTask> tasks)
        {
            return default(UniTask<int>);
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public UniTask(IUniTaskSource source, short token)
        {
            this = default;
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public Awaiter GetAwaiter()
        {
            return default(Awaiter);
        }

        public UniTask<bool> SuppressCancellationThrow()
        {
            return default(UniTask<bool>);
        }

        public override string ToString()
        {
            return null;
        }

        public UniTask<AsyncUnit> AsAsyncUnitUniTask()
        {
            return default(UniTask<AsyncUnit>);
        }
    }
}
