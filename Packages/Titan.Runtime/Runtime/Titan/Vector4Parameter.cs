namespace Titan
{
    using global::System;
    using global::Titan;
    using global::UnityEngine;

    [Serializable]
    public class Vector4Parameter : ParameterBase<Vector4>
    {
        [SerializeField]
        private Vector4AxisType _ignoreAxis;
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

        public bool IgnoreW
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

        protected override Vector4 GetValueCore(IValueResolver resolver, IExpressionHolder expressionHolder)
        {
            return default(Vector4);
        }

        public Vector4Parameter()
        {
        }
    }
}
