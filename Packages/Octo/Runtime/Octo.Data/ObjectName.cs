namespace Octo.Data
{
    using global::System.Text;

    internal struct ObjectName
    {
        private static readonly StringBuilder hexBuilder;
        private static readonly Encoding ascii;
        private static readonly byte[] sharedBuffer;
        private byte b0;
        private byte b1;
        private byte b2;
        private byte b3;
        private byte b4;
        private byte b5;
        public void Set(string name)
        {
        }

        public override string ToString()
        {
            return null;
        }

        public string ToHexString()
        {
            return null;
        }
    }
}
