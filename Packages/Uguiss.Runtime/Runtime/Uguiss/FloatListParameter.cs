namespace Uguiss
{
    using global::System.Collections.Generic;
    using global::Uguiss;

    public class FloatListParameter : AbstractParameter<List<float>>
    {
        public override List<float> GetValue()
        {
            return null;
        }

        public override List<float> GetValue(List<float> defaultValue)
        {
            return null;
        }

        public override void SetValue(List<float> value)
        {
        }

        public FloatListParameter()
        {
        }
    }
}
