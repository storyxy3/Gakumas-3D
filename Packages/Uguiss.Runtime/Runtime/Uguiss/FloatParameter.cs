namespace Uguiss
{
    using global::Uguiss;

    public class FloatParameter : AbstractParameter<float>
    {
        public override float GetValue(float defaultValue)
        {
            return default(float);
        }

        public override void SetValue(float value)
        {
        }

        public FloatParameter()
        {
        }
    }
}
