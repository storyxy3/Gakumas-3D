namespace Octo.Caching
{
    using global::System;
    using global::System.Reflection;
    using global::Octo.Caching;

    [DefaultMember("Item")]
    internal interface IStorageList
    {
        int Count { get; }

        void Add(Storage item);
        void Remove(Storage item);
        void MoveEnd(Storage item);
        void SortByDate();
        void ForEach(Func<Storage, bool> action, ref bool breakLoop);
    }
}
