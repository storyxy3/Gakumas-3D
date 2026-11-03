namespace Octo
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Networking;

    internal static class OctoExtensions
    {
        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return default(bool);
        }

        public static void ForEach<T>(this HashSet<T> set, Action<T> action)
        {
        }

        public static void LogFormat(this ILogger logger, string tag, string format, params object[] args)
        {
        }

        public static void LogWarningFormat(this ILogger logger, string tag, string format, params object[] args)
        {
        }

        public static void LogErrorFormat(this ILogger logger, string tag, string format, params object[] args)
        {
        }

        public static AsyncOperation SendCompatible(this UnityWebRequest unityWebRequest)
        {
            return null;
        }
    }
}
