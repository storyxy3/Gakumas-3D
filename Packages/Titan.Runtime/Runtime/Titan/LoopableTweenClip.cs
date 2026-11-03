namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public class LoopableTweenClip : TweenClipBase, ITweenLoopInfo, IExpressionHolder
    {
        [SerializeField]
        protected int _loopCount;
        [SerializeField]
        protected LoopType _loopType;
        [SerializeField]
        protected float _interval;
        public int LoopCount
        {
            get
            {
                return default(int);
            }

            internal set
            {
            }
        }

        public LoopType LoopType
        {
            get
            {
                return default(LoopType);
            }
        }

        public float Interval
        {
            get
            {
                return default(float);
            }

            internal set
            {
            }
        }

        public float LoopOffset
        {
            get
            {
                return default(float);
            }
        }

        public virtual bool IsFixedDuration
        {
            get
            {
                return default(bool);
            }
        }

        public double GetSingleTweenDuration(double wholeDuration)
        {
            return default(double);
        }

        public LoopableTweenClip()
        {
        }
    }
}
