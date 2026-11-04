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
    public partial class CriAtomEx3dListener
    {


        public void ResetParameters()
        {
        }



        [Obsolete("Use SetDopplerMultiplier instead")]
        public void SetDistanceFactor(float distanceFactor)
        {
        }



        public void SetDopplerMultiplier(float dopplerMultiplier)
        {
        }



        public void SetFocusPoint(float x, float y, float z)
        {
        }



        public void SetDistanceFocusLevel(float distanceFocusLevel)
        {
        }



        public void SetDirectionFocusLevel(float directionFocusLevel)
        {
        }



        public bool IsDestroyable()
        {
            return default(bool);
        }


        [PreserveSig]
        private static void criAtomEx3dListener_Update(IntPtr ex_3d_listener) { throw new NotSupportedException("native criAtomEx3dListener_Update (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dListener_ResetParameters(IntPtr ex_3d_listener) { throw new NotSupportedException("native criAtomEx3dListener_ResetParameters (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dListener_SetPosition(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector position) { throw new NotSupportedException("native criAtomEx3dListener_SetPosition (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dListener_SetVelocity(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector velocity) { throw new NotSupportedException("native criAtomEx3dListener_SetVelocity (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dListener_SetOrientation(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top) { throw new NotSupportedException("native criAtomEx3dListener_SetOrientation (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dListener_SetDistanceFactor(IntPtr ex_3d_listener, float distance_factor) { throw new NotSupportedException("native criAtomEx3dListener_SetDistanceFactor (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dListener_SetDopplerMultiplier(IntPtr ex_3d_listener, float doppler_multiplier) { throw new NotSupportedException("native criAtomEx3dListener_SetDopplerMultiplier (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dListener_SetFocusPoint(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector focus_point) { throw new NotSupportedException("native criAtomEx3dListener_SetFocusPoint (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dListener_SetDistanceFocusLevel(IntPtr ex_3d_listener, float distance_focus_level) { throw new NotSupportedException("native criAtomEx3dListener_SetDistanceFocusLevel (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dListener_SetDirectionFocusLevel(IntPtr ex_3d_listener, float direction_focus_level) { throw new NotSupportedException("native criAtomEx3dListener_SetDirectionFocusLevel (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomEx3dListener_IsDestroyable(IntPtr ex_3d_listener) { throw new NotSupportedException("native criAtomEx3dListener_IsDestroyable (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dListener_Set3dRegionHn(IntPtr ex_3d_listener, IntPtr ex_3d_region) { throw new NotSupportedException("native criAtomEx3dListener_Set3dRegionHn (game P/Invoke; not part of the managed port)"); }
    }
}
