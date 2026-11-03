namespace Qua.PolygonUtility
{
    using global::System.Collections.Generic;
    using global::Qua.PolygonUtility;
    using global::Qua.Utility;

    internal abstract class Pooling<T> : IPooling where T : class, IPooling, new()
    {
        private static SimpleObjectPool<T> _pool;
        private static List<T> _cache;
        private static SimpleObjectPool<T> Pool
        {
            get
            {
                return null;
            }
        }

        public static T Rent()
        {
            return null;
        }

        public abstract void OnBeforeReturn();
        public static void ReturnAll()
        {
        }

        protected Pooling()
        {
        }
    }
}
