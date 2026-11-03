namespace Uguiss.Timeline
{
    using global::Uguiss;

    public abstract class AbstractJSONParameter<T> : AbstractParameter<T> where T : new()
    {
        public override T GetValue()
        {
            return default(T);
        }

        public override T GetValue(T defaultValue)
        {
            return default(T);
        }

        public override void SetValue(T value)
        {
        }

        protected AbstractJSONParameter()
        {
        }
    }
}
