namespace Campus.Common
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.IO;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::System.Threading.Tasks;
    using global::Campus.Common;

    public sealed class MaskedHeaderStream : Stream
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CReadAsync_003Ed__42 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncTaskMethodBuilder<int> _003C_003Et__builder;
            public MaskedHeaderStream _003C_003E4__this;
            public byte[] buffer;
            public int offset;
            public int count;
            public CancellationToken cancellationToken;
            private long _003CstreamPos_003E5__2;
            private TaskAwaiter<int> _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CWriteAsync_003Ed__43 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncTaskMethodBuilder _003C_003Et__builder;
            public MaskedHeaderStream _003C_003E4__this;
            public byte[] buffer;
            public int offset;
            public int count;
            public CancellationToken cancellationToken;
            private TaskAwaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [ThreadStatic]
        private static byte[] _sharedByteBuffer;
        private readonly long _headerLength;
        private readonly byte[] _maskBytes;
        private readonly long _maskLength;
        private readonly string _maskString;
        private readonly Stream _baseStream;
        public override bool CanRead
        {
            get
            {
                return default(bool);
            }
        }

        public override bool CanSeek
        {
            get
            {
                return default(bool);
            }
        }

        public override bool CanWrite
        {
            get
            {
                return default(bool);
            }
        }

        public override bool CanTimeout
        {
            get
            {
                return default(bool);
            }
        }

        public override long Length
        {
            get
            {
                return default(long);
            }
        }

        public override int ReadTimeout
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public override int WriteTimeout
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public override long Position
        {
            get
            {
                return default(long);
            }

            set
            {
            }
        }

        public MaskedHeaderStream(Stream baseStream, long headerLength, string maskString)
        {
        }

        [MethodImpl(256)]
        private void Crypt(byte[] buffer, int offset, int count, long streamPos)
        {
        }

        private unsafe static void StringToMaskBytes(string maskString, byte* maskBytes, int bytesLength)
        {
        }

        internal static void CryptByString(byte[] buffer, int offset, int count, long streamPos, long headerLength, string maskString)
        {
        }

        internal static void CryptByByteArray(byte[] buffer, int offset, int count, long streamPos, long headerLength, byte[] maskBytes, long maskLength)
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        public override void Flush()
        {
        }

        public override Task FlushAsync(CancellationToken cancellationToken)
        {
            return null;
        }

        public override void SetLength(long value)
        {
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return default(long);
        }

        public override int ReadByte()
        {
            return default(int);
        }

        public override void WriteByte(byte value)
        {
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return default(int);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
        }

        [AsyncStateMachine(typeof(_003CReadAsync_003Ed__42))]
        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CWriteAsync_003Ed__43))]
        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return null;
        }

        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return null;
        }

        public override int EndRead(IAsyncResult asyncResult)
        {
            return default(int);
        }

        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return null;
        }

        public override void EndWrite(IAsyncResult asyncResult)
        {
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }

        internal unsafe static int BytesToHash(byte* bytes, int byteLength)
        {
            return default(int);
        }
    }
}
