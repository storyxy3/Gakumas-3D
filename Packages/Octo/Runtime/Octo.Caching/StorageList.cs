namespace Octo.Caching
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Reflection;
    using global::Octo.Caching;

    [DefaultMember("Item")]
    internal sealed class StorageList : IStorageList
    {
        private object _mutex;
        private List<Storage> _list;
        public int Count
        {
            get
            {
                return default(int);
            }
        }

        public StorageList(int capacity)
        {
        }

        public void Add(Storage item)
        {
        }

        public void Remove(Storage item)
        {
        }

        public void MoveEnd(Storage item)
        {
        }

        public void SortByDate()
        {
        }

        public void ForEach(Func<Storage, bool> action, ref bool breakLoop)
        {
        }
    }
}
