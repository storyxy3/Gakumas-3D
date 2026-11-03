namespace Titan
{
    using global::System;
    using global::Titan;
    using global::UnityEngine;

    [Serializable]
    public class Vector3Parameter : ParameterBase<Vector3>
    {
        [SerializeField]
        private Vector3AxisType _ignoreAxis;
        public bool IgnoreX
        {
            get
            {
                return default(bool);
            }
        }

        public bool IgnoreY
        {
            get
            {
                return default(bool);
            }
        }

        public bool IgnoreZ
        {
            get
            {
                return default(bool);
            }
        }

        public bool IgnoreAny
        {
            get
            {
                return default(bool);
            }
        }

        protected override Vector3 GetValueCore(IValueResolver resolver, IExpressionHolder expressionHolder)
        {
            return default(Vector3);
        }

        public Vector3Parameter()
        {
        }
    }
}
