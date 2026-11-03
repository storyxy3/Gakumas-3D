namespace Titan
{
    using global::Titan;

    internal class BoolValue : Value
    {
        private class ValuePool : ObjectPool<BoolValue>
        {
            protected override BoolValue CreateInstance()
            {
                return null;
            }

            public ValuePool()
            {
            }
        }

        private bool _value;
        private static readonly ValuePool Pool;
        public override ValueType Type
        {
            get
            {
                return default(ValueType);
            }
        }

        public new static BoolValue GetOrCreate(bool value)
        {
            return null;
        }

        public override bool GetBool()
        {
            return default(bool);
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

        public BoolValue()
        {
        }
    }
}
