namespace Octo.Network
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::Octo.Network;
    using global::Octo.Util;
    using global::UnityEngine.Networking;

    internal sealed class DownloadHandlerFile : DownloadHandlerScript, IDisposable
    {
        private sealed class Worker
        {
            private static readonly byte[] SharedWriteBuffer;
            private static BufferPool Buffers;
            private readonly AutoResetEvent _resetEvent;
            private bool _finish;
            public void Finsh()
            {
            }
        }

        private static readonly string Tag;
        private static readonly BufferPool Buffers;
        private static byte[] EmptyBytes;
        private byte[] _buffer;
        private Worker _worker;
        [CompilerGenerated]
        private bool _003CIsDone_003Ek__BackingField;
        public bool IsDone
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }
        }

        public new void Dispose()
        {
        }
    }
}
