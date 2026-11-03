namespace Qua.Crypto
{
    using global::System;
    using global::System.Buffers;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Security.Cryptography;
    using global::System.Text;

    public static class SHA256
    {
        [ThreadStatic]
        private static HashAlgorithm _hashAlgorithm;
        [MethodImpl(256)]
        public static byte[] Hash(byte[] val, int offset, int count)
        {
            return null;
        }

        [MethodImpl(256)]
        public static string HashHex(string val, [Optional] Encoding encoding, [Optional] ArrayPool<byte> pool)
        {
            return null;
        }
    }
}
