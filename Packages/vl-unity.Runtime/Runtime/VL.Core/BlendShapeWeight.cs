namespace VL.Core
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::VL.Core;

    [Serializable]
    [StructLayout((LayoutKind)2)]
    public struct BlendShapeWeight
    {
        public const int BlendShapeWeightMax = 192;
        [System.Runtime.InteropServices.FieldOffset(0x0)]
        public BlendShapeWeight16 w0;
        [System.Runtime.InteropServices.FieldOffset(0x40)]
        public BlendShapeWeight16 w1;
        [System.Runtime.InteropServices.FieldOffset(0x80)]
        public BlendShapeWeight16 w2;
        [System.Runtime.InteropServices.FieldOffset(0xC0)]
        public BlendShapeWeight16 w3;
        [System.Runtime.InteropServices.FieldOffset(0x100)]
        public BlendShapeWeight16 w4;
        [System.Runtime.InteropServices.FieldOffset(0x140)]
        public BlendShapeWeight16 w5;
        [System.Runtime.InteropServices.FieldOffset(0x180)]
        public BlendShapeWeight16 w6;
        [System.Runtime.InteropServices.FieldOffset(0x1C0)]
        public BlendShapeWeight16 w7;
        [System.Runtime.InteropServices.FieldOffset(0x200)]
        public BlendShapeWeight16 w8;
        [System.Runtime.InteropServices.FieldOffset(0x240)]
        public BlendShapeWeight16 w9;
        [System.Runtime.InteropServices.FieldOffset(0x280)]
        public BlendShapeWeight16 w10;
        [System.Runtime.InteropServices.FieldOffset(0x2C0)]
        public BlendShapeWeight16 w11;
        public float this[int index]
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public static string GetPropertyPath(int index)
        {
            return null;
        }
    }
}
