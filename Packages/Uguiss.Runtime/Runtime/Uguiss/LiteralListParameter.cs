namespace Uguiss
{
    using global::System.Collections.Generic;
    using global::Uguiss;

    public class LiteralListParameter : AbstractParameter<List<Literal>>
    {
        public override List<Literal> GetValue()
        {
            return null;
        }

        public override List<Literal> GetValue(List<Literal> defaultValue)
        {
            return null;
        }

        public override void SetValue(List<Literal> value)
        {
        }

        public LiteralListParameter()
        {
        }
    }
}
