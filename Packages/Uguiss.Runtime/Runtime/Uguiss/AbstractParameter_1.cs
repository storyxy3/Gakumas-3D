namespace Uguiss
{
    using global::Uguiss;

    public abstract class AbstractParameter<T> : AbstractParameter
    {
        public virtual T GetValue()
        {
            return default(T);
        }

        public abstract T GetValue(T defaultValue);
        public abstract void SetValue(T value);
        public static implicit operator T(AbstractParameter<T> parameter)
        {
            return default(T);
        }

        protected AbstractParameter()
        {
        }
    }
}
