namespace Cysharp.Threading.Tasks
{
    using global::System.Threading;
    using global::UnityEngine;

    public static class UniTaskCancellationExtensions
    {
        public static CancellationToken GetCancellationTokenOnDestroy(this MonoBehaviour monoBehaviour)
        {
            return default(CancellationToken);
        }

        public static CancellationToken GetCancellationTokenOnDestroy(this GameObject gameObject)
        {
            return default(CancellationToken);
        }

        public static CancellationToken GetCancellationTokenOnDestroy(this Component component)
        {
            return default(CancellationToken);
        }
    }
}
