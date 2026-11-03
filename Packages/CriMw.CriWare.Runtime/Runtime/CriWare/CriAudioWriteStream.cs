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
                return default(IntPtr);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public IntPtr callbackPointer
        {
            [CompilerGenerated]
            get
            {
                return default(IntPtr);
            }

            [CompilerGenerated]
            private set
            {
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
