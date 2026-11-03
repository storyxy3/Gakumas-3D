namespace Uguiss
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
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

        [CompilerGenerated]
        private Literal _003CGetValue_003Eb__1_0(string rawValue)
        {
            return null;
        }

        [CompilerGenerated]
        private void _003CSetValue_003Eb__2_0(Literal x)
        {
        }
    }
}
