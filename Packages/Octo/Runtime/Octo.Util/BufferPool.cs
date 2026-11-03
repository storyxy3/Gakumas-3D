namespace Octo.Util
{
    using global::System.Collections.Generic;

    public class BufferPool
    {
        private List<byte[]> _pool;
        private int _bufferSize;
        public BufferPool(int bufferSize, int capacity)
        {
        }

        public void ReturnBuffer(byte[] buffer)
        {
        }
    }
}
