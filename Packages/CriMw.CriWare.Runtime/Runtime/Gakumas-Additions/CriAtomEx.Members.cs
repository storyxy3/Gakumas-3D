// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::CriWare;
using global::System.Collections.Generic;
using global::System.Runtime.InteropServices;
using global::System;
using global::UnityEngine;

namespace CriWare
{
    public static partial class CriAtomEx
    {

        public static event CueLinkCbFunc OnCueLinkCallback
        {
            add
            {
            }

            remove
            {
            }
        }



        public static void SetSpeakerAngle(SpeakerAngles6ch speakerAngle)
        {
        }



        public static void SetSpeakerAngle(SpeakerAngles8ch speakerAngle)
        {
        }



        public static void SetVirtualSpeakerAngle(SpeakerAngles6ch speakerAngle)
        {
        }



        public static void SetVirtualSpeakerAngle(SpeakerAngles8ch speakerAngle)
        {
        }



        public static void ControlVirtualSpeakerSetting(bool sw)
        {
        }



        public static bool RegisterAcf(IntPtr acfData, int dataSize)
        {
            return default(bool);
        }



        public static string GetAppliedDspBusSnapshotName()
        {
            return null;
        }



        public static void ApplyDspBusSnapshot(string snapshot_name, int time_ms)
        {
        }



        public static int GetNumGameVariables()
        {
            return default(int);
        }



        public static bool GetGameVariableInfo(ushort index, out GameVariableInfo info)
        {
            throw null;
        }



        public static float GetGameVariable(uint game_variable_id)
        {
            return default(float);
        }



        public static float GetGameVariable(string game_variable_name)
        {
            return default(float);
        }



        public static void SetGameVariable(uint game_variable_id, float game_variable_value)
        {
        }



        public static void SetGameVariable(string game_variable_name, float game_variable_value)
        {
        }



        public static void ResetPerformanceMonitor()
        {
        }



        public static void GetPerformanceInfo(out PerformanceInfo info)
        {
            throw null;
        }



        public static void SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index)
        {
        }



        public static void SetGlobalLabelToSelectorByName(string selector_name, string label_name)
        {
        }



        public static void PauseTimer(bool sw)
        {
        }



        public static void Lock()
        {
        }



        public static void Unlock()
        {
        }



        public static void SetOutputAudioDevice_PC(string deviceId)
        {
        }



        public static string GetOutputAudioDeviceId_PC(out bool isDefaultDevice)
        {
            throw null;
        }



        public static int GetOutputAudioDeviceIndex_PC(out bool isDefaultDevice)
        {
            throw null;
        }



        public static bool LoadAudioDeviceList_PC()
        {
            return default(bool);
        }



        public static int GetNumAudioDevices_PC()
        {
            return default(int);
        }



        public static string GetAudioDeviceName_PC(int index)
        {
            return null;
        }



        public static void SetOutputAudioDevice_PC(int index)
        {
        }



        public static void SetOutputVolume_VITA(float volume)
        {
        }



        public static bool IsBgmPortAcquired_VITA()
        {
            return default(bool);
        }



        public static void EnableBackgroundPlayback_IOS()
        {
        }



        public static void DisableBackgroundPlayback_IOS()
        {
        }



        public static bool IsInterruptedOtherAudio_IOS()
        {
            return default(bool);
        }



        public static void ResumeAudio_IOS()
        {
        }



        public static bool IsSoundStopped_IOS()
        {
            return default(bool);
        }



        public static void EnableAudioSessionRestoration_IOS(bool flag)
        {
        }



        public static void EnableBusSendOffsetWhenLevelNotExist(bool enable)
        {
        }


        [PreserveSig]
        private static bool criAtomEx_RegisterAcfData(IntPtr acfData, int acfDataSize, IntPtr work, int workSize) { throw new NotSupportedException("native criAtomEx_RegisterAcfData (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx_ApplyDspBusSnapshot(string snapshot_name, int time_ms) { throw new NotSupportedException("native criAtomEx_ApplyDspBusSnapshot (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static IntPtr criAtomEx_GetAppliedDspBusSnapshotName() { throw new NotSupportedException("native criAtomEx_GetAppliedDspBusSnapshotName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomEx_GetNumGameVariables() { throw new NotSupportedException("native criAtomEx_GetNumGameVariables (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomEx_GetGameVariableInfo(ushort index, IntPtr game_variable_info) { throw new NotSupportedException("native criAtomEx_GetGameVariableInfo (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static float criAtomEx_GetGameVariableById(uint game_variable_id) { throw new NotSupportedException("native criAtomEx_GetGameVariableById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static float criAtomEx_GetGameVariableByName(string game_variable_name) { throw new NotSupportedException("native criAtomEx_GetGameVariableByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx_SetGameVariableById(uint game_variable_id, float game_variable_value) { throw new NotSupportedException("native criAtomEx_SetGameVariableById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx_SetGameVariableByName(string game_variable_name, float game_variable_value) { throw new NotSupportedException("native criAtomEx_SetGameVariableByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx_PauseTimer(bool sw) { throw new NotSupportedException("native criAtomEx_PauseTimer (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx_Lock() { throw new NotSupportedException("native criAtomEx_Lock (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx_Unlock() { throw new NotSupportedException("native criAtomEx_Unlock (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtom_ResetPerformanceMonitor() { throw new NotSupportedException("native criAtom_ResetPerformanceMonitor (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtom_GetPerformanceInfo(out PerformanceInfo info) { throw new NotSupportedException("native criAtom_GetPerformanceInfo (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAcf_SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index) { throw new NotSupportedException("native criAtomExAcf_SetGlobalLabelToSelectorByIndex (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAcf_SetGlobalLabelToSelectorByName(string selector_name, string label_name) { throw new NotSupportedException("native criAtomExAcf_SetGlobalLabelToSelectorByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array) { throw new NotSupportedException("native criAtomEx_SetSpeakerAngleArray (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array) { throw new NotSupportedException("native criAtomEx_SetSpeakerAngleArray (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array) { throw new NotSupportedException("native criAtomEx_SetVirtualSpeakerAngleArray (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array) { throw new NotSupportedException("native criAtomEx_SetVirtualSpeakerAngleArray (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx_ControlVirtualSpeakerSetting(bool sw) { throw new NotSupportedException("native criAtomEx_ControlVirtualSpeakerSetting (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx_EnableBusSendOffsetWhenLevelNotExist(bool enable) { throw new NotSupportedException("native criAtomEx_EnableBusSendOffsetWhenLevelNotExist (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        public static void criAtom_EnableSlLatencyCheck_ANDROID(bool sw) { throw new NotSupportedException("native criAtom_EnableSlLatencyCheck_ANDROID (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        public static int criAtom_GetSlBufferConsumptionLatency_ANDROID() { throw new NotSupportedException("native criAtom_GetSlBufferConsumptionLatency_ANDROID (game P/Invoke; not part of the managed port)"); }
    }
}
