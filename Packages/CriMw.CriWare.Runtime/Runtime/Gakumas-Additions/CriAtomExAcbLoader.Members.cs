// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::CriWare;
using global::System.Runtime.InteropServices;
using global::System;

namespace CriWare
{
    public partial class CriAtomExAcbLoader
    {


        private IntPtr handle;


        private GCHandle? gch;


        public static CriAtomExAcbLoader LoadAcbFileAsync(CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory = false)
        {
            return null;
        }



        public static CriAtomExAcbLoader LoadAcbDataAsync(byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false)
        {
            return null;
        }



        public static CriAtomExAcbLoader LoadAcbDataAsync(IntPtr acbData, int dataSize, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false)
        {
            return null;
        }



        public Status GetStatus()
        {
            return default(Status);
        }



        public CriAtomExAcb MoveAcb()
        {
            return null;
        }



        private void Dispose(bool disposing)
        {
        }



        private CriAtomExAcbLoader(IntPtr handle, GCHandle? dataHandle)
        {
        }



        ~CriAtomExAcbLoader()
        {
        }



        [PreserveSig]
        private static IntPtr criAtomExAcbLoader_Create([In] ref LoaderConfig config) { throw new NotSupportedException("native criAtomExAcbLoader_Create (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAcbLoader_Destroy(IntPtr acb_loader) { throw new NotSupportedException("native criAtomExAcbLoader_Destroy (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExAcbLoader_LoadAcbFileAsync(IntPtr acb_loader, IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path) { throw new NotSupportedException("native criAtomExAcbLoader_LoadAcbFileAsync (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExAcbLoader_LoadAcbDataAsync(IntPtr acb_loader, IntPtr acb_data, int acb_size, IntPtr awb_binder, string awb_path) { throw new NotSupportedException("native criAtomExAcbLoader_LoadAcbDataAsync (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static Status criAtomExAcbLoader_GetStatus(IntPtr acb_loader) { throw new NotSupportedException("native criAtomExAcbLoader_GetStatus (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExAcbLoader_WaitForCompletion(IntPtr acb_loader) { throw new NotSupportedException("native criAtomExAcbLoader_WaitForCompletion (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static IntPtr criAtomExAcbLoader_MoveAcbHandle(IntPtr acb_loader) { throw new NotSupportedException("native criAtomExAcbLoader_MoveAcbHandle (game P/Invoke; not part of the managed port)"); }
    }
}
