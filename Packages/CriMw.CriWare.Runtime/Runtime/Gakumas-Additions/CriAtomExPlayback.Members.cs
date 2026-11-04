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
    public partial struct CriAtomExPlayback
    {


        public void Stop(bool ignoresReleaseTime)
        {
        }



        public bool GetFormatInfo(out CriAtomEx.FormatInfo info)
        {
            throw null;
        }



        public bool GetNumPlayedSamples(out long numSamples, out int samplingRate)
        {
            throw null;
        }



        public long GetSequencePosition()
        {
            return default(long);
        }



        public int GetCurrentBlockIndex()
        {
            return default(int);
        }



        public bool GetTrackInfo(out TrackInfo info)
        {
            throw null;
        }



        public bool GetBeatSyncInfo(out CriAtomExBeatSync.Info info)
        {
            throw null;
        }



        public void SetNextBlockIndex(int index)
        {
        }



        public bool SetBeatSyncOffset(short timeMs)
        {
            return default(bool);
        }


        [PreserveSig]
        private static bool criAtomExPlayback_GetFormatInfo(uint id, out CriAtomEx.FormatInfo info) { throw new NotSupportedException("native criAtomExPlayback_GetFormatInfo (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExPlayback_GetNumPlayedSamples(uint id, out long num_samples, out int sampling_rate) { throw new NotSupportedException("native criAtomExPlayback_GetNumPlayedSamples (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static long criAtomExPlayback_GetSequencePosition(uint id) { throw new NotSupportedException("native criAtomExPlayback_GetSequencePosition (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomExPlayback_SetNextBlockIndex(uint id, int index) { throw new NotSupportedException("native criAtomExPlayback_SetNextBlockIndex (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static int criAtomExPlayback_GetCurrentBlockIndex(uint id) { throw new NotSupportedException("native criAtomExPlayback_GetCurrentBlockIndex (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExPlayback_GetPlaybackTrackInfo(uint id, out TrackInfo info) { throw new NotSupportedException("native criAtomExPlayback_GetPlaybackTrackInfo (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExPlayback_GetBeatSyncInfo(uint id, out CriAtomExBeatSync.Info info) { throw new NotSupportedException("native criAtomExPlayback_GetBeatSyncInfo (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomExPlayback_SetBeatSyncOffset(uint id, short timeMs) { throw new NotSupportedException("native criAtomExPlayback_SetBeatSyncOffset (game P/Invoke; not part of the managed port)"); }
    }
}
