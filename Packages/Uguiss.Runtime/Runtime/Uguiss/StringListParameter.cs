namespace Uguiss
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Uguiss;

    public class StringListParameter : AbstractParameter<List<string>>
    {
        public override List<string> GetValue()
        {
            return null;
        }

        public override List<string> GetValue(List<string> defaultValue)
        {
            return null;
        }

        public override void SetValue(List<string> value)
        {
        }

        public StringListParameter()
        {
        }

        [CompilerGenerated]
        private string _003CGetValue_003Eb__1_0(string rawValue)
        {
            return null;
        }
    }
}
