namespace Octo.Util
{
    using global::System.Text;
    using global::Octo.Util;

    internal struct MD5Value
    {
        private const char smallAOffset = 'W';
        private const char largeAOffset = '7';
        private static StringBuilder hexBuilder;
        private byte b0;
        private byte b1;
        private byte b2;
        private byte b3;
        private byte b4;
        private byte b5;
        private byte b6;
        private byte b7;
        private byte b8;
        private byte b9;
        private byte b10;
        private byte b11;
        private byte b12;
        private byte b13;
        private byte b14;
        private byte b15;
        public MD5Value(string md5)
        {
            this = default;
        }

        public bool Equals(MD5Value md5)
        {
            return default(bool);
        }

        public void Set(string md5)
        {
        }

        public override string ToString()
        {
            return null;
        }

        public static byte FromChar(char c)
        {
            return default(byte);
        }

        public static void AddChar(StringBuilder sb, byte b)
        {
        }
    }
}
