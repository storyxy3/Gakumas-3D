// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare
{
    public partial class CriAtom
    {

        protected class NativeMethods
        {
            [PreserveSig]
            internal static extern int criAtom_GetThreadPriority_ANDROID();
            [PreserveSig]
            internal static extern void criAtom_SetThreadPriority_ANDROID(int prio);
            public NativeMethods()
            {
            }
        }
    }
}
