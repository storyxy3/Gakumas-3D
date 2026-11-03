namespace Campus.Common.Extensions
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;

    public static class ReactiveCollectionExtensions
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0<T>
        {
            public IReadOnlyReactiveCollection<T> self;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal IReadOnlyReactiveCollection<T> _003CObserveCollectionChanged_003Eb__0(int _)
            {
                return null;
            }

            internal IReadOnlyReactiveCollection<T> _003CObserveCollectionChanged_003Eb__1(CollectionReplaceEvent<T> _)
            {
                return null;
            }

            internal IReadOnlyReactiveCollection<T> _003CObserveCollectionChanged_003Eb__2(CollectionMoveEvent<T> _)
            {
                return null;
            }

            internal IReadOnlyReactiveCollection<T> _003CObserveCollectionChanged_003Eb__3()
            {
                return null;
            }
        }

        public static IObservable<IReadOnlyReactiveCollection<T>> ObserveCollectionChanged<T>(this IReadOnlyReactiveCollection<T> self, bool notifyCurrentCollection = false)
        {
            return null;
        }
    }
}
