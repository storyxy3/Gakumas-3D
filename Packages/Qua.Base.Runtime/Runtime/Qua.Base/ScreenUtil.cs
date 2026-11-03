namespace Qua.Base
{
    using global::System.Threading;
    using global::UnityEngine;

    public static class ScreenUtil
    {
        private static SynchronizationContext unityContext;
        [RuntimeInitializeOnLoadMethod]
        private static void InitializeOnUnityLoad()
        {
        }
    }
}
