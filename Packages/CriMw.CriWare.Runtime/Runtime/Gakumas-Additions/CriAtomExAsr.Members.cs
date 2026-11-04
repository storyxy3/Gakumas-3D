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
    public static partial class CriAtomExAsr
    {


        public static void AttachBusAnalyzer(string busName, int interval, int peakHoldTime)
        {
        }



        public static void AttachBusAnalyzer(int interval, int peakHoldTime)
        {
        }



        public static void DetachBusAnalyzer(string busName)
        {
        }



        public static void DetachBusAnalyzer()
        {
        }



        public static void GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info)
        {
            throw null;
        }



        [Obsolete("Use CriAtomExAsr.GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info)")]
        public static void GetBusAnalyzerInfo(int busId, out BusAnalyzerInfo info)
        {
            throw null;
        }



        public static void SetBusVolume(string busName, float volume)
        {
        }



        [Obsolete("Use CriAtomExAsr.SetBusVolume(string busName, float volume)")]
        public static void SetBusVolume(int busId, float volume)
        {
        }



        public static void SetBusSendLevel(string busName, string sendTo, float level)
        {
        }



        [Obsolete("Use CriAtomExAsr.SetBusSendLevel(string busName, string sendTo, float level)")]
        public static void SetBusSendLevel(int busId, int sendTo, float level)
        {
        }



        public static void SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix)
        {
        }



        [Obsolete("Use CriAtomExAsr.SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix)")]
        public static void SetBusMatrix(int busId, int inputChannels, int outputChannels, float[] matrix)
        {
        }



        public static void SetEffectBypass(string busName, string effectName, bool bypass)
        {
        }



        public static void SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue)
        {
        }



        public static float GetEffectParameter(string busName, string effectName, uint parameterIndex)
        {
            return default(float);
        }



        public static void UnregisterEffectInterface(IntPtr afx_interface)
        {
        }



        public static void GetBusVolume(string busName, out float volume)
        {
            throw null;
        }



        public static void EnableBinauralizer(bool enabled)
        {
        }



        public static bool IsEnabledBinauralizer()
        {
            return default(bool);
        }



        public static int GetPcmOutput(int outputChannels, int outputSamples, float[][] buffer)
        {
            return default(int);
        }



        public static int GetNumBufferedPcmOutputSamples()
        {
            return default(int);
        }



        public static void SetPcmBufferSize(int numSamples)
        {
        }



        public static void PauseOutputVoice(bool sw)
        {
        }



        [PreserveSig]
        private static void criAtomExAsr_AttachBusAnalyzerByName(string busName, ref BusAnalyzerConfig config) { throw new NotSupportedException("native criAtomExAsr_AttachBusAnalyzerByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_AttachBusAnalyzer(int busNo, ref BusAnalyzerConfig config) { throw new NotSupportedException("native criAtomExAsr_AttachBusAnalyzer (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_DetachBusAnalyzerByName(string busName) { throw new NotSupportedException("native criAtomExAsr_DetachBusAnalyzerByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_DetachBusAnalyzer(int busNo) { throw new NotSupportedException("native criAtomExAsr_DetachBusAnalyzer (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_GetBusAnalyzerInfoByName(string busName, IntPtr info) { throw new NotSupportedException("native criAtomExAsr_GetBusAnalyzerInfoByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_GetBusAnalyzerInfo(int busNo, IntPtr info) { throw new NotSupportedException("native criAtomExAsr_GetBusAnalyzerInfo (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_SetBusVolumeByName(string busName, float volume) { throw new NotSupportedException("native criAtomExAsr_SetBusVolumeByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_SetBusVolume(int busNo, float volume) { throw new NotSupportedException("native criAtomExAsr_SetBusVolume (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_SetBusSendLevelByName(string busName, string sendtoName, float level) { throw new NotSupportedException("native criAtomExAsr_SetBusSendLevelByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_SetBusSendLevel(int busNo, int sendtoNo, float level) { throw new NotSupportedException("native criAtomExAsr_SetBusSendLevel (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_SetBusMatrixByName(string busName, int inputChannels, int outputChannels, float[] matrix) { throw new NotSupportedException("native criAtomExAsr_SetBusMatrixByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_SetBusMatrix(int busNo, int inputChannels, int outputChannels, float[] matrix) { throw new NotSupportedException("native criAtomExAsr_SetBusMatrix (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_SetEffectBypass(string busName, string effectName, bool bypass) { throw new NotSupportedException("native criAtomExAsr_SetEffectBypass (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_UpdateEffectParameters(string busName, string effectName) { throw new NotSupportedException("native criAtomExAsr_UpdateEffectParameters (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue) { throw new NotSupportedException("native criAtomExAsr_SetEffectParameter (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static float criAtomExAsr_GetEffectParameter(string busName, string effectName, uint parameterIndex) { throw new NotSupportedException("native criAtomExAsr_GetEffectParameter (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_UnregisterEffectInterface(IntPtr afx_interface) { throw new NotSupportedException("native criAtomExAsr_UnregisterEffectInterface (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_EnableBinauralizer(bool enabled) { throw new NotSupportedException("native criAtomExAsr_EnableBinauralizer (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExAsr_IsEnabledBinauralizer() { throw new NotSupportedException("native criAtomExAsr_IsEnabledBinauralizer (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_PauseOutputVoice(bool sw) { throw new NotSupportedException("native criAtomExAsr_PauseOutputVoice (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExAsrRack_GetNumBuses(int rackId) { throw new NotSupportedException("native criAtomExAsrRack_GetNumBuses (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExAsr_GetBusVolumeByName(string busName, out float volume) { throw new NotSupportedException("native criAtomExAsr_GetBusVolumeByName (game P/Invoke; not part of the managed port)"); }
    }
}
