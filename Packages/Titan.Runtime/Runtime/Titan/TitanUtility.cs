namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public static class TitanUtility
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static TweenCallback _003C_003E9__1_0;
            public _003C_003Ec()
            {
            }

            internal void _003CCreateTween_003Eb__1_0()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass2_0
        {
            public IValueResolver resolver;
            public IVariableDefinitionHolder overrideVariableHolder;
            public _003C_003Ec__DisplayClass2_0()
            {
            }

            internal KeyValuePair<string, object> _003CCreateTween_003Eb__0(VariableDefinition x)
            {
                return default(KeyValuePair<string, object>);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass6_0
        {
            public TweenCreationContext context;
            public _003C_003Ec__DisplayClass6_0()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass6_1
        {
            public TweenMarkerBase tweenMarker;
            public _003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals1;
            public _003C_003Ec__DisplayClass6_1()
            {
            }

            internal void _003CAddTracks_003Eb__0()
            {
            }
        }

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
