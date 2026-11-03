namespace Campus.Common
{
    using global::System;
    using global::System.IO;

    public static class MaskedHeaderStreamUtility
    {
        internal static readonly int HeaderLength;
        private static readonly byte[] UnitySignature;
        [ThreadStatic]
        private static byte[] _signatureBuffer;
        internal static bool IsEncryptedStreamBytes(byte[] headerBytes, int headerLength)
        {
            return default(bool);
        }

        public static bool IsEncryptedStream(Stream stream)
        {
            return default(bool);
        }
    }
}
