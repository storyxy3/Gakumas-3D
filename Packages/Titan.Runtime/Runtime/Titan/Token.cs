namespace Titan
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Titan;

    internal class Token : IDisposable
    {
        private class TokenPool : ObjectPool<Token>
        {
            protected override Token CreateInstance()
            {
                return null;
            }

            public TokenPool()
            {
            }
        }

        private static readonly TokenPool Pool;
        [CompilerGenerated]
        private TokenType _003CType_003Ek__BackingField;
        public TokenType Type
        {
            [CompilerGenerated]
            get
            {
                return _003CType_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CType_003Ek__BackingField = value;
            }
        }

        public static Token GetOrCreate(TokenType type)
        {
            return null;
        }

        public virtual float GetFloat()
        {
            return default(float);
        }

        public virtual int GetInteger()
        {
            return default(int);
        }

        public virtual string GetIdentifier()
        {
            return null;
        }

        public virtual void Dispose()
        {
        }

        public override string ToString()
        {
            return null;
        }

        public Token()
        {
        }
    }
}
