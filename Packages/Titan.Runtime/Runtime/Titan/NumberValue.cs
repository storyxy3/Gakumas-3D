namespace Titan
{
    using global::Titan;

    internal class NumberValue : Value
    {
        private class ValuePool : ObjectPool<NumberValue>
        {
            protected override NumberValue CreateInstance()
            {
                return null;
            }

            public ValuePool()
            {
            }
        }

        private float _value;
        private static readonly ValuePool Pool;
        public override ValueType Type
        {
            get
            {
                return default(ValueType);
            }
        }

        public new static NumberValue GetOrCreate(float value)
        {
            return null;
        }

        public override float GetNumber()
        {
            return default(float);
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

        public NumberValue()
        {
        }
    }
}
