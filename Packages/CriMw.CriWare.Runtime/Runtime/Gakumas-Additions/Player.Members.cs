// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::AOT;
using global::CriWare.CriMana.Detail;
using global::CriWare.CriMana;
using global::CriWare;
using global::System.Collections.Generic;
using global::System.Collections;
using global::System.Diagnostics;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::System;
using global::UnityEngine;

namespace CriWare.CriMana
{
    public partial class Player
    {

        private Status requiredStatus
        {
            get
            {
                return default(Status);
            }

            set
            {
            }
        }



        public bool isFrameAvailable
        {
            get
            {
                return default(bool);
            }
        }



        public Status nativeStatus
        {
            get
            {
                return default(Status);
            }
        }



        public int numberOfEntries
        {
            get
            {
                return default(int);
            }
        }



        public CriAtomExPlayer subAtomExPlayer
        {
            get
            {
                return null;
            }
        }



        public CriAtomExPlayer extraAtomExPlayer
        {
            get
            {
                return null;
            }
        }



        public CriAtomEx3dSource atomEx3DsourceForAmbisonics
        {
            get
            {
                return null;
            }
        }



        public void CreateRendererResource(int width, int height, bool alpha)
        {
        }



        public void Prepare()
        {
        }



        public void StopForSeek()
        {
        }



        public bool SetData(IntPtr data, long dataSize, SetMode setMode = SetMode.New)
        {
            return default(bool);
        }



        [Obsolete("Use SetData(IntPtr, Int64, SetMode) instead")]
        public bool SetData(byte[] data, long datasize, SetMode setMode = SetMode.New)
        {
            return default(bool);
        }



        public bool SetContentId(CriFsBinder binder, int contentId, SetMode setMode = SetMode.New)
        {
            return default(bool);
        }



        public bool SetFileRange(string filePath, ulong offset, long range, SetMode setMode = SetMode.New)
        {
            return default(bool);
        }



        public void SetMovieEventSyncMode(MovieEventSyncMode mode)
        {
        }



        public void SetSpeed(float speed)
        {
        }



        public void SetMaxPictureDataSize(uint maxDataSize)
        {
        }



        public void SetBufferingTime(float sec)
        {
        }



        public void SetMinBufferSize(int min_buffer_size)
        {
        }



        public void SetAudioTrack(int track)
        {
        }



        public void SetAudioTrack(AudioTrack track)
        {
        }



        public void SetSubAudioTrack(int track)
        {
        }



        public void SetSubAudioTrack(AudioTrack track)
        {
        }



        public void SetExtraAudioTrack(int track)
        {
        }



        public void SetExtraAudioTrack(AudioTrack track)
        {
        }



        public void SetVolume(float volume)
        {
        }



        public float GetVolume()
        {
            return default(float);
        }



        public void SetSubAudioVolume(float volume)
        {
        }



        public float GetSubAudioVolume()
        {
            return default(float);
        }



        public void SetExtraAudioVolume(float volume)
        {
        }



        public float GetExtraAudioVolume()
        {
            return default(float);
        }



        public void SetBusSendLevel(string bus_name, float level)
        {
        }



        public void SetSubAudioBusSendLevel(string bus_name, float volume)
        {
        }



        public void SetExtraAudioBusSendLevel(string bus_name, float volume)
        {
        }



        public void SetSubtitleChannel(int channel)
        {
        }



        public long GetTime()
        {
            return default(long);
        }



        public int GetDisplayedFrameNo()
        {
            return default(int);
        }



        public void SetAsrRackId(int asrRackId)
        {
        }



        public void SetTimeStretchQuality(float quality)
        {
        }



        public void SetDecryptionKey(ulong key)
        {
        }



        public void SetManualTimerUnit(ulong timeUnitN, ulong timeUnitD)
        {
        }



        public void UpdateWithManualTimeAdvanced()
        {
        }



        public void SyncMasterTimer()
        {
        }



        private void DisableInfos(bool keepFrameInfo = false)
        {
        }



        [MonoPInvokeCallback(typeof(SubtitleCallbackFromNativeDelegate))]
        private static void SubtitleCallbackFromNative(IntPtr ptr1, IntPtr ptr2)
        {
        }



        internal static int NativeMethods_GetNumberOfEntry(int playerId)
        {
            return default(int);
        }



        internal static int NativeMethods_Create()
        {
            return default(int);
        }



        internal static int NativeMethods_CreateWithParameters(bool useAtomExPlayer, uint maxPathLength)
        {
            return default(int);
        }



        internal static IntPtr NativeMethods_GetAtomExPlayerByTrackId(int player_id, uint track_id)
        {
            return default(IntPtr);
        }



        internal void NativeMethods_Stop(int player_id)
        {
        }



        internal void NativeMethods_Pause(int player_id, int sw)
        {
        }



        internal static bool NativeMethods_IsPaused(int player_id)
        {
            return default(bool);
        }



        internal static void NativeMethods_SetFile(int player_id, IntPtr binder, string path)
        {
        }



        internal static bool NativeMethods_EntryFile(int player_id, IntPtr binder, string path, bool repeat)
        {
            return default(bool);
        }



        internal static void NativeMethods_SetData(int player_id, IntPtr data, long datasize)
        {
        }



        internal static void NativeMethods_SetData(int player_id, byte[] data, long datasize)
        {
        }



        internal static bool NativeMethods_EntryData(int player_id, IntPtr data, long datasize, bool repeat)
        {
            return default(bool);
        }



        internal static bool NativeMethods_EntryData(int player_id, byte[] data, long datasize, bool repeat)
        {
            return default(bool);
        }



        internal static void NativeMethods_SetContentId(int player_id, IntPtr binder, int content_id)
        {
        }



        internal static bool NativeMethods_EntryContentId(int player_id, IntPtr binder, int content_id, bool repeat)
        {
            return default(bool);
        }



        internal static void NativeMethods_SetFileRange(int player_id, string path, ulong offset, long range)
        {
        }



        internal static bool NativeMethods_EntryFileRange(int player_id, string path, ulong offset, long range, bool repeat)
        {
            return default(bool);
        }



        internal void NativeMethods_Loop(int player_id, int sw)
        {
        }



        internal static void NativeMethods_SetAudioBaseConcatenation(int player_id, bool flag)
        {
        }



        internal static void NativeMethods_SetMasterTimerType(int player_id, TimerType timer_type)
        {
        }



        internal static void NativeMethods_SetSeekPosition(int player_id, int seek_frame_no)
        {
        }



        internal static void NativeMethods_SetMovieEventSyncMode(int player_id, MovieEventSyncMode mode)
        {
        }



        internal static void NativeMethods_SetSpeed(int player_id, float speed)
        {
        }



        internal static void NativeMethods_SetMaxPictureDataSize(int player_id, uint max_data_size)
        {
        }



        internal static void NativeMethods_SetBufferingTime(int player_id, float sec)
        {
        }



        internal static void NativeMethods_SetMinBufferSize(int player_id, int min_buffer_size)
        {
        }



        internal static void NativeMethods_SetAudioTrack(int player_id, int track)
        {
        }



        internal static void NativeMethods_SetSubAudioTrack(int player_id, int track)
        {
        }



        internal static void NativeMethods_SetExtraAudioTrack(int player_id, int track)
        {
        }



        internal static void NativeMethods_SetVolume(int player_id, float vol)
        {
        }



        internal static float NativeMethods_GetVolume(int player_id)
        {
            return default(float);
        }



        internal static void NativeMethods_SetSubAudioVolume(int player_id, float vol)
        {
        }



        internal static float NativeMethods_GetSubAudioVolume(int player_id)
        {
            return default(float);
        }



        internal static void NativeMethods_SetExtraAudioVolume(int player_id, float vol)
        {
        }



        internal static float NativeMethods_GetExtraAudioVolume(int player_id)
        {
            return default(float);
        }



        internal static void NativeMethods_SetBusSendLevelByName(int player_id, string bus_name, float level)
        {
        }



        internal static void NativeMethods_SetSubAudioBusSendLevelByName(int player_id, string bus_name, float level)
        {
        }



        internal static void NativeMethods_SetExtraAudioBusSendLevelByName(int player_id, string bus_name, float level)
        {
        }



        internal static void NativeMethods_SetSubtitleCallback(int player_id, SubtitleCallbackFromNativeDelegate cbfunc)
        {
        }



        internal static void NativeMethods_SetSubtitleChannel(int player_id, int channel)
        {
        }



        internal static long NativeMethods_GetTime(int player_id)
        {
            return default(long);
        }



        internal static int NativeMethods_GetDisplayedFrameNo(int player_id)
        {
            return default(int);
        }



        internal static void NativeMethods_SetAsrRackId(int player_id, int asr_rack_id)
        {
        }



        internal static void NativeMethods_SetTimeStretchQuality(int player_id, float quality)
        {
        }



        internal static void NativeMethods_SetUserTime(int player_id, ulong user_count, ulong user_unit)
        {
        }



        internal static void NativeMethods_SetManualTimerUnit(int player_id, ulong timer_unit_n, ulong timer_unit_d)
        {
        }



        internal static void NativeMethods_AdvanceManualTimer(int player_id)
        {
        }



        internal static void NativeMethods_SyncMasterTimer(int player_id)
        {
        }



        internal static IntPtr NativeMethods_GetRenderEventFunc()
        {
            return default(IntPtr);
        }



        internal static void NativeMethods_Destroy(int player_id)
        {
        }



        internal static void NativeMethods_SyncUpdate(int player_id)
        {
        }



        internal static void NativeMethods_GetMovieInfo(int player_id, [Out] MovieInfo movie_info)
        {
        }



        internal void NativeMethods_Start(int player_id)
        {
        }



        internal void NativeMethods_Prepare(int player_id)
        {
        }



        internal static int NativeMethods_Update(int player_id)
        {
            return default(int);
        }



        internal static void NativeMethods_SetCuePointCallback(int player_id, CuePointCallbackFromNativeDelegate cbfunc)
        {
        }



        internal static int NativeMethods_GetSubtitleOnTime(int player_id, IntPtr subtitle_buffer, int subtitle_buffer_size)
        {
            return default(int);
        }



        internal static void NativeMethods_SetDecryptionKey(int player_id, ulong key)
        {
        }
    }
}
