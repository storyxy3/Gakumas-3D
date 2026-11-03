namespace Titan
{
    using global::Titan;

    internal class IntegerToken : Token
    {
        private class TokenPool : ObjectPool<IntegerToken>
        {
            protected override IntegerToken CreateInstance()
            {
                return null;
            }

            public TokenPool()
            {
            }
        }

        private int _value;
        private static readonly TokenPool Pool;
        private IntegerToken()
        {
        }

        public static IntegerToken GetOrCreate(int value)
        {
            return null;
        }

        public override int GetInteger()
        {
            return default(int);
        }

        public override void Dispose()
        {
        }
    }
}
