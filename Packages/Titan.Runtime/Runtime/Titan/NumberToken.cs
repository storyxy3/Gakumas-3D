namespace Titan
{
    using global::Titan;

    internal class NumberToken : Token
    {
        private class TokenPool : ObjectPool<NumberToken>
        {
            protected override NumberToken CreateInstance()
            {
                return null;
            }

            public TokenPool()
            {
            }
        }

        private float _value;
        private static readonly TokenPool Pool;
        private NumberToken()
        {
        }

        public static NumberToken GetOrCreate(float value)
        {
            return null;
        }

        public override float GetFloat()
        {
            return default(float);
        }

        public override void Dispose()
        {
        }
    }
}
