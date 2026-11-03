namespace CriWare
{
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public static class CriAtomExPlaybackDebug
    {
        public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out float value)
        {
            throw null;
        }

        public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out uint value)
        {
            throw null;
        }

        public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out int value)
        {
            throw null;
        }

        public static bool GetAisacControl(CriAtomExPlayback playback, uint controlId, out float value)
        {
            throw null;
        }

        public static bool GetAisacControl(CriAtomExPlayback playback, string controlName, out float value)
        {
            throw null;
        }

        [PreserveSig]
        private static extern int criAtomExPlayback_GetParameterFloat32(uint id, int parameterId, out float value);
        [PreserveSig]
        private static extern int criAtomExPlayback_GetParameterUint32(uint id, int parameterId, out uint value);
        [PreserveSig]
        private static extern int criAtomExPlayback_GetParameterSint32(uint id, int parameterId, out int value);
        [PreserveSig]
        private static extern int criAtomExPlayback_GetAisacControlById(uint id, uint controlId, out float value);
        [PreserveSig]
        private static extern int criAtomExPlayback_GetAisacControlByName(uint id, string controlName, out float value);
    }
}
