namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [NotKeyable]
    public abstract class TweenClipBase : PlayableAsset, ITimelineClipAsset, IExpressionHolder
    {
        [CompilerGenerated]
        private TimelineClip _003CTimelineClip_003Ek__BackingField;
        [SerializeField]
        private ExpressionWithName[] _expressions;
        private ExpressionHolder _expressionHolder;
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

        public ExpressionHolder ExpressionHolder
        {
            get
            {
                return null;
            }
        }

        public float GetStart(IValueResolver resolver, double start)
        {
            return default(float);
        }

        public float GetDuration(IValueResolver resolver, double duration)
        {
            return default(float);
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return default(Playable);
        }

        public ExpressionWithName GetExpressionWithName(int index)
        {
            return null;
        }

        protected TweenClipBase()
        {
        }
    }
}
