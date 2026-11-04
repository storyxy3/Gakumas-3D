// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::CriWare;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::System;

namespace CriWare
{
    public partial class CriAtomExPlayer
    {


        public event CriAtomExBeatSync.CbFunc OnBeatSyncCallback
        {
            add
            {
            }

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



        public void DetachFader()
        {
        }



        public void SetFadeInStartOffset(int ms)
        {
        }



        public void SetFadeOutEndDelay(int ms)
        {
        }



        public void ResetFaderParameters()
        {
        }



        public void SetGroupNumber(int group_no)
        {
        }



        public void ResetParameters()
        {
        }



        public long GetTime()
        {
            return default(long);
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



        public void SetRandomSeed(uint seed)
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



        private void OnBeatSyncCallbackChainInternal(ref CriAtomExBeatSync.Info info)
        {
        }



        private void OnSequenceCallbackChainInternal(ref CriAtomExSequencer.CriAtomExSequenceEventInfo info)
        {
        }


        [PreserveSig]
        private static void criAtomExPlayer_SetCueId(IntPtr player, IntPtr acb_hn, int id) { throw new NotSupportedException("native criAtomExPlayer_SetCueId (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetCueIndex(IntPtr player, IntPtr acb_hn, int index) { throw new NotSupportedException("native criAtomExPlayer_SetCueIndex (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetFile(IntPtr player, IntPtr binder, string path) { throw new NotSupportedException("native criAtomExPlayer_SetFile (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetData(IntPtr player, byte[] buffer, int size) { throw new NotSupportedException("native criAtomExPlayer_SetData (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetData(IntPtr player, IntPtr buffer, int size) { throw new NotSupportedException("native criAtomExPlayer_SetData (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetContentId(IntPtr player, IntPtr binder, int id) { throw new NotSupportedException("native criAtomExPlayer_SetContentId (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetVoicePoolIdentifier(IntPtr player, uint identifier) { throw new NotSupportedException("native criAtomExPlayer_SetVoicePoolIdentifier (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static uint criAtomExPlayer_Prepare(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_Prepare (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExPlayer_StartAsync(IntPtr player, IntPtr playback_id) { throw new NotSupportedException("native criAtomExPlayer_StartAsync (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_StopAsync(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_StopAsync (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExPlayer_IsReadyToStartAsync(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_IsReadyToStartAsync (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static uint criAtomExPlayer_GetLastPlaybackId(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_GetLastPlaybackId (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static long criAtomExPlayer_GetTime(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_GetTime (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetFormat(IntPtr player, CriAtomEx.Format format) { throw new NotSupportedException("native criAtomExPlayer_SetFormat (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetNumChannels(IntPtr player, int num_channels) { throw new NotSupportedException("native criAtomExPlayer_SetNumChannels (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetSamplingRate(IntPtr player, int sampling_rate) { throw new NotSupportedException("native criAtomExPlayer_SetSamplingRate (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetStartTimeMicro(IntPtr player, long startTimeUs) { throw new NotSupportedException("native criAtomExPlayer_SetStartTimeMicro (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetSequencePrepareTime(IntPtr player, uint seq_prep_time_ms) { throw new NotSupportedException("native criAtomExPlayer_SetSequencePrepareTime (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_ResetParameters(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_ResetParameters (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static float criAtomExPlayer_GetParameterFloat32(IntPtr player, CriAtomEx.Parameter id) { throw new NotSupportedException("native criAtomExPlayer_GetParameterFloat32 (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static uint criAtomExPlayer_GetParameterUint32(IntPtr player, CriAtomEx.Parameter id) { throw new NotSupportedException("native criAtomExPlayer_GetParameterUint32 (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExPlayer_GetParameterSint32(IntPtr player, CriAtomEx.Parameter id) { throw new NotSupportedException("native criAtomExPlayer_GetParameterSint32 (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetPlaybackRatio(IntPtr player, float playback_ratio) { throw new NotSupportedException("native criAtomExPlayer_SetPlaybackRatio (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetPan3dAngle(IntPtr player, float pan3d_angle) { throw new NotSupportedException("native criAtomExPlayer_SetPan3dAngle (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetPan3dInteriorDistance(IntPtr player, float pan3d_interior_distance) { throw new NotSupportedException("native criAtomExPlayer_SetPan3dInteriorDistance (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetPan3dVolume(IntPtr player, float pan3d_volume) { throw new NotSupportedException("native criAtomExPlayer_SetPan3dVolume (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetSendLevel(IntPtr player, int channel, CriAtomEx.Speaker id, float level) { throw new NotSupportedException("native criAtomExPlayer_SetSendLevel (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetBusSendLevel(IntPtr player, int bus_id, float level) { throw new NotSupportedException("native criAtomExPlayer_SetBusSendLevel (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetBusSendLevelByName(IntPtr player, string bus_name, float level) { throw new NotSupportedException("native criAtomExPlayer_SetBusSendLevelByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExPlayer_GetBusSendLevelByName(IntPtr player, string bus_name, out float level) { throw new NotSupportedException("native criAtomExPlayer_GetBusSendLevelByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetBusSendLevelOffset(IntPtr player, int bus_id, float level_offset) { throw new NotSupportedException("native criAtomExPlayer_SetBusSendLevelOffset (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetBusSendLevelOffsetByName(IntPtr player, string bus_name, float level_offset) { throw new NotSupportedException("native criAtomExPlayer_SetBusSendLevelOffsetByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExPlayer_GetBusSendLevelOffsetByName(IntPtr player, string bus_name, out float level_offset) { throw new NotSupportedException("native criAtomExPlayer_GetBusSendLevelOffsetByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetBandpassFilterParameters(IntPtr player, float cof_low, float cof_high) { throw new NotSupportedException("native criAtomExPlayer_SetBandpassFilterParameters (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetBiquadFilterParameters(IntPtr player, CriAtomEx.BiquadFilterType type, float frequency, float gain, float q) { throw new NotSupportedException("native criAtomExPlayer_SetBiquadFilterParameters (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetVoiceControlMethod(IntPtr player, CriAtomEx.VoiceControlMethod method) { throw new NotSupportedException("native criAtomExPlayer_SetVoiceControlMethod (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetAisacControlById(IntPtr player, ushort control_id, float control_value) { throw new NotSupportedException("native criAtomExPlayer_SetAisacControlById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetCategoryById(IntPtr player, uint category_id) { throw new NotSupportedException("native criAtomExPlayer_SetCategoryById (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetCategoryByName(IntPtr player, string category_name) { throw new NotSupportedException("native criAtomExPlayer_SetCategoryByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_UnsetCategory(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_UnsetCategory (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetCuePriority(IntPtr player, int cue_priority) { throw new NotSupportedException("native criAtomExPlayer_SetCuePriority (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetPreDelayTime(IntPtr player, float predelay_time_ms) { throw new NotSupportedException("native criAtomExPlayer_SetPreDelayTime (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetEnvelopeAttackTime(IntPtr player, float attack_time_ms) { throw new NotSupportedException("native criAtomExPlayer_SetEnvelopeAttackTime (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetEnvelopeHoldTime(IntPtr player, float hold_time_ms) { throw new NotSupportedException("native criAtomExPlayer_SetEnvelopeHoldTime (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetEnvelopeDecayTime(IntPtr player, float decay_time_ms) { throw new NotSupportedException("native criAtomExPlayer_SetEnvelopeDecayTime (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetEnvelopeReleaseTime(IntPtr player, float release_time_ms) { throw new NotSupportedException("native criAtomExPlayer_SetEnvelopeReleaseTime (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetEnvelopeSustainLevel(IntPtr player, float susutain_level) { throw new NotSupportedException("native criAtomExPlayer_SetEnvelopeSustainLevel (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_AttachAisac(IntPtr player, string globalAisacName) { throw new NotSupportedException("native criAtomExPlayer_AttachAisac (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_DetachAisac(IntPtr player, string globalAisacName) { throw new NotSupportedException("native criAtomExPlayer_DetachAisac (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_DetachFader(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_DetachFader (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetFadeInStartOffset(IntPtr player, int ms) { throw new NotSupportedException("native criAtomExPlayer_SetFadeInStartOffset (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetFadeOutEndDelay(IntPtr player, int ms) { throw new NotSupportedException("native criAtomExPlayer_SetFadeOutEndDelay (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_ResetFaderParameters(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_ResetFaderParameters (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetGroupNumber(IntPtr player, int group_no) { throw new NotSupportedException("native criAtomExPlayer_SetGroupNumber (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExPlayer_GetAttachedAisacInfo(IntPtr player, int aisac_attached_index, IntPtr aisac_info) { throw new NotSupportedException("native criAtomExPlayer_GetAttachedAisacInfo (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetFirstBlockIndex(IntPtr player, int index) { throw new NotSupportedException("native criAtomExPlayer_SetFirstBlockIndex (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetSelectorLabel(IntPtr player, string selector, string label) { throw new NotSupportedException("native criAtomExPlayer_SetSelectorLabel (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_UnsetSelectorLabel(IntPtr player, string selector) { throw new NotSupportedException("native criAtomExPlayer_UnsetSelectorLabel (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_ClearSelectorLabels(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_ClearSelectorLabels (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetRandomSeed(IntPtr player, uint seed) { throw new NotSupportedException("native criAtomExPlayer_SetRandomSeed (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetAsrRackId(IntPtr player, int asr_rack_id) { throw new NotSupportedException("native criAtomExPlayer_SetAsrRackId (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetDspParameter(IntPtr player, int id, float value) { throw new NotSupportedException("native criAtomExPlayer_SetDspParameter (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_AttachTween(IntPtr player, IntPtr tween) { throw new NotSupportedException("native criAtomExPlayer_AttachTween (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_DetachTween(IntPtr player, IntPtr tween) { throw new NotSupportedException("native criAtomExPlayer_DetachTween (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_DetachTweenAll(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_DetachTweenAll (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetEnvelopeAttackCurve(IntPtr player, CriAtomEx.CurveType curve_type, float strength) { throw new NotSupportedException("native criAtomExPlayer_SetEnvelopeAttackCurve (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetEnvelopeDecayCurve(IntPtr player, CriAtomEx.CurveType curve_type, float strength) { throw new NotSupportedException("native criAtomExPlayer_SetEnvelopeDecayCurve (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetEnvelopeReleaseCurve(IntPtr player, CriAtomEx.CurveType curve_type, float strength) { throw new NotSupportedException("native criAtomExPlayer_SetEnvelopeReleaseCurve (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_AddOutputPort(IntPtr player, IntPtr outputPort) { throw new NotSupportedException("native criAtomExPlayer_AddOutputPort (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_RemoveOutputPort(IntPtr player, IntPtr outputPort) { throw new NotSupportedException("native criAtomExPlayer_RemoveOutputPort (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_ClearOutputPorts(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_ClearOutputPorts (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_AddPreferredOutputPort(IntPtr player, IntPtr outputPort) { throw new NotSupportedException("native criAtomExPlayer_AddPreferredOutputPort (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_RemovePreferredOutputPort(IntPtr player, IntPtr outputPort) { throw new NotSupportedException("native criAtomExPlayer_RemovePreferredOutputPort (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_RemovePreferredOutputPortByName(IntPtr player, string name) { throw new NotSupportedException("native criAtomExPlayer_RemovePreferredOutputPortByName (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_ClearPreferredOutputPorts(IntPtr player) { throw new NotSupportedException("native criAtomExPlayer_ClearPreferredOutputPorts (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayer_SetScheduleTime(IntPtr player, long schedule_time) { throw new NotSupportedException("native criAtomExPlayer_SetScheduleTime (game P/Invoke; not part of the managed port)"); }
    }
}
