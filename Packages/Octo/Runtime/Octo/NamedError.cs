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
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public string Code
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

        public string Message
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
