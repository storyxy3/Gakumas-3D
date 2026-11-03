namespace Titan
{
    using global::Titan;

    internal class StringValue : Value
    {
        private class ValuePool : ObjectPool<StringValue>
        {
            protected override StringValue CreateInstance()
            {
                return null;
            }

            public ValuePool()
            {
            }
        }

        private string _value;
        private static readonly ValuePool Pool;
        public override ValueType Type
        {
            get
            {
                return default(ValueType);
            }
        }

        public new static StringValue GetOrCreate(string value)
        {
            return null;
        }

        public override string GetString()
        {
            return null;
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

        public StringValue()
        {
        }
    }
}
