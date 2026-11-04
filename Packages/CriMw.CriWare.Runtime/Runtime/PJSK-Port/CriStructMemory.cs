using System;
using System.Runtime.InteropServices;

namespace CriWare
{
    // CriWare.CriStructMemory<Type> (TypeDefIndex 31681): a pinned byte buffer the native side fills with a struct;
    // the managed struct is then parsed from the bytes (see the CriAtomEx struct constructors).
    public class CriStructMemory<Type> : IDisposable
    {
        private GCHandle gch;

        public byte[] bytes { get; set; }

        public IntPtr ptr => gch.AddrOfPinnedObject();

        public CriStructMemory()
        {
            bytes = new byte[Marshal.SizeOf(typeof(Type))];
            gch = GCHandle.Alloc(bytes, GCHandleType.Pinned);
        }

        public CriStructMemory(int num)
        {
            bytes = new byte[Marshal.SizeOf(typeof(Type)) * num];
            gch = GCHandle.Alloc(bytes, GCHandleType.Pinned);
        }

        public void Dispose()
        {
            gch.Free();
        }
    }
}
