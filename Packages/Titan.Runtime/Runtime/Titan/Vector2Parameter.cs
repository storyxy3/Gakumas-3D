namespace Titan
{
    using global::System;
    using global::Titan;
    using global::UnityEngine;

    [Serializable]
    public class Vector2Parameter : ParameterBase<Vector2>
    {
        [SerializeField]
        private Vector2AxisType _ignoreAxis;
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

        protected override Vector2 GetValueCore(IValueResolver resolver, IExpressionHolder expressionHolder)
        {
            return default(Vector2);
        }

        public Vector2Parameter()
        {
        }
    }
}
