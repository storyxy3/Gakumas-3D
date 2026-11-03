namespace Campus.Common
{
    using global::System;
    using global::Campus.Common;
    using global::UnityEngine;

    [Serializable]
    public struct SerializableGuid : IEquatable<SerializableGuid>
    {
        private static class GuidUtil
        {
            public static Guid Compose(ulong low, ulong high)
            {
                return default(Guid);
            }
        }

        private static class HashCode
        {
            public static int Combine(int hash1, int hash2)
            {
                return default(int);
            }
        }

        private static readonly SerializableGuid k_Empty;
        [SerializeField]
        private ulong m_GuidLow;
        [SerializeField]
        private ulong m_GuidHigh;
        public Guid guid
        {
            get
            {
                return default(Guid);
            }
        }

        public SerializableGuid(ulong guidLow, ulong guidHigh)
        {
            this = default;
        }

        public override int GetHashCode()
        {
            return default(int);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override string ToString()
        {
            return null;
        }

        public bool Equals(SerializableGuid other)
        {
            return default(bool);
        }
    }
}
