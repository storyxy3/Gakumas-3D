namespace Titan
{
    using global::Titan;

    internal class IdentifierToken : Token
    {
        private class TokenPool : ObjectPool<IdentifierToken>
        {
            protected override IdentifierToken CreateInstance()
            {
                return null;
            }

            public TokenPool()
            {
            }
        }

        private string _value;
        private static readonly TokenPool Pool;
        public static IdentifierToken GetOrCreate(string value, bool isString)
        {
            return null;
        }

        public override string GetIdentifier()
        {
            return null;
        }

        public override void Dispose()
        {
        }

        public IdentifierToken()
        {
        }
    }
}
