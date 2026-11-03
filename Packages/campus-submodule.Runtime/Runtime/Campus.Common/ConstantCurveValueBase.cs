namespace Campus.Common
{
    using global::System;
    using global::Campus.Common;
    using global::UnityEngine;

    [Serializable]
    public abstract class ConstantCurveValueBase
    {
        [SerializeField]
        protected bool isValid;
        [SerializeField]
        public ConstantCurvePairMode mode;
        [SerializeField]
        public SerializableGuid templateGUID;
        public bool IsValid
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public virtual float Duration
        {
            get
            {
                return default(float);
            }
        }

        protected ConstantCurveValueBase()
        {
        }
    }
}
