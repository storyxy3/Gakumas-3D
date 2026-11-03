namespace Titan
{
    using global::System.Collections.Generic;
    using global::Titan;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public static class TitanUtility
    {
        private static readonly HashSet<PlayableDirector> ProcessedDirectors;
        public static void CreateTween(TweenCreationContext context)
        {
        }

        public static void CreateTween(TweenCreationContext context, IVariableDefinitionHolder overrideVariableHolder, IValueResolver resolver)
        {
        }

        public static ITimelineTween CreateTween(this PlayableDirector director)
        {
            return null;
        }

        public static double GetDuration(this PlayableDirector director)
        {
            return default(double);
        }

        private static void CreateTween(TweenCreationContext context, PlayableAsset parent, ICollection<TrackAsset> tracks)
        {
        }

        private static void AddTracks(TweenCreationContext context, ICollection<TrackAsset> tracks, string groupName)
        {
        }

        public static GroupParameterTrack GetGroupParameterTrack(ICollection<TrackAsset> tracks)
        {
            return null;
        }

        public static bool IsTargetTrack(TrackAsset track, IValueResolver resolver, string targetName)
        {
            return default(bool);
        }
    }
}
