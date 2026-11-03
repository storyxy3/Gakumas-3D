namespace UniRx.Operators
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class ToObservableObservable<T> : OperatorObservableBase<T>
    {
        private class ToObservable : OperatorObserverBase<T, T>
        {
            [CompilerGenerated]
            private sealed class _003C_003Ec__DisplayClass2_0
            {
                public SingleAssignmentDisposable flag;
                public IEnumerator<T> e;
                public ToObservable _003C_003E4__this;
                public _003C_003Ec__DisplayClass2_0()
                {
                }

                internal void _003CRun_003Eb__0(Action self)
                {
                }
            }

            private readonly ToObservableObservable<T> parent;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public ToObservable(ToObservableObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
            {
                return null;
            }

            public override void OnNext(T value)
            {
            }

            public override void OnError(Exception error)
            {
            }

            public override void OnCompleted()
            {
            }
        }

        private readonly IEnumerable<T> source;
        private readonly IScheduler scheduler;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public ToObservableObservable(IEnumerable<T> source, IScheduler scheduler) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
