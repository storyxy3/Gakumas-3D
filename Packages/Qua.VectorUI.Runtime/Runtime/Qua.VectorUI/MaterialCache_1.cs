namespace Qua.VectorUI
{
    using global::System.Collections.Generic;
    using global::Qua.VectorUI;
    using global::UnityEngine;

    public class MaterialCache<TKey>
    {
        private class Entry
        {
            public Material material;
            public int count;
            public Entry()
            {
            }
        }

        private readonly Dictionary<TKey, Entry> _entries;
        public bool TryGet(TKey key, out Material material)
        {
            throw null;
        }

        public void Add(TKey key, Material material)
        {
        }

        public void Remove(TKey key)
        {
        }

        public MaterialCache()
        {
        }
    }
}
