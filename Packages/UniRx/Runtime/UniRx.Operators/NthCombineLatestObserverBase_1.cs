namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal abstract class NthCombineLatestObserverBase<T> : OperatorObserverBase<T, T>, ICombineLatestObservable
    {
        private readonly int length;
        private bool isAllValueStarted;
        private readonly bool[] isStarted;
        private readonly bool[] isCompleted;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public NthCombineLatestObserverBase(int length, IObserver<T> observer, IDisposable cancel) : base(default, default)
        {
        }

        public abstract T GetResult();
        public void Publish(int index)
        {
        }

        public void Done(int index)
        {
        }

        public void Fail(Exception error)
        {
        }
    }
}
