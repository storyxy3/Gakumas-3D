namespace Octo.Data
{
    using global::Octo.Data;

    internal sealed class SecureProtoBufDatabase<T> : SecureSerializableDatabase<T> where T : class, new()
    {
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public SecureProtoBufDatabase(string path, AESCrypt crypt) : base(default, default)
        {
        }

        protected override T Deserialize(byte[] bytes)
        {
            return null;
        }
    }
}
