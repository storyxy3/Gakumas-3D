namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;

    public class CriStructMemory<Type> : IDisposable
    {
        [CompilerGenerated]
        private byte[] _003Cbytes_003Ek__BackingField;
        private GCHandle gch;
        public byte[] bytes
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public IntPtr ptr
        {
            get
            {
                return default(IntPtr);
            }
        }

        public CriStructMemory()
        {
        }

        public CriStructMemory(int num)
        {
        }

        public void Dispose()
        {
        }
    }
}
