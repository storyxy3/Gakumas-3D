namespace Uguiss
{
    using global::System.Collections.Generic;
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
    }
}
