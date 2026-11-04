// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare
{
    public static partial class CriAtomPlugin
    {

        public struct FileOpenCondition
        {
            public int freeBindsCount;
            public int freeFilesCount;
            public int freeLoadersCount;
            public bool CanLoadAcf
            {
                get
                {
                    return default(bool);
                }
            }

            public bool CanLoadAcb
            {
                get
                {
                    return default(bool);
                }
            }

            public bool CanLoadAcbWithAwb
            {
                get
                {
                    return default(bool);
                }
            }

            public bool CanAttachAwb
            {
                get
                {
                    return default(bool);
                }
            }
        }



        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1);
    }
}
