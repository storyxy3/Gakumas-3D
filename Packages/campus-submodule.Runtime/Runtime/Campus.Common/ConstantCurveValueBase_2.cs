namespace Campus.Common
{
    using global::System;
    using global::Campus.Common;
    using global::UnityEngine;

    [Serializable]
    public abstract class ConstantCurveValueBase<T1, T2> : ConstantCurveValueBase
    {
        [SerializeField]
        public T1 constant;
        [SerializeField]
        public T2 curve;
        public abstract T1 Evaluate(float time);
        protected ConstantCurveValueBase()
        {
        }
    }
}
