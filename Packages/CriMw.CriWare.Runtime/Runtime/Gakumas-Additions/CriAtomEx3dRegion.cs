// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare
{
    public partial class CriAtomEx3dRegion
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
    }
}
