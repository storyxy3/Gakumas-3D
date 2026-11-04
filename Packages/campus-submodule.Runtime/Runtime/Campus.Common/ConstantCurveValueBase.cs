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
                return isValid;
            }

            set
            {
                isValid = value;
            }
        }

        public virtual float Duration
        {
            get
            {
                return 1f;
            }
        }

        protected ConstantCurveValueBase()
        {
        }
    }
}
