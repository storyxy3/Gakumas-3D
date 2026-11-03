namespace DG.Tweening.Core
{
    using global::System.Runtime.InteropServices;
    using global::DG.Tweening;

    public static class Debugger
    {
        private static int _logPriority;
        public static int logPriority
        {
            get
            {
                return default(int);
            }
        }

        public static void Log(object message)
        {
        }

        public static void LogWarning(object message, [Optional] Tween t)
        {
        }

        public static void LogError(object message)
        {
        }

        public static void LogReport(object message)
        {
        }

        public static void LogSafeModeReport(object message)
        {
        }

        public static void LogInvalidTween(Tween t)
        {
        }

        public static void LogNestedTween(Tween t)
        {
        }

        public static void LogNullTween(Tween t)
        {
        }

        public static void LogRemoveActiveTweenError(string errorInfo, Tween t)
        {
        }

        public static void LogAddActiveTweenError(string errorInfo, Tween t)
        {
        }

        public static void SetLogPriority(LogBehaviour logBehaviour)
        {
        }
    }
}
