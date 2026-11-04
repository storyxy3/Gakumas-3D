// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::AOT;
using global::CriWare;
using global::System.Runtime.InteropServices;
using global::System;

namespace CriWare
{
    public partial class CriAtomExOutputAnalyzer
    {

        protected PcmCaptureCallback userPcmCaptureCallback;


        protected static IntPtr InternalCallbackFunctionPointer;


        protected static InternalPcmCaptureCallback DelegateObject;


        protected static float[] DataL;


        protected static float[] DataR;


        protected static PcmCaptureCallback UserPcmCaptureCallback;



        public bool AttachDspBus(string busName)
        {
            return default(bool);
        }



        public void GetSpectrumLevels(ref float[] levels)
        {
        }



        public void GetPcmData(ref float[] data, int ch)
        {
        }



        public void SetPcmCaptureCallback(PcmCaptureCallback callback)
        {
        }



        public void ExecutePcmCaptureCallback()
        {
        }



        [Obsolete("Use SetPcmCaptureCallback(PcmCaptureCallback) and ExecutePcmCaptureCallback()")]
        public void ExecutePcmCaptureCallback(PcmCaptureCallback callback)
        {
        }



        protected CriAtomExOutputAnalyzer()
        {
        }



        [MonoPInvokeCallback(typeof(InternalPcmCaptureCallback))]
        private static void Callback(IntPtr ptrL, IntPtr ptrR, int numChannels, int numData)
        {
        }


        [PreserveSig]
        protected static void criAtomExOutputAnalyzer_AttachDspBusByName(IntPtr analyzer, string busName) { throw new NotSupportedException("native criAtomExOutputAnalyzer_AttachDspBusByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        protected static IntPtr criAtomExOutputAnalyzer_GetSpectrumLevels(IntPtr analyzer) { throw new NotSupportedException("native criAtomExOutputAnalyzer_GetSpectrumLevels (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        protected static IntPtr criAtomExOutputAnalyzer_GetPcmData(IntPtr analyzer, int ch) { throw new NotSupportedException("native criAtomExOutputAnalyzer_GetPcmData (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        protected static void criAtomExOutputAnalyzer_ExecuteQueuedPcmCapturerCallbacks(IntPtr analyzer, IntPtr callback) { throw new NotSupportedException("native criAtomExOutputAnalyzer_ExecuteQueuedPcmCapturerCallbacks (game P/Invoke; not part of the managed port)"); }
    }
}
