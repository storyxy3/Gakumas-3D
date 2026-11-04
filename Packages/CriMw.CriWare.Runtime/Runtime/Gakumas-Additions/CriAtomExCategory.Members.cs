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
    public static partial class CriAtomExCategory
    {


        public static void SetVolume(string name, float volume)
        {
        }



        public static void SetVolume(int id, float volume)
        {
        }



        public static float GetVolume(string name)
        {
            return default(float);
        }



        public static float GetVolume(int id)
        {
            return default(float);
        }



        public static void Mute(string name, bool mute)
        {
        }



        public static void Mute(int id, bool mute)
        {
        }



        public static bool IsMuted(string name)
        {
            return default(bool);
        }



        public static bool IsMuted(int id)
        {
            return default(bool);
        }



        public static void Solo(string name, bool solo, float muteVolume)
        {
        }



        public static void Solo(int id, bool solo, float muteVolume)
        {
        }



        public static bool IsSoloed(string name)
        {
            return default(bool);
        }



        public static bool IsSoloed(int id)
        {
            return default(bool);
        }



        public static void Pause(string name, bool pause)
        {
        }



        public static void Pause(int id, bool pause)
        {
        }



        public static bool IsPaused(string name)
        {
            return default(bool);
        }



        public static bool IsPaused(int id)
        {
            return default(bool);
        }



        public static void SetAisacControl(string name, string controlName, float value)
        {
        }



        [Obsolete("Use CriAtomExCategory.SetAisacControl")]
        public static void SetAisac(string name, string controlName, float value)
        {
        }



        public static void SetAisacControl(int id, int controlId, float value)
        {
        }



        [Obsolete("Use CriAtomExCategory.SetAisacControl")]
        public static void SetAisac(int id, int controlId, float value)
        {
        }



        public static void SetReactParameter(string name, ReactParameter parameter)
        {
        }



        public static bool GetReactParameter(string name, out ReactParameter parameter)
        {
            throw null;
        }



        public static bool GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo)
        {
            throw null;
        }



        public static bool GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo)
        {
            throw null;
        }



        public static bool GetCurrentAisacControlValue(string categoryName, string aisacControlName, out float controlValue)
        {
            throw null;
        }



        public static ReactStatus GetReactStatus(string reactName)
        {
            return default(ReactStatus);
        }



        public static void Stop(int id)
        {
        }



        public static void Stop(string name)
        {
        }



        public static void StopWithoutReleaseTime(int id)
        {
        }



        public static void StopWithoutReleaseTime(string name)
        {
        }



        public static float GetTotalVolume(int id)
        {
            return default(float);
        }



        public static float GetTotalVolume(string name)
        {
            return default(float);
        }



        public static void SetFadeInTime(int id, ushort ms)
        {
        }



        public static void SetFadeInTime(string name, ushort ms)
        {
        }



        public static void SetFadeOutTime(int id, ushort ms)
        {
        }



        public static void SetFadeOutTime(string name, ushort ms)
        {
        }



        public static bool ResetAllAisacControl(int id)
        {
            return default(bool);
        }



        public static bool ResetAllAisacControl(string name)
        {
            return default(bool);
        }



        public static void AttachAisac(int id, string globalAisacName)
        {
        }



        public static void AttachAisac(string name, string globalAisacName)
        {
        }



        public static void DetachAisac(int id, string globalAisacName)
        {
        }



        public static void DetachAisac(string name, string globalAisacName)
        {
        }



        public static void DetachAisacAll(int id)
        {
        }



        public static void DetachAisacAll(string name)
        {
        }



        public static int GetNumAttachedAisacs(int id)
        {
            return default(int);
        }



        public static int GetNumAttachedAisacs(string name)
        {
            return default(int);
        }



        public static int GetNumCuePlayingCount(int id)
        {
            return default(int);
        }



        public static int GetNumCuePlayingCount(string name)
        {
            return default(int);
        }


        [PreserveSig]
        private static float criAtomExCategory_GetVolumeByName(string name) { throw new NotSupportedException("native criAtomExCategory_GetVolumeByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_SetVolumeById(int id, float volume) { throw new NotSupportedException("native criAtomExCategory_SetVolumeById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static float criAtomExCategory_GetVolumeById(int id) { throw new NotSupportedException("native criAtomExCategory_GetVolumeById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_MuteById(int id, bool mute) { throw new NotSupportedException("native criAtomExCategory_MuteById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExCategory_IsMutedById(int id) { throw new NotSupportedException("native criAtomExCategory_IsMutedById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_MuteByName(string name, bool mute) { throw new NotSupportedException("native criAtomExCategory_MuteByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExCategory_IsMutedByName(string name) { throw new NotSupportedException("native criAtomExCategory_IsMutedByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_SoloById(int id, bool solo, float volume) { throw new NotSupportedException("native criAtomExCategory_SoloById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExCategory_IsSoloedById(int id) { throw new NotSupportedException("native criAtomExCategory_IsSoloedById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_SoloByName(string name, bool solo, float volume) { throw new NotSupportedException("native criAtomExCategory_SoloByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExCategory_IsSoloedByName(string name) { throw new NotSupportedException("native criAtomExCategory_IsSoloedByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_PauseById(int id, bool pause) { throw new NotSupportedException("native criAtomExCategory_PauseById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExCategory_IsPausedById(int id) { throw new NotSupportedException("native criAtomExCategory_IsPausedById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_PauseByName(string name, bool pause) { throw new NotSupportedException("native criAtomExCategory_PauseByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExCategory_IsPausedByName(string name) { throw new NotSupportedException("native criAtomExCategory_IsPausedByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_SetAisacControlById(int id, ushort controlId, float value) { throw new NotSupportedException("native criAtomExCategory_SetAisacControlById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_SetAisacControlByName(string name, string controlName, float value) { throw new NotSupportedException("native criAtomExCategory_SetAisacControlByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_SetReactParameter(string react_name, ref ReactParameter parameter) { throw new NotSupportedException("native criAtomExCategory_SetReactParameter (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExCategory_GetReactParameter(string react_name, out ReactParameter parameter) { throw new NotSupportedException("native criAtomExCategory_GetReactParameter (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExCategory_GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, IntPtr aisacInfo) { throw new NotSupportedException("native criAtomExCategory_GetAttachedAisacInfoById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExCategory_GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, IntPtr aisacInfo) { throw new NotSupportedException("native criAtomExCategory_GetAttachedAisacInfoByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExCategory_GetCurrentAisacControlValueByName(string category_name, string aisac_control_name, out float control_value) { throw new NotSupportedException("native criAtomExCategory_GetCurrentAisacControlValueByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static ReactStatus criAtomExCategory_GetReactStatus(string react_name) { throw new NotSupportedException("native criAtomExCategory_GetReactStatus (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static float criAtomExCategory_GetTotalVolumeById(int id) { throw new NotSupportedException("native criAtomExCategory_GetTotalVolumeById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static float criAtomExCategory_GetTotalVolumeByName(string name) { throw new NotSupportedException("native criAtomExCategory_GetTotalVolumeByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_SetFadeInTimeById(int id, ushort ms) { throw new NotSupportedException("native criAtomExCategory_SetFadeInTimeById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_SetFadeInTimeByName(string name, ushort ms) { throw new NotSupportedException("native criAtomExCategory_SetFadeInTimeByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_SetFadeOutTimeById(int id, ushort ms) { throw new NotSupportedException("native criAtomExCategory_SetFadeOutTimeById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_SetFadeOutTimeByName(string name, ushort ms) { throw new NotSupportedException("native criAtomExCategory_SetFadeOutTimeByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExCategory_ResetAllAisacControlById(int category_id) { throw new NotSupportedException("native criAtomExCategory_ResetAllAisacControlById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExCategory_ResetAllAisacControlByName(string category_name) { throw new NotSupportedException("native criAtomExCategory_ResetAllAisacControlByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_AttachAisacById(int id, string global_aisac_name) { throw new NotSupportedException("native criAtomExCategory_AttachAisacById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_AttachAisacByName(string name, string global_aisac_name) { throw new NotSupportedException("native criAtomExCategory_AttachAisacByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_DetachAisacById(int id, string global_aisac_name) { throw new NotSupportedException("native criAtomExCategory_DetachAisacById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_DetachAisacByName(string name, string global_aisac_name) { throw new NotSupportedException("native criAtomExCategory_DetachAisacByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_DetachAisacAllById(int id) { throw new NotSupportedException("native criAtomExCategory_DetachAisacAllById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_DetachAisacAllByName(string name) { throw new NotSupportedException("native criAtomExCategory_DetachAisacAllByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExCategory_GetNumAttachedAisacsById(int id) { throw new NotSupportedException("native criAtomExCategory_GetNumAttachedAisacsById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExCategory_GetNumAttachedAisacsByName(string name) { throw new NotSupportedException("native criAtomExCategory_GetNumAttachedAisacsByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExCategory_GetNumCuePlayingCountById(int id) { throw new NotSupportedException("native criAtomExCategory_GetNumCuePlayingCountById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExCategory_GetNumCuePlayingCountByName(string name) { throw new NotSupportedException("native criAtomExCategory_GetNumCuePlayingCountByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_StopById(int id) { throw new NotSupportedException("native criAtomExCategory_StopById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_StopByName(string name) { throw new NotSupportedException("native criAtomExCategory_StopByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_StopWithoutReleaseTimeById(int id) { throw new NotSupportedException("native criAtomExCategory_StopWithoutReleaseTimeById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExCategory_StopWithoutReleaseTimeByName(string name) { throw new NotSupportedException("native criAtomExCategory_StopWithoutReleaseTimeByName (game P/Invoke; not part of the managed port)"); }
    }
}
