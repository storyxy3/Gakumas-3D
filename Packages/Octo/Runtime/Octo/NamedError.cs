namespace Octo
{
    using global::System.Runtime.CompilerServices;
    using global::Octo;

    internal sealed class NamedError : AssetLoaderError, LoadError, DownloadError, DatabaseError
    {
        [CompilerGenerated]
        private string _003CName_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CCode_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CMessage_003Ek__BackingField;
        public string Name
        {
            [CompilerGenerated]
            get
            {
                return _003CName_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CName_003Ek__BackingField = value;
            }
        }

        public string Code
        {
            [CompilerGenerated]
            get
            {
                return _003CCode_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CCode_003Ek__BackingField = value;
            }
        }

        public string Message
        {
            [CompilerGenerated]
            get
            {
                return _003CMessage_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CMessage_003Ek__BackingField = value;
            }
        }

        public NamedError(string name, string code, string message)
        {
        }

        public static NamedError CreateWithFormat(string name, string code, string format, params string[] args)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public static NamedError CreateDatabaseNotFoundError(string name)
        {
            return null;
        }
    }
}
