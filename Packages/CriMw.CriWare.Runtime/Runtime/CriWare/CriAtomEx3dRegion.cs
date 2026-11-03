namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomEx3dRegion : CriDisposable
    {
        public struct Config
        {
            public int reserved;
        }

        private static class UnsafeNativeMethods
        {
            [PreserveSig]
            internal static extern IntPtr criAtomEx3dRegion_Create(ref Config config, IntPtr work, int work_size);
            [PreserveSig]
            internal static extern void criAtomEx3dRegion_Destroy(IntPtr ex_3d_region);
            [PreserveSig]
            internal static extern bool criAtomEx3dRegion_IsDestroyable(IntPtr ex3dRegion);
        }

        private IntPtr handle;
        public IntPtr nativeHandle
        {
            get
            {
                return default(IntPtr);
            }
        }

        public CriAtomEx3dRegion()
        {
        }

        public override void Dispose()
        {
        }

        private void Dispose(bool disposing)
        {
        }

        ~CriAtomEx3dRegion()
        {
        }

        public bool IsDestroyable()
        {
            return default(bool);
        }
    }
}
