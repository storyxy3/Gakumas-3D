namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomExTween : CriDisposable
    {
        public enum ParameterType
        {
            Basic,
            Aisac
        }

        private struct Config
        {
            [StructLayout((LayoutKind)2)]
            public struct Target
            {
                [System.Runtime.InteropServices.FieldOffset(0x0)]
                public CriAtomEx.Parameter parameterId;
                [System.Runtime.InteropServices.FieldOffset(0x0)]
                public uint aisacIds;
            }

            public Target target;
            public ParameterType parameterType;
        }

        private IntPtr handle;
        internal IntPtr nativeHandle
        {
            get
            {
                return default(IntPtr);
            }
        }

        public float Value
        {
            get
            {
                return default(float);
            }
        }

        public bool IsActive
        {
            get
            {
                return default(bool);
            }
        }

        public CriAtomExTween()
        {
        }

        public CriAtomExTween(CriAtomEx.Parameter parameterId)
        {
        }

        public CriAtomExTween(uint aisacId)
        {
        }

        public CriAtomExTween(ParameterType parameterType, uint targetId)
        {
        }

        public override void Dispose()
        {
        }

        public void MoveTo(ushort durationMs, float value)
        {
        }

        public void MoveFrom(ushort durationMs, float value)
        {
        }

        public void Stop()
        {
        }

        public void Reset()
        {
        }

        ~CriAtomExTween()
        {
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        [PreserveSig]
        private static extern IntPtr criAtomExTween_Create(ref Config config, IntPtr work, int work_size);
        [PreserveSig]
        private static extern void criAtomExTween_Destroy(IntPtr tween);
        [PreserveSig]
        private static extern float criAtomExTween_GetValue(IntPtr tween);
        [PreserveSig]
        private static extern void criAtomExTween_MoveTo(IntPtr tween, ushort time_ms, float value);
        [PreserveSig]
        private static extern void criAtomExTween_MoveFrom(IntPtr tween, ushort time_ms, float value);
        [PreserveSig]
        private static extern void criAtomExTween_Stop(IntPtr tween);
        [PreserveSig]
        private static extern void criAtomExTween_Reset(IntPtr tween);
        [PreserveSig]
        private static extern bool criAtomExTween_IsActive(IntPtr tween);
    }
}
