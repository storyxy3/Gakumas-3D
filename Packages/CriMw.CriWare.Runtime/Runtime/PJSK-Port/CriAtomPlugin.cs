using System;
using System.Collections.Generic;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriAtomPlugin (TypeDefIndex 31665), the members on the game's paths. The SetConfigAdditionalParameters_*
    // methods are the Android build's (other platforms' variants are empty there).
    public static partial class CriAtomPlugin
    {
        private static int initializationCount = 0;
        private static Action OnFinalized = null;
        private static List<IntPtr> effectInterfaceList = null;
        private static bool isConfigured = false;
        private static float timeSinceStartup = Time.realtimeSinceStartup;
        private static int CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT = 0;
        private static ushort CRIATOMPARAMETER2_ID_INVALID = ushort.MaxValue;

        public static bool isInitialized => initializationCount > 0;

        public static void SetConfigParameters(int max_virtual_voices, int max_voice_limit_groups, int max_categories,
            byte max_aisacs, byte max_bus_sends, int max_sequence_events_per_frame,
            int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices,
            int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices,
            int output_sampling_rate, int num_asr_output_channels, CriAtom.SpeakerMapping speakerMapping, bool uses_in_game_preview,
            float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders,
            int num_buses, float max_pitch, CriAtomEx.SoundRendererType sound_renderer_type, bool enable_sonicsync_for_common)
        {
            CRIWARE893F494B(max_virtual_voices, max_voice_limit_groups, max_categories, max_aisacs, max_bus_sends,
                max_sequence_events_per_frame, max_beatsync_callbacks_per_frame, max_cuelink_callbacks_per_frame,
                num_standard_memory_voices, num_standard_streaming_voices, num_hca_mx_memory_voices,
                num_hca_mx_streaming_voices, output_sampling_rate, num_asr_output_channels, speakerMapping,
                uses_in_game_preview, server_frequency, max_parameter_blocks, categories_per_playback, max_faders,
                num_buses, max_pitch, sound_renderer_type, enable_sonicsync_for_common);
            isConfigured = true;
        }

        public static void SetConfigMonitorParametes(int max_preview_objects, int communication_buffer_size,
            int playback_position_update_interval)
        {
            CRIWAREA1992BC3((uint)max_preview_objects, (uint)(communication_buffer_size << 10),
                playback_position_update_interval);
        }

        public static void SetConfigAdditionalParameters_EDITOR(bool enable_user_pcm_output, int user_pcm_buffer_length)
        {
            CRIWARE7402012B(enable_user_pcm_output);
        }

        public static void SetConfigAdditionalParameters_PC(long buffering_time_pc, bool use_microsoft_spatial_sound)
        {
            CRIWARE88F0008E(buffering_time_pc, use_microsoft_spatial_sound);
        }

        public static void SetConfigAdditionalParameters_LINUX(CriAtomConfig.LinuxOutput output, int pulse_latency_usec)
        {
            CRIWAREC2F00A9B((int)output, pulse_latency_usec);
        }

        public static void SetConfigAdditionalParameters_IOS(bool enable_sonicsync, uint buffering_time_ios,
            bool override_ipod_music_ios)
        {
            CRIWAREA69F40B7(enable_sonicsync, buffering_time_ios, override_ipod_music_ios);
        }

        public static void SetConfigAdditionalParameters_ANDROID(bool enable_sonicsync,
            int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time,
            int sound_start_buffering_time, bool use_fast_mixer, bool use_aaudio, int stream_type)
        {
            CRIWAREB8664B63(enable_sonicsync, num_low_delay_memory_voices, num_low_delay_streaming_voices,
                sound_buffering_time, sound_start_buffering_time, use_fast_mixer, enable_sonicsync ? stream_type : 0);
            if (use_fast_mixer)
            {
#if UNITY_ANDROID
                using (var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
                using (var activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
                {
                    CRIWAREB09AD891(activity.GetRawObject());
                }
#else
                // Host boundary: no Android activity off-device; the backend gets the same call with a null context.
                CRIWAREB09AD891(IntPtr.Zero);
#endif
            }
            CRIWAREF27CB8CB(use_aaudio);
        }

        public static void SetConfigAdditionalParameters_VITA(int num_atrac9_memory_voices,
            int num_atrac9_streaming_voices, int num_mana_decoders)
        {
        }

        public static void SetConfigAdditionalParameters_PS4(int num_atrac9_memory_voices,
            int num_atrac9_streaming_voices, bool use_audio3d, int num_audio3d_memory_voices,
            int num_audio3d_streaming_voices)
        {
        }

        public static void SetConfigAdditionalParameters_PS5(int max_channel_ports, int max_object_ports)
        {
        }

        public static void SetConfigAdditionalParameters_SWITCH(bool enable_sonicsync, int num_opus_memory_voices,
            int num_opus_streaming_voices, bool init_socket)
        {
        }

        public static void SetConfigAdditionalParameters_WEBGL(int num_webaudio_voices)
        {
        }

        // 官方 7.0.0 iOS CriAtomPlugin$$GetRequiredMaxVirtualVoices 0x44A7670：只把 standard 与 hcaMx 两个声部池的
        // memory/streaming 四项相加（vaddvq_s32）。Android 版额外计入的 androidLowLatencyStandardVoicePoolConfig 在 iOS 版没有。
        public static int GetRequiredMaxVirtualVoices(CriAtomConfig atomConfig)
        {
            var required = atomConfig.standardVoicePoolConfig.streamingVoices +
                   atomConfig.standardVoicePoolConfig.memoryVoices +
                   atomConfig.hcaMxVoicePoolConfig.streamingVoices +
                   atomConfig.hcaMxVoicePoolConfig.memoryVoices;
#if !UNITY_IOS
            // JP 7.0.0 Android 0x66A6538 also sums the low-latency pool at config +0xC0.
            required += atomConfig.androidLowLatencyStandardVoicePoolConfig.memoryVoices +
                        atomConfig.androidLowLatencyStandardVoicePoolConfig.streamingVoices;
#endif
            return required;
        }

        public static void InitializeLibrary()
        {
            initializationCount++;
            if (initializationCount != 1)
                return;
            if (IsLibraryInitialized())
            {
                FinalizeLibrary();
                initializationCount = 1;
            }
            if (!isConfigured)
                Debug.Log("[CRIWARE] Atom initialization parameters are not configured. Initializes Atom by default parameters.");
            CriFsPlugin.InitializeLibrary();
            CRIWARE2EA3E3EA();
            if (effectInterfaceList != null)
            {
                for (var i = 0; i < effectInterfaceList.Count; i++)
                    CriAtomExAsr.criAtomExAsr_RegisterEffectInterface(effectInterfaceList[i]);
            }
            CriAtomServer.CreateInstance();
            CriAtomListener.CreateDummyNativeListener();
        }

        public static bool IsLibraryInitialized()
        {
            return CRIWARE5DA58264();
        }

        public static void FinalizeLibrary()
        {
            initializationCount--;
            if (initializationCount < 0)
            {
                initializationCount = 0;
                if (!IsLibraryInitialized())
                    return;
            }
            if (initializationCount != 0)
                return;
            CriAtomListener.DestroyDummyNativeListener();
            CriAtomServer.DestroyInstance();
            CriDisposableObjectManager.CallOnModuleFinalization(CriDisposableObjectManager.ModuleType.Atom);
            if (effectInterfaceList != null)
            {
                effectInterfaceList.Clear();
                effectInterfaceList = null;
            }
            CRIWARE350A7D20();
            if (OnFinalized != null)
                OnFinalized();
            OnFinalized = null;
            CriFsPlugin.FinalizeLibrary();
        }

        public static void Pause(bool pause)
        {
            if (isInitialized)
                CRIWAREF96375A3(pause);
        }

        public static ushort GetLoopCountParameterId()
        {
            var result = CRIWARECC7FD29F(CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT);
            if (CRIATOMPARAMETER2_ID_INVALID == result)
                throw new Exception("GetNativeParameterId failed.");
            return result;
        }

        internal static void ExecuteQueuedCueLinkCallbacks()
        {
            if (CriAtom.cueLinkUserCbFunc != null)
                CRIWAREB9EDC2C9();
        }

        internal static void ExecuteQueuedEventCallbacks()
        {
            if (CriAtom.eventUserCallback != null)
                CRIWARE6376514D();
        }

        internal static void ExecuteQueuedBeatSyncCallbacks()
        {
            if (CriAtom.beatsyncUserCbFunc != null)
                CRIWARE1982DA00();
        }

        private static void CRIWARE893F494B(int max_virtual_voices, int max_voice_limit_groups, int max_categories,
            byte max_aisacs, byte max_bus_sends, int max_sequence_events_per_frame,
            int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices,
            int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices,
            int output_sampling_rate, int num_asr_output_channels, CriAtom.SpeakerMapping speakerMapping, bool uses_in_game_preview,
            float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders,
            int num_buses, float max_pitch, CriAtomEx.SoundRendererType sound_renderer_type, bool enable_sonicsync_for_common) =>
            CriWareNative.Native.CRIWARE893F494B(max_virtual_voices, max_voice_limit_groups, max_categories,
                max_aisacs, max_bus_sends, max_sequence_events_per_frame, max_beatsync_callbacks_per_frame,
                max_cuelink_callbacks_per_frame, num_standard_memory_voices, num_standard_streaming_voices,
                num_hca_mx_memory_voices, num_hca_mx_streaming_voices, output_sampling_rate, num_asr_output_channels,
                speakerMapping, uses_in_game_preview, server_frequency, max_parameter_blocks, categories_per_playback,
                max_faders, num_buses, max_pitch, sound_renderer_type, enable_sonicsync_for_common);
        private static void CRIWAREA1992BC3(uint max_preivew_objects, uint communication_buffer_size,
            int playback_position_update_interval) =>
            CriWareNative.Native.CRIWAREA1992BC3(max_preivew_objects, communication_buffer_size,
                playback_position_update_interval);
        private static void CRIWAREB8664B63(bool enable_sonicsync, int num_low_delay_memory_voices,
            int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time,
            bool apply_hw_property, int stream_type) =>
            CriWareNative.Native.CRIWAREB8664B63(enable_sonicsync, num_low_delay_memory_voices,
                num_low_delay_streaming_voices, sound_buffering_time, sound_start_buffering_time, apply_hw_property,
                stream_type);
        private static void CRIWARE7402012B(bool enable_user_pcm_out_mode) =>
            CriWareNative.Native.CRIWARE7402012B(enable_user_pcm_out_mode);
        private static void CRIWARE88F0008E(long buffering_time_pc, bool use_microsoft_spatial_sound) =>
            CriWareNative.Native.CRIWARE88F0008E(buffering_time_pc, use_microsoft_spatial_sound);
        private static void CRIWAREC2F00A9B(int output, int pulse_latency_usec) =>
            CriWareNative.Native.CRIWAREC2F00A9B(output, pulse_latency_usec);
        private static void CRIWAREA69F40B7(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios) =>
            CriWareNative.Native.CRIWAREA69F40B7(enable_sonicsync, buffering_time_ios, override_ipod_music_ios);
        private static void CRIWAREB09AD891(IntPtr android_context) => CriWareNative.Native.CRIWAREB09AD891(android_context);
        private static void CRIWAREF27CB8CB(bool flag) => CriWareNative.Native.CRIWAREF27CB8CB(flag);
        private static void CRIWARE2EA3E3EA() => CriWareNative.Native.CRIWARE2EA3E3EA();
        private static void CRIWARE350A7D20() => CriWareNative.Native.CRIWARE350A7D20();
        private static bool CRIWARE5DA58264() => CriWareNative.Native.CRIWARE5DA58264();
        internal static void CRIWARE8BB08498(IntPtr cbfunc) => CriWareNative.Native.CRIWARE8BB08498(cbfunc);
        private static ushort CRIWARECC7FD29F(int id) => CriWareNative.Native.CRIWARECC7FD29F(id);
        private static void CRIWAREF96375A3(bool pause) => CriWareNative.Native.CRIWAREF96375A3(pause);
        private static void CRIWAREB9EDC2C9() => CriWareNative.Native.CRIWAREB9EDC2C9();
        private static void CRIWARE6376514D() => CriWareNative.Native.CRIWARE6376514D();
        private static void CRIWARE1982DA00() => CriWareNative.Native.CRIWARE1982DA00();
    }
}
