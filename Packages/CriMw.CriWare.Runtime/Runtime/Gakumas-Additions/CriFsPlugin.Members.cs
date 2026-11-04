// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::System.Runtime.InteropServices;
using global::System;

namespace CriWare
{
    public static partial class CriFsPlugin
    {

        public static bool isInitialized
        {
            get
            {
                return default(bool);
            }
        }



        public static void SetReadDeviceEnabled(int deviceId, bool enabled)
        {
        }



        public static void SetConfigAdditionalParameters_EDITOR(int additionalLoaders)
        {
        }



        public static void SetMemoryFileSystemThreadPriorityExperimentalAndroid(int prio)
        {
        }



        public static void SetDataDecompressionThreadPriorityExperimentalAndroid(int prio)
        {
        }


        [PreserveSig]
        public static uint criFsLoader_GetRetryCount() { throw new NotSupportedException("native criFsLoader_GetRetryCount (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criFs_SetReadDeviceEnabled(int device_id, bool enabled) { throw new NotSupportedException("native criFs_SetReadDeviceEnabled (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        public static void criFsUnity_SetMemoryFileSystemThreadPriority_ANDROID(int prio) { throw new NotSupportedException("native criFsUnity_SetMemoryFileSystemThreadPriority_ANDROID (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        public static void criFsUnity_SetDataDecompressionThreadPriority_ANDROID(int prio) { throw new NotSupportedException("native criFsUnity_SetDataDecompressionThreadPriority_ANDROID (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criFs_EnableAssetsAccess_ANDROID(IntPtr javaVM, IntPtr staticActivityContext) { throw new NotSupportedException("native criFs_EnableAssetsAccess_ANDROID (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criFs_DisableAssetsAccess_ANDROID() { throw new NotSupportedException("native criFs_DisableAssetsAccess_ANDROID (game P/Invoke; not part of the managed port)"); }
    }
}
