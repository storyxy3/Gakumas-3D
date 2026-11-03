namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TrackColor(0.2f, 0.8f, 0.6f)]
    [DisplayName("Titan/GroupParameter")]
    public class GroupParameterTrack : TweenTrackBase, ITweenLoopInfo, IExpressionHolder
    {
        [SerializeField]
        private int _loopCount;
        [SerializeField]
        private LoopType _loopType;
        [SerializeField]
        protected float _interval;
        [SerializeField]
        private string _targetName;
        [SerializeField]
        protected float _timeScale;
        [SerializeField]
        protected float _loopOffset;
        public int LoopCount
        {
            get
            {
                return default(int);
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
        }

        public float LoopOffset
        {
            get
            {
                return default(float);
            }
        }

        public bool IsGroupEnabled(IValueResolver resolver)
        {
            return default(bool);
        }

        public string GetTargetName(IValueResolver resolver)
        {
            return null;
        }

        public float GetOffset(IValueResolver resolver)
        {
            return default(float);
        }

        public float GetTimeScale(IValueResolver resolver)
        {
            return default(float);
        }

        public GroupParameterTrack()
        {
        }
    }
}
