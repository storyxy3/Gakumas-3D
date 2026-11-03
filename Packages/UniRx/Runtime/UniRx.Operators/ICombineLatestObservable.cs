namespace UniRx.Operators
{
    using global::System;

    internal interface ICombineLatestObservable
    {
        void Publish(int index);
        void Fail(Exception error);
        void Done(int index);
    }
}
