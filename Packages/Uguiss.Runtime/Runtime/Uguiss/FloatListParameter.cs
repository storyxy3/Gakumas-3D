namespace Uguiss
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
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

        [CompilerGenerated]
        private float _003CGetValue_003Eb__1_0(string rawValue)
        {
            return default(float);
        }

        [CompilerGenerated]
        private void _003CSetValue_003Eb__2_0(float x)
        {
        }
    }
}
