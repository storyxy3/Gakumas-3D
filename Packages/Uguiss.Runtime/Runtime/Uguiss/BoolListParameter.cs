namespace Uguiss
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Uguiss;

    public class BoolListParameter : AbstractParameter<List<bool>>
    {
        public override List<bool> GetValue()
        {
            return null;
        }

        public override List<bool> GetValue(List<bool> defaultValue)
        {
            return null;
        }

        public override void SetValue(List<bool> value)
        {
        }

        public BoolListParameter()
        {
        }

        [CompilerGenerated]
        private bool _003CGetValue_003Eb__1_0(string rawValue)
        {
            return default(bool);
        }

        [CompilerGenerated]
        private void _003CSetValue_003Eb__2_0(bool x)
        {
        }
    }
}
