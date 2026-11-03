namespace Octo.Data
{
    using global::System.Collections.Generic;

    internal static class ProtoWriterExtensions
    {
        public static void Write(this object /* TODO(qa-recon): protobuf-net ProtoBuf.ProtoWriter excluded. */ writer, int tag, int value)
        {
        }

        public static void Write(this object /* TODO(qa-recon): protobuf-net ProtoBuf.ProtoWriter excluded. */ writer, int tag, uint value)
        {
        }

        public static void Write(this object /* TODO(qa-recon): protobuf-net ProtoBuf.ProtoWriter excluded. */ writer, int tag, string value)
        {
        }

        public static void Write(this object /* TODO(qa-recon): protobuf-net ProtoBuf.ProtoWriter excluded. */ writer, int tag, IEnumerable<int> values)
        {
        }

        public static void Write(this object /* TODO(qa-recon): protobuf-net ProtoBuf.ProtoWriter excluded. */ writer, int tag, IEnumerable<string> values)
        {
        }

        public static void WriteIfNotDefault(this object /* TODO(qa-recon): protobuf-net ProtoBuf.ProtoWriter excluded. */ writer, int tag, int value)
        {
        }

        public static void WriteIfNotDefault(this object /* TODO(qa-recon): protobuf-net ProtoBuf.ProtoWriter excluded. */ writer, int tag, uint value)
        {
        }
    }
}
