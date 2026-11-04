using System;

namespace CriWare
{
    // CriWare.CriAtomExAsr: the member on the library initialization path.
    public static partial class CriAtomExAsr
    {
        public static bool RegisterEffectInterface(IntPtr afx_interface)
        {
            return criAtomExAsr_RegisterEffectInterface(afx_interface);
        }

        internal static bool criAtomExAsr_RegisterEffectInterface(IntPtr afx_interface) =>
            CriWareNative.Native.criAtomExAsr_RegisterEffectInterface(afx_interface);
    }

    // CriWare.CriAtomExLatencyEstimator: the Android latency estimator, finalized before the Atom library.
    public static partial class CriAtomExLatencyEstimator
    {
        public enum Status
        {
            Stop = 0,
            Processing = 1,
            Done = 2,
            Error = 3
        }

        public struct EstimatorInfo
        {
            public Status status;
            public uint estimated_latency;
        }

        public static void FinalizeModule()
        {
            criAtomLatencyEstimator_Finalize_ANDROID();
        }

        public static EstimatorInfo GetCurrentInfo()
        {
            return criAtomLatencyEstimator_GetCurrentInfo_ANDROID();
        }

        private static void criAtomLatencyEstimator_Finalize_ANDROID() =>
            CriWareNative.Native.criAtomLatencyEstimator_Finalize_ANDROID();
        private static EstimatorInfo criAtomLatencyEstimator_GetCurrentInfo_ANDROID() =>
            CriWareNative.Native.criAtomLatencyEstimator_GetCurrentInfo_ANDROID();
    }
}
