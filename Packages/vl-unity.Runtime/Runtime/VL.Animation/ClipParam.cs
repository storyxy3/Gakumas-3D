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
                return null;
            }
        }

        public MotionDefine motionDefine
        {
            get
            {
                return null;
            }
        }

        public double transitionTime
        {
            get
            {
                return default(double);
            }
        }

        public double length
        {
            get
            {
                return default(double);
            }
        }

        public bool isLoop
        {
            get
            {
                return default(bool);
            }
        }

        public bool ignoreAdditive
        {
            get
            {
                return default(bool);
            }
        }

        public ClipParam(MotionDefine motionDefine)
        {
        }

        public ClipParam SetTransitionTime(double time)
        {
            return null;
        }

        public ClipParam SetEase(EaseType type)
        {
            return null;
        }

        public ClipParam SetLength(double length)
        {
            return null;
        }

        public float EvaluateWeight(float time)
        {
            return default(float);
        }
    }
}
