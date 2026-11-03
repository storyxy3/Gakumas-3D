namespace LibTessDotNet
{
    using global::System.Runtime.InteropServices;
    using global::LibTessDotNet;

    internal struct ContourVertex
    {
        public Vec3 Position;
        public object Data;
        public ContourVertex(Vec3 position, [Optional] object data)
        {
            this = default;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
