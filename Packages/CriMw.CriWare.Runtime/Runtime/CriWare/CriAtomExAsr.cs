namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomExAsr
    {
        private struct BusAnalyzerConfig
        {
            public int interval;
            public int peakHoldTime;
        }

        public struct BusAnalyzerInfo
        {
            public int numChannels;
            public float[] rmsLevels;
            public float[] peakLevels;
            public float[] peakHoldLevels;
            public BusAnalyzerInfo(byte[] data)
            {
                this = default;
            }
        }

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

        public static bool RegisterEffectInterface(IntPtr afx_interface)
        {
            return default(bool);
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
        private static extern void criAtomExAsr_AttachBusAnalyzerByName(string busName, ref BusAnalyzerConfig config);
        [PreserveSig]
        private static extern void criAtomExAsr_AttachBusAnalyzer(int busNo, ref BusAnalyzerConfig config);
        [PreserveSig]
        private static extern void criAtomExAsr_DetachBusAnalyzerByName(string busName);
        [PreserveSig]
        private static extern void criAtomExAsr_DetachBusAnalyzer(int busNo);
        [PreserveSig]
        private static extern void criAtomExAsr_GetBusAnalyzerInfoByName(string busName, IntPtr info);
        [PreserveSig]
        private static extern void criAtomExAsr_GetBusAnalyzerInfo(int busNo, IntPtr info);
        [PreserveSig]
        private static extern void criAtomExAsr_SetBusVolumeByName(string busName, float volume);
        [PreserveSig]
        private static extern void criAtomExAsr_SetBusVolume(int busNo, float volume);
        [PreserveSig]
        private static extern void criAtomExAsr_SetBusSendLevelByName(string busName, string sendtoName, float level);
        [PreserveSig]
        private static extern void criAtomExAsr_SetBusSendLevel(int busNo, int sendtoNo, float level);
        [PreserveSig]
        private static extern void criAtomExAsr_SetBusMatrixByName(string busName, int inputChannels, int outputChannels, float[] matrix);
        [PreserveSig]
        private static extern void criAtomExAsr_SetBusMatrix(int busNo, int inputChannels, int outputChannels, float[] matrix);
        [PreserveSig]
        private static extern void criAtomExAsr_SetEffectBypass(string busName, string effectName, bool bypass);
        [PreserveSig]
        private static extern void criAtomExAsr_UpdateEffectParameters(string busName, string effectName);
        [PreserveSig]
        private static extern void criAtomExAsr_SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue);
        [PreserveSig]
        private static extern float criAtomExAsr_GetEffectParameter(string busName, string effectName, uint parameterIndex);
        [PreserveSig]
        private static extern bool criAtomExAsr_RegisterEffectInterface(IntPtr afx_interface);
        [PreserveSig]
        private static extern void criAtomExAsr_UnregisterEffectInterface(IntPtr afx_interface);
        [PreserveSig]
        private static extern void criAtomExAsr_EnableBinauralizer(bool enabled);
        [PreserveSig]
        private static extern bool criAtomExAsr_IsEnabledBinauralizer();
        [PreserveSig]
        private static extern void criAtomExAsr_PauseOutputVoice(bool sw);
        [PreserveSig]
        private static extern int criAtomExAsrRack_GetNumBuses(int rackId);
        [PreserveSig]
        private static extern void criAtomExAsr_GetBusVolumeByName(string busName, out float volume);
        public CriAtomExAsr()
        {
        }
    }
}
