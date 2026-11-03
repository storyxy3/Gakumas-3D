namespace Titan
{
    using global::Titan;
    using global::UnityEngine;

    public class SequentialClipBase<TValue> : LoopableTweenClip
    {
        [SerializeField]
        private TValue[] _values;
        [SerializeField]
        private float _stepDuration;
        public TValue[] Values
        {
            get
            {
                return null;
            }
        }

        public override bool IsFixedDuration
        {
            get
            {
                return default(bool);
            }
        }

        public float StepDuration
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public SequentialClipBase()
        {
        }
    }
}
