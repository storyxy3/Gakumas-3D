namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomExPlayer : CriDisposable
    {
        public enum Status
        {
            Stop,
            Prep,
            Playing,
            PlayEnd,
            Error
        }

        internal struct Config
        {
            public CriAtomEx.VoiceAllocationMethod voiceAllocationMethod;
            public int maxPathStrings;
            public int maxPath;
            public int maxAisacs;
            public bool updatesTime;
            public bool enableAudioSyncedTimer;
            public static Config Default
            {
                get
                {
                    return default(Config);
                }
            }
        }

        public enum TimeStretchParameterId
        {
            Ratio,
            FrameTime,
            Quality
        }

        public enum PitchShifterParameterId
        {
            Pitch,
            Formant,
            Mode
        }

        [CompilerGenerated]
        private CriAtomExBeatSync.CbFunc m__onBeatSyncCallback;
        [CompilerGenerated]
        private CriAtomExSequencer.EventCallback m__onSequenceCallback;
        private bool hasExistingNativeHandle;
        private IntPtr entryPoolHandle;
        private int _entryPoolCapacity;
        private int max_path;
        public static readonly uint MaxOutputPorts;
        private IntPtr handle;
        public IntPtr nativeHandle
        {
            get
            {
                return default(IntPtr);
            }
        }

        public bool isAvailable
        {
            get
            {
                return default(bool);
            }
        }

        public int entryPoolCapacity
        {
            get
            {
                return default(int);
            }
        }

        private event CriAtomExBeatSync.CbFunc _onBeatSyncCallback
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

        public event CriAtomExBeatSync.CbFunc OnBeatSyncCallback
        {
            add
            {
            }

            remove
            {
            }
        }

        private event CriAtomExSequencer.EventCallback _onSequenceCallback
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

        public event CriAtomExSequencer.EventCallback OnSequenceCallback
        {
            add
            {
            }

            remove
            {
            }
        }

        public CriAtomExPlayer()
        {
        }

        public CriAtomExPlayer(int maxPath, int maxPathStrings)
        {
        }

        public CriAtomExPlayer(bool enableAudioSyncedTimer)
        {
        }

        public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer)
        {
        }

        public CriAtomExPlayer(IntPtr existingNativeHandle)
        {
        }

        public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer, IntPtr existingNativeHandle)
        {
        }

        public override void Dispose()
        {
        }

        public void SetCue(CriAtomExAcb acb, string name)
        {
        }

        public void SetCue(CriAtomExAcb acb, int id)
        {
        }

        public void SetCueIndex(CriAtomExAcb acb, int index)
        {
        }

        public void SetContentId(CriFsBinder binder, int contentId)
        {
        }

        public void SetFile(CriFsBinder binder, string path)
        {
        }

        public void SetData(byte[] buffer, int size)
        {
        }

        public void SetData(IntPtr buffer, int size)
        {
        }

        public void SetFormat(CriAtomEx.Format format)
        {
        }

        public void SetNumChannels(int numChannels)
        {
        }

        public void SetSamplingRate(int samplingRate)
        {
        }

        public void PrepareEntryPool(int capacity, bool stopOnEmpty)
        {
        }

        public int GetNumEntries()
        {
            return default(int);
        }

        public int GetNumConsumedEntries()
        {
            return default(int);
        }

        public bool EntryFile(CriFsBinder binder, string path, bool repeat)
        {
            return default(bool);
        }

        public bool EntryContentId(CriFsBinder binder, int contentId, bool repeat)
        {
            return default(bool);
        }

        public bool EntryData(byte[] buffer, int size, bool repeat)
        {
            return default(bool);
        }

        public bool EntryData(IntPtr buffer, int size, bool repeat)
        {
            return default(bool);
        }

        public bool EntryCue(CriAtomExAcb acb, string name, bool repeat)
        {
            return default(bool);
        }

        public CriAtomExPlayback Start()
        {
            return default(CriAtomExPlayback);
        }

        public CriAtomExPlayback Prepare()
        {
            return default(CriAtomExPlayback);
        }

        public bool StartAsync([Optional] IntPtr playbackId)
        {
            return default(bool);
        }

        public bool IsReadyToStartAsync()
        {
            return default(bool);
        }

        public void StopAsync()
        {
        }

        public CriAtomExPlayback GetLastPlaybackId()
        {
            return default(CriAtomExPlayback);
        }

        public void Stop(bool ignoresReleaseTime)
        {
        }

        public void Pause()
        {
        }

        public void Resume(CriAtomEx.ResumeMode mode)
        {
        }

        public bool IsPaused()
        {
            return default(bool);
        }

        public void SetVolume(float volume)
        {
        }

        public void SetPitch(float pitch)
        {
        }

        public void SetPlaybackRatio(float ratio)
        {
        }

        public void SetPan3dAngle(float angle)
        {
        }

        public void SetPan3dInteriorDistance(float distance)
        {
        }

        public void SetPan3dVolume(float volume)
        {
        }

        public void SetPanType(CriAtomEx.PanType panType)
        {
        }

        public void SetSendLevel(int channel, CriAtomEx.Speaker id, float level)
        {
        }

        public void SetBiquadFilterParameters(CriAtomEx.BiquadFilterType type, float frequency, float gain, float q)
        {
        }

        public void SetBandpassFilterParameters(float cofLow, float cofHigh)
        {
        }

        public void SetBusSendLevel(string busName, float level)
        {
        }

        public bool GetBusSendLevel(string busName, out float level)
        {
            throw null;
        }

        [Obsolete("Use CriAtomExPlayer.SetBusSendLevel(string busName, float level)")]
        public void SetBusSendLevel(int busId, float level)
        {
        }

        public void SetBusSendLevelOffset(string busName, float levelOffset)
        {
        }

        public bool GetBusSendLevelOffset(string busName, out float level)
        {
            throw null;
        }

        [Obsolete("Use CriAtomExPlayer.SetBusSendLevelOffset(int busId, float levelOffset)")]
        public void SetBusSendLevelOffset(int busId, float levelOffset)
        {
        }

        public void AttachAisac(string globalAisacName)
        {
        }

        public void DetachAisac(string globalAisacName)
        {
        }

        public void SetAisacControl(string controlName, float value)
        {
        }

        [Obsolete("Use CriAtomExPlayer.SetAisacControl")]
        public void SetAisac(string controlName, float value)
        {
        }

        public void SetAisacControl(uint controlId, float value)
        {
        }

        [Obsolete("Use SetAisacControl")]
        public void SetAisac(uint controlId, float value)
        {
        }

        public bool GetAttachedAisacInfo(int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo)
        {
            throw null;
        }

        public void Set3dSource(CriAtomEx3dSource source)
        {
        }

        public void Set3dListener(CriAtomEx3dListener listener)
        {
        }

        public void SetStartTime(long startTimeMs)
        {
        }

        public void SetStartTimeMicro(long startTimeUs)
        {
        }

        public void SetFirstBlockIndex(int index)
        {
        }

        public void SetSelectorLabel(string selector, string label)
        {
        }

        public void UnsetSelectorLabel(string selector)
        {
        }

        public void ClearSelectorLabels()
        {
        }

        public void SetCategory(int categoryId)
        {
        }

        public void SetCategory(string categoryName)
        {
        }

        public void UnsetCategory()
        {
        }

        public void SetCuePriority(int priority)
        {
        }

        public void SetVoicePriority(int priority)
        {
        }

        public void SetVoiceControlMethod(CriAtomEx.VoiceControlMethod method)
        {
        }

        public void SetPreDelayTime(float time)
        {
        }

        public void SetEnvelopeAttackTime(float time)
        {
        }

        public void SetEnvelopeHoldTime(float time)
        {
        }

        public void SetEnvelopeDecayTime(float time)
        {
        }

        public void SetEnvelopeReleaseTime(float time)
        {
        }

        public void SetEnvelopeSustainLevel(float level)
        {
        }

        public void AttachFader()
        {
        }

        public void DetachFader()
        {
        }

        public void SetFadeOutTime(int ms)
        {
        }

        public void SetFadeInTime(int ms)
        {
        }

        public void SetFadeInStartOffset(int ms)
        {
        }

        public void SetFadeOutEndDelay(int ms)
        {
        }

        public bool IsFading()
        {
            return default(bool);
        }

        public void ResetFaderParameters()
        {
        }

        public void SetGroupNumber(int group_no)
        {
        }

        public void Update(CriAtomExPlayback playback)
        {
        }

        public void UpdateAll()
        {
        }

        public void ResetParameters()
        {
        }

        public long GetTime()
        {
            return default(long);
        }

        public Status GetStatus()
        {
            return default(Status);
        }

        public float GetParameterFloat32(CriAtomEx.Parameter id)
        {
            return default(float);
        }

        public uint GetParameterUint32(CriAtomEx.Parameter id)
        {
            return default(uint);
        }

        public int GetParameterSint32(CriAtomEx.Parameter id)
        {
            return default(int);
        }

        public void SetSoundRendererType(CriAtomEx.SoundRendererType type)
        {
        }

        public void SetRandomSeed(uint seed)
        {
        }

        public void Loop(bool sw)
        {
        }

        public void SetAsrRackId(int asr_rack_id)
        {
        }

        public void SetVoicePoolIdentifier(uint identifier)
        {
        }

        public void SetDspTimeStretchRatio(float ratio)
        {
        }

        public void SetDspPitchShifterPitch(float pitch)
        {
        }

        public void SetDspParameter(int id, float value)
        {
        }

        public void SetSequencePrepareTime(uint ms)
        {
        }

        public void AttachTween(CriAtomExTween tween)
        {
        }

        public void DetachTween(CriAtomExTween tween)
        {
        }

        public void DetachTweenAll()
        {
        }

        public void SetEnvelopeAttackCurve(CriAtomEx.CurveType curveType, float strength)
        {
        }

        public void SetEnvelopeDecayCurve(CriAtomEx.CurveType curveType, float strength)
        {
        }

        public void SetEnvelopeReleaseCurve(CriAtomEx.CurveType curveType, float strength)
        {
        }

        public void AddOutputPort(CriAtomExOutputPort outputPort)
        {
        }

        public void RemoveOutputPort(CriAtomExOutputPort outputPort)
        {
        }

        public void ClearOutputPorts()
        {
        }

        public void AddPreferredOutputPort(CriAtomExOutputPort outputPort)
        {
        }

        public void RemovePreferredOutputPort(CriAtomExOutputPort outputPort)
        {
        }

        public void RemovePreferredOutputPort(string name)
        {
        }

        public void ClearPreferredOutputPorts()
        {
        }

        public void SetScheduleTime(long scheduleTime)
        {
        }

        public void Stop()
        {
        }

        public void StopWithoutReleaseTime()
        {
        }

        public void Pause(bool sw)
        {
        }

        ~CriAtomExPlayer()
        {
        }

        private void OnBeatSyncCallbackChainInternal(ref CriAtomExBeatSync.Info info)
        {
        }

        private void OnSequenceCallbackChainInternal(ref CriAtomExSequencer.CriAtomExSequenceEventInfo info)
        {
        }

        [PreserveSig]
        private static extern IntPtr criAtomExPlayer_Create(ref Config config, IntPtr work, int work_size);
        [PreserveSig]
        private static extern void criAtomExPlayer_Destroy(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetCueId(IntPtr player, IntPtr acb_hn, int id);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetCueIndex(IntPtr player, IntPtr acb_hn, int index);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetFile(IntPtr player, IntPtr binder, string path);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetData(IntPtr player, byte[] buffer, int size);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetData(IntPtr player, IntPtr buffer, int size);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetContentId(IntPtr player, IntPtr binder, int id);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetVoicePoolIdentifier(IntPtr player, uint identifier);
        [PreserveSig]
        private static extern uint criAtomExPlayer_Start(IntPtr player);
        [PreserveSig]
        private static extern uint criAtomExPlayer_Prepare(IntPtr player);
        [PreserveSig]
        private static extern int criAtomExPlayer_StartAsync(IntPtr player, IntPtr playback_id);
        [PreserveSig]
        private static extern void criAtomExPlayer_StopAsync(IntPtr player);
        [PreserveSig]
        private static extern int criAtomExPlayer_IsReadyToStartAsync(IntPtr player);
        [PreserveSig]
        private static extern uint criAtomExPlayer_GetLastPlaybackId(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_Stop(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_Pause(IntPtr player, bool sw);
        [PreserveSig]
        private static extern void criAtomExPlayer_Resume(IntPtr player, CriAtomEx.ResumeMode mode);
        [PreserveSig]
        private static extern bool criAtomExPlayer_IsPaused(IntPtr player);
        [PreserveSig]
        private static extern Status criAtomExPlayer_GetStatus(IntPtr player);
        [PreserveSig]
        private static extern long criAtomExPlayer_GetTime(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetFormat(IntPtr player, CriAtomEx.Format format);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetNumChannels(IntPtr player, int num_channels);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetSamplingRate(IntPtr player, int sampling_rate);
        [PreserveSig]
        private static extern IntPtr CRIWARE44450E1C(IntPtr player, int capacity, int max_path, bool stopOnEmpty);
        [PreserveSig]
        private static extern void CRIWARE61F5B53D(IntPtr pool);
        [PreserveSig]
        private static extern int CRIWAREDBD0B292(IntPtr pool);
        [PreserveSig]
        private static extern int CRIWARE1E5F497F(IntPtr pool);
        [PreserveSig]
        private static extern void CRIWARE971874F2(IntPtr pool);
        [PreserveSig]
        private static extern bool CRIWARE730297AF(IntPtr pool, IntPtr binder, string path, bool repeat, int max_path);
        [PreserveSig]
        private static extern bool CRIWARE1F5B423D(IntPtr pool, IntPtr binder, int id, bool repeat);
        [PreserveSig]
        private static extern bool CRIWARED3CB40B6(IntPtr pool, byte[] buffer, int size, bool repeat);
        [PreserveSig]
        private static extern bool CRIWARED3CB40B6(IntPtr pool, IntPtr buffer, int size, bool repeat);
        [PreserveSig]
        private static extern bool CRIWAREBC08F553(IntPtr pool, IntPtr acbhn, string name, bool repeat);
        [PreserveSig]
        private static extern void CRIWAREE870FB9F(IntPtr pool);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetStartTimeMicro(IntPtr player, long startTimeUs);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetSequencePrepareTime(IntPtr player, uint seq_prep_time_ms);
        [PreserveSig]
        private static extern void criAtomExPlayer_LimitLoopCount(IntPtr player, int count);
        [PreserveSig]
        private static extern void criAtomExPlayer_Update(IntPtr player, uint id);
        [PreserveSig]
        private static extern void criAtomExPlayer_UpdateAll(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_ResetParameters(IntPtr player);
        [PreserveSig]
        private static extern float criAtomExPlayer_GetParameterFloat32(IntPtr player, CriAtomEx.Parameter id);
        [PreserveSig]
        private static extern uint criAtomExPlayer_GetParameterUint32(IntPtr player, CriAtomEx.Parameter id);
        [PreserveSig]
        private static extern int criAtomExPlayer_GetParameterSint32(IntPtr player, CriAtomEx.Parameter id);
        [PreserveSig]
        private static extern IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, uint id);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetVolume(IntPtr player, float volume);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetPitch(IntPtr player, float pitch);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetPlaybackRatio(IntPtr player, float playback_ratio);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetPan3dAngle(IntPtr player, float pan3d_angle);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetPan3dInteriorDistance(IntPtr player, float pan3d_interior_distance);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetPan3dVolume(IntPtr player, float pan3d_volume);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetPanType(IntPtr player, CriAtomEx.PanType panType);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetSendLevel(IntPtr player, int channel, CriAtomEx.Speaker id, float level);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetBusSendLevel(IntPtr player, int bus_id, float level);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetBusSendLevelByName(IntPtr player, string bus_name, float level);
        [PreserveSig]
        private static extern bool criAtomExPlayer_GetBusSendLevelByName(IntPtr player, string bus_name, out float level);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetBusSendLevelOffset(IntPtr player, int bus_id, float level_offset);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetBusSendLevelOffsetByName(IntPtr player, string bus_name, float level_offset);
        [PreserveSig]
        private static extern bool criAtomExPlayer_GetBusSendLevelOffsetByName(IntPtr player, string bus_name, out float level_offset);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetBandpassFilterParameters(IntPtr player, float cof_low, float cof_high);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetBiquadFilterParameters(IntPtr player, CriAtomEx.BiquadFilterType type, float frequency, float gain, float q);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetVoicePriority(IntPtr player, int priority);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetVoiceControlMethod(IntPtr player, CriAtomEx.VoiceControlMethod method);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetAisacControlById(IntPtr player, ushort control_id, float control_value);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetAisacControlByName(IntPtr player, string control_name, float control_value);
        [PreserveSig]
        private static extern void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source);
        [PreserveSig]
        private static extern void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetCategoryById(IntPtr player, uint category_id);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetCategoryByName(IntPtr player, string category_name);
        [PreserveSig]
        private static extern void criAtomExPlayer_UnsetCategory(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetCuePriority(IntPtr player, int cue_priority);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetPreDelayTime(IntPtr player, float predelay_time_ms);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetEnvelopeAttackTime(IntPtr player, float attack_time_ms);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetEnvelopeHoldTime(IntPtr player, float hold_time_ms);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetEnvelopeDecayTime(IntPtr player, float decay_time_ms);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetEnvelopeReleaseTime(IntPtr player, float release_time_ms);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetEnvelopeSustainLevel(IntPtr player, float susutain_level);
        [PreserveSig]
        private static extern void criAtomExPlayer_AttachFader(IntPtr player, IntPtr config, IntPtr work, int work_size);
        [PreserveSig]
        private static extern void criAtomExPlayer_AttachAisac(IntPtr player, string globalAisacName);
        [PreserveSig]
        private static extern void criAtomExPlayer_DetachAisac(IntPtr player, string globalAisacName);
        [PreserveSig]
        private static extern void criAtomExPlayer_DetachFader(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetFadeOutTime(IntPtr player, int ms);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetFadeInTime(IntPtr player, int ms);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetFadeInStartOffset(IntPtr player, int ms);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetFadeOutEndDelay(IntPtr player, int ms);
        [PreserveSig]
        private static extern bool criAtomExPlayer_IsFading(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_ResetFaderParameters(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetGroupNumber(IntPtr player, int group_no);
        [PreserveSig]
        private static extern bool criAtomExPlayer_GetAttachedAisacInfo(IntPtr player, int aisac_attached_index, IntPtr aisac_info);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetFirstBlockIndex(IntPtr player, int index);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetSelectorLabel(IntPtr player, string selector, string label);
        [PreserveSig]
        private static extern void criAtomExPlayer_UnsetSelectorLabel(IntPtr player, string selector);
        [PreserveSig]
        private static extern void criAtomExPlayer_ClearSelectorLabels(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetSoundRendererType(IntPtr player, CriAtomEx.SoundRendererType type);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetRandomSeed(IntPtr player, uint seed);
        [PreserveSig]
        private static extern void CRIWAREFEACA8A6(IntPtr player, bool sw);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetAsrRackId(IntPtr player, int asr_rack_id);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetDspParameter(IntPtr player, int id, float value);
        [PreserveSig]
        private static extern void criAtomExPlayer_AttachTween(IntPtr player, IntPtr tween);
        [PreserveSig]
        private static extern void criAtomExPlayer_DetachTween(IntPtr player, IntPtr tween);
        [PreserveSig]
        private static extern void criAtomExPlayer_DetachTweenAll(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetEnvelopeAttackCurve(IntPtr player, CriAtomEx.CurveType curve_type, float strength);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetEnvelopeDecayCurve(IntPtr player, CriAtomEx.CurveType curve_type, float strength);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetEnvelopeReleaseCurve(IntPtr player, CriAtomEx.CurveType curve_type, float strength);
        [PreserveSig]
        private static extern void criAtomExPlayer_AddOutputPort(IntPtr player, IntPtr outputPort);
        [PreserveSig]
        private static extern void criAtomExPlayer_RemoveOutputPort(IntPtr player, IntPtr outputPort);
        [PreserveSig]
        private static extern void criAtomExPlayer_ClearOutputPorts(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_AddPreferredOutputPort(IntPtr player, IntPtr outputPort);
        [PreserveSig]
        private static extern void criAtomExPlayer_RemovePreferredOutputPort(IntPtr player, IntPtr outputPort);
        [PreserveSig]
        private static extern void criAtomExPlayer_RemovePreferredOutputPortByName(IntPtr player, string name);
        [PreserveSig]
        private static extern void criAtomExPlayer_ClearPreferredOutputPorts(IntPtr player);
        [PreserveSig]
        private static extern void criAtomExPlayer_SetScheduleTime(IntPtr player, long schedule_time);
    }
}
