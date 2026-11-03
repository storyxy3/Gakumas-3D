namespace CriWare
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::AOT;
    using global::CriWare;

    public static class CriAtomPlugin
    {
        public struct FileOpenCondition
        {
            public int freeBindsCount;
            public int freeFilesCount;
            public int freeLoadersCount;
            public bool CanLoadAcf
            {
                get
                {
                    return default(bool);
                }
            }

            public bool CanLoadAcb
            {
                get
                {
                    return default(bool);
                }
            }

            public bool CanLoadAcbWithAwb
            {
                get
                {
                    return default(bool);
                }
            }

            public bool CanAttachAwb
            {
                get
                {
                    return default(bool);
                }
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1);
        private static int initializationCount;
        [CompilerGenerated]
        private static Action m_OnBeforeInitialize;
        [CompilerGenerated]
        private static Action m_OnInitialized;
        [CompilerGenerated]
        private static Action m_OnBeforeFinalize;
        [CompilerGenerated]
        private static Action m_OnFinalized;
        private static List<IntPtr> effectInterfaceList;
        private static bool isConfigured;
        private static float timeSinceStartup;
        private static Common.CpuUsage cpuUsage;
        private static int CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT;
        private static ushort CRIATOMPARAMETER2_ID_INVALID;
        private static ulong temporalStorage;
        public static bool isInitialized
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

        public static void Log(string log)
        {
        }

        public static void ExecuteQueuedCueLinkCallbacks()
        {
        }

        public static void ExecuteQueuedEventCallbacks()
        {
        }

        public static void ExecuteQueuedBeatSyncCallbacks()
        {
        }

        public static bool GetAudioEffectInterfaceList(out List<IntPtr> effect_interface_list)
        {
            throw null;
        }

        public static void SetConfigParameters(int max_virtual_voices, int max_voice_limit_groups, int max_categories, byte max_aisacs, byte max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, CriAtom.SpeakerMapping speakerMapping, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, float max_pitch, CriAtomEx.SoundRendererType sound_renderer_type, bool enable_sonicsync_for_common, bool enable_atom_sound_disabled_mode)
        {
        }

        public static void SetConfigMonitorParametes(int max_preview_objects, int communication_buffer_size, int playback_position_update_interval)
        {
        }

        public static void SetConfigAdditionalParameters_EDITOR(bool enable_user_pcm_output, int user_pcm_buffer_length)
        {
        }

        public static void SetConfigAdditionalParameters_PC(long buffering_time_pc, bool use_microsoft_spatial_sound)
        {
        }

        public static void SetConfigAdditionalParameters_LINUX(CriAtomConfig.LinuxOutput output, int pulse_latency_usec)
        {
        }

        public static void SetConfigAdditionalParameters_IOS(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios, bool enable_os_notification_handling)
        {
        }

        public static void SetConfigAdditionalParameters_ANDROID(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool use_fast_mixer, bool use_aaudio, int stream_type)
        {
        }

        public static void SetConfigAdditionalParameters_VITA(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, int num_mana_decoders)
        {
        }

        public static void SetConfigAdditionalParameters_PS4(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, bool use_audio3d, int num_audio3d_memory_voices, int num_audio3d_streaming_voices, int num_mp4_streaming_voices)
        {
        }

        public static void SetConfigAdditionalParameters_PS5(int max_channel_ports, int max_object_ports, int num_mp4_streaming_voices)
        {
        }

        public static void SetConfigAdditionalParameters_SWITCH(bool enable_sonicsync, int num_opus_memory_voices, int num_opus_streaming_voices, bool init_socket)
        {
        }

        public static void SetConfigAdditionalParameters_SWITCH2(int num_opus_memory_voices, int num_opus_streaming_voices, bool init_socket)
        {
        }

        public static void SetConfigAdditionalParameters_WEBGL(int num_webaudio_voices)
        {
        }

        public static void SetMaxSamplingRateForStandardVoicePool(int sampling_rate_for_memory, int sampling_rate_for_streaming)
        {
        }

        public static int GetRequiredMaxVirtualVoices(CriAtomConfig atomConfig)
        {
            return default(int);
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

        public static void Pause(bool pause)
        {
        }

        public static Common.CpuUsage GetCpuUsage()
        {
            return default(Common.CpuUsage);
        }

        public static int GetOutputSamplingRate()
        {
            return default(int);
        }

        public static int GetOutputChannels()
        {
            return default(int);
        }

        public static bool IsInitializedForPcmOutput()
        {
            return default(bool);
        }

        public static ushort GetLoopCountParameterId()
        {
            return default(ushort);
        }

        public static bool GetWaveSamples(CriAtomExAcb acb, string cueName, short[] decodeLpcmBuffer)
        {
            return default(bool);
        }

        public static void DecryptAcb(IntPtr acb_hn, ulong key, ulong nonce)
        {
        }

        public static FileOpenCondition GetFileOpenCondition()
        {
            return default(FileOpenCondition);
        }

        [MonoPInvokeCallback(typeof(CallbackFromNativeDelegate))]
        private static ulong CallbackFromNative(IntPtr ptr1)
        {
            return default(ulong);
        }

        private static bool CRIWAREDBFCA844(IntPtr acbHn, string cue_name, IntPtr decode_lpcm_buffer, long decodeLpcmBufferLength)
        {
            return default(bool);
        }

        [PreserveSig]
        private static extern void CRIWAREB0BB9C69(int max_virtual_voices, int max_voice_limit_groups, int max_categories, byte max_aisacs, byte max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, CriAtom.SpeakerMapping speakerMapping, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, float max_pitch, CriAtomEx.SoundRendererType sound_renderer_type, bool enable_sonicsync_for_common, bool enable_atom_sound_disabled_mode);
        [PreserveSig]
        private static extern void CRIWARE9CAB8A22(uint max_preivew_objects, uint communication_buffer_size, int playback_position_update_interval);
        [PreserveSig]
        private static extern void CRIWARED43325E3(bool enable_user_pcm_out_mode);
        [PreserveSig]
        private static extern void CRIWAREC44E3FD4(long buffering_time_pc, bool use_microsoft_spatial_sound);
        [PreserveSig]
        private static extern void CRIWARE73A19542(int output, int pulse_latency_usec);
        [PreserveSig]
        private static extern void CRIWARE3EF0BAE8(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios, bool enable_os_notification_handling);
        [PreserveSig]
        private static extern void CRIWAREAC32842A(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool apply_hw_property, int stream_type);
        [PreserveSig]
        private static extern void CRIWARE1937BEE7(IntPtr android_context);
        [PreserveSig]
        private static extern void CRIWARE66433306(bool flag);
        [PreserveSig]
        private static extern void CRIWAREA0136359();
        [PreserveSig]
        public static extern bool CRIWARECC27FBE6();
        [PreserveSig]
        private static extern void CRIWARE0C1D82DA();
        [PreserveSig]
        private static extern void CRIWARE6F0BEFAB(bool pause);
        [PreserveSig]
        public static extern uint CRIWARE543940B8();
        [PreserveSig]
        public static extern void CRIWARE47D9347C(int code);
        [PreserveSig]
        public static extern void CRIWARE9DE78201(IntPtr cbfunc, string separator_string);
        [PreserveSig]
        public static extern void CRIWARE8447C285(IntPtr cbfunc);
        [PreserveSig]
        private static extern void CRIWARE2F615E8F();
        [PreserveSig]
        public static extern void CRIWARE9AEB609C(IntPtr cbfunc);
        [PreserveSig]
        private static extern void CRIWARE01E7D88C();
        [PreserveSig]
        public static extern void CRIWAREE61CF4E9(IntPtr cbfunc);
        [PreserveSig]
        private static extern void CRIWARE626F7AD2();
        [PreserveSig]
        private static extern void CRIWAREB17A41EB(int sampling_rate_for_memory, int sampling_rate_for_streaming);
        [PreserveSig]
        public static extern void CRIWARE779FFD9B();
        [PreserveSig]
        public static extern void CRIWAREE93D4F50();
        [PreserveSig]
        public static extern void CRIWAREDDF3418C(IntPtr acb_hn, CallbackFromNativeDelegate func, IntPtr obj);
        [PreserveSig]
        public static extern ushort CRIWARE5307F49A(int id);
        [PreserveSig]
        private static extern bool CRIWARE4C5BC175();
        [PreserveSig]
        private static extern int CRIWAREA3411983();
        [PreserveSig]
        private static extern int CRIWARE9C5D96DF();
    }
}
