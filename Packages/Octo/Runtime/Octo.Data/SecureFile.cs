namespace Octo.Data
{
    using global::System.IO;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Data;

    internal class SecureFile
    {
        private enum Mode : byte
        {
            Raw,
            AESWithMD5
        }

        private static readonly string Tag;
        [CompilerGenerated]
        private string _003CPath_003Ek__BackingField;
        protected AESCrypt _crypt;
        public string Path
        {
            [CompilerGenerated]
            get
            {
                return _003CPath_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CPath_003Ek__BackingField = value;
            }
        }

        public SecureFile(string path, AESCrypt crypt)
        {
        }

        public BinaryReader GetReader()
        {
            return null;
        }

        private MemoryStream CreateMode1ReadStream(MemoryStream cipherStream)
        {
            return null;
        }

        public byte[] Load()
        {
            return null;
        }

        public Error Save(byte[] plainBytes)
        {
            return null;
        }
    }
}
