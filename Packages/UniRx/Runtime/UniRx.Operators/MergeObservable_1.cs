namespace UniRx.Operators
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class MergeObservable<T> : OperatorObservableBase<T>
    {
        private class MergeOuterObserver : OperatorObserverBase<IObservable<T>, T>
        {
            private class Merge : OperatorObserverBase<T, T>
            {
                private readonly MergeOuterObserver parent;
                private readonly IDisposable cancel;
                // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
                public Merge(MergeOuterObserver parent, IDisposable cancel) : base(default, default)
                {
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

            private readonly MergeObservable<T> parent;
            private CompositeDisposable collectionDisposable;
            private SingleAssignmentDisposable sourceDisposable;
            private object gate;
            private bool isStopped;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public MergeOuterObserver(MergeObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
            {
                return null;
            }

            public override void OnNext(IObservable<T> value)
            {
            }

            public override void OnError(Exception error)
            {
            }

            public override void OnCompleted()
            {
            }
        }

        private class MergeConcurrentObserver : OperatorObserverBase<IObservable<T>, T>
        {
            private class Merge : OperatorObserverBase<T, T>
            {
                private readonly MergeConcurrentObserver parent;
                private readonly IDisposable cancel;
                // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
                public Merge(MergeConcurrentObserver parent, IDisposable cancel) : base(default, default)
                {
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

            private readonly MergeObservable<T> parent;
            private CompositeDisposable collectionDisposable;
            private SingleAssignmentDisposable sourceDisposable;
            private object gate;
            private bool isStopped;
            private Queue<IObservable<T>> q;
            private int activeCount;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public MergeConcurrentObserver(MergeObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
            {
                return null;
            }

            public override void OnNext(IObservable<T> value)
            {
            }

            public override void OnError(Exception error)
            {
            }

            public override void OnCompleted()
            {
            }

            private void Subscribe(IObservable<T> innerSource)
            {
            }
        }

        private readonly IObservable<IObservable<T>> sources;
        private readonly int maxConcurrent;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public MergeObservable(IObservable<IObservable<T>> sources, bool isRequiredSubscribeOnCurrentThread) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
