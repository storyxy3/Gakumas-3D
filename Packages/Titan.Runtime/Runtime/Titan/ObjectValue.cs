namespace Titan
{
    using global::Titan;

    internal class ObjectValue : Value
    {
        private class ValuePool : ObjectPool<ObjectValue>
        {
            protected override ObjectValue CreateInstance()
            {
                return null;
            }

            public ValuePool()
            {
            }
        }

        private object _value;
        private static readonly ValuePool Pool;
        public override ValueType Type
        {
            get
            {
                return default(ValueType);
            }
        }

        public new static ObjectValue GetOrCreate(object value)
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

        public ObjectValue()
        {
        }
    }
}
