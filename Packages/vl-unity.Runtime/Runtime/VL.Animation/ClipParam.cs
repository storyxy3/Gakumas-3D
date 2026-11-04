namespace VL.Animation
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Animation;
    using global::VL.Ease;

    [Serializable]
    public class ClipParam
    {
        [SerializeField]
        private MotionDefine _motion;
        [SerializeField]
        private double _transitionTime;
        [SerializeField]
        private double _length;
        [SerializeField]
        private EaseType _easeType;
        [SerializeField]
        private bool _isLoop;
        private EaseFunction _easeFunction;
        [CompilerGenerated]
        private ClipEvent _003ConPlay_003Ek__BackingField;
        [CompilerGenerated]
        private ClipEvent _003ConComplete_003Ek__BackingField;
        [CompilerGenerated]
        private ClipEvent _003ConStepComplete_003Ek__BackingField;
        public string name
        {
            get
            {
                return _motion != null ? _motion.name : "Null";
            }
        }

        public MotionDefine motionDefine
        {
            get
            {
                return _motion;
            }
        }

        public double transitionTime
        {
            get
            {
                return _transitionTime;
            }
        }

        public double length
        {
            get
            {
                return _length;
            }
        }

        public bool isLoop
        {
            get
            {
                return _isLoop;
            }
        }

        public bool ignoreAdditive
        {
            get
            {
                return _motion != null && _motion.ignoreAdditive;
            }
        }

        public ClipParam(MotionDefine motionDefine)
        {
            _motion = motionDefine;
            _length = _motion != null ? _motion.animationLength : 0;
            _transitionTime = 0;
            _easeType = EaseType.Linear;
            _isLoop = _motion != null && _motion.isLoop;
        }

        public ClipParam SetTransitionTime(double time)
        {
            _transitionTime = time;
            return this;
        }

        public ClipParam SetEase(EaseType type)
        {
            _easeType = type;
            return this;
        }

        public ClipParam SetLength(double length)
        {
            _length = Math.Max(0, length);
            return this;
        }

        public float EvaluateWeight(float time)
        {
            if (_easeFunction == null)
                _easeFunction = EaseFunctions.GetEaseFunction(_easeType);
            return Mathf.Clamp01(_easeFunction(time, (float)_transitionTime));
        }
    }
}
