namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Titan;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    internal static class TrackStartTimeCache
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<TimelineClip, double> _003C_003E9__5_0;
            public _003C_003Ec()
            {
            }

            internal double _003CCalculateTrackStart_003Eb__5_0(TimelineClip x)
            {
                return default(double);
            }
        }

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
