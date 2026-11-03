namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public class TitanControlClip : PlayableAsset, ITimelineClipAsset
    {
        [CompilerGenerated]
        private TimelineClip _003CTimelineClip_003Ek__BackingField;
        public TimelineClip TimelineClip
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public ClipCaps clipCaps
        {
            get
            {
                return default(ClipCaps);
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return default(Playable);
        }

        public TitanControlClip()
        {
        }
    }
}
