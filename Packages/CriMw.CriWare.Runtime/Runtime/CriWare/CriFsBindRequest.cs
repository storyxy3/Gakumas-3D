namespace CriWare
{
    using global::System.Runtime.CompilerServices;
    using global::CriWare;

    public class CriFsBindRequest : CriFsRequest
    {
        public enum BindType
        {
            Cpk,
            Directory,
            File
        }

        [CompilerGenerated]
        private string _003Cpath_003Ek__BackingField;
        [CompilerGenerated]
        private uint _003CbindId_003Ek__BackingField;
        public string path
        {
            [CompilerGenerated]
            get
            {
                return _003Cpath_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003Cpath_003Ek__BackingField = value;
            }
        }

        public uint bindId
        {
            [CompilerGenerated]
            get
            {
                return _003CbindId_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CbindId_003Ek__BackingField = value;
            }
        }

        public CriFsBindRequest(BindType type, CriFsBinder targetBinder, CriFsBinder srcBinder, string path)
        {
        }

        public override void Stop()
        {
        }

        public override void Update()
        {
        }

        protected override void Dispose(bool disposing)
        {
        }
    }
}
