namespace Titan
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;

    public class VectorParameterLabelsAttribute : Attribute
    {
        private readonly string _x;
        private readonly string _y;
        private readonly string _z;
        private readonly string _w;
        [CompilerGenerated]
        private readonly string _003CAxisOrder_003Ek__BackingField;
        public VectorParameterLabelsAttribute(string x, string y, [Optional] string z, [Optional] string w, [Optional] string axisOrder)
        {
        }
    }
}
