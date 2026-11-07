namespace Octo.Caching
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Reflection;
    using global::System.Runtime.CompilerServices;
    using global::Octo.Caching;

    [DefaultMember("Item")]
    internal sealed class StorageList : IStorageList
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Comparison<Storage> _003C_003E9__11_0;
            public _003C_003Ec()
            {
            }

            internal int _003CSortByDate_003Eb__11_0(Storage a, Storage b)
            {
                return default(int);
            }
        }

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
