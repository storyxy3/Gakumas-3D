namespace Titan
{
    using global::System.Collections.Generic;
    using global::Titan;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    internal static class TrackStartTimeCache
    {
        private static readonly Dictionary<PlayableDirector, Dictionary<PlayableAsset, double>> StartCache;
        public static void InitializeCache(TweenCreationContext context)
        {
        }

        public static void ClearCache(TweenCreationContext context)
        {
        }

        public static float GetTrackStart(TweenCreationContext context, PlayableAsset parent, ICollection<TrackAsset> tracks)
        {
            return default(float);
        }

        private static double CalculateTrackSpan(TweenCreationContext context, PlayableAsset parent, ICollection<TrackAsset> tracks)
        {
            return default(double);
        }

        private static double CalculateTrackStart(TweenCreationContext context, TrackAsset track)
        {
            return default(double);
        }
    }
}
