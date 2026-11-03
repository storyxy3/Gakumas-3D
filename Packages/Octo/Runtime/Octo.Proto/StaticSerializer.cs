namespace Octo.Proto
{
    using global::System.IO;

    internal static class StaticSerializer
    {
        private static object /* TODO(qa-recon): OCTProtoSerializer excluded. */ _serializer;
        public static T Deserialize<T>(MemoryStream stream)
            where T : class
        {
            return null;
        }

        public static T Deserialize<T>(byte[] binary)
            where T : class
        {
            return null;
        }
    }
}
