namespace UniRx
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public static class UnityUIComponentExtensions
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<ScrollRect, IObserver<Vector2>, IDisposable> _003C_003E9__7_0;
            public _003C_003Ec()
            {
            }

            internal IDisposable _003COnValueChangedAsObservable_003Eb__7_0(ScrollRect s, IObserver<Vector2> observer)
            {
                return null;
            }
        }

        public static IObservable<Vector2> OnValueChangedAsObservable(this ScrollRect scrollRect)
        {
            return null;
        }
    }
}
