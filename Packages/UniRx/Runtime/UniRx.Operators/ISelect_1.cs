namespace UniRx.Operators
{
    using global::System;

    internal interface ISelect<TR>
    {
        IObservable<TR> CombinePredicate(Func<TR, bool> predicate);
    }
}
