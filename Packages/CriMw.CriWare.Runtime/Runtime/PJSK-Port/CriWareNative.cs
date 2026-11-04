using System;

namespace CriWare
{
    // The native entry points of libcri_ware_unity.so (P/Invoke "cri_ware_unity" in the game) that the ported managed
    // CRIWARE layer calls, with the game's export names (some are obfuscated, e.g. CRIWARE893F494B =
    // criAtomUnity_SetConfigParameters) and parameter names. A backend that reproduces the native library is
    // installed by the host (SL-CRI-Atom / SL-CRI-Mana); without one, calls throw NotSupportedException.
    public partial interface ICriWareNativeBackend
    {
        // Common
        int CRIWARECE8DBD94();
        void criWareUnity_SetRenderingEventOffsetForMana(int offset);

        // CriFsPlugin / CriFsUtility
        void CRIWARED671D92C(int num_loaders, int num_binders, int num_installers, int max_path,
            bool minimize_file_descriptor_usage, bool enable_crc_check);
        void criFsUnity_SetConfigAdditionalParameters_ANDROID(int device_read_bps);
        void CRIWARE8B8CF7AE();
        void CRIWARE60FEBD39();
        bool CRIWARE7DA1D7FD();
        bool CRIWARED4C30199(string userAgentString);
        uint criFsBinder_Create(out IntPtr binder);
        uint criFsBinder_Destroy(IntPtr binder);

        // CriAtomPlugin
        void CRIWARE893F494B(int max_virtual_voices, int max_voice_limit_groups, int max_categories, byte max_aisacs,
            byte max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame,
            int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices,
            int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate,
            int num_asr_output_channels, CriAtom.SpeakerMapping speakerMapping, bool uses_in_game_preview, float server_frequency,
            int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, float max_pitch,
            CriAtomEx.SoundRendererType sound_renderer_type, bool enable_sonicsync_for_common);
        void CRIWAREA1992BC3(uint max_preivew_objects, uint communication_buffer_size,
            int playback_position_update_interval);
        void CRIWARE7402012B(bool enable_user_pcm_out_mode);
        void CRIWARE88F0008E(long buffering_time_pc, bool use_microsoft_spatial_sound);
        void CRIWAREC2F00A9B(int output, int pulse_latency_usec);
        void CRIWAREA69F40B7(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios);
        void CRIWAREB8664B63(bool enable_sonicsync, int num_low_delay_memory_voices,
            int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time,
            bool apply_hw_property, int stream_type);
        void CRIWAREB09AD891(IntPtr android_context);
        void CRIWAREF27CB8CB(bool flag);
        void CRIWARE2EA3E3EA();
        void CRIWARE350A7D20();
        bool CRIWARE5DA58264();
        void CRIWARE8BB08498(IntPtr cbfunc);
        ushort CRIWARECC7FD29F(int id);
        void CRIWAREF96375A3(bool pause);
        void CRIWAREB9EDC2C9();
        void CRIWARE6376514D();
        void CRIWARE1982DA00();

        // CriAtomExAsr / CriAtomExLatencyEstimator
        bool criAtomExAsr_RegisterEffectInterface(IntPtr afx_interface);
        void criAtomLatencyEstimator_Finalize_ANDROID();
        CriAtomExLatencyEstimator.EstimatorInfo criAtomLatencyEstimator_GetCurrentInfo_ANDROID();

        // CriAtomEx
        bool criAtomEx_RegisterAcfFile(IntPtr binder, string path, IntPtr work, int workSize);
        bool criAtomEx_RegisterAcfData(byte[] acfData, int acfDataSize, IntPtr work, int workSize);
        void criAtomEx_UnregisterAcf();
        void criAtomEx_AttachDspBusSetting(string settingName, IntPtr work, int workSize);
        void criAtomEx_DetachDspBusSetting();
        void criAtomEx_SetRandomSeed(uint seed);

        // CriAtomExCategory
        void criAtomExCategory_SetVolumeByName(string name, float volume);

        // CriAtomExAcb
        IntPtr criAtomExAcb_LoadAcbFile(IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path,
            IntPtr work, int work_size);
        IntPtr criAtomExAcb_LoadAcbData(IntPtr acb_data, int acb_data_size, IntPtr awb_binder, string awb_path,
            IntPtr work, int work_size);
        void criAtomExAcb_Release(IntPtr acb_hn);
        int criAtomExAcb_GetNumCues(IntPtr acb_hn);
        bool criAtomExAcb_GetCueInfoByIndex(IntPtr acb_hn, int index, IntPtr info);
        bool criAtomExAcb_GetWaveformInfoByName(IntPtr acb_hn, string name, IntPtr waveform_info);

        // CriAtomExPlayer
        IntPtr criAtomExPlayer_Create(ref CriAtomExPlayer.Config config, IntPtr work, int work_size);
        void criAtomExPlayer_Destroy(IntPtr player);
        void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name);
        uint criAtomExPlayer_Start(IntPtr player);
        void criAtomExPlayer_Stop(IntPtr player);
        void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player);
        void criAtomExPlayer_Pause(IntPtr player, bool sw);
        void criAtomExPlayer_Resume(IntPtr player, CriAtomEx.ResumeMode mode);
        bool criAtomExPlayer_IsPaused(IntPtr player);
        CriAtomExPlayer.Status criAtomExPlayer_GetStatus(IntPtr player);
        void criAtomExPlayer_SetVolume(IntPtr player, float volume);
        void criAtomExPlayer_SetPitch(IntPtr player, float pitch);
        void criAtomExPlayer_SetAisacControlByName(IntPtr player, string control_name, float control_value);
        void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source);
        void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener);
        void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms);
        void criAtomExPlayer_SetVoicePriority(IntPtr player, int priority);
        void criAtomExPlayer_AttachFader(IntPtr player, IntPtr config, IntPtr work, int work_size);
        void criAtomExPlayer_SetFadeOutTime(IntPtr player, int ms);
        void criAtomExPlayer_SetFadeInTime(IntPtr player, int ms);
        bool criAtomExPlayer_IsFading(IntPtr player);
        void criAtomExPlayer_Update(IntPtr player, uint id);
        void criAtomExPlayer_UpdateAll(IntPtr player);
        void criAtomExPlayer_SetSoundRendererType(IntPtr player, CriAtomEx.SoundRendererType type);
        void criAtomExPlayer_LimitLoopCount(IntPtr player, int count);
        IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player);
        void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, uint id);
        void CRIWARE6BA643AC(IntPtr pool);
        void CRIWARED9B89F57(IntPtr pool);
        void CRIWAREE3EC6941(IntPtr pool);

        // CriAtomExPlayback
        int criAtomExPlayback_GetStatus(uint id);
        void criAtomExPlayback_Stop(uint id);
        void criAtomExPlayback_StopWithoutReleaseTime(uint id);
        void criAtomExPlayback_GetTimeAndScaleSyncedWithAudio(uint id, ref long playbackTime, ref float timeScale);
        void criAtomExPlayback_Pause(uint id, bool sw);
        void criAtomExPlayback_Resume(uint id, CriAtomEx.ResumeMode mode);
        bool criAtomExPlayback_IsPaused(uint id);
        long criAtomExPlayback_GetTime(uint id);
        long criAtomExPlayback_GetTimeSyncedWithAudio(uint id);

        // CriAtomEx3dSource / CriAtomEx3dListener
        IntPtr criAtomEx3dSource_Create(ref CriAtomEx3dSource.Config config, IntPtr work, int work_size);
        void criAtomEx3dSource_Destroy(IntPtr ex_3d_source);
        void criAtomEx3dSource_Set3dRegionHn(IntPtr ex_3d_source, IntPtr ex_3d_region);
        void criAtomEx3dSource_Update(IntPtr ex_3d_source);
        void criAtomEx3dSource_SetPosition(IntPtr ex_3d_source, ref CriAtomEx.NativeVector position);
        void criAtomEx3dSource_SetVelocity(IntPtr ex_3d_source, ref CriAtomEx.NativeVector velocity);
        void criAtomEx3dSource_SetOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector front,
            ref CriAtomEx.NativeVector top);
        void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, ref CriAtomEx.Randomize3dConfig config);
        void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, IntPtr config);
        IntPtr criAtomEx3dListener_Create(ref CriAtomEx3dListener.Config config, IntPtr work, int work_size);
        void criAtomEx3dListener_Destroy(IntPtr ex_3d_listener);
        void criAtomEx3dListener_Update(IntPtr ex_3d_listener);
        void criAtomEx3dListener_SetPosition(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector position);
        void criAtomEx3dListener_SetVelocity(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector velocity);
        void criAtomEx3dListener_SetOrientation(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top);
        void criAtomEx3dListener_Set3dRegionHn(IntPtr ex_3d_listener, IntPtr ex_3d_region);

        // CriAtomExOutputAnalyzer
        IntPtr criAtomExOutputAnalyzer_Create(ref CriAtomExOutputAnalyzer.Config config);
        void criAtomExOutputAnalyzer_Destroy(IntPtr analyzer);
        void criAtomExOutputAnalyzer_AttachExPlayer(IntPtr analyzer, IntPtr player);
        void criAtomExOutputAnalyzer_DetachExPlayer(IntPtr analyzer, IntPtr player);
        void criAtomExOutputAnalyzer_DetachDspBusByName(IntPtr analyzer, string busName);
        float criAtomExOutputAnalyzer_GetRms(IntPtr analyzer, int channel);

        // CriErrorNotifier / CriWareErrorHandler
        void criErr_SetCallback(IntPtr callback);
        void criErr_SetCallback(CriErrorNotifier.ErrorCallbackFunc callback);
        IntPtr criErr_ConvertIdToMessage(IntPtr errmsgPtr, uint p1, uint p2);
        IntPtr CRIWAREC0ED7C62();

        // CriWareDecrypter
        int CRIWARE6B3B300F(bool enable_atom_decryption, bool enable_mana_decryption,
            CriWareDecrypter.CallbackFromNativeDelegate func, IntPtr obj);

        // CriManaPlugin (library initialization)
        void CRIWARE61D25984(int graphics_api, bool graphics_multi_threaded, int num_decoders, int num_of_max_entries);
        void criManaUnity_SetConfigAdditionalParameters_ANDROID(bool buffer_h264, bool buffer_vp9);
        void CRIWARECF1918FA();
        void CRIWAREEA336D77();
        bool CRIWARE39B9723F();
        void criMana_UseStreamerManager(bool flag);
    }

    public static class CriWareNative
    {
        public static ICriWareNativeBackend Backend { get; set; }

        internal static ICriWareNativeBackend Native =>
            Backend ?? throw new NotSupportedException("No CRIWARE native backend is installed (cri_ware_unity).");
    }
}
