// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare
{
    public partial class CriAtomExOutputAnalyzer
    {

        public delegate void PcmCaptureCallback(float[] dataL, float[] dataR, int numChannels, int numData);



        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        protected delegate void InternalPcmCaptureCallback(IntPtr dataL, IntPtr dataR, int numChannels, int numData);
    }
}
