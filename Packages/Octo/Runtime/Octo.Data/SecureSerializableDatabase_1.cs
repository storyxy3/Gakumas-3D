namespace Octo.Data
{
    using global::System.Runtime.CompilerServices;
    using global::Octo.Data;

    internal abstract class SecureSerializableDatabase<T> : SecureFile where T : class, new()
    {
        private static readonly string Tag;
        [CompilerGenerated]
        private T _003CData_003Ek__BackingField;
        public T Data
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public SecureSerializableDatabase(string path, AESCrypt crypt) : base(default, default)
        {
        }

        protected abstract T Deserialize(byte[] bytes);
        public void Deserialize()
        {
        }
    }
}
