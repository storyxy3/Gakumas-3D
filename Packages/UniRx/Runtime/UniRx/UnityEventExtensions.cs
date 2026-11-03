namespace UniRx
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;
    using global::UnityEngine.Events;

    public static class UnityEventExtensions
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec__1<T>
        {
            public static readonly _003C_003Ec__1<T> _003C_003E9;
            public static Func<Action<T>, UnityAction<T>> _003C_003E9__1_0;
            public _003C_003Ec__1()
            {
            }

            internal UnityAction<T> _003CAsObservable_003Eb__1_0(Action<T> h)
            {
                return null;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass1_0<T>
        {
            public UnityEvent<T> unityEvent;
            public _003C_003Ec__DisplayClass1_0()
            {
            }

            internal void _003CAsObservable_003Eb__1(UnityAction<T> h)
            {
            }

            internal void _003CAsObservable_003Eb__2(UnityAction<T> h)
            {
            }
        }

        public static IObservable<T> AsObservable<T>(this UnityEvent<T> unityEvent)
        {
            return null;
        }
    }
}
