namespace Qua.Utility
{
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Threading;
    using global::UnityEngine;

    public static class CancellationUtility
    {
        public static void CancelAndDispose([AllowNull][MaybeNull] ref CancellationTokenSource source)
        {
        }

        public static CancellationToken Rebuild([AllowNull][NotNull] ref CancellationTokenSource source)
        {
            return default(CancellationToken);
        }

        public static CancellationToken Rebuild([AllowNull][NotNull] ref CancellationTokenSource source, CancellationToken ct1)
        {
            return default(CancellationToken);
        }

        public static CancellationToken Rebuild([AllowNull][NotNull] ref CancellationTokenSource source, CancellationToken ct1, CancellationToken ct2)
        {
            return default(CancellationToken);
        }

        public static CancellationToken Rebuild([AllowNull][NotNull] ref CancellationTokenSource source, GameObject gameObject)
        {
            return default(CancellationToken);
        }
    }
}
