namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomExWaveVoicePool : CriAtomExVoicePool
    {
        public struct Config
        {
            public uint identifier;
            public int numVoices;
            public PlayerConfig playerConfig;
            public bool isStreamingOnly;
            public int minChannels;
            public static Config Default()
            {
                return default(Config);
            }
        }

        public static void SetDefaultConfigForWaveVoicePool(ref Config config)
        {
        }

        public CriAtomExWaveVoicePool(Config config)
        {
        }

        public CriAtomExWaveVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0u)
        {
        }

        [PreserveSig]
        private static extern IntPtr criAtomExVoicePool_AllocateWaveVoicePool(ref Config config, IntPtr work, int work_size);
        [PreserveSig]
        private static extern void CRIWARE6947DEA5(ref Config config);
    }
}
