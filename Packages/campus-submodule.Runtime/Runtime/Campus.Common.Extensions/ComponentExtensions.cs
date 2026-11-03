namespace Campus.Common.Extensions
{
    using global::System.Threading;
    using global::UnityEngine;

    public static class ComponentExtensions
    {
        public static CancellationToken GetCt(this Component component)
        {
            return default(CancellationToken);
        }
    }
}
