namespace Octo.Caching
{
    using global::System;
    using global::System.Reflection;
    using global::Octo.Caching;

    [DefaultMember("Item")]
    internal sealed class EmptyStorageList : IStorageList
    {
        public int Count
        {
            get
            {
                return default(int);
            }
        }

        public EmptyStorageList()
        {
        }

        void Octo.Caching.IStorageList.Add(Storage item)
        {
        }

        void Octo.Caching.IStorageList.Remove(Storage item)
        {
        }

        void Octo.Caching.IStorageList.MoveEnd(Storage item)
        {
        }

        void Octo.Caching.IStorageList.SortByDate()
        {
        }

        void Octo.Caching.IStorageList.ForEach(Func<Storage, bool> action, ref bool breakLoop)
        {
        }
    }
}
