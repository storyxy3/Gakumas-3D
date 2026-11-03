namespace Titan
{
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public abstract class TweenTrackBase : TitanTrackBase, ITweenTrack, IExpressionHolder
    {
        protected IValueResolver _valueResolver;
        protected PlayableDirector _director;
        protected TweenCreationContext _context;
        [SerializeField]
        private ExpressionWithName[] _expressions;
        private ExpressionHolder _expressionHolder;
        public ExpressionHolder ExpressionHolder
        {
            get
            {
                return null;
            }
        }

        void Titan.ITweenTrack.InsertTween(TweenCreationContext context)
        {
        }

        protected virtual void InsertTween(TweenCreationContext context)
        {
        }

        protected override void OnCreateClip(TimelineClip clip)
        {
        }

        protected T GetParameter<T>(T value, string valueId)
        {
            return default(T);
        }

        public ExpressionWithName GetExpressionWithName(int index)
        {
            return null;
        }

        void Titan.ITweenTrack.CollectValueReverters(ICollectValueRevertersContext context)
        {
        }

        protected virtual void CollectValueReverters(ICollectValueRevertersContext context)
        {
        }

        protected TweenTrackBase()
        {
        }
    }
}
