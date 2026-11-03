namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public static class CriAtomExBeatSync
    {
        public struct Info
        {
            public IntPtr playerHn;
            public uint playbackId;
            public uint barCount;
            public uint beatCount;
            public float beatProgress;
            public float bpm;
            public int offset;
            public uint numBeats;
            public IntPtr labelPtr;
            public string label
            {
                get
                {
                    return null;
                }
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void CbFunc(ref Info info);
        public static event CbFunc OnCallback
        {
            add
            {
            }

            remove
            {
            }
        }

        [Obsolete("SetCallback is deprecated. Use OnBeatSyncCallback event", false)]
        public static void SetCallback(CbFunc func)
        {
        }
    }
}
