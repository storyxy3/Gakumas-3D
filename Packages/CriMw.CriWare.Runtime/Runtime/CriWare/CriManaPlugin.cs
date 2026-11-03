namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::CriWare.CriMana;
    using global::UnityEngine.Rendering;

    public class CriManaPlugin
    {
        private static int initializationCount;
        private static bool isConfigured;
        private static bool enabledMultithreadedRendering;
        public static int renderingEventOffset;
        [CompilerGenerated]
        private static Action m_OnBeforeInitialize;
        [CompilerGenerated]
        private static Action m_OnInitialized;
        [CompilerGenerated]
        private static Action m_OnBeforeFinalize;
        [CompilerGenerated]
        private static Action m_OnFinalized;
        public static bool isInitialized
        {
            get
            {
                return default(bool);
            }
        }

        public static bool isMultithreadedRenderingEnabled
        {
            get
            {
                return default(bool);
            }
        }

        public static event Action OnBeforeInitialize
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public static event Action OnInitialized
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public static event Action OnBeforeFinalize
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public static event Action OnFinalized
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public static void SetConfigParameters(bool graphicsMultiThreaded, int num_decoders, int max_num_of_entries)
        {
        }

        private static void SetupVp9()
        {
        }

        private static void SetupAV1()
        {
        }

        [Obsolete("Use CriWareVITA.EnableH264Playback and CriWareVITA.SetH264DecoderMaxSize instead.")]
        public static void SetConfigAdditonalParameters_VITA(bool use_h264_playback, int width, int height)
        {
        }

        public static void SetConfigAdditonalParameters_PC(bool use_h264_playback)
        {
        }

        public static void UseLegacyDecoder_PC(bool useLegacyDecoder)
        {
        }

        public static bool IsLegacyDecoderUsed_PC()
        {
            return default(bool);
        }

        public static void SetConfigAdditonalParameters_ANDROID(bool enable_buffer_output_for_h264, bool enable_buffer_output_for_vp9)
        {
        }

        public static void SetConfigAdditonalParameters_WEBGL(string webworkerPath, uint heapSize)
        {
        }

        public static void InitializeLibrary()
        {
        }

        public static bool IsLibraryInitialized()
        {
            return default(bool);
        }

        public static void FinalizeLibrary()
        {
        }

        public static bool IsCodecSupported(CodecType codecType)
        {
            return default(bool);
        }

        private static Type GetVp9ExpansionClass()
        {
            return null;
        }

        private static Type GetAV1ExpansionClass()
        {
            return null;
        }

        private static bool IsAV1CodecSupported()
        {
            return default(bool);
        }

        private static bool IsVp9CodecSupported()
        {
            return default(bool);
        }

        private static bool IsH264CodecSupported()
        {
            return default(bool);
        }

        public static void SetDecodeThreadPriorityAndroidExperimental(int prio)
        {
        }

        public static bool ShouldSampleRed(GraphicsDeviceType type, IntPtr tex_ptr)
        {
            return default(bool);
        }

        public static void UseStreamerManager(bool flag)
        {
        }

        public static bool IsStreamerManagerUsed()
        {
            return default(bool);
        }

        public static void Lock()
        {
        }

        public static void Unlock()
        {
        }

        public static uint GetPrimeBufferAlignmentSize()
        {
            return default(uint);
        }

        public static bool AnalyzeMovieHeader(IntPtr data, out MovieInfo movieInfo)
        {
            throw null;
        }

        [PreserveSig]
        private static extern void CRIWAREA1C9B167(int graphics_api, bool graphics_multi_threaded, int num_decoders, int num_of_max_entries);
        [PreserveSig]
        private static extern void CRIWARE858F3F32();
        [PreserveSig]
        public static extern bool CRIWAREE76CEE53();
        [PreserveSig]
        private static extern void CRIWARE6281964B();
        [PreserveSig]
        public static extern void CRIWARE0EB12815(bool flag);
        [PreserveSig]
        public static extern void CRIWAREF23BF05E();
        [PreserveSig]
        public static extern void CRIWARE9C66139C();
        [PreserveSig]
        private static extern uint CRIWARE6832591C();
        [PreserveSig]
        public static extern void criMana_UseStreamerManager(bool flag);
        [PreserveSig]
        public static extern bool criMana_IsStreamerManagerUsed();
        [PreserveSig]
        public static extern bool CRIWAREEF44258F(IntPtr movie_header_ptr, [Out] MovieInfo mvinf);
        [PreserveSig]
        public static extern uint CRIWARE8E2F51F5();
        [PreserveSig]
        public static extern void criManaUnity_SetDecodeThreadPriority_ANDROID(int prio);
        [PreserveSig]
        private static extern void criManaUnity_SetConfigAdditionalParameters_ANDROID(bool buffer_h264, bool buffer_vp9);
        [PreserveSig]
        public static extern bool criManaUnity_IsBufferOutputForH264Enabled_ANDROID();
        [PreserveSig]
        public static extern void criManaUnity_EnableSwitchTextureSampleColorGLES30_ANDROID();
        [PreserveSig]
        private static extern bool criManaUnity_ShouldSwitchTextureSampleColorToRedGLES30_ANDROID(IntPtr tex_ptr);
        public CriManaPlugin()
        {
        }
    }
}
