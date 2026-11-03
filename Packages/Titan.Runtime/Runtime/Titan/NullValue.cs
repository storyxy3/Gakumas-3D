namespace Titan
{
    using global::Titan;

    internal class NullValue : Value
    {
        public static readonly NullValue Default;
        public override ValueType Type
        {
            get
            {
                return default(ValueType);
            }
        }

        public override object GetObject()
        {
            return null;
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return null;
        }

        public NullValue()
        {
        }
    }
}
