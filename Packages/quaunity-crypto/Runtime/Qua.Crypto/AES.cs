namespace Qua.Crypto
{
    using global::System.Security.Cryptography;
    using global::Qua.Crypto;

    public class AES
    {
        public const int BlockSize = 16;
        private object /* TODO(qa-recon): FastAES excluded from rendering closure. */ _fastAes;
        public static AES CreateKeySize128()
        {
            return null;
        }

        public AES(CipherMode mode, PaddingMode padding, int keySize)
        {
        }

        public byte[] Encrypt(byte[] plain, byte[] key, byte[] iv)
        {
            return null;
        }

        public int Encrypt(byte[] plain, int offset, int length, byte[] key, byte[] iv, byte[] output)
        {
            return default(int);
        }

        public byte[] Decrypt(byte[] cipher, byte[] key, byte[] iv)
        {
            return null;
        }

        public int Decrypt(byte[] cipher, int offset, int length, byte[] key, byte[] iv, byte[] output)
        {
            return default(int);
        }
    }
}
