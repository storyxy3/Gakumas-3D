namespace Qua.Utility
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::Qua.Utility;

    public class ListPool<T>
    {
        public readonly struct ListContainer : IDisposable, IEnumerable<T>, IEnumerable
        {
            public readonly List<T> list;
            internal ListContainer(List<T> list)
            {
                this = default;
            }

            public void Dispose()
            {
            }

            public static implicit operator List<T>(ListContainer self)
            {
                return null;
            }

            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }

            IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
            {
                return null;
            }

            public List<T>.Enumerator GetEnumerator()
            {
                return default(List<T>.Enumerator);
            }
        }

        public static List<T> Get()
        {
            return null;
        }

        public static ListContainer GetDisposable()
        {
            return default(ListContainer);
        }

        public static void Release(List<T> list)
        {
        }
    }
}
