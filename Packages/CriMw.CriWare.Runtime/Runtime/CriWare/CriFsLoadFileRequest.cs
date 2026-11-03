namespace CriWare
{
    using global::System.Runtime.CompilerServices;
    using global::CriWare;

    public class CriFsLoadFileRequest : CriFsRequest
    {
        private enum Phase
        {
            Stop,
            Bind,
            Load,
            Done,
            Error
        }

        [CompilerGenerated]
        private string _003Cpath_003Ek__BackingField;
        [CompilerGenerated]
        private byte[] _003Cbytes_003Ek__BackingField;
        private Phase phase;
        private CriFsBinder refBinder;
        private CriFsBinder newBinder;
        private uint bindId;
        private CriFsLoader loader;
        private int readUnitSize;
        private long fileSize;
        public string path
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

        public CriFsLoadFileRequest(CriFsBinder srcBinder, string path, DoneDelegate doneDelegate, int readUnitSize)
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        public override void Stop()
        {
        }

        public override void Update()
        {
        }

        private void UpdateBinder()
        {
        }

        private void UpdateLoader()
        {
        }

        private void OnError()
        {
        }
    }
}
