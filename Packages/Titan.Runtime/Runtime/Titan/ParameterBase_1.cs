namespace Titan
{
    using global::System;
    using global::Titan;
    using global::UnityEngine;

    [Serializable]
    public abstract class ParameterBase<T>
    {
        [SerializeField]
        protected T _value;
        [SerializeField]
        private bool _isRelative;
        public bool IsRelative
        {
            get
            {
                return default(bool);
            }
        }

        public T GetValue(IValueResolver resolver, IExpressionHolder expressionHolder)
        {
            return default(T);
        }

        protected virtual T GetValueFromExpressionValue(Value value)
        {
            return default(T);
        }

        protected virtual T GetValueCore(IValueResolver resolver, IExpressionHolder expressionHolder)
        {
            return default(T);
        }

        protected ParameterBase()
        {
        }
    }
}
