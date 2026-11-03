namespace Qua.Crypto
{
    using global::System;
    using global::System.Buffers;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Security.Cryptography;
    using global::System.Text;

    public static class Hash
    {
        [ThreadStatic]
        private static char[] _hashCharBuffer;
        private static readonly char[][] ByteToHexLUT;
        private static char[][] CreateByteToHexLUT()
        {
            return null;
        }

        [MethodImpl(256)]
        public static byte[] ComputeHash(HashAlgorithm hashAlgorithm, byte[] val, int offset, int count)
        {
            return null;
        }

        [MethodImpl(256)]
        public static byte[] ComputeHash(HashAlgorithm hashAlgorithm, byte[] val)
        {
            return null;
        }

        [MethodImpl(256)]
        public static byte[] ComputeHash(HashAlgorithm hashAlgorithm, string val, [Optional] Encoding encoding, [Optional] ArrayPool<byte> pool)
        {
            return null;
        }

        [MethodImpl(256)]
        public static string ComputeHashHex(HashAlgorithm hashAlgorithm, string val, [Optional] Encoding encoding, [Optional] ArrayPool<byte> pool)
        {
            return null;
        }

        [MethodImpl(256)]
        public static (byte[], int, ArrayPool<byte>) GetStringToArrayPoolBytes(string val, [Optional] Encoding encoding, [Optional] ArrayPool<byte> pool)
        {
            return default((byte[], int, ArrayPool<byte>));
        }

        [MethodImpl(256)]
        private static string BytesToHex(byte[] bytes)
        {
            return null;
        }
    }
}
