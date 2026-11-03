namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomExStandardVoicePool : CriAtomExVoicePool
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

        public static void SetDefaultConfigForStandardVoicePool(ref Config config)
        {
        }

        public CriAtomExStandardVoicePool(Config config)
        {
        }

        public CriAtomExStandardVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0u)
        {
        }

        [PreserveSig]
        private static extern IntPtr criAtomExVoicePool_AllocateStandardVoicePool(ref Config config, IntPtr work, int work_size);
        [PreserveSig]
        private static extern void CRIWARE0EC76E7C(ref Config config);
    }
}
