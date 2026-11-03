namespace Uguiss.Timeline
{
    using global::System.Collections.Generic;
    using global::System.Text.RegularExpressions;
    using global::Uguiss.Timeline;
    using global::UnityEngine.Playables;

    public static class TimelineEngineUtility
    {
        private static readonly Regex EscapeJsonRegex;
        private static string EscapeJson(string value)
        {
            return null;
        }

        public static string ToJson(object obj)
        {
            return null;
        }

        public static T GetPlayableBehaviour<T>(Playable playable)
            where T : PlayableBehaviour, new()
        {
            return null;
        }

        public static double ClampTime(double time, double minTime = 0.0, double maxTime = 1000000.0)
        {
            return default(double);
        }

        public static T GetActiveElement<T>(this List<T> elements)
            where T : TimelineElement
        {
            return null;
        }

        public static T GetLatestElement<T>(this List<T> elements, double time)
            where T : TimelineElement
        {
            return null;
        }

        public static void RemoveInvalidElements<T>(this List<T> elements)
            where T : TimelineElement
        {
        }

        public static void SortElements<T>(this List<T> elements)
            where T : TimelineElement
        {
        }

        public static void BeginWait<T>(this List<T> elements, double waitStartTime)
            where T : TimelineElement
        {
        }

        public static void EndWait<T>(this List<T> elements, double waitStartTime, double waitEndTime)
            where T : TimelineElement
        {
        }

        public static void OffsetClip<T>(this List<T> elements, double fromTime, double toTime)
            where T : TimelineElement
        {
        }

        public static void OffsetElapsedTime<T>(this List<T> elements, double fromTime, double toTime)
            where T : TimelineElement
        {
        }

        public static void ResetClip<T>(this List<T> elements)
            where T : TimelineElement
        {
        }

        private static int CompareElement<T>(T x, T y)
            where T : TimelineElement
        {
            return default(int);
        }
    }
}
