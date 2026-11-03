namespace Octo.Network
{
    using global::System.Reflection;
    using global::UnityEngine.Networking;

    internal static class UnityWebRequestExtensions
    {
        private static MethodInfo InternalSetUrlMethod;
        private static object[] InternalSetUrlParams;
        static UnityWebRequestExtensions()
        {
        }

        public static void FastSetUrl(this UnityWebRequest req, string url)
        {
        }

        public static ulong GetDownloadedBytesFromAssetBundle(UnityWebRequest req, ulong contentLength)
        {
            return default(ulong);
        }
    }
}
