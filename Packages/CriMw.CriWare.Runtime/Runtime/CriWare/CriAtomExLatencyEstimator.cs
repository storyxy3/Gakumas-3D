namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    [Obsolete("This feature is obsoleted. Estimation will not occur if SonicSYNC is enabled.")]
    public static class CriAtomExLatencyEstimator
    {
        public enum Status
        {
            Stop,
            Processing,
            Done,
            Error
        }

        public struct EstimatorInfo
        {
            public Status status;
            public uint estimated_latency;
        }

        public static void InitializeModule()
        {
        }

        public static void FinalizeModule()
        {
        }

        public static EstimatorInfo GetCurrentInfo()
        {
            return default(EstimatorInfo);
        }

        [PreserveSig]
        private static extern void criAtomLatencyEstimator_Initialize_ANDROID();
        [PreserveSig]
        private static extern void criAtomLatencyEstimator_Finalize_ANDROID();
        [PreserveSig]
        private static extern EstimatorInfo criAtomLatencyEstimator_GetCurrentInfo_ANDROID();
    }
}
