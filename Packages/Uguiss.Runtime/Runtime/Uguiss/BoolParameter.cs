namespace Uguiss
{
    using global::Uguiss;

    public class BoolParameter : AbstractParameter<bool>
    {
        public override bool GetValue(bool defaultValue)
        {
            return default(bool);
        }

        public override void SetValue(bool value)
        {
        }

        public BoolParameter()
        {
        }
    }
}
