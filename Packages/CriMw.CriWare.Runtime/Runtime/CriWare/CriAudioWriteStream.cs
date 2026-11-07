namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAudioWriteStream
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples);
        public delegate uint Delegate(float[][] buffer, uint numSamples);
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass12_0
        {
            public int bufferSize;
            public int numChannels;
            public Delegate callback;
            public float[][] buffer;
            public _003C_003Ec__DisplayClass12_0()
            {
            }

            internal uint _003C_002Ector_003Eb__0(IntPtr cbobj, IntPtr data, uint numSamples)
            {
                return default(uint);
            }
        }

        private InternalDelegate internalDelegate;
        [CompilerGenerated]
        private IntPtr _003CcallbackFunction_003Ek__BackingField;
        [CompilerGenerated]
        private IntPtr _003CcallbackPointer_003Ek__BackingField;
        public IntPtr callbackFunction
        {
            [CompilerGenerated]
            get
            {
                return _003CcallbackFunction_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CcallbackFunction_003Ek__BackingField = value;
            }
        }

        public IntPtr callbackPointer
        {
            [CompilerGenerated]
            get
            {
                return _003CcallbackPointer_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CcallbackPointer_003Ek__BackingField = value;
            }
        }

        public CriAudioWriteStream(IntPtr callbackFunction, IntPtr callbackPointer)
        {
        }

        public CriAudioWriteStream(Delegate callback, int numChannels, int bufferSize = 256)
        {
        }
    }
}
