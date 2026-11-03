namespace Titan
{
    using global::System;
    using global::Titan;
    using global::UnityEngine;

    public abstract class TweenerClipBase<TValue, TParameter> : TweenerClipBase where TParameter : ParameterBase<TValue>, new()
    {
        [SerializeField]
        private EaseInfo _easeInfo;
        [SerializeField]
        protected TParameter _endParameter;
        public override Type ParameterType
        {
            get
            {
                return null;
            }
        }

        public EaseInfo EaseInfo
        {
            get
            {
                return null;
            }
        }

        public TParameter EndParameter
        {
            get
            {
                return null;
            }
        }

        public SetTweenExecutionTiming SetTweenExecutionTiming
        {
            get
            {
                return default(SetTweenExecutionTiming);
            }
        }

        protected TweenerClipBase()
        {
        }
    }
}
