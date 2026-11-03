namespace UniRx
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::UniRx;
    using global::UniRx.Operators;

    public static class Observable
    {
        private class ConnectableObservable<T> : IConnectableObservable<T>, IObservable<T>
        {
            private class Connection : IDisposable
            {
                private readonly ConnectableObservable<T> parent;
                private IDisposable subscription;
                public Connection(ConnectableObservable<T> parent, IDisposable subscription)
                {
                }

                public void Dispose()
                {
                }
            }

            private readonly IObservable<T> source;
            private readonly ISubject<T> subject;
            private readonly object gate;
            private Connection connection;
            public ConnectableObservable(IObservable<T> source, ISubject<T> subject)
            {
            }

            public IDisposable Connect()
            {
                return null;
            }

            public IDisposable Subscribe(IObserver<T> observer)
            {
                return null;
            }
        }

        [CompilerGenerated]
        private sealed class _003CCombineSources_003Ed__29<T> : IEnumerable<IObservable<T>>, IEnumerable, IEnumerator<IObservable<T>>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private IObservable<T> _003C_003E2__current;
            private int _003C_003El__initialThreadId;
            private IObservable<T> first;
            public IObservable<T> _003C_003E3__first;
            private IObservable<T>[] seconds;
            public IObservable<T>[] _003C_003E3__seconds;
            private int _003Ci_003E5__2;
            IObservable<T> System.Collections.Generic.IEnumerator<System.IObservable<T>>.Current
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
            public _003CCombineSources_003Ed__29(int _003C_003E1__state)
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

            [DebuggerHidden]
            IEnumerator<IObservable<T>> System.Collections.Generic.IEnumerable<System.IObservable<T>>.GetEnumerator()
            {
                return null;
            }

            [DebuggerHidden]
            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }
        }

        [CompilerGenerated]
        private sealed class _003CEveryCycleCore_003Ed__311 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public CancellationToken cancellationToken;
            public IObserver<long> observer;
            private long _003Ccount_003E5__2;
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
            public _003CEveryCycleCore_003Ed__311(int _003C_003E1__state)
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
        private sealed class _003CTimerFrameCore_003Ed__320 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public int dueTimeFrameCount;
            public IObserver<long> observer;
            public CancellationToken cancel;
            private int _003CcurrentFrame_003E5__2;
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
            public _003CTimerFrameCore_003Ed__320(int _003C_003E1__state)
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
        private sealed class _003CTimerFrameCore_003Ed__321 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public int dueTimeFrameCount;
            public int periodFrameCount;
            public IObserver<long> observer;
            public CancellationToken cancel;
            private long _003CsendCount_003E5__2;
            private int _003CcurrentFrame_003E5__3;
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
            public _003CTimerFrameCore_003Ed__321(int _003C_003E1__state)
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

        private static readonly TimeSpan InfiniteTimeSpan;
        private static readonly HashSet<Type> YieldInstructionTypes;
        public static IConnectableObservable<T> Multicast<T>(this IObservable<T> source, ISubject<T> subject)
        {
            return null;
        }

        public static IConnectableObservable<T> Publish<T>(this IObservable<T> source)
        {
            return null;
        }

        public static IConnectableObservable<T> Replay<T>(this IObservable<T> source, int bufferSize)
        {
            return null;
        }

        public static IObservable<T> RefCount<T>(this IConnectableObservable<T> source)
        {
            return null;
        }

        public static IObservable<T> Share<T>(this IObservable<T> source)
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CCombineSources_003Ed__29<>))]
        private static IEnumerable<IObservable<T>> CombineSources<T>(IObservable<T> first, IObservable<T>[] seconds)
        {
            return null;
        }

        public static IObservable<TSource> Concat<TSource>(this IEnumerable<IObservable<TSource>> sources)
        {
            return null;
        }

        public static IObservable<TSource> Merge<TSource>(this IEnumerable<IObservable<TSource>> sources)
        {
            return null;
        }

        public static IObservable<TSource> Merge<TSource>(this IEnumerable<IObservable<TSource>> sources, IScheduler scheduler)
        {
            return null;
        }

        public static IObservable<T> Merge<T>(this IObservable<T> first, params IObservable<T>[] seconds)
        {
            return null;
        }

        public static IObservable<TResult> CombineLatest<TLeft, TRight, TResult>(this IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, TRight, TResult> selector)
        {
            return null;
        }

        public static IObservable<IList<T>> CombineLatest<T>(this IEnumerable<IObservable<T>> sources)
        {
            return null;
        }

        public static IObservable<IList<TSource>> CombineLatest<TSource>(params IObservable<TSource>[] sources)
        {
            return null;
        }

        public static IObservable<TR> CombineLatest<T1, T2, T3, TR>(this IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, CombineLatestFunc<T1, T2, T3, TR> resultSelector)
        {
            return null;
        }

        public static IObservable<TR> CombineLatest<T1, T2, T3, T4, TR>(this IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, CombineLatestFunc<T1, T2, T3, T4, TR> resultSelector)
        {
            return null;
        }

        public static IObservable<TR> CombineLatest<T1, T2, T3, T4, T5, TR>(this IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, CombineLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector)
        {
            return null;
        }

        public static IObservable<T> Switch<T>(this IObservable<IObservable<T>> sources)
        {
            return null;
        }

        public static IObservable<TResult> WithLatestFrom<TLeft, TRight, TResult>(this IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, TRight, TResult> selector)
        {
            return null;
        }

        public static IObservable<T> StartWith<T>(this IObservable<T> source, T value)
        {
            return null;
        }

        public static IObservable<T> StartWith<T>(this IObservable<T> source, Func<T> valueFactory)
        {
            return null;
        }

        public static IObservable<T> AsObservable<T>(this IObservable<T> source)
        {
            return null;
        }

        public static IObservable<T> ToObservable<T>(this IEnumerable<T> source, IScheduler scheduler)
        {
            return null;
        }

        public static IObservable<TResult> OfType<TSource, TResult>(this IObservable<TSource> source)
        {
            return null;
        }

        public static IObservable<Unit> AsUnitObservable<T>(this IObservable<T> source)
        {
            return null;
        }

        public static IObservable<T> CreateWithState<T, TState>(TState state, Func<TState, IObserver<T>, IDisposable> subscribe)
        {
            return null;
        }

        public static IObservable<T> Empty<T>()
        {
            return null;
        }

        public static IObservable<T> Empty<T>(IScheduler scheduler)
        {
            return null;
        }

        public static IObservable<T> Return<T>(T value)
        {
            return null;
        }

        public static IObservable<T> Return<T>(T value, IScheduler scheduler)
        {
            return null;
        }

        public static IObservable<Unit> Return(Unit value)
        {
            return null;
        }

        public static IObservable<Unit> FromEvent<TDelegate>(Func<Action, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler)
        {
            return null;
        }

        public static IObservable<TEventArgs> FromEvent<TDelegate, TEventArgs>(Func<Action<TEventArgs>, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler)
        {
            return null;
        }

        public static IObservable<Unit> FromEvent(Action<Action> addHandler, Action<Action> removeHandler)
        {
            return null;
        }

        public static IObservable<T> FromEvent<T>(Action<Action<T>> addHandler, Action<Action<T>> removeHandler)
        {
            return null;
        }

        public static IObservable<T> Skip<T>(this IObservable<T> source, int count)
        {
            return null;
        }

        public static IObservable<IList<T>> Buffer<T>(this IObservable<T> source, int count)
        {
            return null;
        }

        public static IObservable<Pair<T>> Pairwise<T>(this IObservable<T> source)
        {
            return null;
        }

        public static IObservable<T> First<T>(this IObservable<T> source)
        {
            return null;
        }

        public static IObservable<long> Interval(TimeSpan period)
        {
            return null;
        }

        public static IObservable<long> Interval(TimeSpan period, IScheduler scheduler)
        {
            return null;
        }

        public static IObservable<long> Timer(TimeSpan dueTime)
        {
            return null;
        }

        public static IObservable<TSource> Throttle<TSource>(this IObservable<TSource> source, TimeSpan dueTime)
        {
            return null;
        }

        public static IObservable<TSource> Throttle<TSource>(this IObservable<TSource> source, TimeSpan dueTime, IScheduler scheduler)
        {
            return null;
        }

        public static IObservable<TR> Select<T, TR>(this IObservable<T> source, Func<T, TR> selector)
        {
            return null;
        }

        public static IObservable<T> Where<T>(this IObservable<T> source, Func<T, bool> predicate)
        {
            return null;
        }

        public static IObservable<T> Do<T>(this IObservable<T> source, Action<T> onNext)
        {
            return null;
        }

        public static IObservable<T> DistinctUntilChanged<T>(this IObservable<T> source)
        {
            return null;
        }

        public static IObservable<T> DistinctUntilChanged<T, TKey>(this IObservable<T> source, Func<T, TKey> keySelector)
        {
            return null;
        }

        public static IObservable<T> FromMicroCoroutine<T>(Func<IObserver<T>, CancellationToken, IEnumerator> coroutine, FrameCountType frameCountType = FrameCountType.Update)
        {
            return null;
        }

        public static IObservable<long> EveryUpdate()
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CEveryCycleCore_003Ed__311))]
        private static IEnumerator EveryCycleCore(IObserver<long> observer, CancellationToken cancellationToken)
        {
            return null;
        }

        public static IObservable<long> IntervalFrame(int intervalFrameCount, FrameCountType frameCountType = FrameCountType.Update)
        {
            return null;
        }

        public static IObservable<long> TimerFrame(int dueTimeFrameCount, FrameCountType frameCountType = FrameCountType.Update)
        {
            return null;
        }

        public static IObservable<long> TimerFrame(int dueTimeFrameCount, int periodFrameCount, FrameCountType frameCountType = FrameCountType.Update)
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CTimerFrameCore_003Ed__320))]
        private static IEnumerator TimerFrameCore(IObserver<long> observer, int dueTimeFrameCount, CancellationToken cancel)
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CTimerFrameCore_003Ed__321))]
        private static IEnumerator TimerFrameCore(IObserver<long> observer, int dueTimeFrameCount, int periodFrameCount, CancellationToken cancel)
        {
            return null;
        }

        public static IObservable<T> DelayFrame<T>(this IObservable<T> source, int frameCount, FrameCountType frameCountType = FrameCountType.Update)
        {
            return null;
        }

        public static IObservable<TSource> ThrottleFrame<TSource>(this IObservable<TSource> source, int frameCount, FrameCountType frameCountType = FrameCountType.Update)
        {
            return null;
        }
    }
}
