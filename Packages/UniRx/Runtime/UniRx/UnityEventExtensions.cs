namespace UniRx
{
    using global::System;
    using global::UnityEngine.Events;

    public static class UnityEventExtensions
    {
        public static IObservable<T> AsObservable<T>(this UnityEvent<T> unityEvent)
        {
            return null;
        }
    }
}
