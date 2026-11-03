namespace Octo.Data
{
    using global::System.Collections.Generic;
    using global::System.IO;
    using global::System.Security.Cryptography;

    internal sealed class AESCrypt
    {
        private static readonly List<int> ValidKeyLengths;
        private static readonly string IV;
        private RijndaelManaged _aesAlgo;
        private object /* TODO(qa-recon): FastAES excluded. */ _fastAes;
        public AESCrypt(byte[] key, CipherMode mode = CipherMode.CBC, PaddingMode padding = PaddingMode.PKCS7)
        {
        }

        public AESCrypt(string key, CipherMode mode = CipherMode.CBC, PaddingMode padding = PaddingMode.PKCS7)
        {
        }

        public void UpdateIV(byte[] iv)
        {
        }

        private byte[] _Encrypt(byte[] plainTextBytes)
        {
            return null;
        }

        public byte[] Decrypt(MemoryStream memoryStream)
        {
            return null;
        }

        public byte[] Encrypt(byte[] plainTextBytes)
        {
            return null;
        }
    }
}
