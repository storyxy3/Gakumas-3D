namespace Qua.UI.Internal
{
    using global::System;
    using global::System.Security.Cryptography;
    using global::Qua.Crypto;

    internal class UICrypto : IDisposable
    {
        private readonly AES _aes;
        public UICrypto(CipherMode mode, PaddingMode padding, int keySize)
        {
        }

        public byte[] Encrypt(byte[] plain, byte[] key, byte[] iv)
        {
            return null;
        }

        public byte[] Decrypt(byte[] cipher, byte[] key, byte[] iv)
        {
            return null;
        }

        public void Dispose()
        {
        }
    }
}
