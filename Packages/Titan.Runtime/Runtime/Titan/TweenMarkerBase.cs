namespace Titan
{
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    public abstract class TweenMarkerBase : Marker, IExpressionHolder
    {
        [SerializeField]
        private ExpressionWithName[] _expressions;
        private ExpressionHolder _expressionHolder;
        [SerializeField]
        private MarkerExecutionType _executionType;
        [SerializeField]
        private CallbackTiming _timing;
        public ExpressionHolder ExpressionHolder
        {
            get
            {
                return null;
            }
        }

        public MarkerExecutionType ExecutionType
        {
            get
            {
                return default(MarkerExecutionType);
            }
        }

        public CallbackTiming Timing
        {
            get
            {
                return default(CallbackTiming);
            }
        }

        public virtual void Execute(TweenCreationContext context)
        {
        }

        public float GetTime(IValueResolver resolver)
        {
            return default(float);
        }

        public ExpressionWithName GetExpressionWithName(int index)
        {
            return null;
        }

        protected TweenMarkerBase()
        {
        }
    }
}
