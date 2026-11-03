namespace Uguiss
{
    using global::Uguiss;

    public class LiteralParameter : AbstractParameter<Literal>
    {
        public override Literal GetValue()
        {
            return null;
        }

        public override Literal GetValue(Literal defaultValue)
        {
            return null;
        }

        public override void SetValue(Literal value)
        {
        }

        public LiteralParameter()
        {
        }
    }
}
