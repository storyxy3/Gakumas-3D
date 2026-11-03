namespace Uguiss
{
    using global::System.Collections.Generic;
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
    }
}
