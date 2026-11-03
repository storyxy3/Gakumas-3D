namespace Campus.Common.Extensions
{
    using global::System.Threading;
    using global::UniRx;
    using global::UnityEngine;

    public static class GameObjectExtensions
    {
        public static CancellationToken GetCt(this GameObject gameObject)
        {
            return default(CancellationToken);
        }

        public static CompositeDisposable CreateOnDestroyCompositeDisposable(this GameObject gameObject)
        {
            return null;
        }
    }
}
