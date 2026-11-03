namespace UniRx
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.ComponentModel;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::UniRx;
    using global::UniRx.InternalUtil;
    using global::UnityEngine;

    public static class Scheduler
    {
        private class CurrentThreadScheduler : IScheduler
        {
            private static class Trampoline
            {
                public static void Run(SchedulerQueue queue)
                {
                }
            }

            [ThreadStatic]
            private static SchedulerQueue s_threadLocalQueue;
            [ThreadStatic]
            private static Stopwatch s_clock;
            private static TimeSpan Time
            {
                get
                {
                    return default(TimeSpan);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Advanced)]
            public static bool IsScheduleRequired
            {
                get
                {
                    return default(bool);
                }
            }

            public DateTimeOffset Now
            {
                get
                {
                    return default(DateTimeOffset);
                }
            }

            private static SchedulerQueue GetQueue()
            {
                return null;
            }

            private static void SetQueue(SchedulerQueue newQueue)
            {
            }

            public IDisposable Schedule(Action action)
            {
                return null;
            }

            public IDisposable Schedule(TimeSpan dueTime, Action action)
            {
                return null;
            }

            public CurrentThreadScheduler()
            {
            }
        }

        private class ImmediateScheduler : IScheduler
        {
            public DateTimeOffset Now
            {
                get
                {
                    return default(DateTimeOffset);
                }
            }

            public ImmediateScheduler()
            {
            }

            public IDisposable Schedule(Action action)
            {
                return null;
            }

            public IDisposable Schedule(TimeSpan dueTime, Action action)
            {
                return null;
            }
        }

        public static class DefaultSchedulers
        {
            private static IScheduler constantTime;
            private static IScheduler tailRecursion;
            private static IScheduler iteration;
            private static IScheduler timeBasedOperations;
            public static IScheduler ConstantTimeOperations
            {
                get
                {
                    return null;
                }
            }

            public static IScheduler TailRecursion
            {
                get
                {
                    return null;
                }
            }

            public static IScheduler Iteration
            {
                get
                {
                    return null;
                }
            }

            public static IScheduler TimeBasedOperations
            {
                get
                {
                    return null;
                }
            }
        }

        private class ThreadPoolScheduler : IScheduler, ISchedulerPeriodic
        {
            private sealed class Timer : IDisposable
            {
                private static readonly HashSet<System.Threading.Timer> s_timers;
                private readonly SingleAssignmentDisposable _disposable;
                private Action _action;
                private System.Threading.Timer _timer;
                private bool _hasAdded;
                private bool _hasRemoved;
                public Timer(TimeSpan dueTime, Action action)
                {
                }

                private void Tick(object state)
                {
                }

                private void Unroot()
                {
                }

                public void Dispose()
                {
                }
            }

            private sealed class PeriodicTimer : IDisposable
            {
                private static readonly HashSet<System.Threading.Timer> s_timers;
                private Action _action;
                private System.Threading.Timer _timer;
                private readonly AsyncLock _gate;
                public PeriodicTimer(TimeSpan period, Action action)
                {
                }

                private void Tick(object state)
                {
                }

                public void Dispose()
                {
                }
            }

            public DateTimeOffset Now
            {
                get
                {
                    return default(DateTimeOffset);
                }
            }

            public ThreadPoolScheduler()
            {
            }

            public IDisposable Schedule(Action action)
            {
                return null;
            }

            public IDisposable Schedule(TimeSpan dueTime, Action action)
            {
                return null;
            }

            public IDisposable SchedulePeriodic(TimeSpan period, Action action)
            {
                return null;
            }
        }

        private class MainThreadScheduler : IScheduler, ISchedulerPeriodic
        {
            [CompilerGenerated]
            private sealed class _003CDelayAction_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
            {
                private int _003C_003E1__state;
                private object _003C_003E2__current;
                public TimeSpan dueTime;
                public ICancelable cancellation;
                public Action action;
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
                public _003CDelayAction_003Ed__2(int _003C_003E1__state)
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
            private sealed class _003CPeriodicAction_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
            {
                private int _003C_003E1__state;
                private object _003C_003E2__current;
                public TimeSpan period;
                public ICancelable cancellation;
                public Action action;
                private WaitForSeconds _003CyieldInstruction_003E5__2;
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
                public _003CPeriodicAction_003Ed__3(int _003C_003E1__state)
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

            private readonly Action<object> scheduleAction;
            public DateTimeOffset Now
            {
                get
                {
                    return default(DateTimeOffset);
                }
            }

            public MainThreadScheduler()
            {
            }

            [IteratorStateMachine(typeof(_003CDelayAction_003Ed__2))]
            private IEnumerator DelayAction(TimeSpan dueTime, Action action, ICancelable cancellation)
            {
                return null;
            }

            [IteratorStateMachine(typeof(_003CPeriodicAction_003Ed__3))]
            private IEnumerator PeriodicAction(TimeSpan period, Action action, ICancelable cancellation)
            {
                return null;
            }

            private void Schedule(object state)
            {
            }

            public IDisposable Schedule(Action action)
            {
                return null;
            }

            public IDisposable Schedule(TimeSpan dueTime, Action action)
            {
                return null;
            }

            public IDisposable SchedulePeriodic(TimeSpan period, Action action)
            {
                return null;
            }
        }

        public static readonly IScheduler CurrentThread;
        public static readonly IScheduler Immediate;
        public static readonly IScheduler ThreadPool;
        private static IScheduler mainThread;
        public static bool IsCurrentThreadSchedulerScheduleRequired
        {
            get
            {
                return default(bool);
            }
        }

        public static DateTimeOffset Now
        {
            get
            {
                return default(DateTimeOffset);
            }
        }

        public static IScheduler MainThread
        {
            get
            {
                return null;
            }
        }

        public static TimeSpan Normalize(TimeSpan timeSpan)
        {
            return default(TimeSpan);
        }

        public static IDisposable Schedule(this IScheduler scheduler, Action<Action> action)
        {
            return null;
        }

        public static IDisposable Schedule(this IScheduler scheduler, TimeSpan dueTime, Action<Action<TimeSpan>> action)
        {
            return null;
        }
    }
}
