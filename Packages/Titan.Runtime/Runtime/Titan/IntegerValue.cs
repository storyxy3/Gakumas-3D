namespace Titan
{
    using global::Titan;

    internal class IntegerValue : Value
    {
        private class ValuePool : ObjectPool<IntegerValue>
        {
            protected override IntegerValue CreateInstance()
            {
                return null;
            }

            public ValuePool()
            {
            }
        }

        private int _value;
        private static readonly ValuePool Pool;
        public override ValueType Type
        {
            get
            {
                return default(ValueType);
            }
        }

        public new static IntegerValue GetOrCreate(int value)
        {
            return null;
        }

        public override int GetInteger()
        {
            return default(int);
        }

        public override float GetNumber()
        {
            return default(float);
        }

        public override bool GetBool()
        {
            return default(bool);
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

        public IntegerValue()
        {
        }
    }
}
