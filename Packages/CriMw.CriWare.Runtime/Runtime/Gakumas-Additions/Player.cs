// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare.CriMana
{
    public partial class Player
    {


        public enum MovieEventSyncMode
        {
            FrameTime,
            PlayBackTime
        }



        public enum AudioTrack
        {
            Off,
            Auto
        }


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void SubtitleCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2);
    }
}
