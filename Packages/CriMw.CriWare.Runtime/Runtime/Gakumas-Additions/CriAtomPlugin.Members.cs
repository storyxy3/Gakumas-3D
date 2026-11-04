// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::AOT;
using global::CriWare;
using global::System.Collections.Generic;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::System;

namespace CriWare
{
    public static partial class CriAtomPlugin
    {

        private static Common.CpuUsage cpuUsage;


        private static ulong temporalStorage;

        public static event Action OnBeforeInitialize;

        public static event Action OnInitialized;

        public static event Action OnBeforeFinalize;



        public static void Log(string log)
        {
        }



        public static bool GetAudioEffectInterfaceList(out List<IntPtr> effect_interface_list)
        {
            throw null;
        }



        public static void SetConfigParameters(int max_virtual_voices, int max_voice_limit_groups, int max_categories, byte max_aisacs, byte max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, CriAtom.SpeakerMapping speakerMapping, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, float max_pitch, CriAtomEx.SoundRendererType sound_renderer_type, bool enable_sonicsync_for_common, bool enable_atom_sound_disabled_mode)
        {
        }



        public static void SetConfigAdditionalParameters_IOS(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios, bool enable_os_notification_handling)
        {
        }



        public static void SetConfigAdditionalParameters_PS4(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, bool use_audio3d, int num_audio3d_memory_voices, int num_audio3d_streaming_voices, int num_mp4_streaming_voices)
        {
        }



        public static void SetConfigAdditionalParameters_PS5(int max_channel_ports, int max_object_ports, int num_mp4_streaming_voices)
        {
        }



        public static void SetConfigAdditionalParameters_SWITCH2(int num_opus_memory_voices, int num_opus_streaming_voices, bool init_socket)
        {
        }



        public static void SetMaxSamplingRateForStandardVoicePool(int sampling_rate_for_memory, int sampling_rate_for_streaming)
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
    }
}
