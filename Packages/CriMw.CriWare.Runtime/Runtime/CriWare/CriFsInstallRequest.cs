namespace CriWare
{
    using global::System.Runtime.CompilerServices;
    using global::CriWare;

    public class CriFsInstallRequest : CriFsRequest
    {
        [CompilerGenerated]
        private string _003CsourcePath_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CdestinationPath_003Ek__BackingField;
        [CompilerGenerated]
        private float _003Cprogress_003Ek__BackingField;
        public string sourcePath
        {
            [CompilerGenerated]
            get
            {
                return _003CsourcePath_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CsourcePath_003Ek__BackingField = value;
            }
        }

        public string destinationPath
        {
            [CompilerGenerated]
            get
            {
                return _003CdestinationPath_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CdestinationPath_003Ek__BackingField = value;
            }
        }

        public float progress
        {
            [CompilerGenerated]
            get
            {
                return _003Cprogress_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003Cprogress_003Ek__BackingField = value;
            }
        }

        public CriFsInstallRequest()
        {
        }
    }
}
